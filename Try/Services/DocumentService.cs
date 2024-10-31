using System;
using System.IO;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DocumentManagementSystem.Models;
using DocumentManagementSystem.Data;
using System.Windows.Forms;

namespace DocumentManagementSystem.Services
{
    public class DocumentService
    {
        private readonly AuditTrailService _auditTrailService;

        public DocumentService()
        {
            _auditTrailService = new AuditTrailService();
        }

        private const string StoragePath = @"C:\Documents\Data\";

        // Method to retrieve documents uploaded by a specific user
        public List<Document> GetDocumentsByUser(int userId)
        {
            List<Document> documents = new List<Document>();

            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Document WHERE UserId = @UserId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", userId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        documents.Add(new Document
                        {
                            DocumentId = (int)reader["DocumentId"],
                            UserId = (int)reader["UserId"],
                            DocumentName = reader["DocumentName"].ToString(),
                            FilePath = reader["FilePath"].ToString(),
                            UploadedAt = (DateTime)reader["UploadedAt"]
                        });
                    }
                }
            }

            return documents;
        }

        // Method to upload a document
        public void UploadDocument(int userId, string fileName, string filePath)
        {
            try
            {
                // Ensure the storage directory exists
                if (!Directory.Exists(StoragePath))
                {
                    Directory.CreateDirectory(StoragePath);
                }

                string uniqueFileName = Guid.NewGuid() + Path.GetExtension(fileName);
                string destinationPath = Path.Combine(StoragePath, uniqueFileName);

                // Copy the file to the storage path
                File.Copy(filePath, destinationPath);

                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Document (UserId, DocumentName, FilePath, UploadedAt) VALUES (@UserId, @DocumentName, @FilePath, @UploadedAt)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@DocumentName", fileName);
                    cmd.Parameters.AddWithValue("@FilePath", destinationPath);
                    cmd.Parameters.AddWithValue("@UploadedAt", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }

                _auditTrailService.LogAction(userId, "Upload", "Documents", 0, fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred during document upload: " + ex.Message);
            }
        }

        // Method to download a document
        public void DownloadDocument(int userId, Document document, string destinationPath)
        {
            try
            {
                if (File.Exists(document.FilePath))
                {
                    string destinationFilePath = Path.Combine(destinationPath, document.DocumentName);

                    if (!Directory.Exists(destinationPath))
                    {
                        Directory.CreateDirectory(destinationPath);
                    }

                    File.Copy(document.FilePath, destinationFilePath, overwrite: true);

                    _auditTrailService.LogAction(userId, "Download", "Documents", document.DocumentId, document.DocumentName);
                }
                else
                {
                    throw new FileNotFoundException($"Document not found at {document.FilePath}.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred during document download: " + ex.Message);
                throw;
            }
        }

        // Method to delete a document
        public void DeleteDocument(int userId, int documentId, string documentName)
        {
            string filePath = string.Empty;

            try
            {
                // Step 1: Retrieve document details (document name and file path) from the database
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT DocumentName, FilePath FROM Document WHERE DocumentId = @DocumentId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DocumentId", documentId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            documentName = reader["DocumentName"].ToString();
                            filePath = reader["FilePath"].ToString();
                        }
                        else
                        {
                            Console.WriteLine("Document not found.");
                            return;
                        }
                    }
                }

                // Step 2: Delete the file from storage
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    Console.WriteLine("File deleted successfully.");
                }
                else
                {
                    Console.WriteLine($"File not found at {filePath}.");
                }

                // Step 3: Delete the record from the database
                using (MySqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Document WHERE DocumentId = @DocumentId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DocumentId", documentId);
                    cmd.ExecuteNonQuery();
                }

                // Step 4: Log the deletion action in the audit trail
                _auditTrailService.LogAction(userId, "Delete", "Documents", documentId, documentName);

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred during document deletion: " + ex.Message);
            }
        }

        public void LoadDocuments(int userId, ListView lvDocuments)
        {
            if (userId != 0)
            {
                List<Document> documents = GetDocumentsByUser(userId);
                lvDocuments.Items.Clear(); // Clear existing items

                foreach (var doc in documents)
                {
                    ListViewItem item = new ListViewItem(new[] { doc.DocumentName, doc.UploadedAt.ToString(), doc.FilePath });
                    item.Tag = doc.DocumentId; // Store DocumentId in the Tag property
                    lvDocuments.Items.Add(item);
                }
            }
        }

    }
}
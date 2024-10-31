using DocumentManagementSystem.Models;
using DocumentManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try
{
    public partial class formDocuments : Form
    {
        public ListView LvDocuments { get; private set; }
        private int _loggedInUserId;
        private DocumentService documentService = new DocumentService();

        public formDocuments(int loggedInUserId)
        {
            InitializeComponent();
            LvDocuments = lvDocuments;
            _loggedInUserId = loggedInUserId;
        }

        private void formDocuments_Load(object sender, EventArgs e)
        {
            documentService.LoadDocuments(_loggedInUserId, LvDocuments);
        }

        private void lvDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Documents|*.pdf;*.doc;*.ppt;*.csv;*.xls";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(filePath);

                    // Ensure the user is logged in
                    if (_loggedInUserId != 0)
                    {
                        // Call the upload method
                        DocumentService documentService = new DocumentService();
                        documentService.UploadDocument(_loggedInUserId, fileName, filePath);
                        documentService.LoadDocuments(_loggedInUserId, LvDocuments);
                    }
                }
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (lvDocuments.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvDocuments.SelectedItems[0];
                string documentName = selectedItem.Text;
                string filePath = selectedItem.SubItems[2].Text; // Assuming this is the file path

                // Create and configure the SaveFileDialog
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.FileName = documentName; // Set the default file name
                    saveFileDialog.Filter = "Documents|*.pdf;*.doc;*.ppt;*.csv;*.xls"; // Set the filter for file types

                    // Show the dialog and check if the user clicked 'Save'
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Document document = new Document { DocumentName = documentName, FilePath = filePath };
                        DocumentService documentService = new DocumentService();

                        try
                        {
                            // Pass the logged-in user ID and the directory chosen by the user to the download method
                            documentService.DownloadDocument(_loggedInUserId, document, Path.GetDirectoryName(saveFileDialog.FileName));
                            MessageBox.Show("Download initiated successfully.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error during download: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a document to download.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvDocuments.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvDocuments.SelectedItems[0];
                int documentId = Convert.ToInt32(selectedItem.Tag); // Assuming you set the DocumentId as the Tag
                string filePath = selectedItem.SubItems[2].Text; // Assuming this is the file path

                DocumentService documentService = new DocumentService();

                try
                {
                    // Call the DeleteDocument method using _loggedInUserId
                    documentService.DeleteDocument(_loggedInUserId, documentId, filePath);
                    MessageBox.Show("Document deleted successfully.");
                    documentService.LoadDocuments(_loggedInUserId, LvDocuments); // Refresh the document list after deletion

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during deletion: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a document to delete.");
            }
        }
    }
}

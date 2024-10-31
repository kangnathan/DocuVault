﻿namespace DocumentManagementSystem.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsLocked { get; set; }
    }
}
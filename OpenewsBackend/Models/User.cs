﻿using System.ComponentModel.DataAnnotations;

namespace OpenewsBackend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool IsVerified { get; set; }
    }
}
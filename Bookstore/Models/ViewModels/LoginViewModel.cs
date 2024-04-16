﻿using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Please enter a username")]
        [StringLength(255)]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage ="Please enter a password")]
        [StringLength(255)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; } = string.Empty;

        public bool RememberMe { get; set; }
    }
}

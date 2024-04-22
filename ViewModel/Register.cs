﻿using System.ComponentModel.DataAnnotations;

namespace WebApp5.ViewModel
{
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Must match!")]
        public string ConfirmPassword { get; set; }
    }
}

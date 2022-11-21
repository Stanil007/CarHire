﻿using System.ComponentModel.DataAnnotations;

namespace CarHire.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Compare(nameof(PasswordRepeat))]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string PasswordRepeat { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        [Range(18,250)]
        public int Age { get; set; }
    }
}

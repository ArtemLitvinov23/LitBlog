﻿using System.ComponentModel.DataAnnotations;

namespace LitBlog.API.Models
{
    public class ForgotPasswordRequestViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

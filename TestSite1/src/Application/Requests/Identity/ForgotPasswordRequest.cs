﻿using System.ComponentModel.DataAnnotations;

namespace TestSite1.Application.Requests.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
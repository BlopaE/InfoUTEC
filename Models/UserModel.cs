﻿using System.ComponentModel.DataAnnotations;

namespace InfoUTEC_alpha.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

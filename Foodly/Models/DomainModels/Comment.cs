﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foodly.Models
{
    public class Comment
    {
        [Key,Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentID { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
        [Required]
        public string Entry { get; set; }
        [Required]
        public int Like { get; set; }
        public int Dislike { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Review Review { get; set; }
    }
}

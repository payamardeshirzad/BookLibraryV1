using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPA_Example.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(150)]
        public string BookName { get; set; }

        [Required]
        [MaxLength(150)]
        public string Author { get; set; }

        [Required]
        public string ISBN { get; set; }

    }
}
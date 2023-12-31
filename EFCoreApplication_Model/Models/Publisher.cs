﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreApplication_Model.Models
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Book> Books { get; set; }

        public string FoundDate { get; set; }

        public string Location { get; set; }

        
    }
}

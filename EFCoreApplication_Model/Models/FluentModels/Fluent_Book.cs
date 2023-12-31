﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreApplication_Model.Models
{
    public class Fluent_Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        //public Fluent_BookDetail BookDetail { get; set; }

        //[ForeignKey("Publisher")]
        //public int Publisher_Id { get; set; }
        //public Fluent_Publisher Publisher { get; set; }

        //public List<Fluent_Author> Authors { get; set; }
    }
}

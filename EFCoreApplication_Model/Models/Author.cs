﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreApplication_Model.Models
{
    public class Author
    {
        [Key]
        public Guid Author_id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Location { get; set; }

        [NotMapped]
        public string FullName { get =>  FirstName + "_" + LastName;}
    }
}

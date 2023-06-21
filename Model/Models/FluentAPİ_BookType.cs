﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class FluentAPİ_BookType
    {
        public int BookTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FluentAPİ_Book FluentAPİ_Book { get; set; }
    }
}

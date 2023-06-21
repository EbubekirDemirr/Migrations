using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class FluentAPİ_WriterAndBook
    {
        public int WriterId { get; set; }
        public int BookId { get; set; }

       public FluentAPİ_Book FluentAPİ_Book { get; set; }
       public FluentAPİ_Writer FluentAPİ_Writer { get; set; }
    }
}

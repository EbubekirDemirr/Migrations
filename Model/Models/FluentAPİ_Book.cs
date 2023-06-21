using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class FluentAPİ_Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public decimal DailyPrice { get; set; }
        public string ISPN { get; set; }
        public int PublisherId { get; set; }
        public FluentAPİ_BookType FluentAPİ_BookType { get; set; }
        public FluentAPİ_Publisher FluentAPİ_Publisher { get; set; }
        public ICollection<FluentAPİ_WriterAndBook> FluentAPİ_WriterAndBooks { get; set; }
    }
}

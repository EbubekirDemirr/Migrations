using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class FluentAPİ_Publisher
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public List<FluentAPİ_Book> FluentAPİ_Book { get; set; }
    }
}

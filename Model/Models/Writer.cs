using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Writer
    {
        public int WriterId { get; set; }
        public string WriterFirstName { get; set; }
        public string WriterLastName { get; set; }
        public DateTime WriterBirthDay { get; set; }
        public string WriterBirthPlace { get; set; }
    }
}

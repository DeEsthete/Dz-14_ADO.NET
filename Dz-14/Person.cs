using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_14
{
    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public IEnumerable<Book> Books {get; set; }
    }
}

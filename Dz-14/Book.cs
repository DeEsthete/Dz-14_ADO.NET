using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_14
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Author> Authors {get; set;}
        public bool IsStock { get; set; }
    }
}

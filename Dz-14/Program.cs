using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_14
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LibraryContext context = new LibraryContext())
            {
                context.Authors.ToList();

                //1
                var resultFirst = from p in context.Persons
                                  where p.Books.Count() != 1
                                  select new { p.Id, p.FullName, p.IsDeptor };

                //2
                var resultSecond = from b in context.Books
                                   where b.Id == 3
                                   select new { b.Id, b.Name };

                //3
                var resultThird = from p in context.Persons
                                  where p.Books != context.Books
                                  select new { p.Id, p.FullName, p.IsDeptor };

                //4
                var resultresultFour = from p in context.Persons
                                       where p.Id == 2
                                       select new { p.Books };

                //5
                var resultFifth = from p in context.Persons
                                  where p.IsDeptor == true
                                  select p;
                var deptorPersons = resultFifth.ToList();
                deptorPersons.ForEach(p => { p.IsDeptor = false; });

                context.SaveChanges();
            }
        }
    }
}

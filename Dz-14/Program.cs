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
                                  select new { p.Id, p.FullName };

                //2
                var resultSecond = from b in context.Books
                                   where b.Id == 3
                                   select new { b.Id, b.Name, b.IsStock };

                //3
                var resultThird = from b in context.Books
                                  where b.IsStock == true
                                  select new { b.Id, b.Name, b.IsStock };

                //4
                var resultresultFour = from p in context.Persons
                                       where p.Id == 2
                                       select new { p.Books };

                //5
                for (int i = 0; i < context.Persons.Count(); i++)
                {
                    context.Persons[i].
                }
        }
    }
}

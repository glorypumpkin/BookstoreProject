using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreProject
{
    public  class BookstoresList
    {
        public IQueryable<BookBookstore> Bookstores
        {
            get
            {
                DataClassesDataContext db = new DataClassesDataContext();
                return db.BookBookstore;
            }
        }

        public IEnumerable<BookBookstore> Search(string search)
        {
            return from bs in Bookstores
                   where bs.BookstoreName.ToLower().Contains(search.ToLower())
                   select bs;
        }
    }
}

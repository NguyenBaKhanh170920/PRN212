using SE1825_GROUP2_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1825_GROUP2_PROJECT.Repository
{
    public class BookRepository
    {
        private readonly Prn212ProjectContext prn212ProjectContext;
        public BookRepository(Prn212ProjectContext prn212ProjectContext)
        {
            this.prn212ProjectContext = prn212ProjectContext;
        }
        public void Add(Book Book)
        {
            var rs = prn212ProjectContext.Add(Book);
            prn212ProjectContext.SaveChanges();
        }
        public void Update(Book Book)
        {
            var rs = prn212ProjectContext.Update(Book);
            prn212ProjectContext.SaveChanges();
        }
        public void Delete(Book Book)
        {
            var rs = prn212ProjectContext.Books.Remove(Book);
            prn212ProjectContext.SaveChanges();
        }
        public IEnumerable<Book> GetAll()
        {
            var rs = prn212ProjectContext.Books;
            return rs;
        }
    }
}

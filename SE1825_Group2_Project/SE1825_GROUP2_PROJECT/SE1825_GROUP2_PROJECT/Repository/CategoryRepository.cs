using SE1825_GROUP2_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1825_GROUP2_PROJECT.Repository
{
    public class CategoryRepository
    {
        private readonly Prn212ProjectContext prn212ProjectContext;
        public CategoryRepository(Prn212ProjectContext prn212ProjectContext)
        {
            this.prn212ProjectContext = prn212ProjectContext;
        }
        public void Add(Category Category)
        {
            var rs = prn212ProjectContext.Add(Category);
            prn212ProjectContext.SaveChanges();
        }
        public void Update(Category Category)
        {
            var rs = prn212ProjectContext.Update(Category);
            prn212ProjectContext.SaveChanges();
        }
        public void Delete(Category Category)
        {
            var rs = prn212ProjectContext.Categories.Remove(Category);
            prn212ProjectContext.SaveChanges();
        }
        public IEnumerable<Category> GetAll()
        {
            var rs = prn212ProjectContext.Categories;
            return rs;

        }
    }
}

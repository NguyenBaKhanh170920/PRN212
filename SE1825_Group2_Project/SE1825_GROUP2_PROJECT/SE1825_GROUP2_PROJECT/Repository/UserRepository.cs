using SE1825_GROUP2_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1825_GROUP2_PROJECT.Repository
{
    public class UserRepository
    {
        private readonly Prn212ProjectContext prn212ProjectContext;
        public UserRepository(Prn212ProjectContext prn212ProjectContext)
        {
            this.prn212ProjectContext = prn212ProjectContext;
        }
        public void Add(User user)
        {
            var rs=prn212ProjectContext.Add(user);
            prn212ProjectContext.SaveChanges();
        }
        public void Update(User user)
        {
            var rs=prn212ProjectContext.Update(user);
            prn212ProjectContext.SaveChanges();
        }
        public void Delete(User user)
        {
            var rs=prn212ProjectContext.Users.Remove(user);
            prn212ProjectContext.SaveChanges();
        }
        public IEnumerable<User> GetAll()
        {
            var rs = prn212ProjectContext.Users;
            return rs;
        }
    }
}

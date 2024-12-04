using SE1825_GROUP2_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1825_GROUP2_PROJECT.Repository
{
    public class BorrowRecordRepository
    {
        private readonly Prn212ProjectContext prn212ProjectContext;
        public BorrowRecordRepository(Prn212ProjectContext prn212ProjectContext)
        {
            this.prn212ProjectContext = prn212ProjectContext;
        }
        public void Add(BorrowRecord BorrowRecord)
        {
            var rs = prn212ProjectContext.Add(BorrowRecord);
            prn212ProjectContext.SaveChanges();
        }
        public void Update(BorrowRecord BorrowRecord)
        {
            var rs = prn212ProjectContext.Update(BorrowRecord);
            prn212ProjectContext.SaveChanges();
        }
        public void Delete(BorrowRecord BorrowRecord)
        {
            var rs = prn212ProjectContext.BorrowRecords.Remove(BorrowRecord);
            prn212ProjectContext.SaveChanges();
        }
        public IEnumerable<BorrowRecord> GetAll()
        {
            var rs = prn212ProjectContext.BorrowRecords;
            return rs;
        }
    }
}

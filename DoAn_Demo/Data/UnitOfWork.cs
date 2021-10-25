using DoAn_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_Demo.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbQLHocSinh dbContext { set; get; }
        
        public UnitOfWork(DbQLHocSinh dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}

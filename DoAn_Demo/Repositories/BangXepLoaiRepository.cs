using DoAn_Demo.Data;
using DoAn_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_Demo.Repositories
{
   public class BangXepLoaiRepository : RepositoryBase<BangXepLoai>, IBangXepLoaiRepository
    {
        public BangXepLoaiRepository(DbQLHocSinh dbContext) : base(dbContext) { }
    }
}

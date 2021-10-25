using DoAn_Demo.Data;
using DoAn_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_Demo.Repositories
{
    public class CTBangDiemRepository : RepositoryBase<CTBangDiem>, ICTBangDiemRepository
    {
        public CTBangDiemRepository(DbQLHocSinh dbContext) : base(dbContext) { }
    }
}

using DoAn_Demo.Data;
using DoAn_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_Demo.Repositories
{
    public class HocSinhRepository : RepositoryBase<HocSinh>, IHocSinhRepository
    {
       public HocSinhRepository(DbQLHocSinh dbContext) : base(dbContext) { }

        public override HocSinh MaxID()
        {
            int idnew = dbComponent.Max(hs => hs.IDHS);
            HocSinh hocSinh = dbComponent.Where(h => h.IDHS == idnew).FirstOrDefault();
            return hocSinh;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_Demo.Data
{
    interface IUnitOfWork 
    {
        /// <summary>
        /// Thực hiện cập nhật thay đổi database
        /// </summary>
        void Save();
       
    }
}

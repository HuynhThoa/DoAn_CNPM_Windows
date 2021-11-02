using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_Demo.Reports.ModelReport
{
    public class XepLoaiHocSinh
    {
        public int STT { get; set; }
        public int IDHS { get; set; }
        public string TenHS { get; set; }
        public DateTime NTNS { get; set; }
        public string GioiTinh { get; set; }
        public string XepLoai { get; set; }
        public string HanhKiem { get; set; }
        public string TenLop { get; set; }
        public DateTime? NTH { get; set; }
    }
}

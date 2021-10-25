using DoAn_Demo.Data;
using DoAn_Demo.Entities;
using DoAn_Demo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_Demo.Services
{
    /// <summary>
    /// service xử lý nghiệp vụ quản lý học sinh
    /// </summary>
    public class QLHSService 
    {
        private IUnitOfWork unitOfWork;
        private IHocSinhRepository hocSinhRepository;
        private IGiaoVienRepository giaoVienRepository;
        private ILoaiLopRepository loaiLopRepository;
        private ILopHocRepository lopHocRepository;
        private ICTBangDiemRepository cTBangDiemRepository;
        private IBangXepLoaiRepository bangXepLoaiRepository;
        private IDanhSachLopRepository danhSachLopRepository;
        private IMonHocRepository monHocRepository;

        public QLHSService()
        {
            DbQLHocSinh db = new DbQLHocSinh();
            unitOfWork = new UnitOfWork(db);
            hocSinhRepository = new HocSinhRepository(db);
            giaoVienRepository = new GiaoVienRepository(db);
            loaiLopRepository = new LoaiLopRepository(db);
            lopHocRepository = new LopHocRepository(db);
            cTBangDiemRepository = new CTBangDiemRepository(db);
            bangXepLoaiRepository = new BangXepLoaiRepository(db);
            danhSachLopRepository = new DanhSachLopRepository(db);
            monHocRepository = new MonHocRepository(db);
        }

        /// <summary>
        /// Lưu dữ liệu vừa thực hiện
        /// </summary>
        public void Save()
        {
            unitOfWork.Save();
        }


    }
}

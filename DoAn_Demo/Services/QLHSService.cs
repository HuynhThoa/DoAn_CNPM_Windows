using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using DoAn_Demo.Data;
using DoAn_Demo.Entities;
using DoAn_Demo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        /// <summary>
        /// lấy giáo viên theo biểu thức truyền vào
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public GiaoVien GetGiaoVien(Expression<Func<GiaoVien,bool>> expression)
        {
            GiaoVien giaoVien = giaoVienRepository.GetBy(expression);
            return giaoVien;
        }

        /// <summary>
        /// lấy danh sách giáo viên
        /// </summary>
        /// <returns></returns>
        public List<GiaoVien> GetListGiaoVien()
        {
            return giaoVienRepository.GetAll().ToList();
        }

        /// <summary>
        /// Lấy lớp học theo biểu thức truyền vào 
        /// </summary>
        /// <param name="expression">biểu thức</param>
        /// <returns></returns>
        public LopHoc GetLopHocBy(Expression<Func<LopHoc,bool>> expression)
        {
            LopHoc lopHoc = lopHocRepository.GetBy(expression);
            return lopHoc;
        }
        
        public List<HocSinh> GetListHocSinhBy(Expression<Func<HocSinh,bool>> expression)
        {
            return hocSinhRepository.GetListBy(expression).ToList();
        }

        public List<DanhSachLop> GetDanhSachLop(Expression<Func<DanhSachLop, bool>> expression)
        {
            return danhSachLopRepository.GetListBy(expression).ToList();
        }

        /// <summary>
        /// tạo bảng xếp loại và lưu
        /// </summary>
        /// <param name="bangXepLoai"></param>
        public void CreateBangXepLoai(BangXepLoai bangXepLoai)
        {
            bangXepLoaiRepository.Add(bangXepLoai);
            
        }

        public BangXepLoai GetBangXepLoaiNew()
        {
            BangXepLoai bangXepLoai = bangXepLoaiRepository.MaxID();
            return bangXepLoai;
        }

        public List<MonHoc> GetDanhSachMonHocBy(Expression<Func<MonHoc, bool>> expression)
        {
            List<MonHoc> list = (List<MonHoc>)monHocRepository.GetListBy(expression);
            return list;
        }

        public HocSinh GetHocSinh(Expression<Func<HocSinh, bool>> expression)
        {
            HocSinh hocSinh = hocSinhRepository.GetBy(expression);
            return hocSinh;
        }

        public void AddCT_BangDiem(CTBangDiem ct)
        {
            cTBangDiemRepository.Add(ct);   
        }

        internal void Add_HS(HocSinh hs)
        {
            hocSinhRepository.Add(hs);
        }

        /// <summary>
        /// sau khi gọi sẽ đưa học sinh vừa thêm vào danh sách học sinh vào trực tiếp lớp 
        /// </summary>
        internal void JoinLopHoc(LopHoc lop)
        {
            BangXepLoai bxl = GetBangXepLoaiNew();
            HocSinh hocSinh = GetHocSinhNew();
            DanhSachLop danhSachLop = new DanhSachLop() { IDBXL = bxl.IDBXL,
                                                            IDLopHoc = lop.IDLopHoc, 
                                                            IDHS = hocSinh.IDHS};

            danhSachLopRepository.Add(danhSachLop);
        }

        public HocSinh GetHocSinhNew()
        {
            HocSinh hs =  hocSinhRepository.MaxID();
            return hs;
        }
    }
}

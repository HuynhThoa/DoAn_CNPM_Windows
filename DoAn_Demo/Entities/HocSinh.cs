namespace DoAn_Demo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocSinh")]
    public partial class HocSinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HocSinh()
        {
            DanhSachLops = new HashSet<DanhSachLop>();
        }

        [Key]
        public int IDHS { get; set; }

        [Required]
        [StringLength(100)]
        public string TenHS { get; set; }

        [Required]
        [StringLength(100)]
        public string TenPH { get; set; }

        [Column(TypeName = "date")]
        public DateTime NTNS { get; set; }

        [Required]
        [StringLength(200)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(13)]
        public string SDT { get; set; }

        [Column(TypeName = "date")]
        public DateTime NNH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NTH { get; set; }

        public bool GioiTinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhSachLop> DanhSachLops { get; set; }

        /// <summary>
        /// update ngày thôi học
        /// </summary>
        /// <param name="date">Date</param>
        public void UpdateNTH(DateTime date)
        {
            this.NTH = date;
        }

        /// <summary>
        /// update tên phụ huynh
        /// </summary>
        /// <param name="tenPH">tên phụ huynh</param>
        public void EditTenPH(string tenPH)
        {
            this.TenPH = tenPH;
        }

        /// <summary>
        /// cập nhật ngày tháng năm sinh
        /// </summary>
        /// <param name="date">date</param>
        public void EditNTNS(DateTime date)
        {
            this.NTNS = date;
        }

        /// <summary>
        /// update ngày nhập học 
        /// </summary>
        /// <param name="date">date</param>
        public void EditNNH(DateTime date)
        {
            this.NNH = date;
        }

        /// <summary>
        /// GetInfor Object
        /// </summary>
        /// <returns>Infor Object </returns>
        public string GetInfor()
        {
            return "IDHS: " + IDHS +
                    "HoTen: " + TenHS +
                    "SDT: " + SDT +
                    "GioiTinh: " + GioiTinh +
                    "TenPH: " + TenPH +
                    "DiaChi: " + DiaChi +
                    "NTNS: " + NTNS +
                    "NNH: " + NNH +
                    "NTH: " + NTH;
        }

        /// <summary>
        /// update tên học sinh
        /// </summary>
        /// <param name="hoTen">tên học sinh</param>
        public void EditHoTen(string hoTen)
        {
            this.TenHS = hoTen;
        }

        /// <summary>
        /// update địa chỉ
        /// </summary>
        /// <param name="diaChi">string</param>
        public void EditDC(string diaChi)
        {
            this.DiaChi = diaChi;
        }

        /// <summary>
        /// cập nhật giới tính 
        /// nam : gioiTinh = true
        /// Nu : gioiTinh = false
        /// </summary>
        /// <param name="gioiTinh">bool</param>
        public void EditGioiTinh(bool gioiTinh)
        {
            this.GioiTinh = gioiTinh;
        }

        public void EditSDT(string sdt)
        {
            this.SDT = sdt;
        }

    }
}

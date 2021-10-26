namespace DoAn_Demo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHoc")]
    public partial class LopHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LopHoc()
        {
            DanhSachLops = new HashSet<DanhSachLop>();
        }

        [Key]
        [StringLength(5)]
        public string IDLopHoc { get; set; }

        [Required]
        [StringLength(100)]
        public string TenLop { get; set; }

        public int? IDLoaiLop { get; set; }

        public int? IDGV { get; set; }

        public int? SiSo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhSachLop> DanhSachLops { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual LoaiLop LoaiLop { get; set; }

        public void EditTenLop(string value)
        {
            this.TenLop = value;
        }

        public void EditIDGV(int value)
        {
            this.IDGV = value;
        }

        public void EditIDLoaiLop(int value)
        {
            this.IDLoaiLop = value;
        }

        public string GetInfor()
        {
            return "IDLopHoc: " + IDLopHoc +
                    "TenLop: " + TenLop +
                    "SiSo: " + SiSo +
                    "IDGV: " + GiaoVien.HoTen +
                    "IDLoaiLop: " + LoaiLop.TenLoaiLop;
        }
    }
}

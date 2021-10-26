namespace DoAn_Demo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BangXepLoai")]
    public partial class BangXepLoai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BangXepLoai()
        {
            CTBangDiems = new HashSet<CTBangDiem>();
            DanhSachLops = new HashSet<DanhSachLop>();
        }

        [Key]
        public int IDBXL { get; set; }

        [StringLength(50)]
        public string XepLoai { get; set; }

        [StringLength(50)]
        public string HanhKiem { get; set; }

        public int NienKhoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTBangDiem> CTBangDiems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhSachLop> DanhSachLops { get; set; }

        public void EditXepLoai(string value)
        {
            this.XepLoai = value;
        }

        public void EditHanhKiem(string value)
        {
            this.HanhKiem = value;
        }

        public void EditNienKhoa(int value)
        {
            this.NienKhoa = value;
        }

        public string GetInfor()
        {
            return "IDBXL: " + IDBXL +
                    "XepLoai: " + XepLoai +
                    "HanhKiem: " + HanhKiem +
                       "NienKhoa: " + NienKhoa;
        }
    }
}

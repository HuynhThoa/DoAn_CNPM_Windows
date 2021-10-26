namespace DoAn_Demo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonHoc")]
    public partial class MonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonHoc()
        {
            CTBangDiems = new HashSet<CTBangDiem>();
        }

        [Key]
        public int IDMH { get; set; }

        [Required]
        [StringLength(100)]
        public string TenMH { get; set; }

        public int? IDLoaiLop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTBangDiem> CTBangDiems { get; set; }

        public virtual LoaiLop LoaiLop { get; set; }

        public void EditIDLoaiLop(int value)
        {
            this.IDLoaiLop = value;
        }

        public void EditTenMH(string value)
        {
            this.TenMH = value;
        }

        public string GetInfor()
        {
            return "IDMH: " + IDMH +
                    "TenMH: " + TenMH +
                    "IDLoaiLop: " + IDLoaiLop +
                    "TenLoaiLop: " + LoaiLop.TenLoaiLop;
        }
    }
}

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
    }
}

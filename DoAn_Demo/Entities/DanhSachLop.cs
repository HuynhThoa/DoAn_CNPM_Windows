namespace DoAn_Demo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhSachLop")]
    public partial class DanhSachLop
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string IDLopHoc { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDHS { get; set; }

        public int? IDBXL { get; set; }

        public virtual BangXepLoai BangXepLoai { get; set; }

        public virtual HocSinh HocSinh { get; set; }

        public virtual LopHoc LopHoc { get; set; }

        public void EditIDBXL(int value)
        {
            this.IDBXL = value;
        }

        public string GetInfor()
        {
            return "IDLopHoc: " + IDLopHoc +
                    "TenLop: " + LopHoc.TenLop +
                    "IDHS: " + IDHS +
                    "TenHS: " + HocSinh.TenHS +
                    "IDBXL: " + IDBXL;
        }


    }
}

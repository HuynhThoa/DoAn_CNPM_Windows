namespace DoAn_Demo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTBangDiem")]
    public partial class CTBangDiem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDBXL { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDMH { get; set; }

        public int? DiemKyMot { get; set; }

        public int? DiemKyHai { get; set; }

        public virtual BangXepLoai BangXepLoai { get; set; }

        public virtual MonHoc MonHoc { get; set; }

        public void EditDiemKyMot(int value)
        {
            this.DiemKyMot = value;
        }

        public void EditDiemKyHai(int value)
        {
            this.DiemKyHai = value;
        }

        public void EditTenMH(int value)
        {
            this.IDMH = value;
        }

        public string GetInfor()
        {
            return "IDMH: " + IDMH +
                    "TenMH: " + MonHoc.TenMH +
                    "IDBXL: " + IDBXL +
                    "DiemKyMot: " + DiemKyMot +
                    "DiemKyHai: " + DiemKyHai;
        }
    }
}

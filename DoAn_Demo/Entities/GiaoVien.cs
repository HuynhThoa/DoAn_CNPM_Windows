namespace DoAn_Demo.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaoVien")]
    public partial class GiaoVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiaoVien()
        {
            LopHocs = new HashSet<LopHoc>();
        }

        [Key]
        public int IDGV { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(13)]
        public string SDT { get; set; }

        [Required]
        [StringLength(200)]
        public string DC { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Pass { get; set; }

        public bool GioiTinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHoc> LopHocs { get; set; }

        public void EditEmail(string email)
        {
            this.Email = email;
        }

        public void EditPass(string pass)
        {
            this.Pass = pass;
        }

        public void EditHoTen(string value)
        {
            this.HoTen = value;
        }

        public void EditDC(string value)
        {
            this.DC = value;
        }

        public void EditSDT(string value)
        {
            this.SDT = value;
        }

        public string GetInfor()
        {
            return "IDGV: " + IDGV +
                    "Hoten: " + HoTen +
                    "Email: " + Email +
                    "SDT: " + SDT +
                    "DC: " + DC +
                    "GioiTinh: " + GioiTinh +
                    "Pass: " + Pass;
        }

        /// <summary>
        /// nếu là nam value is true
        /// nữ value is false
        /// </summary>
        /// <param name="value"></param>
        public void EditGioiTinh(bool value)
        {
            this.GioiTinh = value;
        }
    }
}

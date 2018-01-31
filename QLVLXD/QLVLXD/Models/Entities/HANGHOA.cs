namespace QLVLXD.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HANGHOA")]
    public partial class HANGHOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HANGHOA()
        {
            CHITIETPNs = new HashSet<CHITIETPN>();
            CTHOADONs = new HashSet<CTHOADON>();
        }
        public HANGHOA(int Mahh, string tenHH, string dvt, int giaNhap , int giaBan , int sl)
        {
            this.MAHH = Mahh;
            this.TENHH = tenHH;
            this.DONVITINH = dvt;
            this.GIANHAP = giaNhap;
            this.DONGIA = giaBan;
            this.SOLUONGTON = sl;
        }
        [Key]
        public int MAHH { get; set; }

        [StringLength(250)]
        public string TENHH { get; set; }

        public int? SOLUONGTON { get; set; }
        

        public int? DONGIA { get; set; }

        public int? LOAIHANG { get; set; }
        public string DONVITINH { get; set; }
        public int? GIANHAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPN> CHITIETPNs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHOADON> CTHOADONs { get; set; }

        public virtual LOAIHANGHOA LOAIHANGHOA { get; set; }
    }
}

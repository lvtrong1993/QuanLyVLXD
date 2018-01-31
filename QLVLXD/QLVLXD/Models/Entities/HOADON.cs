namespace QLVLXD.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            CTHOADONs = new HashSet<CTHOADON>();
        }
        public HOADON(int soHD, int tongTien, DateTime ngayLap , int? maKH, int maNV)
        {
            this.SOHD = soHD;
            this.TONGTIEN = tongTien;
            this.NGAYLAP = ngayLap;
            this.MAKH = maKH;
            this.NVLAP = maNV;
        }

        [Key]
        public int SOHD { get; set; }

        public int? TONGTIEN { get; set; }

        public DateTime? NGAYLAP { get; set; }

        public int? MAKH { get; set; }

        public int? NVLAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHOADON> CTHOADONs { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}

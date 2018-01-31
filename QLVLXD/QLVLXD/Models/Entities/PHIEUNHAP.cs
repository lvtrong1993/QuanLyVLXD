namespace QLVLXD.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUNHAP")]
    public partial class PHIEUNHAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUNHAP()
        {
            CHITIETPNs = new HashSet<CHITIETPN>();
        }
        public PHIEUNHAP(int soPN, int tongTien, DateTime ngayLap, int? maNCC, int maNV)
        {
            this.SOPN = soPN;
            this.TONGTIEN = tongTien;
            this.NGAYNHAP = ngayLap;
            this.MANCC = maNCC;
            this.NVLAP = maNV;
        }
        [Key]
        public int SOPN { get; set; }

        public int? MANCC { get; set; }

        public DateTime? NGAYNHAP { get; set; }

        public int? TONGTIEN { get; set; }

        public int? NVLAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPN> CHITIETPNs { get; set; }

        public virtual NHACC NHACC { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}

namespace QLVLXD.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHACC")]
    public partial class NHACC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHACC()
        {
            PHIEUNHAPs = new HashSet<PHIEUNHAP>();
        }

        public NHACC(int maKH, string tenKH, int sdt, string diaChi)
        {
            this.MANCC = maKH;
            this.TENNCC = tenKH;
            this.SDT = sdt;
            this.DIACHI = diaChi;
        }

        [Key]
        public int MANCC { get; set; }

        [StringLength(250)]
        public string TENNCC { get; set; }

        public int? SDT { get; set; }

        [StringLength(1000)]
        public string DIACHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAP> PHIEUNHAPs { get; set; }
    }
}

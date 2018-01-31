namespace QLVLXD.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            HOADONs = new HashSet<HOADON>();
        }

        public KHACHHANG(int maKH, string tenKH, int sdt, string diaChi)
        {
            this.MAKH = maKH;
            this.TENKH = tenKH;
            this.SDT = sdt;
            this.DIACHI = diaChi;
        }

        [Key]
        public int MAKH { get; set; }

        [StringLength(250)]
        public string TENKH { get; set; }

        public int? SDT { get; set; }

        [StringLength(1000)]
        public string DIACHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}

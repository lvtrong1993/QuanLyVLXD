namespace QLVLXD.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETPN")]
    public partial class CHITIETPN
    {
        public CHITIETPN(int sopn, int maHH, int sl)
        {
            this.SOPN = sopn;
            this.MAHH = maHH;
            this.SOLUONGNHAP = sl;
        }
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SOPN { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAHH { get; set; }

        public int? SOLUONGNHAP { get; set; }

        public virtual PHIEUNHAP PHIEUNHAP { get; set; }

        public virtual HANGHOA HANGHOA { get; set; }
    }
}

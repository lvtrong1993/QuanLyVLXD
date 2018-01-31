namespace QLVLXD.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHOADON")]
    public partial class CTHOADON
    {
        public CTHOADON(int soHD, int maHH, int sl)
        {
            this.SOHD = soHD;
            this.MAHH = maHH;
            this.SOLUONG = sl;
        }
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SOHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAHH { get; set; }

        public int? SOLUONG { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual HANGHOA HANGHOA { get; set; }
    }
}

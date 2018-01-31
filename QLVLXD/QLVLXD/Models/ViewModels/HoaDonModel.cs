using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLVLXD.Models.ViewModels
{
    class HoaDonModel
    {
        public int SOHD { get; set; }

        public int? TONGTIEN { get; set; }

        public DateTime? NGAYLAP { get; set; }

        public int? MAKH { get; set; }

        public int? MANVLAP { get; set; }
        public String TENNVLAP { get; set; }
        public String TENKH { get; set; }
    }
}

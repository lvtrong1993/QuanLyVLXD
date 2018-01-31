using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLVLXD.Models.ViewModels
{
    class PhieuNhapModel
    {

        public int SOPN { get; set; }

        public int? MANCC { get; set; }

        public DateTime? NGAYNHAP { get; set; }

        public int? TONGTIEN { get; set; }

        public int? NVLAP { get; set; }
        public string TENNCC { get; set; }
        public string TENNVLAP { get; set; }
    }
}

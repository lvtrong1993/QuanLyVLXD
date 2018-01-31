using QLVLXD.Models.DAO;
using QLVLXD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLVLXD.Controllers
{
    class CTPNController
    {
        ChiTietPhieuNhapDao ctpnDao = new ChiTietPhieuNhapDao();
        public int addCTPN(int soPN, int maHH, int sl)
        {
            CHITIETPN cthd = new CHITIETPN(soPN, maHH, sl);
            return ctpnDao.addCTPN(cthd);
        }
    }
}

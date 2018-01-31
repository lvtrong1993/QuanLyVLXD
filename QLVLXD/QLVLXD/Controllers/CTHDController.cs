using QLVLXD.Models.DAO;
using QLVLXD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLVLXD.Controllers
{
    class CTHDController
    {
        ChiTietHoaDonDao cthdDao = new ChiTietHoaDonDao();
        public int addCTHD(int soHD, int maHH, int sl)
        {
            CTHOADON cthd = new CTHOADON(soHD, maHH, sl);
            return cthdDao.addCTHD(cthd);
        }
    }
}

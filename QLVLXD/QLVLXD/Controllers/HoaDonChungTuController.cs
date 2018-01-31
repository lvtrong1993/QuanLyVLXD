using QLVLXD.Models.DAO;
using QLVLXD.Models.Entities;
using QLVLXD.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLVLXD.Controllers
{
    class HoaDonChungTuController
    {
        HoaDonChungTuDao hdctDao = new HoaDonChungTuDao();
        public List<HoaDonModel> listHD()
        {
            List<HoaDonModel> dsHD = hdctDao.listHD();
            return dsHD;
        }
        public List<PhieuNhapModel> listPN()
        {
            List<PhieuNhapModel> pn = hdctDao.listPN();
            return pn;
        }
        public List<CTHDModel> getListCTHDByHD(int idHD)
        {
            return hdctDao.getListCTHDByHD(idHD);
        }
        public bool deleteHD(int idHD)
        {
            return hdctDao.deleteHD(idHD);
        }
        public bool deletePN(int idPN)
        {
            return hdctDao.deletePN(idPN);
        }
        public List<CTPNModel> getListCTPNByPN(int idpn)
        {
            return hdctDao.getListCTPNByPN(idpn);
        }
        public int addHD(int tongTien, DateTime ngayLap,int maKH, int maNVLap)
        {
            HOADON h = new HOADON(1, tongTien, ngayLap, maKH, maNVLap);
            return hdctDao.addHD(h);
        }
        public int addPN(int tongTien, DateTime ngayLap, int maNCC, int maNVLap)
        {
            PHIEUNHAP h = new PHIEUNHAP(1, tongTien, ngayLap, maNCC, maNVLap);
            return hdctDao.addPN(h);
        }

    }
}

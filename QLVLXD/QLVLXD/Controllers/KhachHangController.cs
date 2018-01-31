using QLVLXD.Models.DAO;
using QLVLXD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLVLXD.Controllers
{
    class KhachHangController
    {
        KhachHangDao khDao = new KhachHangDao();
        public List<KHACHHANG> dsKhachHang()
        {
            List<KHACHHANG> dsKH = khDao.dsKH();
            return dsKH;
        }
        public bool updateKH(int maKH, string tenKH, int sdt, string diaChi)
        {
            try
            {
                KHACHHANG k = new KHACHHANG(maKH, tenKH, sdt, diaChi);
                return khDao.updateKH(k);
            }catch(Exception e)
            {
                return false;
            }
            
        }
        public bool addKH(int maKH, string tenKH, int sdt, string diaChi)
        {
            try
            {
                KHACHHANG k = new KHACHHANG(maKH, tenKH, sdt, diaChi);
                return khDao.addKH(k);
            }
            catch (Exception e)
            {
                return false;
            }

        }
        //addNewKH
        public int addNewKH(int maKH, string tenKH, int sdt, string diaChi)
        {
            try
            {
                KHACHHANG k = new KHACHHANG(maKH, tenKH, sdt, diaChi);
                return  khDao.addNewKH(k);
                
            }
            catch (Exception e)
            {
                return 0;
            }

        }
        public bool deleteKH(int id)
        {
            return khDao.deleteKH(id);
        }
        public KHACHHANG getKHById(int id)
        {
            return khDao.getKHById(id);
        }
      
    }
}

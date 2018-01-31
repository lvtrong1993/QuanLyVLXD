using QLVLXD.Models.DAO;
using QLVLXD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLVLXD.Controllers
{
    class HangHoaController
    {
        HangHoaDao hhDao = new HangHoaDao();
        public List<HANGHOA> listAllHangHoa()
        {
            
            List<HANGHOA> hhList = hhDao.listAllHangHoa();
            return hhList;
        }
       /* public List<string> listTenHangHoa(List<HANGHOA> listHH)
        {
            List<string> rs=null; 
            for (int i = 0; i < listHH.Count; i++)
            {
                rs.Add(listHH[i].TENHH );//+ " - " + listHH[i].MAHH
            }
            return rs;
        }*/
        public HANGHOA getHHById(int id)
        {
            return hhDao.getHHById(id);
        }
        public bool checkExistHH(int id)
        {
            return hhDao.checkExistHH(id);
        }
        public bool updateSLHH(int id, int slban)
        {
            HANGHOA findHH = hhDao.getHHById(id);
            if (findHH == null)
            {
                return false;
            }
            else
            {
                return hhDao.updateHH(findHH, slban);
            }
        }

        public List<HANGHOA> getAllHH()
        {
            return hhDao.listAllHH();
        }
        public bool addHH(string tenHH, string dvt, int giaNhap, int giaBan, int sl)
        {
            HANGHOA hh = new HANGHOA(1, tenHH, dvt, giaNhap, giaBan, sl);
            return hhDao.addHangHoa(hh);
        }
        public bool updateHangHoa(int mahh, string tenHH, string dvt, int giaNhap, int giaBan, int sl)
        {
            HANGHOA hh = new HANGHOA(mahh, tenHH, dvt, giaNhap, giaBan, sl);

            return hhDao.updateHangHoa(hh);
        }
        public bool deleteHH(int id)
        {
            return hhDao.deleteHH(id);
        }
        /*   public bool addHH(int )
           {

           }*/
        public bool updateSLHH2(int id, int SL)
        {
            HANGHOA findHH = hhDao.getHHById(id);
            if (findHH == null)
            {
                return false;
            }
            else
            {
                return hhDao.updateHH2(findHH, SL);
            }
        }
    }
}

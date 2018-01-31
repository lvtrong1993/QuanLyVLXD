using QLVLXD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLVLXD.Models.DAO
{
   
    class HangHoaDao
    {
        VLXDDbContext db = null;
        public HangHoaDao()
        {
            db = new VLXDDbContext();
        }

        public List<HANGHOA> listAllHangHoa()
        {
            return db.HANGHOAs.ToList();
        }

        public bool checkExistHH(int id)
        {
            var hh = db.HANGHOAs
                           .Where(b => b.MAHH == id)
                           .FirstOrDefault();
            if (hh != null)
                return true;
            return false;
        }
        public bool updateHH(HANGHOA hh, int slBan)
        {
            try
            {
                var k = db.HANGHOAs.Find(hh.MAHH);
                /*k.TENKH = kh.TENKH;
                k.SDT = kh.SDT;
                k.DIACHI = kh.DIACHI;
                db.SaveChanges();*/
                //  k.MAHH=hh.MAHH
                k.SOLUONGTON = k.SOLUONGTON - slBan;
                db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public HANGHOA getHHById(int id)
        {
            HANGHOA hh = db.HANGHOAs
                           .Where(b => b.MAHH == id)
                           .FirstOrDefault();
            if (hh != null)
                return hh;
            return null;
        }
        public List<HANGHOA> listAllHH()
        {
            return db.HANGHOAs.ToList();
        }
        public bool updateHangHoa(HANGHOA kh)
        {
            try
            {
                var k = db.HANGHOAs.Find(kh.MAHH);
                k.TENHH = kh.TENHH;
                k.GIANHAP = kh.GIANHAP;
                k.DONGIA = kh.DONGIA;
                k.SOLUONGTON = kh.SOLUONGTON;
                k.DONVITINH = kh.DONVITINH;
                db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool deleteHH(int id)
        {
            try
            {
                var itemToRemove = db.HANGHOAs.SingleOrDefault(x => x.MAHH == id); //returns a single item.

                if (itemToRemove != null)
                {
                    db.HANGHOAs.Remove(itemToRemove);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool updateHH2(HANGHOA hh, int sl)
        {
            try
            {
                var k = db.HANGHOAs.Find(hh.MAHH);
                /*k.TENKH = kh.TENKH;
                k.SDT = kh.SDT;
                k.DIACHI = kh.DIACHI;
                db.SaveChanges();*/
                //  k.MAHH=hh.MAHH
                k.SOLUONGTON = k.SOLUONGTON + sl;
                db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool addHangHoa(HANGHOA kh)
        {

            //int maxMaHD = db.HoaDons.Max(p => p.maHD);
            //  hd.maHD = maxMaHD + 1;
            //  DialogResult dialog = MessageBox.Show("ID: "+hd.maHD, "Thông báo", MessageBoxButtons.YesNo);
            //  return false;
            try
            {
                db.HANGHOAs.Add(kh);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}

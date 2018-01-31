using QLVLXD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVLXD.Models.DAO
{
    class KhachHangDao
    {
        //   VL
        VLXDDbContext db = null;
        public KhachHangDao()
        {
            db = new VLXDDbContext();
        }
        public List<KHACHHANG> dsKH()
        {
            return db.KHACHHANGs.ToList();
        }
        public bool updateKH(KHACHHANG kh)
        {
            try
            {
                var k = db.KHACHHANGs.Find(kh.MAKH);
                k.TENKH = kh.TENKH;
                k.SDT = kh.SDT;
                k.DIACHI = kh.DIACHI;
                db.SaveChanges();

                return true;
            }catch(Exception e)
            {
                return false;
            }
        }
        public bool addKH(KHACHHANG kh)
        {

           //int maxMaHD = db.HoaDons.Max(p => p.maHD);
          //  hd.maHD = maxMaHD + 1;
            //  DialogResult dialog = MessageBox.Show("ID: "+hd.maHD, "Thông báo", MessageBoxButtons.YesNo);
            //  return false;
            try
            {
                db.KHACHHANGs.Add(kh);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public int addNewKH(KHACHHANG kh)
        {

            //int maxMaHD = db.HoaDons.Max(p => p.maHD);
            //  hd.maHD = maxMaHD + 1;
            //  DialogResult dialog = MessageBox.Show("ID: "+hd.maHD, "Thông báo", MessageBoxButtons.YesNo);
            //  return false;
            try
            {
                db.KHACHHANGs.Add(kh);
                db.SaveChanges();
                int id = kh.MAKH;
               // DialogResult dialog = MessageBox.Show("ID: "+id, "Thông báo", MessageBoxButtons.YesNo);

                return id;
               
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public bool deleteKH(int id)
        {
           // DialogResult dialog = MessageBox.Show("ID: " + id, "Thông báo", MessageBoxButtons.YesNo);
            try {
                var itemToRemove = db.KHACHHANGs.SingleOrDefault(x => x.MAKH == id); //returns a single item.

                if (itemToRemove != null)
                {
                    db.KHACHHANGs.Remove(itemToRemove);
                    db.SaveChanges();
                    
                    return true;
                }else
                {
                    return false;
                }
                
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public KHACHHANG getKHById(int id)
        {
            KHACHHANG hh = db.KHACHHANGs
                           .Where(b => b.MAKH == id)
                           .FirstOrDefault();
            if (hh != null)
                return hh;
            return null;
        }
    }
}

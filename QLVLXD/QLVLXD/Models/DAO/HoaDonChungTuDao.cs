using QLVLXD.Models.Entities;
using QLVLXD.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVLXD.Models.DAO
{
    class HoaDonChungTuDao
    {
        VLXDDbContext db = null;
        public HoaDonChungTuDao()
        {
            db = new VLXDDbContext();
        }
        public List<HoaDonModel> listHD()
        {
            // return db.HOADONs.ToList();
            List<HoaDonModel> rs = (
                             from n in db.NHANVIENs
                             join h in db.HOADONs on n.MANV equals h.NVLAP
                             join k in db.KHACHHANGs on h.MAKH equals k.MAKH
                        
                             select new HoaDonModel
                             {
                                 SOHD = h.SOHD,
                                 TONGTIEN = h.TONGTIEN,
                                 NGAYLAP = h.NGAYLAP,
                                 MAKH = k.MAKH,
                                 TENKH = k.TENKH,
                                 MANVLAP = n.MANV,
                                 TENNVLAP = n.TENNV

                             }
          ).ToList();


            return rs;
        }

        public List<PhieuNhapModel> listPN()
        {
            List<PhieuNhapModel> rs = (
                         from P in db.PHIEUNHAPs
                         join N in db.NHACCs on P.MANCC equals N.MANCC
                         join NV in db.NHANVIENs on P.NVLAP equals NV.MANV
                         where P.SOPN > 0
                         select new PhieuNhapModel
                         {
                             SOPN = P.SOPN,
                             MANCC = N.MANCC,
                             NGAYNHAP = P.NGAYNHAP,
                             TONGTIEN = P.TONGTIEN,
                             NVLAP = NV.MANV,
                             TENNVLAP = NV.TENNV,
                             TENNCC = N.TENNCC
                         }
            ).ToList();
            return rs;
        }

        public List<CTHOADON> listCTHD(int idHD)
        {
            return db.CTHOADONs.Where(x => x.SOHD == idHD).ToList();
        }

        public List<CTHDModel> getListCTHDByHD(int idHD)
        {
            List<CTHDModel> rs = (
                              from c in db.CTHOADONs
                              join h in db.HOADONs on c.SOHD equals h.SOHD
                              join k in db.KHACHHANGs on h.MAKH equals k.MAKH
                              join hh in db.HANGHOAs on c.MAHH equals hh.MAHH

                              where h.SOHD == idHD
                              select new CTHDModel
                              {
                                  SOHD = h.SOHD,
                                  SOLUONG = c.SOLUONG,
                                  MAHH = c.MAHH,
                                  MAKH = k.MAKH,
                                  TENKH = k.TENKH,
                                  TENHH = hh.TENHH,
                                  DONGIA = hh.DONGIA

                              }
           ).ToList();
            return rs;
        }

        public List<CTPNModel> getListCTPNByPN(int idpn)
        {
            List<CTPNModel> rs = (
                              from c in db.CHITIETPNs
                              join p in db.PHIEUNHAPs on c.SOPN equals p.SOPN
                              join n in db.NHACCs on p.MANCC equals n.MANCC
                              join hh in db.HANGHOAs on c.MAHH equals hh.MAHH

                              where c.SOPN == idpn
                              select new CTPNModel
                              {
                                  SOPN = p.SOPN,
                                  MAHH = hh.MAHH,
                                  SOLUONGNHAP = c.SOLUONGNHAP,
                                  TENHH = hh.TENHH,
                                  MANCC = n.MANCC,
                                  TENNCC = n.TENNCC,
                                  GIANHAP = hh.DONGIA


                              }
           ).ToList();
            return rs;
        }
        public int addHD(HOADON hd)
        {
            try
            {
                db.HOADONs.Add(hd);
                db.SaveChanges();
                int id = hd.SOHD;
                return id;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public int addPN(PHIEUNHAP pn)
        {
            try
            {
                db.PHIEUNHAPs.Add(pn);
                db.SaveChanges();
                int id = pn.SOPN;
                return id;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public bool deleteHD(int idHD)
        {
            try
            {
                //db.CTHOADONs.RemoveRange(db.CTHOADONs.Where(c => c.SOHD == idHD));

               // DialogResult dialog = MessageBox.Show("ID: " + idHD, "Thông báo", MessageBoxButtons.YesNo);

                var itemToRemove = db.HOADONs.SingleOrDefault(x => x.SOHD == idHD); //returns a single item.

                if (itemToRemove != null)
                {
                    db.HOADONs.Remove(itemToRemove);
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool deletePN(int idPN)
        {
            try
            {
                db.PHIEUNHAPs.RemoveRange(db.PHIEUNHAPs.Where(c => c.SOPN == idPN));
                var itemToRemove = db.PHIEUNHAPs.SingleOrDefault(x => x.SOPN == idPN); //returns a single item.

                if (itemToRemove != null)
                {
                    db.PHIEUNHAPs.Remove(itemToRemove);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

using QLVLXD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLVLXD.Models.DAO
{
    class ChiTietHoaDonDao
    {
        VLXDDbContext db = null;
        public ChiTietHoaDonDao()
        {
            db = new VLXDDbContext();
        }
        public int addCTHD(CTHOADON hd)
        {
            try
            {
                db.CTHOADONs.Add(hd);
                db.SaveChanges();
                int id = hd.SOHD;
                return id;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}

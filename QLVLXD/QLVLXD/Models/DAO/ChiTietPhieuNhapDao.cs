using QLVLXD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLVLXD.Models.DAO
{
    class ChiTietPhieuNhapDao
    {
        VLXDDbContext db = null;
        public ChiTietPhieuNhapDao()
        {
            db = new VLXDDbContext();
        }
        public int addCTPN(CHITIETPN hd)
        {
            try
            {
                db.CHITIETPNs.Add(hd);
                db.SaveChanges();
                int id = hd.SOPN;
                return id;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}


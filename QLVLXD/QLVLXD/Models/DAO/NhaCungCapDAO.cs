using QLVLXD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;

namespace QLVLXD.Models.DAO
{
    class NhaCungCapDAO
    {
        private VLXDDbContext context;

        public NhaCungCapDAO()
        {
            context = new QLVLXD.Models.Entities.VLXDDbContext();
        }

        public List<NHACC> getAll()
        {
            try
            {
                var nvs = from b in context.NHACCs
                          select b;

                var ks = nvs.ToList();
                return ks;
            }
            catch (EntityException ex)
            {
                throw ex;
            }
        }

        public NHACC find(int id)
        {
            try
            {
                var nv = context.NHACCs
                            .Where(b => b.MANCC == id)
                            .FirstOrDefault();
                return nv;
            }
            catch (EntityException ex)
            {
                throw ex;
            }
        }

        public NHACC getNCCById(int id)
        {
            NHACC hh = context.NHACCs
                           .Where(b => b.MANCC == id)
                           .FirstOrDefault();
            if (hh != null)
                return hh;
            return null;
        }
        public bool delete(int id)
        {
            try
            {
                var nvRemove = context.NHACCs.SingleOrDefault(x => x.MANCC == id);
                context.NHACCs.Remove(nvRemove);
                context.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw ex;
            }
        }

        public bool add(NHACC nv)
        {
            try
            {
                context.NHACCs.Add(nv);
                context.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw ex;
            }
        }



        public bool update(NHACC nv)
        {
            try
            {
                var itemUpdate = context.NHACCs.SingleOrDefault(x => x.MANCC == nv.MANCC);
                itemUpdate.TENNCC = nv.TENNCC;
                itemUpdate.SDT = nv.SDT;
                itemUpdate.DIACHI = nv.DIACHI;
                context.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw ex;
            }
        }

        public int addNewNCC(NHACC kh)
        {

            //int maxMaHD = db.HoaDons.Max(p => p.maHD);
            //  hd.maHD = maxMaHD + 1;
            //  DialogResult dialog = MessageBox.Show("ID: "+hd.maHD, "Thông báo", MessageBoxButtons.YesNo);
            //  return false;
            try
            {
                context.NHACCs.Add(kh);
                context.SaveChanges();
                int id = kh.MANCC;
                // DialogResult dialog = MessageBox.Show("ID: "+id, "Thông báo", MessageBoxButtons.YesNo);

                return id;

            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}

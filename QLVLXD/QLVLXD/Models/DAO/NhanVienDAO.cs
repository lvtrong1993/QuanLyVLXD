using QLVLXD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;

namespace QLVLXD.Models.DAO
{
    class NhanVienDAO
    {
        private VLXDDbContext context;

        public NhanVienDAO()
        {
            context = new QLVLXD.Models.Entities.VLXDDbContext();
        }

        public List<NHANVIEN> getAll()
        {
            try
            {
                var nvs = from b in context.NHANVIENs
                          select b;

                var ks = nvs.ToList();
                return ks;
            }catch(EntityException ex)
            {
                throw ex;
            }
        }

        public NHANVIEN find(int id)
        {
            try
            {
                var nv = context.NHANVIENs
                            .Where(b => b.MANV == id)
                            .FirstOrDefault();
                return nv;
            }
            catch (EntityException ex)
            {
                throw ex;
            }
        }

        public bool delete(int id)
        {
            try
            {
                var nvRemove = context.NHANVIENs.SingleOrDefault(x => x.MANV == id);
                context.NHANVIENs.Remove(nvRemove);
                context.SaveChanges();
                return true;
            }catch(EntityException ex)
            {
                throw ex;
            }
        }

        public bool add(NHANVIEN nv)
        {
            try
            {
                context.NHANVIENs.Add(nv);
                context.SaveChanges();
                return true;
            }catch(EntityException ex)
            {
                throw ex;
            }
        }

        public bool update(NHANVIEN nv)
        {
            try
            {
                var nvUpdate = context.NHANVIENs.SingleOrDefault(x => x.MANV == nv.MANV);
                nvUpdate.TENNV = nv.TENNV;
                nvUpdate.SDT = nv.SDT;
                nvUpdate.DIACHI = nv.DIACHI;
                context.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw ex;
            }
        }
        public NHANVIEN login(string us, string pwd)
        {
            NHANVIEN hh = context.NHANVIENs
                           .Where(b => b.TENDANGNHAP == us && b.MATKHAU==pwd)
                           .FirstOrDefault();
            if (hh != null)
                return hh;
            return null;
        }
    }
}

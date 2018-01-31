using QLVLXD.Models.DAO;
using QLVLXD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLVLXD.Controllers
{
    class NhanVienController
    {
        NhanVienDAO nvDAO;

        public NhanVienController()
        {
             nvDAO = new NhanVienDAO();
        }

        public List<NHANVIEN> getDataLoadView()
        {
            return nvDAO.getAll();
        }

        public NHANVIEN loadDataEdit(int id)
        {
            return nvDAO.find(id);
        }

        public bool delete(int id)
        {
            return nvDAO.delete(id);
        }

        public bool addItem(NHANVIEN nv)
        {
            return nvDAO.add(nv);
        }

        public bool updateItem(NHANVIEN nv)
        {
            return nvDAO.update(nv);
        }
        public NHANVIEN login(string us, string pwd)
        {
            return nvDAO.login(us, pwd);
        }
    
    }
}

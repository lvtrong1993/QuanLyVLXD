using QLVLXD.Models.DAO;
using QLVLXD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLVLXD.Controllers
{
    class NhaCungCapController
    {
        NhaCungCapDAO nccDAO;

        public NhaCungCapController()
        {
            nccDAO = new NhaCungCapDAO();
        }

        public List<NHACC> getDataLoadView()
        {
            return nccDAO.getAll();
        }

        public NHACC loadDataEdit(int id)
        {
            return nccDAO.find(id);
        }

        public bool delete(int id)
        {
            return nccDAO.delete(id);
        }

        public bool addItem(NHACC nv)
        {
            return nccDAO.add(nv);
        }

        public bool updateItem(NHACC nv)
        {
            return nccDAO.update(nv);
        }
        //getNCCById

        public NHACC getNccById(int id)
        {
            return nccDAO.getNCCById(id);
        }
        public int addNewNCC(int maNCC, string tenNCC, int sdt, string diaChi)
        {
            try
            {
                NHACC k = new NHACC(maNCC, tenNCC, sdt, diaChi);
                return nccDAO.addNewNCC(k);

            }
            catch (Exception e)
            {
                return 0;
            }

        }
    }
}

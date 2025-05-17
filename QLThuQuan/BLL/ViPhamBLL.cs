using QLThuQuan.DAL;
using QLThuQuan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuQuan.BLL
{
    class ViPhamBLL
    {
        private ViPhamDAL viPhamDAL = new ViPhamDAL();
        public List<ViPham> GetViPham()
        {
            return viPhamDAL.GetAllViPham();
        }
        public bool AddViPham(ViPham viPham)
        {
            return viPhamDAL.AddViPham(viPham);
        }
        public bool UpdateViPham(ViPham viPham)
        {
            return viPhamDAL.UpdateViPham(viPham);
        }
        public bool DeleteViPham(int id)
        {
            return viPhamDAL.DeleteViPham(id);
        }

        public List<ViPham> SearchViPhamById(string id)
        {
            return viPhamDAL.SearchViPhamById(id);
        }
    }
}
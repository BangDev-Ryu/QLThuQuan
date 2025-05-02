using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuQuan.DAL;
using QLThuQuan.Models;

namespace QLThuQuan.BLL
{
    public class ThanhVienBLL
    {
        private ThanhVienDAL thanhVienDAL = new ThanhVienDAL();

        public List<ThanhVien> GetThanhViens()
        {
            return thanhVienDAL.GetAllThanhVien();
        }

        public bool AddThanhVien(ThanhVien thanhVien)
        {
            return thanhVienDAL.AddThanhVien(thanhVien);
        }

        public bool UpdateThanhVien(ThanhVien thanhVien)
        {
            return thanhVienDAL.UpdateThanhVien(thanhVien);
        }

        public bool DeleteThanhVien(int id)
        {
            return thanhVienDAL.DeleteThanhVien(id);
        }
    }
}

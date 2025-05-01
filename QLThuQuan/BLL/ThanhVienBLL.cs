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
    }
}

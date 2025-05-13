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

        public ThanhVien GetThanhVienByID(int id)
        {
            return thanhVienDAL.getThanhVienByID(id);
        }

        public int checkLogin(int id, string password)
        {
            ThanhVien tv = thanhVienDAL.getThanhVienByID(id);

            if (tv == null)
            {
                return 0; // Tài khoản không tồn tại
            }

            if (password != tv.password)
            {
                return -1; // Sai mật khẩu
            }

            return 1;
        }

        public bool AddLuotVao(int id_thanhVien, DateTime ngayVao)
        {
            return thanhVienDAL.AddLuotVao(id_thanhVien, ngayVao);
        }
    }
}

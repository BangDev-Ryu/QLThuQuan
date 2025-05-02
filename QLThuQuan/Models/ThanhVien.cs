using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuQuan.Models
{
    public class ThanhVien
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }
        public string khoa { get; set; }
        public string nganh { get; set; }
        public string trangThai { get; set; }
        public bool isExist { get; set; }

        public ThanhVien() { }

        public ThanhVien(int id, string username, string password, string fullName, string khoa, string nganh, string trangThai, bool isExist)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.fullName = fullName;
            this.khoa = khoa;
            this.nganh = nganh;
            this.trangThai = trangThai;
            this.isExist = isExist;
        }
    }
}

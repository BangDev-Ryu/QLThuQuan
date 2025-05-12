using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuQuan.Models
{
    public class ThietBi
    {
        public int id { get; set; }
        public string name { get; set; }
        public string loai { get; set; }
        public string trangThai { get; set; }
        public bool isExist { get; set; }

        public ThietBi() { }

        public ThietBi(int id, string name, string loai, string trangThai, bool isExist)
        {
            this.id = id;
            this.name = name;
            this.loai = loai;
            this.trangThai = trangThai;
            this.isExist = isExist;
        }

    }
}

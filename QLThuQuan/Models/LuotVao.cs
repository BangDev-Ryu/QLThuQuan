using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuQuan.Models
{
    public class LuotVao
    {
        public int id_thanhVien { get; set; }
        public DateTime ngayVao { get; set; }

        public LuotVao() { }

        public LuotVao(int id_thanhVien, DateTime ngayVao)
        {
            this.id_thanhVien = id_thanhVien;
            this.ngayVao = ngayVao;
        }
    }
}
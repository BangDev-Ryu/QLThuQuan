using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuQuan.Models
{
    public class PhieuMuon
    {
        public int id { get; set; }
        public int id_thietBi { get; set; }
        public int id_thanhVien { get; set; }
        public string trangThai { get; set; }
        public string loai { get; set; }
        public DateTime ngayMuon { get; set; }
        public DateTime ngayHanTra { get; set; }
        public bool isExist { get; set; }

        public PhieuMuon() { }

        public PhieuMuon(int id, int id_thietBi, int id_thanhVien, 
            string trangThai, string loai, DateTime ngayMuon, DateTime ngayHanTra, bool isExist)
        {
            this.id = id;
            this.id_thietBi = id_thietBi;
            this.id_thanhVien = id_thanhVien;
            this.trangThai = trangThai;
            this.loai = loai;
            this.ngayMuon = ngayMuon;
            this.ngayHanTra = ngayHanTra;
            this.isExist = isExist;
        }
    }
}

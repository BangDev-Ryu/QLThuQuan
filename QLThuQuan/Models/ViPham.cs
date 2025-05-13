using System;

namespace QLThuQuan.Models
{
    public class ViPham
    {
        public int Id { get; set; }
        public int IdThanhVien { get; set; }
        public string HinhThucXuLy { get; set; }
        public int TienBoiThuong { get; set; }
        public DateTime NgayPhat { get; set; }
        public DateTime NgayHetHan { get; set; }
        public string LyDo { get; set; }
        public string TrangThai { get; set; }
        public bool IsExist { get; set; } = true;
        public ViPham() { }
        public ViPham(int id, int idThanhVien, string hinhThucXuLy, int tienBoiThuong, DateTime ngayPhat, DateTime ngayHetHan, string lyDo, string trangThai, bool isExist = true)
        {
            Id = id;
            IdThanhVien = idThanhVien;
            HinhThucXuLy = hinhThucXuLy;
            TienBoiThuong = tienBoiThuong;
            NgayPhat = ngayPhat;
            NgayHetHan = ngayHetHan;
            LyDo = lyDo;
            TrangThai = trangThai;
            IsExist = isExist;
        }
    }
}
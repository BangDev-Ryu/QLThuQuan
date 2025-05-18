using System;
using System.Collections.Generic;
using System.Linq;
using QLThuQuan.DAL;
using QLThuQuan.DB;
using QLThuQuan.Models;

namespace QLThuQuan.BLL
{
    public class ThongKeBLL
    {
        private ThietBiDAL thietBiDAL = new ThietBiDAL();
        private ViPhamDAL viPhamDAL = new ViPhamDAL();
        private ThanhVienDAL thanhVienDAL = new ThanhVienDAL();
        private PhieuMuonDAL phieuMuonDAL = new PhieuMuonDAL();

        public int GetSoThietBiDangMuon()
        {
            return phieuMuonDAL.GetAllPhieuMuon()
                .Where(x => x.trangThai == "Đang mượn")
                .Select(x => x.id_thietBi)
                .Distinct()
                .Count();
        }

        public int GetSoThietBiDaMuon()
        {
            return phieuMuonDAL.GetAllPhieuMuon()
                .Where(x => x.trangThai == "Đã trả")
                .Select(x => x.id_thietBi)
                .Distinct()
                .Count();
        }

        public int GetSoViPhamDaXuLy()
        {
            return viPhamDAL.GetAllViPham().Count(x => x.TrangThai == "Đã xử lý");
        }

        public int GetSoViPhamChuaXuLy()
        {
            return viPhamDAL.GetAllViPham().Count(x => x.TrangThai == "Chưa xử lý");
        }

        public int GetTongTienPhat()
        {
            return viPhamDAL.GetAllViPham()
                .Where(x => x.TrangThai == "Đã xử lý")
                .Sum(x => x.TienBoiThuong);
        }
        public Dictionary<int, int> GetLuotVaoTheoThoiGian(DateTime start, DateTime end)
        {
            var result = new Dictionary<int, int>();

            string query = @"SELECT id_thanh_vien, COUNT(*) as SoLuot 
                             FROM luot_vao 
                             WHERE ngay_vao BETWEEN @start AND @end 
                             GROUP BY id_thanh_vien";

            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(reader.GetInt32("id_thanh_vien"), reader.GetInt32("SoLuot"));
                        }
                    }
                }
            }

            return result;
        }

        public Dictionary<string, int> GetLuotVaoTheoKhoa()
        {
            var result = new Dictionary<string, int>();

            string query = @"SELECT tv.khoa, COUNT(*) as SoLuot 
                             FROM luot_vao lv
                             JOIN thanh_vien tv ON lv.id_thanh_vien = tv.id
                             GROUP BY tv.khoa";

            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(reader.GetString("khoa"), reader.GetInt32("SoLuot"));
                        }
                    }
                }
            }

            return result;
        }

        public Dictionary<int, int> GetLuotVaoTheoThanhVienKhoa(string khoa)
        {
            var result = new Dictionary<int, int>();

            string query = @"SELECT lv.id_thanh_vien, COUNT(*) as SoLuot 
                             FROM luot_vao lv
                             JOIN thanh_vien tv ON lv.id_thanh_vien = tv.id
                             WHERE tv.khoa = @khoa
                             GROUP BY lv.id_thanh_vien";

            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@khoa", khoa);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(reader.GetInt32("id_thanh_vien"), reader.GetInt32("SoLuot"));
                        }
                    }
                }
            }

            return result;
        }
    }
}

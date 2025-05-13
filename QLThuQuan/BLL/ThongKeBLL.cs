using System;
using System.Collections.Generic;
using System.Linq;
using QLThuQuan.DAL;
using QLThuQuan.Models;

namespace QLThuQuan.BLL
{
    public class ThongKeBLL
    {
        private ThietBiDAL thietBiDAL = new ThietBiDAL();
        private ViPhamDAL viPhamDAL = new ViPhamDAL();
        private ThanhVienDAL thanhVienDAL = new ThanhVienDAL();

        public int GetSoThietBiDangMuon()
        {
            return thietBiDAL.getAllThietBi().Count(x => x.trangThai == "Đang mượn");
        }

        public int GetSoThietBiDaMuon()
        {
            return thietBiDAL.getAllThietBi().Count(x => x.trangThai != "Có sẵn");
        }

        public int GetSoViPhamDaXuLy()
        {
            return viPhamDAL.GetAllViPham().Count(x => x.TrangThai == "Đã xử lý");
        }

        public int GetSoViPhamChuaXuLy()
        {
            return viPhamDAL.GetAllViPham().Count(x => x.TrangThai == "Chưa xử lý");
        }

        // Trả về Dictionary<int, int> : ID thành viên - số lượt vào trong khoảng thời gian
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

        // Trả về Dictionary<string, int> : Tên khoa - số lượt vào
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

        // Trả về Dictionary<int, int> : ID thành viên - số lượt vào (chỉ thành viên thuộc khoa được chọn)
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

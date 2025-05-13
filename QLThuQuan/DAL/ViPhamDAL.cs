using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using QLThuQuan.DB;
using QLThuQuan.Models;

namespace QLThuQuan.DAL
{
    public class ViPhamDAL
    {
        // Lấy danh sách tất cả vi phạm
        public List<ViPham> GetAllViPham()
        {
            List<ViPham> list = new List<ViPham>();
            string query = "SELECT * FROM phieu_phat WHERE is_exist = 1";

            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ViPham
                        {
                            Id = reader.GetInt32("id"),
                            IdThanhVien = reader.GetInt32("id_thanh_vien"),
                            HinhThucXuLy = reader.GetString("hinh_thuc_xu_ly"),
                            TienBoiThuong = reader.GetInt32("tien_boi_thuong"),
                            NgayPhat = reader.GetDateTime("ngay_phat"),
                            NgayHetHan = reader.GetDateTime("ngay_het_han"),
                            LyDo = reader.GetString("ly_do"),
                            TrangThai = reader.GetString("trang_thai"),
                            IsExist = reader.GetBoolean("is_exist")
                        });
                    }
                }
            }

            return list;
        }

        // Thêm một vi phạm mới
        public bool AddViPham(ViPham viPham)
        {
            string query = @"INSERT INTO phieu_phat (id_thanh_vien, hinh_thuc_xu_ly, tien_boi_thuong, ngay_phat, ngay_het_han, ly_do, trang_thai, is_exist) 
                             VALUES (@id_thanh_vien, @hinh_thuc_xu_ly, @tien_boi_thuong, @ngay_phat, @ngay_het_han, @ly_do, @trang_thai, 1)";

            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_thanh_vien", viPham.IdThanhVien);
                    cmd.Parameters.AddWithValue("@hinh_thuc_xu_ly", viPham.HinhThucXuLy);
                    cmd.Parameters.AddWithValue("@tien_boi_thuong", viPham.TienBoiThuong);
                    cmd.Parameters.AddWithValue("@ngay_phat", viPham.NgayPhat);
                    cmd.Parameters.AddWithValue("@ngay_het_han", viPham.NgayHetHan);
                    cmd.Parameters.AddWithValue("@ly_do", viPham.LyDo);
                    cmd.Parameters.AddWithValue("@trang_thai", viPham.TrangThai);
                    cmd.Parameters.AddWithValue("@is_exist", viPham.IsExist);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Cập nhật thông tin vi phạm
        public bool UpdateViPham(ViPham viPham)
        {
            string query = @"UPDATE phieu_phat 
                             SET id_thanh_vien = @id_thanh_vien,
                                 hinh_thuc_xu_ly = @hinh_thuc_xu_ly,
                                 tien_boi_thuong = @tien_boi_thuong,
                                 ngay_phat = @ngay_phat,
                                 ngay_het_han = @ngay_het_han,
                                 ly_do = @ly_do,
                                 trang_thai = @trang_thai
                             WHERE id = @id AND is_exist = 1";

            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", viPham.Id);
                    cmd.Parameters.AddWithValue("@id_thanh_vien", viPham.IdThanhVien);
                    cmd.Parameters.AddWithValue("@hinh_thuc_xu_ly", viPham.HinhThucXuLy);
                    cmd.Parameters.AddWithValue("@tien_boi_thuong", viPham.TienBoiThuong);
                    cmd.Parameters.AddWithValue("@ngay_phat", viPham.NgayPhat);
                    cmd.Parameters.AddWithValue("@ngay_het_han", viPham.NgayHetHan);
                    cmd.Parameters.AddWithValue("@ly_do", viPham.LyDo);
                    cmd.Parameters.AddWithValue("@trang_thai", viPham.TrangThai);
                    cmd.Parameters.AddWithValue("@is_exist", viPham.IsExist);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Xóa một vi phạm (đánh dấu is_exist = 0)
        public bool DeleteViPham(int id)
        {
            string query = @"UPDATE phieu_phat 
                             SET is_exist = 0 
                             WHERE id = @id";

            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Tìm kiếm vi phạm theo tên
        public List<ViPham> SearchViPhamByName(string name)
        {
            List<ViPham> list = new List<ViPham>();
            string query = @"SELECT * FROM phieu_phat  
                             WHERE id_thanh_vien LIKE @id_thanh_vien AND is_exist = 1";

            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", $"%{name}%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ViPham
                            {
                                Id = reader.GetInt32("id"),
                                IdThanhVien = reader.GetInt32("id_thanh_vien"),
                                HinhThucXuLy = reader.GetString("hinh_thuc_xu_ly"),
                                TienBoiThuong = reader.GetInt32("tien_boi_thuong"),
                                NgayPhat = reader.GetDateTime("ngay_phat"),
                                NgayHetHan = reader.GetDateTime("ngay_het_han"),
                                LyDo = reader.GetString("ly_do"),
                                TrangThai = reader.GetString("trang_thai"),
                                IsExist = reader.GetBoolean("is_exist")
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}

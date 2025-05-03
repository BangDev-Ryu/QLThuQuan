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
            string query = "SELECT * FROM vi_pham WHERE is_exist = 1";

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
                            TenViPham = reader.GetString("name"),
                            LyDo = reader.GetString("lydo")
                        });
                    }
                }
            }

            return list;
        }

        // Thêm một vi phạm mới
        public bool AddViPham(ViPham viPham)
        {
            string query = @"INSERT INTO vi_pham (name, lydo, is_exist) 
                             VALUES (@name, @lydo, 1)";

            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", viPham.TenViPham);
                    cmd.Parameters.AddWithValue("@lydo", viPham.LyDo);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Cập nhật thông tin vi phạm
        public bool UpdateViPham(ViPham viPham)
        {
            string query = @"UPDATE vi_pham 
                             SET name = @name, 
                                 lydo = @lydo
                             WHERE id = @id AND is_exist = 1";

            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", viPham.Id);
                    cmd.Parameters.AddWithValue("@name", viPham.TenViPham);
                    cmd.Parameters.AddWithValue("@lydo", viPham.LyDo);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Xóa một vi phạm (đánh dấu is_exist = 0)
        public bool DeleteViPham(int id)
        {
            string query = @"UPDATE vi_pham 
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
            string query = @"SELECT * FROM vi_pham 
                             WHERE name LIKE @name AND is_exist = 1";

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
                                TenViPham = reader.GetString("name"),
                                LyDo = reader.GetString("lydo")
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using QLThuQuan.DB;
using QLThuQuan.Models;

namespace QLThuQuan.DAL
{
    public class ThanhVienDAL
    {
        public List<ThanhVien> GetAllThanhVien()
        {
            List<ThanhVien> list = new List<ThanhVien>();

            string query = "SELECT * FROM thanh_vien WHERE is_exist = 1";
            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ThanhVien(
                            reader.GetInt32("id"),
                            reader.GetString("username"),
                            reader.GetString("password"),
                            reader.GetString("fullname"),
                            reader.GetString("khoa"),
                            reader.GetString("nganh"),
                            reader.GetString("trang_thai"),
                            reader.GetBoolean("is_exist")
                        ));
                    }
                }
            }

            return list;
        }

        public bool AddThanhVien(ThanhVien thanhVien)
        {
            string query = @"INSERT INTO thanh_vien (username, password, fullname, khoa, nganh, trang_thai, is_exist) 
                            VALUES (@username, @password, @fullname, @khoa, @nganh, @trangThai, @isExist)";
                            
            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", thanhVien.username);
                    cmd.Parameters.AddWithValue("@password", thanhVien.password);
                    cmd.Parameters.AddWithValue("@fullname", thanhVien.fullName); 
                    cmd.Parameters.AddWithValue("@khoa", thanhVien.khoa);
                    cmd.Parameters.AddWithValue("@nganh", thanhVien.nganh);
                    cmd.Parameters.AddWithValue("@trangThai", thanhVien.trangThai);
                    cmd.Parameters.AddWithValue("@isExist", thanhVien.isExist);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateThanhVien(ThanhVien thanhVien) 
        {
            string query = @"UPDATE thanh_vien 
                            SET username = @username,
                                password = @password, 
                                fullname = @fullname,
                                khoa = @khoa,
                                nganh = @nganh,
                                trang_thai = @trangThai,
                                is_exist = @isExist
                            WHERE id = @id";

            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", thanhVien.id);
                    cmd.Parameters.AddWithValue("@username", thanhVien.username);
                    cmd.Parameters.AddWithValue("@password", thanhVien.password);
                    cmd.Parameters.AddWithValue("@fullname", thanhVien.fullName);
                    cmd.Parameters.AddWithValue("@khoa", thanhVien.khoa); 
                    cmd.Parameters.AddWithValue("@nganh", thanhVien.nganh);
                    cmd.Parameters.AddWithValue("@trangThai", thanhVien.trangThai);
                    cmd.Parameters.AddWithValue("@isExist", thanhVien.isExist);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteThanhVien(int id)
        {
            string query = @"UPDATE thanh_vien 
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

        public ThanhVien getThanhVienByUserName(string username)
        {
            string query = "SELECT * FROM thanh_vien WHERE username = @username";

            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ThanhVien(
                                reader.GetInt32("id"),
                                reader.GetString("username"),
                                reader.GetString("password"),
                                reader.GetString("fullname"),
                                reader.GetString("khoa"),
                                reader.GetString("nganh"),
                                reader.GetString("trang_thai"),
                                reader.GetBoolean("is_exist")
                            );
                        }
                    }
                }
            }

            return null;
        }

        public bool AddLuotVao(int id_thanhVien, DateTime ngayVao)
        {
            string query = @"INSERT INTO luot_vao (id_thanh_vien, ngay_vao) 
                            VALUES (@id_thanh_vien, @ngay_vao)";
            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_thanh_vien", id_thanhVien);
                    cmd.Parameters.AddWithValue("@ngay_vao", ngayVao);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }



    }
}


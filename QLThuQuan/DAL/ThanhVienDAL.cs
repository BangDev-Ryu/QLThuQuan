using System;
using System.Collections.Generic;
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

            string query = "SELECT * FROM thanh_vien";
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
                            reader.GetBoolean("is_exist")
                        ));
                    }
                }

            }

            return list;
        }
    }
}

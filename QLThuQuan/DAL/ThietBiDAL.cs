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
    public class ThietBiDAL
    {
        public List<ThietBi> getAllThietBi()
        {
            List<ThietBi> listThietBi = new List<ThietBi>();
            string query = "SELECT * FROM thiet_bi WHERE is_exist = 1";
            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listThietBi.Add(new ThietBi(
                            reader.GetInt32("id"),
                            reader.GetString("name"),
                            reader.GetString("loai"),
                            reader.GetBoolean("is_exist")
                        ));
                    }
                }

            }
            return listThietBi;
        }


        public bool addThietBi(ThietBi thietBi)
        {
            string query = @"INSERT INTO thiet_bi (name, loai, is_exist) VALUES (@name, @loai, @isExist)";

            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))

                {
                    cmd.Parameters.AddWithValue("@name", thietBi.name);
                    cmd.Parameters.AddWithValue("@loai", thietBi.loai);
                    cmd.Parameters.AddWithValue("@isExist", thietBi.isExist);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool updateThietBi(ThietBi thietBi)
        {
            string query = @"UPDATE thiet_bi 
                             SET name = @name,
                                 loai = @loai,
                                 is_exist = @isExist
                             WHERE id = @id";
            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", thietBi.id);
                    cmd.Parameters.AddWithValue("@name", thietBi.name);
                    cmd.Parameters.AddWithValue("@loai", thietBi.loai);
                    cmd.Parameters.AddWithValue("@isExist", thietBi.isExist);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool deleteThietBi(int id)
        {
            string query = @"UPDATE thiet_bi
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
    }
}

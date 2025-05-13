using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using QLThuQuan.DB;
using QLThuQuan.Models;

namespace QLThuQuan.DAL
{
    public class PhieuMuonDAL
    {
        public List<PhieuMuon> GetAllPhieuMuon()
        {
            List<PhieuMuon> list = new List<PhieuMuon>();

            string query = "SELECT * FROM phieu_muon WHERE is_exist = 1";
            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new PhieuMuon(
                            reader.GetInt32("id"),
                            reader.GetInt32("id_thiet_bi"),
                            reader.GetInt32("id_thanh_vien"),
                            reader.GetString("trang_thai"),
                            reader.GetString("loai"),
                            reader.GetDateTime("ngay_muon"),
                            reader.GetDateTime("ngay_han_tra"),
                            reader.GetBoolean("is_exist")
                        ));
                    }
                }
            }

            return list;
        }

        public bool AddPhieuMuon(PhieuMuon phieuMuon)
        {
            string query = @"INSERT INTO phieu_muon 
                (id_thiet_bi, id_thanh_vien, trang_thai, loai, ngay_muon, ngay_han_tra, is_exist) 
                VALUES (@id_thiet_bi, @id_thanh_vien, @trang_thai, @loai, @ngay_muon, @ngay_han_tra, @is_exist)";

            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_thiet_bi", phieuMuon.id_thietBi);
                    cmd.Parameters.AddWithValue("@id_thanh_vien", phieuMuon.id_thanhVien);
                    cmd.Parameters.AddWithValue("@trang_thai", phieuMuon.trangThai);
                    cmd.Parameters.AddWithValue("@loai", phieuMuon.loai);
                    cmd.Parameters.AddWithValue("@ngay_muon", phieuMuon.ngayMuon);
                    cmd.Parameters.AddWithValue("@ngay_han_tra", phieuMuon.ngayHanTra);
                    cmd.Parameters.AddWithValue("@is_exist", phieuMuon.isExist);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateTrangThaiVaNgayTraByID(int id_thietBi, string trangThai, DateTime ngayHanTra)
        {
            string query = @"UPDATE phieu_muon 
                     SET trang_thai = @trang_thai, ngay_han_tra = @ngay_han_tra
                     WHERE id_thiet_bi = @id_thiet_bi";

            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@trang_thai", trangThai);
                    cmd.Parameters.AddWithValue("@ngay_han_tra", ngayHanTra);
                    cmd.Parameters.AddWithValue("@id_thiet_bi", id_thietBi);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


    }
}



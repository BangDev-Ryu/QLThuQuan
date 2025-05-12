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
    public class CTPhieuMuonDAL
    {
        public List<CTPhieuMuon> GetAllCTPhieuMuon()
        {
            List<CTPhieuMuon> list = new List<CTPhieuMuon>();

            string query = "SELECT * FROM ct_phieu_muon";
            using (var conn = DBConnect.GetConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CTPhieuMuon(
                            reader.GetInt32("id_phieu_muon"),
                            reader.GetInt32("id_thiet_bi")
                        ));
                    }
                }
            }

            return list;
        }

        public bool AddCTPhieuMuon(CTPhieuMuon CTphieuMuon)
        {
            string query = @"INSERT INTO ct_phieu_muon (id_phieu_muon, id_thiet_bi) 
                 VALUES (@id_phieu_muon, @id_thiet_bi)";


            using (var conn = DBConnect.GetConnection())
            {
              
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_phieu_muon", CTphieuMuon.idPhieuMuon);
                    cmd.Parameters.AddWithValue("@id_thiet_bi", CTphieuMuon.idThietBi);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }



    }
}

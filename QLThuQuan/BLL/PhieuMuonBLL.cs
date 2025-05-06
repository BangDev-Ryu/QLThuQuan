using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuQuan.DAL;
using QLThuQuan.Models;

namespace QLThuQuan.BLL
{
    public class PhieuMuonBLL
    {
        private PhieuMuonDAL phieuMuonDAL = new PhieuMuonDAL();

        public List<PhieuMuon> GetPhieuMuons()
        {
            return phieuMuonDAL.GetAllPhieuMuon ();
        }

       public int AddPhieuMuon(PhieuMuon phieuMuon)
        {
            return phieuMuonDAL.AddPhieuMuon (phieuMuon);
        }
    }
}

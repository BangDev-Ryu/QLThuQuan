using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuQuan.DAL;
using QLThuQuan.Models;

namespace QLThuQuan.BLL
{
    public class CTPhieuMuonBLL
    {
        private CTPhieuMuonDAL CTphieuMuonDAL = new CTPhieuMuonDAL();

        public List<CTPhieuMuon> GetCTPhieuMuons()
        {
            return CTphieuMuonDAL.GetAllCTPhieuMuon ();
        }

       public bool AddCTPhieuMuon(CTPhieuMuon CTphieuMuon)
        {
            return CTphieuMuonDAL.AddCTPhieuMuon (CTphieuMuon);
        }
    }
}

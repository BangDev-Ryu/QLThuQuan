using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuQuan.Models
{
    public class CTPhieuMuon
    {
        public int idPhieuMuon { get; set; }
        public int idThietBi{ get; set; }

        public CTPhieuMuon() { }

        public CTPhieuMuon(int idPhieuMuon, int idThietBi)
        {
            this.idPhieuMuon = idPhieuMuon;
            this.idThietBi = idThietBi;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuQuan.DAL;
using QLThuQuan.Models;

namespace QLThuQuan.BLL
{
    public class ThietBiBLL
    {
        private ThietBiDAL thietBiDAL = new ThietBiDAL();

        public List<ThietBi> GetALLThietBi()
        {
            return thietBiDAL.getAllThietBi();
        }

        public bool AddThietBi(ThietBi thietBi)
        {
            return thietBiDAL.addThietBi(thietBi);
        }

        public bool UpdateThietBi(ThietBi thietBi)
        {
            return thietBiDAL.updateThietBi(thietBi);
        }

        public bool DeleteThietBi(int id)
        {
            return thietBiDAL.deleteThietBi(id);
        }
    }
}

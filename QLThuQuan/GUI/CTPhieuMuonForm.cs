using MySqlX.XDevAPI.Relational;
using QLThuQuan.BLL;
using QLThuQuan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuQuan.GUI
{
    public partial class CTPhieuMuonForm : Form
    {
        private CTPhieuMuonBLL CTphieuMuonBLL = new CTPhieuMuonBLL();
        public CTPhieuMuonForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            
        }

        private void InitializeDataGridView()
        {
            tableCTPhieuMuon.AutoGenerateColumns = false;

            idPhieuMuonTable.DataPropertyName = "idPhieuMuon";
            id_ThietBiTable.DataPropertyName = "idThietBi";
        }


        private void CTPhieuMuonForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            List<CTPhieuMuon> list = CTphieuMuonBLL.GetCTPhieuMuons();
            tableCTPhieuMuon.DataSource = null;
            tableCTPhieuMuon.DataSource = list;
            tableCTPhieuMuon.ClearSelection();
        }

    }
}

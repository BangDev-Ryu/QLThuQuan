using QLThuQuan.BLL;
using QLThuQuan.DAL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLThuQuan.GUI
{
    public partial class PhieuMuonForm : Form
    {
        private PhieuMuonBLL phieuMuonBLL = new PhieuMuonBLL();
        private ThanhVienBLL thanhVienBLL = new ThanhVienBLL();



        public PhieuMuonForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            tablePhieuMuon.AutoGenerateColumns = false;

            idTable.DataPropertyName = "id";
            id_thanhVienTable.DataPropertyName = "id_thanhVien";
            trangThaiTable.DataPropertyName = "trangThai";
            loaiTable.DataPropertyName = "loai";
            ngayMuonTable.DataPropertyName = "ngayMuon";

        }
        public void PhieuMuonForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            List<PhieuMuon> list = phieuMuonBLL.GetPhieuMuons();
            tablePhieuMuon.DataSource = null;
            tablePhieuMuon.DataSource = list;
            tablePhieuMuon.ClearSelection();
        }



        private void btnMuon_Click(object sender, EventArgs e)
        {
            MuonThietBiForm m = new MuonThietBiForm();
            m.StartPosition = FormStartPosition.CenterParent;

            if (m.ShowDialog() == DialogResult.OK)
            {
                int tvID = int.Parse(m.tvIDInput);
                int tbID = int.Parse(m.tbIDInput);


                string loaiInput = m.LoaiInput;

                string trangThaiInput = "Đang xử lý";
                bool isExistInput = true;

                DateTime ngayMuonInput = DateTime.Now;

                PhieuMuon phieuMuon = new PhieuMuon
                {
                    id_thanhVien = tvID,
                    trangThai = trangThaiInput,
                    loai = loaiInput,
                    ngayMuon = ngayMuonInput,
                    isExist = isExistInput
                };

                int idPhieuMuonMoi = phieuMuonBLL.AddPhieuMuon(phieuMuon);

      
                LoadData();
                MessageBox.Show("Đã mượn thiết bị thành công.");
            }

        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            TraThietBiForm t = new TraThietBiForm();
            t.StartPosition = FormStartPosition.CenterParent;
            if (t.ShowDialog() == DialogResult.OK)
            {
                string tbID = t.tbIDTraInput;
                DateTime timeTra = DateTime.Now;

                MessageBox.Show($"Đã trả thiết bị {tbID} lúc {timeTra:HH:mm:ss dd/MM/yyyy}", "Thông báo");
            }
        }

      
    }
    }

  


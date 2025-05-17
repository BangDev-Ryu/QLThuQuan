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
        private ThietBiBLL thietBiBLL = new ThietBiBLL();



        public PhieuMuonForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            tablePhieuMuon.AutoGenerateColumns = false;

            idTable.DataPropertyName = "id";
            id_thietBiTable.DataPropertyName = "id_thietBi";
            id_thanhVienTable.DataPropertyName = "id_thanhVien";
            trangThaiTable.DataPropertyName = "trangThai";
            loaiTable.DataPropertyName = "loai";
            ngayMuonTable.DataPropertyName = "ngayMuon";
            ngayHanTraTable.DataPropertyName = "ngayHanTra";

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
            try
            {
                MuonThietBiForm m = new MuonThietBiForm();
                m.StartPosition = FormStartPosition.CenterParent;

                if (m.ShowDialog() == DialogResult.OK)
                {
                    int tvID = int.Parse(m.tvIDInput);
                    int tbID = int.Parse(m.tbIDInput);
                    string loaiInput = m.LoaiInput;
                    string trangThaiInput = "Đang mượn";
                    bool isExistInput = true;
                    DateTime ngayMuonInput = DateTime.Now;
                    DateTime ngayTraInput = DateTime.MinValue;

                    var phieuMuonList = phieuMuonBLL.GetPhieuMuons();
                    var thisPhieuMuon = phieuMuonList
                        .Where(p => p.id_thietBi == tbID)
                        .OrderByDescending(p => p.id)
                        .FirstOrDefault();

                    PhieuMuon phieuMuon = new PhieuMuon
                    {
                        id_thietBi = tbID,
                        id_thanhVien = tvID,
                        trangThai = trangThaiInput,
                        loai = loaiInput,
                        ngayMuon = ngayMuonInput,
                        ngayHanTra = ngayTraInput,
                        isExist = isExistInput
                    };

                    if (thisPhieuMuon != null)
                    {
                        if (thisPhieuMuon.trangThai == "Đang mượn")
                        {
                            MessageBox.Show("Thiết bị đã được mượn");
                            return;
                        }
                        else if (thisPhieuMuon.trangThai == "Đã trả" || thisPhieuMuon.trangThai == "Có sẵn")
                        {
                            phieuMuonBLL.AddPhieuMuon(phieuMuon);
                            thietBiBLL.UpdateTrangThaiByID(tbID, trangThaiInput);
                            LoadData();
                            MessageBox.Show($"Mượn thiết bị {tbID} thành công lúc {ngayMuonInput:HH:mm:ss dd/MM/yyyy}", "Thông báo");
                        }
                    }
                    else
                    {
                        phieuMuonBLL.AddPhieuMuon(phieuMuon);
                        thietBiBLL.UpdateTrangThaiByID(tbID, trangThaiInput);
                        LoadData();
                        MessageBox.Show($"Mượn thiết bị {tbID} thành công lúc {ngayMuonInput:HH:mm:ss dd/MM/yyyy}", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Lỗi: " + ex.ToString());

            }
        }


        private void btnTra_Click(object sender, EventArgs e)
        {
            TraThietBiForm t = new TraThietBiForm();
            t.StartPosition = FormStartPosition.CenterParent;
            if (t.ShowDialog() == DialogResult.OK)
            {
                int tbID = int.Parse(t.tbIDTraInput);
                DateTime timeTra = DateTime.Now;

                var phieuMuonList = phieuMuonBLL.GetPhieuMuons();
                var thisPhieuMuon = phieuMuonList.FirstOrDefault(p => p.id_thietBi == tbID);
                string trangThai = "Đã trả";
                
                if(thisPhieuMuon != null)
                {
                    if (thisPhieuMuon.trangThai == "Đang mượn")
                    {
                        phieuMuonBLL.UpdateTrangThaiVaNgayTraByID(tbID, trangThai, timeTra);
                        thietBiBLL.UpdateTrangThaiByID(tbID, "Có sẵn");
                        LoadData();
                        MessageBox.Show($"Đã trả thiết bị {tbID} lúc {timeTra:HH:mm:ss dd/MM/yyyy}", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Trả thiết bị thất bại.");

                    }
                }
                else
                {
                    MessageBox.Show("Không có thiết bị để trả");
                }
            }
        }

      
    }
    }

  


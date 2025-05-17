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
using System.Xml.Linq;

namespace QLThuQuan.GUI
{
    public partial class ViPhamFormControl: Form
    {
        ViPhamBLL viPhamBLL = new ViPhamBLL();

        public int id;
        public string idThanhVien => txtIdThanhVien.Text;
        public string hinhThucXuLy => txtHinhThuc.Text;
        public int tienBoiThuong => int.Parse(txtTien.Text);
        public DateTime ngayPhat => DateTime.Parse(dtNgayPhat.Text);
        public DateTime ngayHethan => DateTime.Parse(dtNgayHetHan.Text);
        public string lyDo => txtLyDo.Text;
        public bool isExist => true;

        public ViPhamFormControl(ViPham viPham = null)
        {
            InitializeComponent();
            if (viPham != null)
            {
                this.id = viPham.Id;
                txtIdThanhVien.Text = viPham.IdThanhVien.ToString();
                txtHinhThuc.Text = viPham.HinhThucXuLy;
                txtTien.Text = viPham.TienBoiThuong.ToString();
                dtNgayPhat.Text = viPham.NgayPhat.ToString("yyyy-MM-dd");
                dtNgayHetHan.Text = viPham.NgayHetHan.ToString("yyyy-MM-dd");
                txtLyDo.Text = viPham.LyDo;
            }
        }

        private void ViPhamFormControl_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdThanhVien.Text) || string.IsNullOrEmpty(txtHinhThuc.Text) || string.IsNullOrEmpty(txtTien.Text) || string.IsNullOrEmpty(dtNgayPhat.Text) || string.IsNullOrEmpty(dtNgayHetHan.Text) || string.IsNullOrEmpty(txtLyDo.Text) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var viPham = new ViPham
            {
                Id = this.id,
                IdThanhVien = int.Parse(txtIdThanhVien.Text.Trim()),
                HinhThucXuLy = txtHinhThuc.Text.Trim(),
                TienBoiThuong = int.Parse(txtTien.Text.Trim()),
                NgayPhat = DateTime.Parse(dtNgayPhat.Text.Trim()),
                NgayHetHan = DateTime.Parse(dtNgayHetHan.Text.Trim()),
                LyDo = txtLyDo.Text.Trim(),
                TrangThai = "Đang xử lý",
                IsExist = true
            };

            try
            {
                bool result;
                if (this.id == 0)
                {
                    result = viPhamBLL.AddViPham(viPham);
                }
                else
                {
                    result = viPhamBLL.UpdateViPham(viPham);
                }

                if (result)
                {
                    MessageBox.Show("Thao tác thành công!", "Thông báo",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thao tác thất bại!", "Lỗi",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

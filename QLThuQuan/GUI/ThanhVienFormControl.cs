using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuQuan.BLL;
using QLThuQuan.Models;

namespace QLThuQuan.GUI
{
    public partial class ThanhVienFormControl : Form
    {
        ThanhVienBLL thanhVienBLL = new ThanhVienBLL();

        public int id;
        public string username => txtUsername.Text;
        public string password => txtPassword.Text;
        public string fullName => txtFullname.Text;
        public string khoa => txtKhoa.Text;
        public string nganh => txtNganh.Text;
        public string trangThai;
        public bool isExist => true;
        public ThanhVienFormControl()
        {
            InitializeComponent();
        }

        public ThanhVienFormControl(ThanhVien thanhVien = null)
        {
            InitializeComponent();
            if (thanhVien != null)
            {
                this.id = thanhVien.id;
                txtUsername.Text = thanhVien.username;
                txtPassword.Text = thanhVien.password;
                txtFullname.Text = thanhVien.fullName;
                txtKhoa.Text = thanhVien.khoa;
                txtNganh.Text = thanhVien.nganh;
                trangThai = thanhVien.trangThai;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || 
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtFullname.Text) ||
                string.IsNullOrEmpty(txtKhoa.Text) ||
                string.IsNullOrEmpty(txtNganh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var thanhVien = new ThanhVien
            {
                id = this.id,
                username = txtUsername.Text.Trim(),
                password = txtPassword.Text.Trim(),
                fullName = txtFullname.Text.Trim(), 
                khoa = txtKhoa.Text.Trim(),
                nganh = txtNganh.Text.Trim(),
                trangThai = "Hoạt động", 
                isExist = true
            };

            try {
                bool result;
                if (thanhVien.id == 0)
                {
                    result = thanhVienBLL.AddThanhVien(thanhVien);
                }
                else 
                {
                    result = thanhVienBLL.UpdateThanhVien(thanhVien);
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
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

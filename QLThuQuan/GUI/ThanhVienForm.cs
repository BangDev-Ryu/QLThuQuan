﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuQuan.BLL;
using QLThuQuan.DAL;
using QLThuQuan.Models;

namespace QLThuQuan.GUI
{
    public partial class ThanhVienForm : Form
    {
        private ThanhVienBLL thanhVienBLL = new ThanhVienBLL();
        public ThanhVienForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            tableThanhVien.AutoGenerateColumns = false;

            id.DataPropertyName = "id";
            username.DataPropertyName = "username"; 
            password.DataPropertyName = "password";
            fullname.DataPropertyName = "fullname";
            khoa.DataPropertyName = "khoa";
            nganh.DataPropertyName = "nganh";
            trangThai.DataPropertyName = "trangThai";
        }

        public void ThanhVienForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            List<ThanhVien> list = thanhVienBLL.GetThanhViens();
            tableThanhVien.DataSource = null;
            tableThanhVien.DataSource = list;
            tableThanhVien.ClearSelection();
        }

        private void btnAddThanhVien_Click(object sender, EventArgs e)
        {
            var addForm = new ThanhVienFormControl();
            addForm.ShowDialog();
            LoadData();
        }

        private void btnUpdateThanhVien_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (tableThanhVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thành viên cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin thành viên từ dòng được chọn
            var selectedRow = tableThanhVien.SelectedRows[0];
            var thanhVien = new ThanhVien
            {
                id = Convert.ToInt32(selectedRow.Cells["id"].Value),
                username = selectedRow.Cells["username"].Value.ToString(),
                password = selectedRow.Cells["password"].Value.ToString(),
                fullName = selectedRow.Cells["fullname"].Value.ToString(),
                khoa = selectedRow.Cells["khoa"].Value.ToString(),
                nganh = selectedRow.Cells["nganh"].Value.ToString(),
                trangThai = selectedRow.Cells["trangThai"].Value.ToString(),
                isExist = true
            };

            var updateForm = new ThanhVienFormControl(thanhVien);
            updateForm.ShowDialog();

            LoadData();
        }

        private void btnDeleteThanhVien_Click(object sender, EventArgs e)
        {
            if (tableThanhVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thành viên cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            // Lấy thông tin thành viên từ dòng được chọn
            var selectedRow = tableThanhVien.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

            // Hiện hộp thoại xác nhận xóa
            var result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (thanhVienBLL.DeleteThanhVien(id))
                    {
                        MessageBox.Show("Xóa thành viên thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); 
                    }
                    else
                    {
                        MessageBox.Show("Xóa thành viên thất bại!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tableThanhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuanLyPhieuMuon_Click(object sender, EventArgs e)
        {
            PhieuMuonForm f = new PhieuMuonForm();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog(this);



        }

        private void btnAddLuotVao_Click(object sender, EventArgs e)
        {
            using (AddLuotVaoForm formAdd = new AddLuotVaoForm())
            {
                if (formAdd.ShowDialog() == DialogResult.OK)
                {
                    int ID = formAdd.IDInput;
                    string Password = formAdd.PasswordInput;

                    ThanhVien tv = thanhVienBLL.GetThanhVienByID(ID);

                    // Nếu có password (nhập tay), kiểm tra lại, nếu không thì bỏ qua (quét chỉ dùng ID)
                    if (!string.IsNullOrEmpty(Password))
                    {
                        int checkLog = thanhVienBLL.checkLogin(ID, Password);

                        if (checkLog == 0)
                        {
                            MessageBox.Show("Không phải thành viên.");
                            return;
                        }
                        else if (checkLog == -1)
                        {
                            MessageBox.Show("Mật khẩu không đúng.");
                            return;
                        }
                    }

                    if (tv.trangThai == "Đang vi phạm")
                    {
                        MessageBox.Show("Thành viên đang bị xử lý vi phạm.");
                        return;
                    }

                    // Đã thêm lượt vào trong form rồi, có thể hiện thêm thông báo ở đây nếu muốn
                    MessageBox.Show("Ghi nhận lượt vào thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Nếu muốn load lại danh sách hoặc làm gì thêm, làm ở đây
                    LoadData();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
            }
            else
            {
                List<ThanhVien> result = thanhVienBLL.SearchThanhVien(keyword);
                tableThanhVien.DataSource = null;
                tableThanhVien.DataSource = result;
                tableThanhVien.ClearSelection();
            }
        }
    }
}

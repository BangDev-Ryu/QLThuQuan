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
using System.Xml.Linq;

namespace QLThuQuan.GUI
{
    public partial class ViPhamForm : Form
    {
        private ViPhamBLL viPhamBLL = new ViPhamBLL();
        public ViPhamForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            tableViPham.AutoGenerateColumns = false;
            id.DataPropertyName = "id";
            idthanhvien.DataPropertyName = "idthanhvien";
            hinhthucxuly.DataPropertyName = "hinhthucxuly";
            tienboithuong.DataPropertyName = "tienboithuong";
            ngayphat.DataPropertyName = "ngayphat";
            ngayhethan.DataPropertyName = "ngayhethan";
            lydo.DataPropertyName = "lydo";
            trangthai.DataPropertyName = "trangthai";
            isexist.DataPropertyName = "isexist";
        }
        public void LoadData()
        {
            List<ViPham> list = viPhamBLL.GetViPham();
            tableViPham.DataSource = null;
            tableViPham.DataSource = list;
            tableViPham.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addForm = new ViPhamFormControl();
            addForm.ShowDialog();
            LoadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (tableViPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = tableViPham.SelectedRows[0];

            var viPham = new ViPham
            {
                Id = Convert.ToInt32(selectedRow.Cells["id"].Value),
                IdThanhVien = Convert.ToInt32(selectedRow.Cells["idthanhvien"].Value),
                HinhThucXuLy = selectedRow.Cells["hinhthucxuly"].Value.ToString(),
                TienBoiThuong = Convert.ToInt32(selectedRow.Cells["tienboithuong"].Value),
                NgayPhat = Convert.ToDateTime(selectedRow.Cells["ngayphat"].Value),
                NgayHetHan = Convert.ToDateTime(selectedRow.Cells["ngayhethan"].Value),
                LyDo = selectedRow.Cells["lydo"].Value.ToString(),
                TrangThai = selectedRow.Cells["trangthai"].Value.ToString(),
                IsExist = true
            };
            var updateForm = new ViPhamFormControl(viPham);
            updateForm.ShowDialog();
            LoadData();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (tableViPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn vi phạm muốn xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = tableViPham.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

            var result = MessageBox.Show(
                $"Bạn có muốn xóa?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (viPhamBLL.DeleteViPham(id))
                    {
                        MessageBox.Show("Xóa vi phạm thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa vi phạm thất bại!", "Lỗi",
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
    }
}

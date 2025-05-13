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
using QLThuQuan.DAL;
using QLThuQuan.Models;
using OfficeOpenXml;
using System.IO;
using LicenseContext = OfficeOpenXml.LicenseContext;
namespace QLThuQuan.GUI
{
    public partial class ThietBiForm : Form
    {
        private ThietBiBLL thietBiBLL = new ThietBiBLL();
        public ThietBiForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private void InitializeDataGridView()
        {
            tableThietBi.AutoGenerateColumns = false;
            id.DataPropertyName = "id";
            name.DataPropertyName = "name";
            loai.DataPropertyName = "loai";
            trangThai.DataPropertyName = "trangThai";
        }

        public void LoadData()
        {
            List<ThietBi> list = thietBiBLL.GetALLThietBi();
            tableThietBi.DataSource = null;
            tableThietBi.DataSource = list;
            tableThietBi.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThietBiForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var addForm = new ThietBiFormControl();
            addForm.ShowDialog();
            LoadData();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if(tableThietBi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = tableThietBi.SelectedRows[0];

            var thietBi = new ThietBi
            {
                id = Convert.ToInt32(selectedRow.Cells["id"].Value),
                name = selectedRow.Cells["name"].Value.ToString(),
                loai = selectedRow.Cells["loai"].Value.ToString(),
                isExist = true
            };
            var updateForm = new ThietBiFormControl(thietBi);
            updateForm.ShowDialog();
            LoadData();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (tableThietBi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = tableThietBi.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["id"].Value);

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
                    if (thietBiBLL.DeleteThietBi(id))
                    {
                        MessageBox.Show("Xóa thiết bị thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thiết bị thất bại!", "Lỗi",
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<ThietBi> list = thietBiBLL.SearchThietBi(keyword);
            tableThietBi.DataSource = null;
            tableThietBi.DataSource = list;
            tableThietBi.ClearSelection();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            txtSearch.Text = string.Empty;
            MessageBox.Show("Dữ liệu đã được làm mới!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<ThietBi> ReadExcelFile(string filePath)
        {
            List<ThietBi> thietBiList = new List<ThietBi>();

            using (var package = new ExcelPackage(new System.IO.FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0]; 
                int rowCount = worksheet.Dimension.Rows; 

                for (int row = 2; row <= rowCount; row++) 
                {
                    var thietBi = new ThietBi
                    {
                        name = worksheet.Cells[row, 1].Text.Trim(), 
                        loai = worksheet.Cells[row, 2].Text.Trim(),
                        trangThai = "Có sẵn", 
                        isExist = true 
                    };

                    thietBiList.Add(thietBi);
                }
            }

            return thietBiList;
        }


        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
                Title = "Chọn tệp Excel"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    var thietBiList = ReadExcelFile(filePath);

                    foreach (var thietBi in thietBiList)
                    {
                        thietBiBLL.AddThietBi(thietBi);
                    }

                    MessageBox.Show("Nhập dữ liệu từ Excel thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
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

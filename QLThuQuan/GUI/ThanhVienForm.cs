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

            id.DataPropertyName = "Id";
            username.DataPropertyName = "Username"; 
            password.DataPropertyName = "Password";
            fullname.DataPropertyName = "FullName";
            khoa.DataPropertyName = "Khoa";
            nganh.DataPropertyName = "Nganh";
        }

        public void ThanhVienForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            List<ThanhVien> list = thanhVienBLL.GetThanhViens();
            tableThanhVien.DataSource = list;
        }

    }
}

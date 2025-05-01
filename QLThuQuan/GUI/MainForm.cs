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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadFormToPanel(Form childForm)
        {
            // Xóa form cũ
            pnContent.Controls.Clear();

            // Thiết lập để nhúng
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Thêm vào panel và hiển thị
            pnContent.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new ThietBiForm());
        }

        private void btnThanhVien_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new ThanhVienForm());
        }

        private void btnViPham_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new ViPhamForm());
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadFormToPanel(new ThongKeForm());
        }
    }
}

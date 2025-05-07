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
    public partial class MuonThietBiForm : Form
    {
        public string tvIDInput { get; private set; }
        public string tbIDInput { get; private set; }
        public string LoaiInput { get; private set; }
        public MuonThietBiForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttvID.Text) || string.IsNullOrWhiteSpace(txttbID.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (cmbLoai.SelectedItem == null || cmbLoai.SelectedItem.ToString() == "Chọn loại")
            {
                MessageBox.Show("Vui lòng chọn loại hợp lệ.");
                return;
            }

            tvIDInput = txttvID.Text.Trim();
            tbIDInput = txttbID.Text.Trim();
            LoaiInput = cmbLoai.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

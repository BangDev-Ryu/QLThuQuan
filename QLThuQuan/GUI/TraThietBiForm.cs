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
    public partial class TraThietBiForm : Form
    {
        public string tbIDTraInput { get; private set; }
        public TraThietBiForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txttbIDTra.Text))
            {
                tbIDTraInput = txttbIDTra.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã thiết bị.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

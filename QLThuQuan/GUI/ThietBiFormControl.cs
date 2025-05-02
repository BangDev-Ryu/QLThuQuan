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
    public partial class ThietBiFormControl : Form
    {
        ThietBiBLL thietBiBLL = new ThietBiBLL();

        public int id;
        public string tenThietBi => txtName.Text;
        public string loaiThietBi => cbLoai.Text;

        public bool isExist => true;

        public ThietBiFormControl(ThietBi thietBi = null)
        {
            InitializeComponent();
            if (thietBi != null)
            {
                this.id = thietBi.id;
                txtName.Text = thietBi.name;
                cbLoai.Text = thietBi.loai;
            }
        }

        public ThietBiFormControl()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(cbLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var thietBi = new ThietBi
            {
                id = this.id,
                name = txtName.Text.Trim(),
                loai = cbLoai.Text.Trim(),
                isExist = true
            };

            try
            {
                bool result;
                if (this.id == 0)
                {
                    result = thietBiBLL.AddThietBi(thietBi);
                }
                else
                {
                    result = thietBiBLL.UpdateThietBi(thietBi);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

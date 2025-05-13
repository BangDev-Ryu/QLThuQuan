using System;
using System.Windows.Forms;
using QLThuQuan.BLL;

namespace QLThuQuan.GUI
{
    public partial class AddLuotVaoForm : Form
    {
        public int IDInput { get; private set; }
        public string PasswordInput { get; private set; }

        private ThanhVienBLL thanhVienBLL = new ThanhVienBLL();

        public AddLuotVaoForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtID.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                IDInput = int.Parse(txtID.Text.Trim());
                PasswordInput = txtPassword.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin thành viên.");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuet_Click(object sender, EventArgs e)
        {
            using (QuetMaForm formQuet = new QuetMaForm())
            {
                if (formQuet.ShowDialog() == DialogResult.OK)
                {
                    int checkLog = thanhVienBLL.checkLogin(formQuet.IDInput, formQuet.PasswordInput);
                    if (checkLog == 0)
                    {
                        MessageBox.Show("Không phải thành viên.");
                    }
                    else if (checkLog == -1)
                    {
                        MessageBox.Show("Mật khẩu không đúng.");
                    }
                    else
                    {
                        IDInput = formQuet.IDInput;
                        PasswordInput = formQuet.PasswordInput;
                        MessageBox.Show("Đăng nhập thành công.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }
    }
}
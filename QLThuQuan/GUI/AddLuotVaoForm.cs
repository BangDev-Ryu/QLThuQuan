using System;
using System.Windows.Forms;
using QLThuQuan.BLL;
using QLThuQuan.Models;


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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtID.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                if (!string.IsNullOrWhiteSpace(txtID.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    if (!int.TryParse(txtID.Text.Trim(), out int id))
                    {
                        MessageBox.Show("Mã thành viên không hợp lệ.");
                        return;
                    }

                    string password = txtPassword.Text.Trim();

                    ThanhVien tv = thanhVienBLL.GetThanhVienByID(id);
                    if (tv == null)
                    {
                        MessageBox.Show("Không phải thành viên.");
                        return;
                    }

                    int checkLog = thanhVienBLL.checkLogin(id, password);
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

                    if (tv.trangThai == "Đang vi phạm")
                    {
                        MessageBox.Show("Thành viên đang bị xử lý vi phạm.");
                        return;
                    }

                    ShowSuccessAndClose(tv);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin thành viên.");
                }

            }
        }

       

        private void btnQuet_Click(object sender, EventArgs e)
        {
                using (QuetMaForm formQuet = new QuetMaForm())
                {
                    if (formQuet.ShowDialog() == DialogResult.OK)
                    {
                        int id = formQuet.IDInput;

                        ThanhVien tv = thanhVienBLL.GetThanhVienByID(id);
                        if (tv == null)
                        {
                            MessageBox.Show("Không phải thành viên.");
                            return;
                        }

                        if (tv.trangThai == "Đang vi phạm")
                        {
                            MessageBox.Show("Thành viên đang bị xử lý vi phạm.");
                            return;
                        }

                        IDInput = id;
                        PasswordInput = "";

                        ShowSuccessAndClose(tv);
                    }
                }
            }

          private void ShowSuccessAndClose(ThanhVien tv)
            {
                DateTime timeIn = DateTime.Now;

                string info = $"THÔNG TIN THÀNH VIÊN:\n" +
                              $"- Mã TV: {tv.id}\n" +
                              $"- Tên đăng nhập: {tv.username}\n" +
                              $"- Họ tên: {tv.fullName}\n" +
                              $"- Khoa: {tv.khoa}\n" +
                              $"- Ngành: {tv.nganh}\n" +
                              $"- Trạng thái: {tv.trangThai}\n" +
                              $"- Thời điểm vào: {timeIn:HH:mm:ss dd/MM/yyyy}";

                MessageBox.Show(info, "Ghi nhận thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                thanhVienBLL.AddLuotVao(tv.id, timeIn);

                IDInput = tv.id;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
}
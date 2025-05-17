using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace QLThuQuan.GUI
{
    public partial class QuetMaForm : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public int IDInput { get; private set; }
        public string PasswordInput { get; private set; }
        public QuetMaForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void QuetMaForm_Load(object sender, EventArgs e)
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thiết bị camera.");
                    this.Close();
                    return;
                }

                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += video_NewFrame;
                videoSource.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khởi động camera: " + ex.Message);
                this.Close();
            }
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

                if (pictureBoxCamera.InvokeRequired)
                {
                    pictureBoxCamera.Invoke(new MethodInvoker(() =>
                    {
                        pictureBoxCamera.Image?.Dispose();
                        pictureBoxCamera.Image = (Bitmap)frame.Clone();
                    }));
                }
                else
                {
                    pictureBoxCamera.Image?.Dispose();
                    pictureBoxCamera.Image = (Bitmap)frame.Clone();
                }

                // Giải mã barcode
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode(frame);
                frame.Dispose();

                if (result != null)
                {
                    Invoke(new MethodInvoker(delegate
                    {
                        if (int.TryParse(result.Text.Trim(), out int id))
                        {
                            IDInput = id;

                            StopCamera();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Mã QR không hợp lệ. Không thể đọc ID.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }));
                }
            }
            catch
            {
                // Bỏ qua lỗi nhỏ
            }
        }

        private void StopCamera()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.NewFrame -= video_NewFrame;
                videoSource = null;
            }
        }

        private void QuetMaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }

        
    }
}

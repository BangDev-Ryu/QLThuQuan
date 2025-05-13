using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QLThuQuan.BLL;

namespace QLThuQuan.GUI
{
    public partial class ThongKeForm : Form
    {
        private ThongKeBLL thongKeBLL = new ThongKeBLL();
        private ThanhVienBLL thanhVienBLL = new ThanhVienBLL();

        public ThongKeForm()
        {
            InitializeComponent();
            InitComboBoxKhoa();
            LoadAllStats();
            LoadLuotVaoChart();
            LoadKhoaChart();
        }

        private void InitComboBoxKhoa()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Tất cả");
            var khoas = thanhVienBLL.GetThanhViens().Select(x => x.khoa).Distinct().ToList();
            foreach (var khoa in khoas)
            {
                comboBox1.Items.Add(khoa);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void LoadAllStats()
        {
            lbNumThietBiDaMuon.Text = thongKeBLL.GetSoThietBiDaMuon().ToString();
            label1.Text = thongKeBLL.GetSoThietBiDangMuon().ToString();
            label3.Text = thongKeBLL.GetSoViPhamDaXuLy().ToString();
            label5.Text = thongKeBLL.GetSoViPhamChuaXuLy().ToString();
        }

        private void LoadLuotVaoChart()
        {
            chart1.Series.Clear();
            Series series = new Series("Lượt vào theo thời gian");
            series.ChartType = SeriesChartType.Column;

            var data = thongKeBLL.GetLuotVaoTheoThoiGian(dateTimePicker1.Value, dateTimePicker2.Value);

            foreach (var item in data)
            {
                series.Points.AddXY(item.Key, item.Value); // item.Key = ID thành viên
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "ID Thành Viên";
            chart1.ChartAreas[0].AxisY.Title = "Số lượt vào";
            chart1.Titles.Clear();
            chart1.Titles.Add("Số lượt vào trong khoảng thời gian");
        }

        private void LoadKhoaChart()
        {
            chart2.Series.Clear();
            Series series = new Series("Lượt vào");
            series.ChartType = SeriesChartType.Column;

            if (comboBox1.SelectedItem.ToString() == "Tất cả")
            {
                var data = thongKeBLL.GetLuotVaoTheoKhoa();
                foreach (var item in data)
                {
                    series.Points.AddXY(item.Key, item.Value); // Tên khoa
                }

                chart2.Titles.Clear();
                chart2.Titles.Add("Số lượt vào theo khoa");
            }
            else
            {
                var data = thongKeBLL.GetLuotVaoTheoThanhVienKhoa(comboBox1.SelectedItem.ToString());
                foreach (var item in data)
                {
                    series.Points.AddXY(item.Key, item.Value);
                }

                chart2.Titles.Clear();
                chart2.Titles.Add($"Số lượt vào - Khoa {comboBox1.SelectedItem}");
            }

            chart2.Series.Add(series);
            chart2.ChartAreas[0].AxisX.Title = "ID Thành Viên / Khoa";
            chart2.ChartAreas[0].AxisY.Title = "Số lượt vào";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadLuotVaoChart();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadKhoaChart();
        }
    }
}

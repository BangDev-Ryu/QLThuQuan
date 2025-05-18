namespace QLThuQuan.GUI
{
    partial class ThongKeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 6D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 13D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 15D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 9D);
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 14D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 7D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 3D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10D);
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnChart = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbNumThietBiDaMuon = new System.Windows.Forms.Label();
            this.lbThietBiDaMuon = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbThietBiDangMuon = new System.Windows.Forms.Label();
            this.lbTBDangMuon = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbTongTienPhat = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbSoViPhamDaXuLy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbSoViPhamChuaXuLy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel9 = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnChart.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Lượt vào";
            series3.Points.Add(dataPoint10);
            series3.Points.Add(dataPoint11);
            series3.Points.Add(dataPoint12);
            series3.Points.Add(dataPoint13);
            series3.Points.Add(dataPoint14);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(450, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title3.Name = "LuotVao";
            title3.Text = "Số lượt vào theo thời gian";
            this.chart1.Titles.Add(title3);
            // 
            // pnChart
            // 
            this.pnChart.Controls.Add(this.chart1);
            this.pnChart.Location = new System.Drawing.Point(35, 307);
            this.pnChart.Name = "pnChart";
            this.pnChart.Size = new System.Drawing.Size(450, 300);
            this.pnChart.TabIndex = 1;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(402, 274);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(83, 27);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbNumThietBiDaMuon);
            this.panel1.Controls.Add(this.lbThietBiDaMuon);
            this.panel1.Location = new System.Drawing.Point(35, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(3, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 30);
            this.panel2.TabIndex = 8;
            // 
            // lbNumThietBiDaMuon
            // 
            this.lbNumThietBiDaMuon.AutoSize = true;
            this.lbNumThietBiDaMuon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumThietBiDaMuon.Location = new System.Drawing.Point(90, 58);
            this.lbNumThietBiDaMuon.Name = "lbNumThietBiDaMuon";
            this.lbNumThietBiDaMuon.Size = new System.Drawing.Size(19, 21);
            this.lbNumThietBiDaMuon.TabIndex = 7;
            this.lbNumThietBiDaMuon.Text = "0";
            // 
            // lbThietBiDaMuon
            // 
            this.lbThietBiDaMuon.AutoSize = true;
            this.lbThietBiDaMuon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThietBiDaMuon.Location = new System.Drawing.Point(27, 16);
            this.lbThietBiDaMuon.Name = "lbThietBiDaMuon";
            this.lbThietBiDaMuon.Size = new System.Drawing.Size(147, 21);
            this.lbThietBiDaMuon.TabIndex = 6;
            this.lbThietBiDaMuon.Text = "Số thiết bị đã mượn";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lbThietBiDangMuon);
            this.panel3.Controls.Add(this.lbTBDangMuon);
            this.panel3.Location = new System.Drawing.Point(285, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(3, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 30);
            this.panel4.TabIndex = 8;
            // 
            // lbThietBiDangMuon
            // 
            this.lbThietBiDangMuon.AutoSize = true;
            this.lbThietBiDangMuon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThietBiDangMuon.Location = new System.Drawing.Point(90, 58);
            this.lbThietBiDangMuon.Name = "lbThietBiDangMuon";
            this.lbThietBiDangMuon.Size = new System.Drawing.Size(19, 21);
            this.lbThietBiDangMuon.TabIndex = 7;
            this.lbThietBiDangMuon.Text = "0";
            // 
            // lbTBDangMuon
            // 
            this.lbTBDangMuon.AutoSize = true;
            this.lbTBDangMuon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTBDangMuon.Location = new System.Drawing.Point(18, 16);
            this.lbTBDangMuon.Name = "lbTBDangMuon";
            this.lbTBDangMuon.Size = new System.Drawing.Size(165, 21);
            this.lbTBDangMuon.TabIndex = 6;
            this.lbTBDangMuon.Text = "Số thiết bị đang mượn";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Goldenrod;
            this.panel5.Controls.Add(this.lbTongTienPhat);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.lbSoViPhamDaXuLy);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(535, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 10;
            // 
            // lbTongTienPhat
            // 
            this.lbTongTienPhat.AutoSize = true;
            this.lbTongTienPhat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbTongTienPhat.Location = new System.Drawing.Point(49, 58);
            this.lbTongTienPhat.Name = "lbTongTienPhat";
            this.lbTongTienPhat.Size = new System.Drawing.Size(19, 21);
            this.lbTongTienPhat.TabIndex = 10;
            this.lbTongTienPhat.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.Location = new System.Drawing.Point(47, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tổng tiền phạt";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(3, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(30, 30);
            this.panel6.TabIndex = 8;
            // 
            // lbSoViPhamDaXuLy
            // 
            this.lbSoViPhamDaXuLy.AutoSize = true;
            this.lbSoViPhamDaXuLy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoViPhamDaXuLy.Location = new System.Drawing.Point(163, 16);
            this.lbSoViPhamDaXuLy.Name = "lbSoViPhamDaXuLy";
            this.lbSoViPhamDaXuLy.Size = new System.Drawing.Size(19, 21);
            this.lbSoViPhamDaXuLy.TabIndex = 7;
            this.lbSoViPhamDaXuLy.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số vi phạm đã xử lý";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.OrangeRed;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.lbSoViPhamChuaXuLy);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(785, 50);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(3, 67);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(30, 30);
            this.panel8.TabIndex = 8;
            // 
            // lbSoViPhamChuaXuLy
            // 
            this.lbSoViPhamChuaXuLy.AutoSize = true;
            this.lbSoViPhamChuaXuLy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoViPhamChuaXuLy.Location = new System.Drawing.Point(90, 58);
            this.lbSoViPhamChuaXuLy.Name = "lbSoViPhamChuaXuLy";
            this.lbSoViPhamChuaXuLy.Size = new System.Drawing.Size(19, 21);
            this.lbSoViPhamChuaXuLy.TabIndex = 7;
            this.lbSoViPhamChuaXuLy.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số vi phạm chưa xử lý";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Khoảng thời gian";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 280);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "----";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(288, 280);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.chart2);
            this.panel9.Location = new System.Drawing.Point(538, 307);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(450, 300);
            this.panel9.TabIndex = 2;
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Lượt vào";
            dataPoint15.AxisLabel = "CNTT";
            dataPoint16.AxisLabel = "Kinh tế";
            dataPoint17.AxisLabel = "Luật";
            dataPoint18.AxisLabel = "Tâm lý học";
            series4.Points.Add(dataPoint15);
            series4.Points.Add(dataPoint16);
            series4.Points.Add(dataPoint17);
            series4.Points.Add(dataPoint18);
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(450, 300);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            title4.Name = "LuotVao";
            title4.Text = "Lượt vào theo khoa";
            this.chart2.Titles.Add(title4);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(691, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Thống kê theo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(789, 274);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Text = "Khoa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(902, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 27);
            this.button1.TabIndex = 19;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThongKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.pnChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeForm";
            this.Text = "ThongKeForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnChart.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel pnChart;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNumThietBiDaMuon;
        private System.Windows.Forms.Label lbThietBiDaMuon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbThietBiDangMuon;
        private System.Windows.Forms.Label lbTBDangMuon;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbSoViPhamDaXuLy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbSoViPhamChuaXuLy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTongTienPhat;
    }
}
namespace QLThuQuan.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnThanhVien = new System.Windows.Forms.Panel();
            this.btnThanhVien = new System.Windows.Forms.Button();
            this.pnThietBi = new System.Windows.Forms.Panel();
            this.btnThietBi = new System.Windows.Forms.Button();
            this.pnViPham = new System.Windows.Forms.Panel();
            this.btnViPham = new System.Windows.Forms.Button();
            this.pnThongKe = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.pnContent = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnThanhVien.SuspendLayout();
            this.pnThietBi.SuspendLayout();
            this.pnViPham.SuspendLayout();
            this.pnThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.flowLayoutPanel1.Controls.Add(this.pnThanhVien);
            this.flowLayoutPanel1.Controls.Add(this.pnThietBi);
            this.flowLayoutPanel1.Controls.Add(this.pnViPham);
            this.flowLayoutPanel1.Controls.Add(this.pnThongKe);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 681);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnThanhVien
            // 
            this.pnThanhVien.Controls.Add(this.btnThanhVien);
            this.pnThanhVien.Location = new System.Drawing.Point(3, 3);
            this.pnThanhVien.Name = "pnThanhVien";
            this.pnThanhVien.Size = new System.Drawing.Size(197, 55);
            this.pnThanhVien.TabIndex = 4;
            // 
            // btnThanhVien
            // 
            this.btnThanhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnThanhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThanhVien.FlatAppearance.BorderSize = 0;
            this.btnThanhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhVien.ForeColor = System.Drawing.Color.White;
            this.btnThanhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhVien.Image")));
            this.btnThanhVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhVien.Location = new System.Drawing.Point(0, 0);
            this.btnThanhVien.Margin = new System.Windows.Forms.Padding(0);
            this.btnThanhVien.Name = "btnThanhVien";
            this.btnThanhVien.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnThanhVien.Size = new System.Drawing.Size(197, 55);
            this.btnThanhVien.TabIndex = 2;
            this.btnThanhVien.Text = "Thành viên";
            this.btnThanhVien.UseVisualStyleBackColor = false;
            this.btnThanhVien.Click += new System.EventHandler(this.btnThanhVien_Click);
            // 
            // pnThietBi
            // 
            this.pnThietBi.Controls.Add(this.btnThietBi);
            this.pnThietBi.Location = new System.Drawing.Point(3, 64);
            this.pnThietBi.Name = "pnThietBi";
            this.pnThietBi.Size = new System.Drawing.Size(197, 55);
            this.pnThietBi.TabIndex = 2;
            // 
            // btnThietBi
            // 
            this.btnThietBi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnThietBi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThietBi.FlatAppearance.BorderSize = 0;
            this.btnThietBi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThietBi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThietBi.ForeColor = System.Drawing.Color.White;
            this.btnThietBi.Image = ((System.Drawing.Image)(resources.GetObject("btnThietBi.Image")));
            this.btnThietBi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThietBi.Location = new System.Drawing.Point(0, 0);
            this.btnThietBi.Margin = new System.Windows.Forms.Padding(0);
            this.btnThietBi.Name = "btnThietBi";
            this.btnThietBi.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnThietBi.Size = new System.Drawing.Size(197, 55);
            this.btnThietBi.TabIndex = 2;
            this.btnThietBi.Text = "Thiết bị";
            this.btnThietBi.UseVisualStyleBackColor = false;
            this.btnThietBi.Click += new System.EventHandler(this.btnThietBi_Click);
            // 
            // pnViPham
            // 
            this.pnViPham.Controls.Add(this.btnViPham);
            this.pnViPham.Location = new System.Drawing.Point(3, 125);
            this.pnViPham.Name = "pnViPham";
            this.pnViPham.Size = new System.Drawing.Size(197, 55);
            this.pnViPham.TabIndex = 3;
            // 
            // btnViPham
            // 
            this.btnViPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnViPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViPham.FlatAppearance.BorderSize = 0;
            this.btnViPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViPham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViPham.ForeColor = System.Drawing.Color.White;
            this.btnViPham.Image = ((System.Drawing.Image)(resources.GetObject("btnViPham.Image")));
            this.btnViPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViPham.Location = new System.Drawing.Point(0, 0);
            this.btnViPham.Margin = new System.Windows.Forms.Padding(0);
            this.btnViPham.Name = "btnViPham";
            this.btnViPham.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnViPham.Size = new System.Drawing.Size(197, 55);
            this.btnViPham.TabIndex = 2;
            this.btnViPham.Text = "Vi phạm";
            this.btnViPham.UseVisualStyleBackColor = false;
            this.btnViPham.Click += new System.EventHandler(this.btnViPham_Click);
            // 
            // pnThongKe
            // 
            this.pnThongKe.Controls.Add(this.btnThongKe);
            this.pnThongKe.Location = new System.Drawing.Point(3, 186);
            this.pnThongKe.Name = "pnThongKe";
            this.pnThongKe.Size = new System.Drawing.Size(197, 55);
            this.pnThongKe.TabIndex = 4;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 0);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(0);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(197, 55);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // pnContent
            // 
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(200, 0);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1064, 681);
            this.pnContent.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnThanhVien.ResumeLayout(false);
            this.pnThietBi.ResumeLayout(false);
            this.pnViPham.ResumeLayout(false);
            this.pnThongKe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnThietBi;
        private System.Windows.Forms.Button btnThietBi;
        private System.Windows.Forms.Panel pnViPham;
        private System.Windows.Forms.Button btnViPham;
        private System.Windows.Forms.Panel pnThanhVien;
        private System.Windows.Forms.Button btnThanhVien;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Panel pnThongKe;
        private System.Windows.Forms.Button btnThongKe;
    }
}
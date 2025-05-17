namespace QLThuQuan.GUI
{
    partial class ViPhamFormControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdThanhVien = new System.Windows.Forms.TextBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbHinhThuc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID thành viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hình thức xử lý";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiền bồi thường";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lý do";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtIdThanhVien
            // 
            this.txtIdThanhVien.Location = new System.Drawing.Point(255, 46);
            this.txtIdThanhVien.Name = "txtIdThanhVien";
            this.txtIdThanhVien.Size = new System.Drawing.Size(282, 24);
            this.txtIdThanhVien.TabIndex = 7;
            this.txtIdThanhVien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(255, 135);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(282, 24);
            this.txtTien.TabIndex = 9;
            this.txtTien.Text = "0";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(255, 185);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(282, 24);
            this.txtLyDo.TabIndex = 12;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(106, 280);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(107, 29);
            this.save_btn.TabIndex = 14;
            this.save_btn.Text = "Lưu";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbHinhThuc
            // 
            this.cbHinhThuc.FormattingEnabled = true;
            this.cbHinhThuc.Items.AddRange(new object[] {
            "Khóa thẻ 1 tháng",
            "Khóa thẻ 2 tháng",
            "Khóa thẻ 3 tháng",
            "Khóa thẻ vĩnh viễn",
            "Bồi thường"});
            this.cbHinhThuc.Location = new System.Drawing.Point(255, 85);
            this.cbHinhThuc.Name = "cbHinhThuc";
            this.cbHinhThuc.Size = new System.Drawing.Size(282, 26);
            this.cbHinhThuc.TabIndex = 16;
            // 
            // ViPhamFormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 347);
            this.Controls.Add(this.cbHinhThuc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.txtTien);
            this.Controls.Add(this.txtIdThanhVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViPhamFormControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViPhamFormControl";
            this.Load += new System.EventHandler(this.ViPhamFormControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdThanhVien;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbHinhThuc;
    }
}
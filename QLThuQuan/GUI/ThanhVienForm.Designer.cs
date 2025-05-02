namespace QLThuQuan.GUI
{
    partial class ThanhVienForm
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
            this.tableThanhVien = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddThanhVien = new System.Windows.Forms.Button();
            this.btnUpdateThanhVien = new System.Windows.Forms.Button();
            this.btnDeleteThanhVien = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddLuotVao = new System.Windows.Forms.Button();
            this.btnQuanLyPhieuMuon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableThanhVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableThanhVien
            // 
            this.tableThanhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableThanhVien.BackgroundColor = System.Drawing.Color.White;
            this.tableThanhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableThanhVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tableThanhVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tableThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableThanhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.username,
            this.password,
            this.fullname,
            this.khoa,
            this.nganh,
            this.trangThai});
            this.tableThanhVien.Location = new System.Drawing.Point(64, 132);
            this.tableThanhVien.Name = "tableThanhVien";
            this.tableThanhVien.RowHeadersVisible = false;
            this.tableThanhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableThanhVien.Size = new System.Drawing.Size(904, 512);
            this.tableThanhVien.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.HeaderText = "Fullname";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // khoa
            // 
            this.khoa.HeaderText = "Khoa";
            this.khoa.Name = "khoa";
            this.khoa.ReadOnly = true;
            // 
            // nganh
            // 
            this.nganh.HeaderText = "Nganh";
            this.nganh.Name = "nganh";
            this.nganh.ReadOnly = true;
            // 
            // trangThai
            // 
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.Name = "trangThai";
            // 
            // btnAddThanhVien
            // 
            this.btnAddThanhVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddThanhVien.Location = new System.Drawing.Point(64, 83);
            this.btnAddThanhVien.Name = "btnAddThanhVien";
            this.btnAddThanhVien.Size = new System.Drawing.Size(112, 40);
            this.btnAddThanhVien.TabIndex = 1;
            this.btnAddThanhVien.Text = "Thêm thành viên";
            this.btnAddThanhVien.UseVisualStyleBackColor = true;
            this.btnAddThanhVien.Click += new System.EventHandler(this.btnAddThanhVien_Click);
            // 
            // btnUpdateThanhVien
            // 
            this.btnUpdateThanhVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateThanhVien.Location = new System.Drawing.Point(182, 83);
            this.btnUpdateThanhVien.Name = "btnUpdateThanhVien";
            this.btnUpdateThanhVien.Size = new System.Drawing.Size(112, 40);
            this.btnUpdateThanhVien.TabIndex = 2;
            this.btnUpdateThanhVien.Text = "Sửa thành viên";
            this.btnUpdateThanhVien.UseVisualStyleBackColor = true;
            this.btnUpdateThanhVien.Click += new System.EventHandler(this.btnUpdateThanhVien_Click);
            // 
            // btnDeleteThanhVien
            // 
            this.btnDeleteThanhVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteThanhVien.Location = new System.Drawing.Point(300, 83);
            this.btnDeleteThanhVien.Name = "btnDeleteThanhVien";
            this.btnDeleteThanhVien.Size = new System.Drawing.Size(112, 40);
            this.btnDeleteThanhVien.TabIndex = 3;
            this.btnDeleteThanhVien.Text = "Xóa thành viên";
            this.btnDeleteThanhVien.UseVisualStyleBackColor = true;
            this.btnDeleteThanhVien.Click += new System.EventHandler(this.btnDeleteThanhVien_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(739, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 47);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm kiếm";
            // 
            // btnAddLuotVao
            // 
            this.btnAddLuotVao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLuotVao.Location = new System.Drawing.Point(856, 33);
            this.btnAddLuotVao.Name = "btnAddLuotVao";
            this.btnAddLuotVao.Size = new System.Drawing.Size(112, 40);
            this.btnAddLuotVao.TabIndex = 6;
            this.btnAddLuotVao.Text = "Vào khu học tập";
            this.btnAddLuotVao.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyPhieuMuon
            // 
            this.btnQuanLyPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyPhieuMuon.Location = new System.Drawing.Point(738, 33);
            this.btnQuanLyPhieuMuon.Name = "btnQuanLyPhieuMuon";
            this.btnQuanLyPhieuMuon.Size = new System.Drawing.Size(112, 40);
            this.btnQuanLyPhieuMuon.TabIndex = 7;
            this.btnQuanLyPhieuMuon.Text = "Quản lý phiếu mượn";
            this.btnQuanLyPhieuMuon.UseVisualStyleBackColor = true;
            // 
            // ThanhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btnQuanLyPhieuMuon);
            this.Controls.Add(this.btnAddLuotVao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeleteThanhVien);
            this.Controls.Add(this.btnUpdateThanhVien);
            this.Controls.Add(this.btnAddThanhVien);
            this.Controls.Add(this.tableThanhVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThanhVienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ThanhVienForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ThanhVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableThanhVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tableThanhVien;
        private System.Windows.Forms.Button btnAddThanhVien;
        private System.Windows.Forms.Button btnUpdateThanhVien;
        private System.Windows.Forms.Button btnDeleteThanhVien;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddLuotVao;
        private System.Windows.Forms.Button btnQuanLyPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
    }
}
namespace QLThuQuan.GUI
{
    partial class ViPhamForm
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
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.tableViPham = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idthanhvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhthucxuly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienboithuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayphat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayhethan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lydo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isexist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableViPham)).BeginInit();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(73, 87);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(116, 36);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "Thêm vi phạm";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(317, 87);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(116, 36);
            this.edit_btn.TabIndex = 1;
            this.edit_btn.Text = "Sửa vi phạm";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(195, 87);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(116, 36);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "Xóa vi phạm";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // tableViPham
            // 
            this.tableViPham.AllowUserToAddRows = false;
            this.tableViPham.AllowUserToDeleteRows = false;
            this.tableViPham.AllowUserToResizeColumns = false;
            this.tableViPham.AllowUserToResizeRows = false;
            this.tableViPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tableViPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tableViPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableViPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idthanhvien,
            this.hinhthucxuly,
            this.tienboithuong,
            this.ngayphat,
            this.ngayhethan,
            this.lydo,
            this.trangthai,
            this.isexist});
            this.tableViPham.Enabled = false;
            this.tableViPham.EnableHeadersVisualStyles = false;
            this.tableViPham.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.tableViPham.Location = new System.Drawing.Point(12, 136);
            this.tableViPham.Name = "tableViPham";
            this.tableViPham.RowHeadersVisible = false;
            this.tableViPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableViPham.ShowCellErrors = false;
            this.tableViPham.ShowCellToolTips = false;
            this.tableViPham.Size = new System.Drawing.Size(1025, 533);
            this.tableViPham.TabIndex = 3;
            this.tableViPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // idthanhvien
            // 
            this.idthanhvien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idthanhvien.HeaderText = "ID thành viên";
            this.idthanhvien.Name = "idthanhvien";
            // 
            // hinhthucxuly
            // 
            this.hinhthucxuly.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hinhthucxuly.HeaderText = "Hình thức xử lý";
            this.hinhthucxuly.Name = "hinhthucxuly";
            // 
            // tienboithuong
            // 
            this.tienboithuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tienboithuong.HeaderText = "Tiền bồi thường";
            this.tienboithuong.Name = "tienboithuong";
            // 
            // ngayphat
            // 
            this.ngayphat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayphat.HeaderText = "Ngày phạt";
            this.ngayphat.Name = "ngayphat";
            // 
            // ngayhethan
            // 
            this.ngayhethan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayhethan.HeaderText = "Ngày hết hạn";
            this.ngayhethan.Name = "ngayhethan";
            // 
            // lydo
            // 
            this.lydo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lydo.HeaderText = "Lý do";
            this.lydo.Name = "lydo";
            // 
            // trangthai
            // 
            this.trangthai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            // 
            // isexist
            // 
            this.isexist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.isexist.HeaderText = "Is exsist";
            this.isexist.Name = "isexist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(635, 95);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(210, 22);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ViPhamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableViPham);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViPhamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViPhamForm";
            this.Load += new System.EventHandler(this.ViPhamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableViPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.DataGridView tableViPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idthanhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhthucxuly;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienboithuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayphat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayhethan;
        private System.Windows.Forms.DataGridViewTextBoxColumn lydo;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn isexist;
    }
}
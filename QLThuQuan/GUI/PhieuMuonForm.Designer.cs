namespace QLThuQuan.GUI
{
    partial class PhieuMuonForm
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
            this.tablePhieuMuon = new System.Windows.Forms.DataGridView();
            this.btnMuon = new System.Windows.Forms.Button();
            this.btnTra = new System.Windows.Forms.Button();
            this.idTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_thietBiTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_thanhVienTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayMuonTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHanTraTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablePhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePhieuMuon
            // 
            this.tablePhieuMuon.AllowUserToAddRows = false;
            this.tablePhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePhieuMuon.BackgroundColor = System.Drawing.Color.White;
            this.tablePhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTable,
            this.id_thietBiTable,
            this.id_thanhVienTable,
            this.trangThaiTable,
            this.loaiTable,
            this.ngayMuonTable,
            this.ngayHanTraTable});
            this.tablePhieuMuon.Location = new System.Drawing.Point(12, 116);
            this.tablePhieuMuon.Name = "tablePhieuMuon";
            this.tablePhieuMuon.RowHeadersVisible = false;
            this.tablePhieuMuon.RowHeadersWidth = 51;
            this.tablePhieuMuon.RowTemplate.Height = 24;
            this.tablePhieuMuon.Size = new System.Drawing.Size(1026, 430);
            this.tablePhieuMuon.TabIndex = 0;
            // 
            // btnMuon
            // 
            this.btnMuon.Location = new System.Drawing.Point(754, 23);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(116, 52);
            this.btnMuon.TabIndex = 1;
            this.btnMuon.Text = "Mượn thiết bị";
            this.btnMuon.UseVisualStyleBackColor = true;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // btnTra
            // 
            this.btnTra.Location = new System.Drawing.Point(901, 23);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(114, 52);
            this.btnTra.TabIndex = 2;
            this.btnTra.Text = "Trả thiết bị";
            this.btnTra.UseVisualStyleBackColor = true;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // idTable
            // 
            this.idTable.HeaderText = "ID";
            this.idTable.MinimumWidth = 6;
            this.idTable.Name = "idTable";
            // 
            // id_thietBiTable
            // 
            this.id_thietBiTable.HeaderText = "ID Thiết Bị";
            this.id_thietBiTable.MinimumWidth = 6;
            this.id_thietBiTable.Name = "id_thietBiTable";
            // 
            // id_thanhVienTable
            // 
            this.id_thanhVienTable.HeaderText = "ID Thành Viên";
            this.id_thanhVienTable.MinimumWidth = 6;
            this.id_thanhVienTable.Name = "id_thanhVienTable";
            // 
            // trangThaiTable
            // 
            this.trangThaiTable.HeaderText = "Trạng thái";
            this.trangThaiTable.MinimumWidth = 6;
            this.trangThaiTable.Name = "trangThaiTable";
            // 
            // loaiTable
            // 
            this.loaiTable.HeaderText = "Loại";
            this.loaiTable.MinimumWidth = 6;
            this.loaiTable.Name = "loaiTable";
            // 
            // ngayMuonTable
            // 
            this.ngayMuonTable.HeaderText = "Ngày mượn";
            this.ngayMuonTable.MinimumWidth = 6;
            this.ngayMuonTable.Name = "ngayMuonTable";
            // 
            // ngayHanTraTable
            // 
            this.ngayHanTraTable.HeaderText = "Ngày trả";
            this.ngayHanTraTable.MinimumWidth = 6;
            this.ngayHanTraTable.Name = "ngayHanTraTable";
            // 
            // PhieuMuonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 645);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.btnMuon);
            this.Controls.Add(this.tablePhieuMuon);
            this.Name = "PhieuMuonForm";
            this.Text = "PhieuMuonForm";
            this.Load += new System.EventHandler(this.PhieuMuonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePhieuMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablePhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_thietBiTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_thanhVienTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuonTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHanTraTable;
    }
}
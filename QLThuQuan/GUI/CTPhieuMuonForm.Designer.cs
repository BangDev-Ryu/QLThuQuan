namespace QLThuQuan.GUI
{
    partial class CTPhieuMuonForm
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
            this.tableCTPhieuMuon = new System.Windows.Forms.DataGridView();
            this.idPhieuMuonTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ThietBiTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableCTPhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableCTPhieuMuon
            // 
            this.tableCTPhieuMuon.AllowUserToAddRows = false;
            this.tableCTPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableCTPhieuMuon.BackgroundColor = System.Drawing.Color.White;
            this.tableCTPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCTPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPhieuMuonTable,
            this.id_ThietBiTable});
            this.tableCTPhieuMuon.Location = new System.Drawing.Point(12, 45);
            this.tableCTPhieuMuon.Name = "tableCTPhieuMuon";
            this.tableCTPhieuMuon.RowHeadersVisible = false;
            this.tableCTPhieuMuon.RowHeadersWidth = 51;
            this.tableCTPhieuMuon.RowTemplate.Height = 24;
            this.tableCTPhieuMuon.Size = new System.Drawing.Size(1026, 430);
            this.tableCTPhieuMuon.TabIndex = 1;
            // 
            // idPhieuMuonTable
            // 
            this.idPhieuMuonTable.HeaderText = "ID Phiếu Mượn";
            this.idPhieuMuonTable.MinimumWidth = 6;
            this.idPhieuMuonTable.Name = "idPhieuMuonTable";
            // 
            // id_ThietBiTable
            // 
            this.id_ThietBiTable.HeaderText = "ID Thiết Bị";
            this.id_ThietBiTable.MinimumWidth = 6;
            this.id_ThietBiTable.Name = "id_ThietBiTable";
            // 
            // CTPhieuMuonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 535);
            this.Controls.Add(this.tableCTPhieuMuon);
            this.Name = "CTPhieuMuonForm";
            this.Text = "CTPhieuMuonForm";
            this.Load += new System.EventHandler(this.CTPhieuMuonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableCTPhieuMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableCTPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPhieuMuonTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ThietBiTable;
    }
}
namespace QLThuQuan.GUI
{
    partial class ThietBiForm
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
            this.tableThietBi = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableThietBi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableThietBi
            // 
            this.tableThietBi.BackgroundColor = System.Drawing.Color.White;
            this.tableThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.loai});
            this.tableThietBi.Location = new System.Drawing.Point(74, 115);
            this.tableThietBi.Margin = new System.Windows.Forms.Padding(2);
            this.tableThietBi.Name = "tableThietBi";
            this.tableThietBi.RowHeadersVisible = false;
            this.tableThietBi.RowTemplate.Height = 24;
            this.tableThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableThietBi.Size = new System.Drawing.Size(904, 512);
            this.tableThietBi.TabIndex = 0;
            this.tableThietBi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Width = 300;
            // 
            // name
            // 
            this.name.HeaderText = "Tên thiết bị";
            this.name.Name = "name";
            this.name.Width = 300;
            // 
            // loai
            // 
            this.loai.HeaderText = "Loại thiết bị";
            this.loai.Name = "loai";
            this.loai.Width = 300;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(74, 60);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(112, 40);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Thêm thiết bị";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(219, 60);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(112, 40);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Sửa thiết bị";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(368, 60);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(112, 40);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Xóa thiết bị";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(748, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 47);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 4;
            // 
            // ThietBiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.tableThietBi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThietBiForm";
            this.Text = "ThietBiForm";
            this.Load += new System.EventHandler(this.ThietBiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableThietBi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableThietBi;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
    }
}
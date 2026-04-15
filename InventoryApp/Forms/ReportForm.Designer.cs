namespace InventoryApp.Forms
{
    partial class ReportForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvLowStock = new DataGridView();
            tabPage2 = new TabPage();
            lblStatus = new StatusStrip();
            lblTotalLowStock = new Label();
            lblTotalTransaksi = new Label();
            lblTotalKategori = new Label();
            lblTotalProduk = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(882, 453);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvLowStock);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(874, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Low Stock";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvLowStock
            // 
            dgvLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStock.Dock = DockStyle.Fill;
            dgvLowStock.Location = new Point(3, 3);
            dgvLowStock.Name = "dgvLowStock";
            dgvLowStock.RowHeadersWidth = 51;
            dgvLowStock.Size = new Size(868, 414);
            dgvLowStock.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblStatus);
            tabPage2.Controls.Add(lblTotalLowStock);
            tabPage2.Controls.Add(lblTotalTransaksi);
            tabPage2.Controls.Add(lblTotalKategori);
            tabPage2.Controls.Add(lblTotalProduk);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(874, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ringkasan";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.ImageScalingSize = new Size(20, 20);
            lblStatus.Location = new Point(3, 395);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(868, 22);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "statusStrip1";
            // 
            // lblTotalLowStock
            // 
            lblTotalLowStock.AutoSize = true;
            lblTotalLowStock.Location = new Point(33, 152);
            lblTotalLowStock.Name = "lblTotalLowStock";
            lblTotalLowStock.Size = new Size(109, 20);
            lblTotalLowStock.TabIndex = 3;
            lblTotalLowStock.Text = "Total LowStock";
            // 
            // lblTotalTransaksi
            // 
            lblTotalTransaksi.AutoSize = true;
            lblTotalTransaksi.Location = new Point(33, 113);
            lblTotalTransaksi.Name = "lblTotalTransaksi";
            lblTotalTransaksi.Size = new Size(105, 20);
            lblTotalTransaksi.TabIndex = 2;
            lblTotalTransaksi.Text = "Total Transaksi";
            // 
            // lblTotalKategori
            // 
            lblTotalKategori.AutoSize = true;
            lblTotalKategori.Location = new Point(33, 74);
            lblTotalKategori.Name = "lblTotalKategori";
            lblTotalKategori.Size = new Size(103, 20);
            lblTotalKategori.TabIndex = 1;
            lblTotalKategori.Text = "Total Kategori";
            // 
            // lblTotalProduk
            // 
            lblTotalProduk.AutoSize = true;
            lblTotalProduk.Location = new Point(33, 35);
            lblTotalProduk.Name = "lblTotalProduk";
            lblTotalProduk.Size = new Size(92, 20);
            lblTotalProduk.TabIndex = 0;
            lblTotalProduk.Text = "Total Produk";
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 453);
            Controls.Add(tabControl1);
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            Load += ReportForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvLowStock;
        private TabPage tabPage2;
        private Label lblTotalProduk;
        private StatusStrip lblStatus;
        private Label lblTotalLowStock;
        private Label lblTotalTransaksi;
        private Label lblTotalKategori;
    }
}
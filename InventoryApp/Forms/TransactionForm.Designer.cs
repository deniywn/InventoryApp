namespace InventoryApp.Forms
{
    partial class TransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            toolStrip1 = new ToolStrip();
            btnTambah = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            cboFilterProduk = new ToolStripComboBox();
            btnSemuaProduk = new ToolStripButton();
            dgvTransactions = new DataGridView();
            lblStatus = new StatusStrip();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnTambah, toolStripSeparator1, toolStripLabel1, cboFilterProduk, btnSemuaProduk });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(982, 28);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnTambah
            // 
            btnTambah.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnTambah.Image = (Image)resources.GetObject("btnTambah.Image");
            btnTambah.ImageTransparentColor = Color.Magenta;
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(128, 25);
            btnTambah.Text = "Tambah Transaksi";
            btnTambah.Click += btnTambah_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(95, 25);
            toolStripLabel1.Text = "Filter Produk:";
            // 
            // cboFilterProduk
            // 
            cboFilterProduk.Name = "cboFilterProduk";
            cboFilterProduk.Size = new Size(200, 28);
            cboFilterProduk.Click += cboFilterProduk_SelectedIndexChanged;
            // 
            // btnSemuaProduk
            // 
            btnSemuaProduk.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSemuaProduk.Image = (Image)resources.GetObject("btnSemuaProduk.Image");
            btnSemuaProduk.ImageTransparentColor = Color.Magenta;
            btnSemuaProduk.Name = "btnSemuaProduk";
            btnSemuaProduk.Size = new Size(108, 25);
            btnSemuaProduk.Text = "Semua Produk";
            btnSemuaProduk.Click += btnSemuaProduk_Click;
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Dock = DockStyle.Fill;
            dgvTransactions.Location = new Point(0, 28);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 51;
            dgvTransactions.Size = new Size(982, 505);
            dgvTransactions.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.ImageScalingSize = new Size(20, 20);
            lblStatus.Location = new Point(0, 511);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(982, 22);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "statusStrip1";
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 533);
            Controls.Add(lblStatus);
            Controls.Add(dgvTransactions);
            Controls.Add(toolStrip1);
            Name = "TransactionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transactions";
            Load += TransactionForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnTambah;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox cboFilterProduk;
        private DataGridView dgvTransactions;
        private StatusStrip lblStatus;
        private ToolStripButton btnSemuaProduk;
    }
}
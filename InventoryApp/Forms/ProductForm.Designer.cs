namespace InventoryApp.Forms
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            toolStrip1 = new ToolStrip();
            btnTambah = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnHapus = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnRefresh = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            txtCari = new ToolStripTextBox();
            dgvProducts = new DataGridView();
            lbl = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            lbl.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnTambah, btnEdit, btnHapus, toolStripSeparator1, btnRefresh, toolStripSeparator2, toolStripLabel1, txtCari });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(982, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnTambah
            // 
            btnTambah.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnTambah.Image = (Image)resources.GetObject("btnTambah.Image");
            btnTambah.ImageTransparentColor = Color.Magenta;
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(65, 24);
            btnTambah.Text = "Tambah";
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(39, 24);
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnHapus.Image = (Image)resources.GetObject("btnHapus.Image");
            btnHapus.ImageTransparentColor = Color.Magenta;
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(55, 24);
            btnHapus.Text = "Hapus";
            btnHapus.Click += btnHapus_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnRefresh
            // 
            btnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageTransparentColor = Color.Magenta;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(62, 24);
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(35, 24);
            toolStripLabel1.Text = "Cari";
            // 
            // txtCari
            // 
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(200, 27);
            txtCari.TextChanged += txtCari_TextChanged;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 27);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(982, 506);
            dgvProducts.TabIndex = 1;
            // 
            // lbl
            // 
            lbl.ImageScalingSize = new Size(20, 20);
            lbl.Items.AddRange(new ToolStripItem[] { lblStatus });
            lbl.Location = new Point(0, 507);
            lbl.Name = "lbl";
            lbl.Size = new Size(982, 26);
            lbl.TabIndex = 2;
            lbl.Text = "Siap";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(38, 20);
            lblStatus.Text = "Siap";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 533);
            Controls.Add(lbl);
            Controls.Add(dgvProducts);
            Controls.Add(toolStrip1);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            Load += ProductForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            lbl.ResumeLayout(false);
            lbl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private DataGridView dgvProducts;
        private StatusStrip lbl;
        private ToolStripStatusLabel lblStatus;
        private ToolStripButton btnTambah;
        private ToolStripButton btnEdit;
        private ToolStripButton btnHapus;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnRefresh;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtCari;
    }
}
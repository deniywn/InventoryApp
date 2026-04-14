namespace InventoryApp.Forms
{
    partial class ProductDetailForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtNama = new TextBox();
            label2 = new Label();
            txtSKU = new TextBox();
            label3 = new Label();
            cboKategori = new ComboBox();
            label4 = new Label();
            nudHarga = new NumericUpDown();
            label5 = new Label();
            nudStok = new NumericUpDown();
            label6 = new Label();
            nudMinStok = new NumericUpDown();
            label7 = new Label();
            txtDeskripsi = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudHarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 39);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama Produk";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(149, 32);
            txtNama.MaxLength = 150;
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(152, 27);
            txtNama.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 73);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 2;
            label2.Text = "SKU";
            // 
            // txtSKU
            // 
            txtSKU.Location = new Point(149, 70);
            txtSKU.MaxLength = 50;
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(152, 27);
            txtSKU.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 111);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 4;
            label3.Text = "Kategori";
            // 
            // cboKategori
            // 
            cboKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKategori.FormattingEnabled = true;
            cboKategori.Location = new Point(149, 111);
            cboKategori.Name = "cboKategori";
            cboKategori.Size = new Size(151, 28);
            cboKategori.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 150);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 6;
            label4.Text = "Harga";
            // 
            // nudHarga
            // 
            nudHarga.Location = new Point(148, 150);
            nudHarga.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudHarga.Name = "nudHarga";
            nudHarga.Size = new Size(150, 27);
            nudHarga.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 194);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 8;
            label5.Text = "Stok";
            // 
            // nudStok
            // 
            nudStok.Location = new Point(148, 192);
            nudStok.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudStok.Name = "nudStok";
            nudStok.Size = new Size(150, 27);
            nudStok.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 233);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 10;
            label6.Text = "Min Stok";
            // 
            // nudMinStok
            // 
            nudMinStok.Location = new Point(148, 233);
            nudMinStok.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudMinStok.Name = "nudMinStok";
            nudMinStok.Size = new Size(150, 27);
            nudMinStok.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 275);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 12;
            label7.Text = "Deskripsi";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(148, 275);
            txtDeskripsi.MaxLength = 50;
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(152, 70);
            txtDeskripsi.TabIndex = 13;
            // 
            // btnSimpan
            // 
            btnSimpan.DialogResult = DialogResult.OK;
            btnSimpan.Location = new Point(120, 372);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 14;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.DialogResult = DialogResult.Cancel;
            btnBatal.Location = new Point(220, 372);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 15;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ProductDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 453);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(txtDeskripsi);
            Controls.Add(label7);
            Controls.Add(nudMinStok);
            Controls.Add(label6);
            Controls.Add(nudStok);
            Controls.Add(label5);
            Controls.Add(nudHarga);
            Controls.Add(label4);
            Controls.Add(cboKategori);
            Controls.Add(label3);
            Controls.Add(txtSKU);
            Controls.Add(label2);
            Controls.Add(txtNama);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductDetailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = " ";
            Load += ProductDetailForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudHarga).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNama;
        private Label label2;
        private TextBox txtSKU;
        private Label label3;
        private ComboBox cboKategori;
        private Label label4;
        private NumericUpDown nudHarga;
        private Label label5;
        private NumericUpDown nudStok;
        private Label label6;
        private NumericUpDown nudMinStok;
        private Label label7;
        private TextBox txtDeskripsi;
        private Button btnSimpan;
        private Button btnBatal;
        private ErrorProvider errorProvider1;
    }
}
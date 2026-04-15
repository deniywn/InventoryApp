namespace InventoryApp.Forms
{
    partial class TransactionDetailForm
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
            cboProduk = new ComboBox();
            label2 = new Label();
            cboTipe = new ComboBox();
            label3 = new Label();
            nudJumlah = new NumericUpDown();
            nudHarga = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            txtCatatan = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudJumlah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 18);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Produk";
            // 
            // cboProduk
            // 
            cboProduk.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProduk.FormattingEnabled = true;
            cboProduk.Location = new Point(138, 12);
            cboProduk.Name = "cboProduk";
            cboProduk.Size = new Size(151, 28);
            cboProduk.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 52);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 2;
            label2.Text = "Tipe";
            // 
            // cboTipe
            // 
            cboTipe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipe.FormattingEnabled = true;
            cboTipe.Location = new Point(137, 52);
            cboTipe.Name = "cboTipe";
            cboTipe.Size = new Size(151, 28);
            cboTipe.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 92);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 4;
            label3.Text = "Jumlah";
            // 
            // nudJumlah
            // 
            nudJumlah.Location = new Point(137, 92);
            nudJumlah.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudJumlah.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudJumlah.Name = "nudJumlah";
            nudJumlah.Size = new Size(150, 27);
            nudJumlah.TabIndex = 5;
            nudJumlah.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudHarga
            // 
            nudHarga.Location = new Point(138, 134);
            nudHarga.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nudHarga.Name = "nudHarga";
            nudHarga.Size = new Size(150, 27);
            nudHarga.TabIndex = 7;
            nudHarga.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 134);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 6;
            label4.Text = "Harga Satuan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 175);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 8;
            label5.Text = "Catatan";
            // 
            // txtCatatan
            // 
            txtCatatan.Location = new Point(138, 172);
            txtCatatan.Multiline = true;
            txtCatatan.Name = "txtCatatan";
            txtCatatan.Size = new Size(125, 50);
            txtCatatan.TabIndex = 9;
            // 
            // btnSimpan
            // 
            btnSimpan.DialogResult = DialogResult.OK;
            btnSimpan.Location = new Point(83, 235);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 10;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.DialogResult = DialogResult.Cancel;
            btnBatal.Location = new Point(193, 235);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 11;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // TransactionDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 273);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(txtCatatan);
            Controls.Add(label5);
            Controls.Add(nudHarga);
            Controls.Add(label4);
            Controls.Add(nudJumlah);
            Controls.Add(label3);
            Controls.Add(cboTipe);
            Controls.Add(label2);
            Controls.Add(cboProduk);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "TransactionDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaksi Baru";
            Load += TransactionDetailForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudJumlah).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHarga).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboProduk;
        private Label label2;
        private ComboBox cboTipe;
        private Label label3;
        private NumericUpDown nudJumlah;
        private NumericUpDown nudHarga;
        private Label label4;
        private Label label5;
        private TextBox txtCatatan;
        private Button btnSimpan;
        private Button btnBatal;
        private ErrorProvider errorProvider1;
    }
}
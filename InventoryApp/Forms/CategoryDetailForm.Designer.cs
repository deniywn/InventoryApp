namespace InventoryApp.Forms
{
    partial class CategoryDetailForm
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
            txtDeskripsi = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(150, 12);
            txtNama.MaxLength = 100;
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(125, 27);
            txtNama.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 45);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Deskripsi";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(150, 45);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(125, 60);
            txtDeskripsi.TabIndex = 3;
            // 
            // btnSimpan
            // 
            btnSimpan.DialogResult = DialogResult.OK;
            btnSimpan.Location = new Point(67, 121);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 4;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.DialogResult = DialogResult.Cancel;
            btnBatal.Location = new Point(181, 121);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 5;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CategoryDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 173);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(txtDeskripsi);
            Controls.Add(label2);
            Controls.Add(txtNama);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CategoryDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategori";
            Load += CategoryDetailForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNama;
        private Label label2;
        private TextBox txtDeskripsi;
        private Button btnSimpan;
        private Button btnBatal;
        private ErrorProvider errorProvider1;
    }
}
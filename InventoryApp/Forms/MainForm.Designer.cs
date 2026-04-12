namespace InventoryApp.Forms
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            prodToolStripMenuItem = new ToolStripMenuItem();
            categoriesToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            pnlContent = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { prodToolStripMenuItem, categoriesToolStripMenuItem, transactionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1082, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.UseWaitCursor = true;
            // 
            // prodToolStripMenuItem
            // 
            prodToolStripMenuItem.Name = "prodToolStripMenuItem";
            prodToolStripMenuItem.Size = new Size(80, 24);
            prodToolStripMenuItem.Text = "Products";
            prodToolStripMenuItem.Click += productsToolStripMenuItem_Click;
            // 
            // categoriesToolStripMenuItem
            // 
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Size = new Size(94, 24);
            categoriesToolStripMenuItem.Text = "Categories";
            categoriesToolStripMenuItem.Click += categoriesToolStripMenuItem_Click;
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(108, 24);
            transactionsToolStripMenuItem.Text = " Transactions";
            transactionsToolStripMenuItem.Click += transactionsToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 577);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1082, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.UseWaitCursor = true;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(36, 20);
            lblStatus.Text = "siap";
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 28);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1082, 549);
            pnlContent.TabIndex = 2;
            pnlContent.UseWaitCursor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 603);
            Controls.Add(pnlContent);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 500);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            UseWaitCursor = true;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private Panel pnlContent;
        private ToolStripMenuItem prodToolStripMenuItem;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripStatusLabel lblStatus;
    }
}
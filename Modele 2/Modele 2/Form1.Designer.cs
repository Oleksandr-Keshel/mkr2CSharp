namespace Modele_2
{
    partial class Form1
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
            this.buhInfoGridView = new System.Windows.Forms.DataGridView();
            this.searchResultGridView = new System.Windows.Forms.DataGridView();
            this.FindBtn = new System.Windows.Forms.Button();
            this.searchByIdLabel = new System.Windows.Forms.Label();
            this.searchByIdTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduceSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReduceBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.buhInfoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buhInfoGridView
            // 
            this.buhInfoGridView.AllowUserToAddRows = false;
            this.buhInfoGridView.AllowUserToDeleteRows = false;
            this.buhInfoGridView.AllowUserToResizeColumns = false;
            this.buhInfoGridView.AllowUserToResizeRows = false;
            this.buhInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buhInfoGridView.Location = new System.Drawing.Point(71, 46);
            this.buhInfoGridView.Name = "buhInfoGridView";
            this.buhInfoGridView.ReadOnly = true;
            this.buhInfoGridView.RowHeadersWidth = 51;
            this.buhInfoGridView.RowTemplate.Height = 24;
            this.buhInfoGridView.Size = new System.Drawing.Size(805, 203);
            this.buhInfoGridView.TabIndex = 0;
            // 
            // searchResultGridView
            // 
            this.searchResultGridView.AllowUserToAddRows = false;
            this.searchResultGridView.AllowUserToDeleteRows = false;
            this.searchResultGridView.AllowUserToResizeColumns = false;
            this.searchResultGridView.AllowUserToResizeRows = false;
            this.searchResultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultGridView.Location = new System.Drawing.Point(384, 345);
            this.searchResultGridView.Name = "searchResultGridView";
            this.searchResultGridView.ReadOnly = true;
            this.searchResultGridView.RowHeadersWidth = 51;
            this.searchResultGridView.RowTemplate.Height = 24;
            this.searchResultGridView.Size = new System.Drawing.Size(358, 283);
            this.searchResultGridView.TabIndex = 1;
            // 
            // FindBtn
            // 
            this.FindBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindBtn.Location = new System.Drawing.Point(119, 515);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(126, 47);
            this.FindBtn.TabIndex = 2;
            this.FindBtn.Text = "Find";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // searchByIdLabel
            // 
            this.searchByIdLabel.AutoSize = true;
            this.searchByIdLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchByIdLabel.Location = new System.Drawing.Point(67, 378);
            this.searchByIdLabel.Name = "searchByIdLabel";
            this.searchByIdLabel.Size = new System.Drawing.Size(253, 23);
            this.searchByIdLabel.TabIndex = 3;
            this.searchByIdLabel.Text = "The first two letters of code";
            // 
            // searchByIdTextBox
            // 
            this.searchByIdTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchByIdTextBox.Location = new System.Drawing.Point(105, 427);
            this.searchByIdTextBox.MaxLength = 2;
            this.searchByIdTextBox.Name = "searchByIdTextBox";
            this.searchByIdTextBox.Size = new System.Drawing.Size(166, 30);
            this.searchByIdTextBox.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.ExportToExcelToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reduceSalaryToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.ToolStripMenuItem.Text = "Operations";
            // 
            // reduceSalaryToolStripMenuItem
            // 
            this.reduceSalaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReduceBtn});
            this.reduceSalaryToolStripMenuItem.Name = "reduceSalaryToolStripMenuItem";
            this.reduceSalaryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reduceSalaryToolStripMenuItem.Text = "Reduce Salary";
            // 
            // ReduceBtn
            // 
            this.ReduceBtn.Name = "ReduceBtn";
            this.ReduceBtn.Size = new System.Drawing.Size(156, 26);
            this.ReduceBtn.Text = "Engineers";
            this.ReduceBtn.Click += new System.EventHandler(this.ReduceSalaryOfEngineersToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // ExportToExcelToolStripMenuItem
            // 
            this.ExportToExcelToolStripMenuItem.Name = "ExportToExcelToolStripMenuItem";
            this.ExportToExcelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ExportToExcelToolStripMenuItem.Text = "Export to Excel";
            this.ExportToExcelToolStripMenuItem.Click += new System.EventHandler(this.ExportToExcelToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 744);
            this.Controls.Add(this.searchByIdTextBox);
            this.Controls.Add(this.searchByIdLabel);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.searchResultGridView);
            this.Controls.Add(this.buhInfoGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buhInfoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView buhInfoGridView;
        private System.Windows.Forms.DataGridView searchResultGridView;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.Label searchByIdLabel;
        private System.Windows.Forms.TextBox searchByIdTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reduceSalaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReduceBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportToExcelToolStripMenuItem;
    }
}


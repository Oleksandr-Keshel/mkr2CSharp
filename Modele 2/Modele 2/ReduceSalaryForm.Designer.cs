namespace Modele_2
{
    partial class ReduceSalaryForm
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
            this.reduceSalaryLabel = new System.Windows.Forms.Label();
            this.reduceSalaryByLabel = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ReduceBtn = new System.Windows.Forms.Button();
            this.PercentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.experienceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PercentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // reduceSalaryLabel
            // 
            this.reduceSalaryLabel.AutoSize = true;
            this.reduceSalaryLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reduceSalaryLabel.Location = new System.Drawing.Point(12, 49);
            this.reduceSalaryLabel.Name = "reduceSalaryLabel";
            this.reduceSalaryLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reduceSalaryLabel.Size = new System.Drawing.Size(259, 63);
            this.reduceSalaryLabel.TabIndex = 0;
            this.reduceSalaryLabel.Text = "Reduce the salary of engineers\r\n\r\nwhose experience is less than ";
            this.reduceSalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reduceSalaryByLabel
            // 
            this.reduceSalaryByLabel.AutoSize = true;
            this.reduceSalaryByLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reduceSalaryByLabel.Location = new System.Drawing.Point(24, 175);
            this.reduceSalaryByLabel.Name = "reduceSalaryByLabel";
            this.reduceSalaryByLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reduceSalaryByLabel.Size = new System.Drawing.Size(209, 24);
            this.reduceSalaryByLabel.TabIndex = 2;
            this.reduceSalaryByLabel.Text = "Reduce the salary by";
            this.reduceSalaryByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.Location = new System.Drawing.Point(49, 271);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(125, 38);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // ReduceBtn
            // 
            this.ReduceBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ReduceBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReduceBtn.Location = new System.Drawing.Point(262, 271);
            this.ReduceBtn.Name = "ReduceBtn";
            this.ReduceBtn.Size = new System.Drawing.Size(125, 38);
            this.ReduceBtn.TabIndex = 5;
            this.ReduceBtn.Text = "OK";
            this.ReduceBtn.UseVisualStyleBackColor = true;
            // 
            // PercentNumericUpDown
            // 
            this.PercentNumericUpDown.DecimalPlaces = 2;
            this.PercentNumericUpDown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PercentNumericUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.PercentNumericUpDown.Location = new System.Drawing.Point(292, 175);
            this.PercentNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.PercentNumericUpDown.Name = "PercentNumericUpDown";
            this.PercentNumericUpDown.Size = new System.Drawing.Size(80, 30);
            this.PercentNumericUpDown.TabIndex = 6;
            this.PercentNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // experienceNumericUpDown
            // 
            this.experienceNumericUpDown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.experienceNumericUpDown.Location = new System.Drawing.Point(292, 82);
            this.experienceNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.experienceNumericUpDown.Name = "experienceNumericUpDown";
            this.experienceNumericUpDown.Size = new System.Drawing.Size(80, 30);
            this.experienceNumericUpDown.TabIndex = 7;
            this.experienceNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(392, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "%";
            // 
            // ReduceSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.experienceNumericUpDown);
            this.Controls.Add(this.PercentNumericUpDown);
            this.Controls.Add(this.ReduceBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.reduceSalaryByLabel);
            this.Controls.Add(this.reduceSalaryLabel);
            this.Name = "ReduceSalaryForm";
            this.Text = "Reduce Salary of Engineers";
            ((System.ComponentModel.ISupportInitialize)(this.PercentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reduceSalaryLabel;
        private System.Windows.Forms.Label reduceSalaryByLabel;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ReduceBtn;
        public System.Windows.Forms.NumericUpDown PercentNumericUpDown;
        public System.Windows.Forms.NumericUpDown experienceNumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}
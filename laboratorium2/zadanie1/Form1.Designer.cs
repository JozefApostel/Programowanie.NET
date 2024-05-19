namespace DivisionApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDividend = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDividend
            // 
            this.txtDividend.Location = new System.Drawing.Point(12, 12);
            this.txtDividend.Name = "txtDividend";
            this.txtDividend.Size = new System.Drawing.Size(260, 20);
            this.txtDividend.TabIndex = 0;
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(12, 38);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(260, 20);
            this.txtDivisor.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 64);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(260, 20);
            this.txtResult.TabIndex = 2;
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(12, 90);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(260, 23);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "Podziel";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.txtDividend);
            this.Name = "Form1";
            this.Text = "Division App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtDividend;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnDivide;
    }
}

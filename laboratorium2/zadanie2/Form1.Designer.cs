namespace SimpleCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtDisplay;
        private Button[] numberButtons;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnEquals;
        private Button btnClear;

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
            this.txtDisplay = new TextBox();
            this.btnAdd = new Button();
            this.btnSubtract = new Button();
            this.btnMultiply = new Button();
            this.btnDivide = new Button();
            this.btnEquals = new Button();
            this.btnClear = new Button();
            this.numberButtons = new Button[10];

            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(210, 20);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // number buttons
            // 
            int buttonWidth = 45;
            int buttonHeight = 45;
            for (int i = 0; i < 10; i++)
            {
                this.numberButtons[i] = new Button();
                this.numberButtons[i].Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                this.numberButtons[i].Text = i.ToString();
                this.numberButtons[i].Click += new System.EventHandler(this.number_Click);
            }

            // 
            // Positioning number buttons
            // 
            int xPos = 12;
            int yPos = 50;
            for (int i = 1; i <= 9; i++)
            {
                this.numberButtons[i].Location = new System.Drawing.Point(xPos, yPos);
                xPos += buttonWidth + 5;
                if (i % 3 == 0)
                {
                    xPos = 12;
                    yPos += buttonHeight + 5;
                }
            }
            this.numberButtons[0].Location = new System.Drawing.Point(12 + buttonWidth + 5, yPos + buttonHeight + 5);

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(177, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(177, 100);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btnSubtract.TabIndex = 2;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(177, 150);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btnMultiply.TabIndex = 3;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(177, 200);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(12, 300);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btnEquals.TabIndex = 5;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(62, 300);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(234, 361);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDisplay);
            foreach (var button in numberButtons)
            {
                this.Controls.Add(button);
            }
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

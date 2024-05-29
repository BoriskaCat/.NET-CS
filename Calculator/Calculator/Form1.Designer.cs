namespace Calculator
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.ParenthesesOpenButton = new System.Windows.Forms.Button();
            this.ParenthesesCloseButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(1, 9);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(382, 128);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "0";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ClearButton.Location = new System.Drawing.Point(193, 207);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(94, 64);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DivideButton.Location = new System.Drawing.Point(289, 143);
            this.DivideButton.Margin = new System.Windows.Forms.Padding(4);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(94, 64);
            this.DivideButton.TabIndex = 2;
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MultiplyButton.Location = new System.Drawing.Point(289, 207);
            this.MultiplyButton.Margin = new System.Windows.Forms.Padding(4);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(94, 64);
            this.MultiplyButton.TabIndex = 3;
            this.MultiplyButton.Text = "×";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MinusButton.ForeColor = System.Drawing.Color.Black;
            this.MinusButton.Location = new System.Drawing.Point(289, 271);
            this.MinusButton.Margin = new System.Windows.Forms.Padding(4);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(94, 64);
            this.MinusButton.TabIndex = 4;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PlusButton.Location = new System.Drawing.Point(289, 335);
            this.PlusButton.Margin = new System.Windows.Forms.Padding(4);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(94, 64);
            this.PlusButton.TabIndex = 5;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(190)))));
            this.EqualsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.EqualsButton.ForeColor = System.Drawing.Color.White;
            this.EqualsButton.Location = new System.Drawing.Point(289, 399);
            this.EqualsButton.Margin = new System.Windows.Forms.Padding(0);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(94, 64);
            this.EqualsButton.TabIndex = 6;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = false;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ZeroButton.Location = new System.Drawing.Point(1, 335);
            this.ZeroButton.Margin = new System.Windows.Forms.Padding(4);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(94, 64);
            this.ZeroButton.TabIndex = 8;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ThreeButton.Location = new System.Drawing.Point(1, 271);
            this.ThreeButton.Margin = new System.Windows.Forms.Padding(4);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(94, 64);
            this.ThreeButton.TabIndex = 9;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TwoButton.Location = new System.Drawing.Point(193, 335);
            this.TwoButton.Margin = new System.Windows.Forms.Padding(4);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(94, 64);
            this.TwoButton.TabIndex = 10;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.OneButton.Location = new System.Drawing.Point(97, 335);
            this.OneButton.Margin = new System.Windows.Forms.Padding(4);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(94, 64);
            this.OneButton.TabIndex = 11;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SixButton.Location = new System.Drawing.Point(1, 207);
            this.SixButton.Margin = new System.Windows.Forms.Padding(4);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(94, 64);
            this.SixButton.TabIndex = 12;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FiveButton.Location = new System.Drawing.Point(193, 271);
            this.FiveButton.Margin = new System.Windows.Forms.Padding(4);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(94, 64);
            this.FiveButton.TabIndex = 13;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FourButton.Location = new System.Drawing.Point(97, 271);
            this.FourButton.Margin = new System.Windows.Forms.Padding(4);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(94, 64);
            this.FourButton.TabIndex = 14;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SevenButton.Location = new System.Drawing.Point(97, 207);
            this.SevenButton.Margin = new System.Windows.Forms.Padding(4);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(94, 64);
            this.SevenButton.TabIndex = 17;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // ParenthesesOpenButton
            // 
            this.ParenthesesOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ParenthesesOpenButton.Location = new System.Drawing.Point(1, 143);
            this.ParenthesesOpenButton.Name = "ParenthesesOpenButton";
            this.ParenthesesOpenButton.Size = new System.Drawing.Size(94, 64);
            this.ParenthesesOpenButton.TabIndex = 18;
            this.ParenthesesOpenButton.Text = "(";
            this.ParenthesesOpenButton.UseVisualStyleBackColor = true;
            this.ParenthesesOpenButton.Click += new System.EventHandler(this.ParenthesesOpenButton_Click);
            // 
            // ParenthesesCloseButton
            // 
            this.ParenthesesCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ParenthesesCloseButton.Location = new System.Drawing.Point(97, 143);
            this.ParenthesesCloseButton.Name = "ParenthesesCloseButton";
            this.ParenthesesCloseButton.Size = new System.Drawing.Size(94, 64);
            this.ParenthesesCloseButton.TabIndex = 19;
            this.ParenthesesCloseButton.Text = ")";
            this.ParenthesesCloseButton.UseVisualStyleBackColor = true;
            this.ParenthesesCloseButton.Click += new System.EventHandler(this.ParenthesesCloseButton_Click);
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BackspaceButton.Location = new System.Drawing.Point(193, 143);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(94, 64);
            this.BackspaceButton.TabIndex = 20;
            this.BackspaceButton.Text = "⌫";
            this.BackspaceButton.UseVisualStyleBackColor = true;
            this.BackspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DecimalButton.Location = new System.Drawing.Point(192, 399);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(94, 64);
            this.DecimalButton.TabIndex = 21;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(384, 463);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.BackspaceButton);
            this.Controls.Add(this.ParenthesesCloseButton);
            this.Controls.Add(this.ParenthesesOpenButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.SevenButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button ParenthesesOpenButton;
        private System.Windows.Forms.Button ParenthesesCloseButton;
        private System.Windows.Forms.Button BackspaceButton;
        private System.Windows.Forms.Button DecimalButton;
    }
}

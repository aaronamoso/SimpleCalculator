namespace SimpleCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textDisplay = new TextBox();
            num7 = new Button();
            num8 = new Button();
            num9 = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            num6 = new Button();
            num5 = new Button();
            num4 = new Button();
            btnMultiply = new Button();
            num3 = new Button();
            num2 = new Button();
            num1 = new Button();
            btnDivide = new Button();
            btnEqual = new Button();
            btnClear = new Button();
            num0 = new Button();
            SuspendLayout();
            // 
            // textDisplay
            // 
            textDisplay.Location = new Point(278, 115);
            textDisplay.Name = "textDisplay";
            textDisplay.Size = new Size(232, 23);
            textDisplay.TabIndex = 0;
            // 
            // num7
            // 
            num7.Location = new Point(278, 161);
            num7.Name = "num7";
            num7.Size = new Size(55, 33);
            num7.TabIndex = 1;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += num7_Click;
            // 
            // num8
            // 
            num8.Location = new Point(339, 161);
            num8.Name = "num8";
            num8.Size = new Size(52, 33);
            num8.TabIndex = 2;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += num8_Click;
            // 
            // num9
            // 
            num9.Location = new Point(397, 161);
            num9.Name = "num9";
            num9.Size = new Size(54, 33);
            num9.TabIndex = 3;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += num9_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(457, 161);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(53, 33);
            btnPlus.TabIndex = 4;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(457, 200);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(53, 33);
            btnMinus.TabIndex = 8;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // num6
            // 
            num6.Location = new Point(397, 200);
            num6.Name = "num6";
            num6.Size = new Size(54, 33);
            num6.TabIndex = 7;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += num6_Click;
            // 
            // num5
            // 
            num5.Location = new Point(339, 200);
            num5.Name = "num5";
            num5.Size = new Size(52, 33);
            num5.TabIndex = 6;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += num5_Click;
            // 
            // num4
            // 
            num4.Location = new Point(278, 200);
            num4.Name = "num4";
            num4.Size = new Size(55, 33);
            num4.TabIndex = 5;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += num4_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(457, 239);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(53, 33);
            btnMultiply.TabIndex = 12;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // num3
            // 
            num3.Location = new Point(397, 239);
            num3.Name = "num3";
            num3.Size = new Size(54, 33);
            num3.TabIndex = 11;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += num3_Click;
            // 
            // num2
            // 
            num2.Location = new Point(339, 239);
            num2.Name = "num2";
            num2.Size = new Size(52, 33);
            num2.TabIndex = 10;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += num2_Click;
            // 
            // num1
            // 
            num1.Location = new Point(278, 239);
            num1.Name = "num1";
            num1.Size = new Size(55, 33);
            num1.TabIndex = 9;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += num1_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(457, 278);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(53, 33);
            btnDivide.TabIndex = 16;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(397, 278);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(54, 33);
            btnEqual.TabIndex = 15;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(339, 278);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(52, 33);
            btnClear.TabIndex = 14;
            btnClear.Text = "A/C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // num0
            // 
            num0.Location = new Point(278, 278);
            num0.Name = "num0";
            num0.Size = new Size(55, 33);
            num0.TabIndex = 13;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += num0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDivide);
            Controls.Add(btnEqual);
            Controls.Add(btnClear);
            Controls.Add(num0);
            Controls.Add(btnMultiply);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(btnMinus);
            Controls.Add(num6);
            Controls.Add(num5);
            Controls.Add(num4);
            Controls.Add(btnPlus);
            Controls.Add(num9);
            Controls.Add(num8);
            Controls.Add(num7);
            Controls.Add(textDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textDisplay;
        private Button num7;
        private Button num8;
        private Button num9;
        private Button btnPlus;
        private Button btnMinus;
        private Button num6;
        private Button num5;
        private Button num4;
        private Button btnMultiply;
        private Button num3;
        private Button num2;
        private Button num1;
        private Button btnDivide;
        private Button btnEqual;
        private Button btnClear;
        private Button num0;
    }
}

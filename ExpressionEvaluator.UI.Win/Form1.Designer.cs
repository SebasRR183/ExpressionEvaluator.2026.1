namespace ExpressionEvaluator.UI.Win
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
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDivide = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMultiply = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnResult = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnPow = new Button();
            btnOpenParenthesis = new Button();
            btnClosePrenthesis = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = Color.OliveDrab;
            txtDisplay.ForeColor = Color.White;
            txtDisplay.Location = new Point(12, 11);
            txtDisplay.Margin = new Padding(3, 2, 3, 3);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(343, 23);
            txtDisplay.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Location = new Point(25, 123);
            btn7.Name = "btn7";
            btn7.Size = new Size(56, 57);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button1_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(87, 123);
            btn8.Name = "btn8";
            btn8.Size = new Size(56, 57);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(149, 123);
            btn9.Name = "btn9";
            btn9.Size = new Size(56, 57);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.Orange;
            btnDivide.Location = new Point(25, 60);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(56, 57);
            btnDivide.TabIndex = 4;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(25, 186);
            btn4.Name = "btn4";
            btn4.Size = new Size(56, 57);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(87, 186);
            btn5.Name = "btn5";
            btn5.Size = new Size(56, 57);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(149, 186);
            btn6.Name = "btn6";
            btn6.Size = new Size(56, 57);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.Orange;
            btnMultiply.Location = new Point(87, 60);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(56, 57);
            btnMultiply.TabIndex = 8;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(25, 249);
            btn1.Name = "btn1";
            btn1.Size = new Size(56, 57);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(87, 249);
            btn2.Name = "btn2";
            btn2.Size = new Size(56, 57);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(149, 249);
            btn3.Name = "btn3";
            btn3.Size = new Size(56, 57);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.Orange;
            btnResult.Location = new Point(25, 375);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(242, 57);
            btnResult.TabIndex = 12;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += button12_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(25, 312);
            btn0.Name = "btn0";
            btn0.Size = new Size(56, 57);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.White;
            btnDot.Location = new Point(87, 312);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(56, 57);
            btnDot.TabIndex = 14;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.Orange;
            btnPlus.Location = new Point(211, 60);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(56, 57);
            btnPlus.TabIndex = 16;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.Orange;
            btnMinus.Location = new Point(149, 60);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(56, 57);
            btnMinus.TabIndex = 17;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.Orange;
            btnPow.Location = new Point(211, 249);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(57, 57);
            btnPow.TabIndex = 18;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.Orange;
            btnOpenParenthesis.Location = new Point(211, 123);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(56, 57);
            btnOpenParenthesis.TabIndex = 19;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnClosePrenthesis
            // 
            btnClosePrenthesis.BackColor = Color.Orange;
            btnClosePrenthesis.Location = new Point(211, 186);
            btnClosePrenthesis.Name = "btnClosePrenthesis";
            btnClosePrenthesis.Size = new Size(56, 57);
            btnClosePrenthesis.TabIndex = 20;
            btnClosePrenthesis.Text = ")";
            btnClosePrenthesis.UseVisualStyleBackColor = false;
            btnClosePrenthesis.Click += btnClosePrenthesis_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Orange;
            btnDelete.Location = new Point(149, 312);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(56, 57);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "⌫";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Orange;
            btnClear.Location = new Point(211, 312);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(57, 57);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(367, 495);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnClosePrenthesis);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnPow);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnResult);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMultiply);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnDivide);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Functions Evaluator";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnDivide;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMultiply;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnResult;
        private Button btn0;
        private Button btnDot;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnPow;
        private Button btnOpenParenthesis;
        private Button btnClosePrenthesis;
        private Button btnDelete;
        private Button btnClear;
    }
}

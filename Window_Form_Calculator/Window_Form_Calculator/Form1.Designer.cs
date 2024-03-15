namespace Window_Form_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            seven = new Button();
            eight = new Button();
            divine = new Button();
            nine = new Button();
            CE = new Button();
            C = new Button();
            multiply = new Button();
            six = new Button();
            five = new Button();
            four = new Button();
            minus = new Button();
            three = new Button();
            two = new Button();
            one = new Button();
            equal = new Button();
            plus = new Button();
            dot = new Button();
            zero = new Button();
            resultText = new TextBox();
            SuspendLayout();
            // 
            // seven
            // 
            seven.BackColor = Color.FromArgb(251, 193, 147);
            seven.FlatAppearance.BorderColor = Color.LightGray;
            seven.FlatAppearance.BorderSize = 3;
            seven.FlatAppearance.CheckedBackColor = Color.Red;
            seven.FlatAppearance.MouseDownBackColor = Color.SandyBrown;
            seven.FlatAppearance.MouseOverBackColor = Color.Bisque;
            seven.FlatStyle = FlatStyle.Flat;
            seven.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            seven.Location = new Point(23, 82);
            seven.Name = "seven";
            seven.Size = new Size(60, 60);
            seven.TabIndex = 0;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = false;
            seven.Click += numClick;
            // 
            // eight
            // 
            eight.BackColor = Color.FromArgb(251, 193, 147);
            eight.FlatAppearance.BorderColor = Color.LightGray;
            eight.FlatAppearance.BorderSize = 3;
            eight.FlatAppearance.CheckedBackColor = Color.Red;
            eight.FlatAppearance.MouseDownBackColor = Color.SandyBrown;
            eight.FlatAppearance.MouseOverBackColor = Color.Bisque;
            eight.FlatStyle = FlatStyle.Flat;
            eight.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eight.Location = new Point(90, 82);
            eight.Name = "eight";
            eight.Size = new Size(60, 60);
            eight.TabIndex = 1;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = false;
            eight.Click += numClick;
            // 
            // divine
            // 
            divine.BackColor = Color.FromArgb(251, 193, 147);
            divine.FlatAppearance.BorderColor = Color.LightGray;
            divine.FlatAppearance.BorderSize = 3;
            divine.FlatAppearance.CheckedBackColor = Color.Red;
            divine.FlatAppearance.MouseDownBackColor = Color.SandyBrown;
            divine.FlatAppearance.MouseOverBackColor = Color.Bisque;
            divine.FlatStyle = FlatStyle.Flat;
            divine.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            divine.Location = new Point(225, 82);
            divine.Name = "divine";
            divine.Size = new Size(60, 60);
            divine.TabIndex = 3;
            divine.Text = "/";
            divine.UseVisualStyleBackColor = false;
            divine.Click += operatorClick;
            // 
            // nine
            // 
            nine.BackColor = Color.FromArgb(251, 193, 147);
            nine.FlatAppearance.BorderColor = Color.LightGray;
            nine.FlatAppearance.BorderSize = 3;
            nine.FlatAppearance.CheckedBackColor = Color.Red;
            nine.FlatAppearance.MouseDownBackColor = Color.SandyBrown;
            nine.FlatAppearance.MouseOverBackColor = Color.Bisque;
            nine.FlatStyle = FlatStyle.Flat;
            nine.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nine.Location = new Point(158, 82);
            nine.Name = "nine";
            nine.Size = new Size(60, 60);
            nine.TabIndex = 2;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = false;
            nine.Click += numClick;
            // 
            // CE
            // 
            CE.BackColor = Color.FromArgb(242, 128, 118);
            CE.FlatAppearance.BorderColor = Color.LightGray;
            CE.FlatAppearance.BorderSize = 3;
            CE.FlatAppearance.CheckedBackColor = Color.Red;
            CE.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            CE.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            CE.FlatStyle = FlatStyle.Flat;
            CE.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CE.Location = new Point(291, 148);
            CE.Name = "CE";
            CE.Size = new Size(60, 60);
            CE.TabIndex = 4;
            CE.Text = "CE";
            CE.UseVisualStyleBackColor = false;
            CE.Click += CEClick;
            // 
            // C
            // 
            C.BackColor = Color.FromArgb(242, 128, 118);
            C.FlatAppearance.BorderColor = Color.LightGray;
            C.FlatAppearance.BorderSize = 3;
            C.FlatAppearance.CheckedBackColor = Color.Red;
            C.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            C.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            C.FlatStyle = FlatStyle.Flat;
            C.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            C.Location = new Point(291, 82);
            C.Name = "C";
            C.Size = new Size(60, 60);
            C.TabIndex = 9;
            C.Text = "C";
            C.UseVisualStyleBackColor = false;
            C.Click += CClick;
            // 
            // multiply
            // 
            multiply.BackColor = Color.OldLace;
            multiply.FlatAppearance.BorderColor = Color.LightGray;
            multiply.FlatAppearance.BorderSize = 3;
            multiply.FlatAppearance.CheckedBackColor = Color.Red;
            multiply.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            multiply.FlatAppearance.MouseOverBackColor = Color.White;
            multiply.FlatStyle = FlatStyle.Flat;
            multiply.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            multiply.Location = new Point(225, 148);
            multiply.Name = "multiply";
            multiply.Size = new Size(60, 60);
            multiply.TabIndex = 8;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += operatorClick;
            // 
            // six
            // 
            six.BackColor = Color.OldLace;
            six.FlatAppearance.BorderColor = Color.LightGray;
            six.FlatAppearance.BorderSize = 3;
            six.FlatAppearance.CheckedBackColor = Color.Red;
            six.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            six.FlatAppearance.MouseOverBackColor = Color.White;
            six.FlatStyle = FlatStyle.Flat;
            six.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            six.Location = new Point(158, 148);
            six.Name = "six";
            six.Size = new Size(60, 60);
            six.TabIndex = 7;
            six.Text = "6";
            six.UseVisualStyleBackColor = false;
            six.Click += numClick;
            // 
            // five
            // 
            five.BackColor = Color.OldLace;
            five.FlatAppearance.BorderColor = Color.LightGray;
            five.FlatAppearance.BorderSize = 3;
            five.FlatAppearance.CheckedBackColor = Color.Red;
            five.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            five.FlatAppearance.MouseOverBackColor = Color.White;
            five.FlatStyle = FlatStyle.Flat;
            five.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            five.Location = new Point(90, 148);
            five.Name = "five";
            five.Size = new Size(60, 60);
            five.TabIndex = 6;
            five.Text = "5";
            five.UseVisualStyleBackColor = false;
            five.Click += numClick;
            // 
            // four
            // 
            four.BackColor = Color.OldLace;
            four.FlatAppearance.BorderColor = Color.LightGray;
            four.FlatAppearance.BorderSize = 3;
            four.FlatAppearance.CheckedBackColor = Color.Red;
            four.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            four.FlatAppearance.MouseOverBackColor = Color.White;
            four.FlatStyle = FlatStyle.Flat;
            four.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            four.Location = new Point(23, 148);
            four.Name = "four";
            four.Size = new Size(60, 60);
            four.TabIndex = 5;
            four.Text = "4";
            four.UseVisualStyleBackColor = false;
            four.Click += numClick;
            // 
            // minus
            // 
            minus.BackColor = Color.OldLace;
            minus.FlatAppearance.BorderColor = Color.LightGray;
            minus.FlatAppearance.BorderSize = 3;
            minus.FlatAppearance.CheckedBackColor = Color.Red;
            minus.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            minus.FlatAppearance.MouseOverBackColor = Color.White;
            minus.FlatStyle = FlatStyle.Flat;
            minus.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minus.Location = new Point(225, 214);
            minus.Name = "minus";
            minus.Size = new Size(60, 60);
            minus.TabIndex = 13;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += operatorClick;
            // 
            // three
            // 
            three.BackColor = Color.OldLace;
            three.FlatAppearance.BorderColor = Color.LightGray;
            three.FlatAppearance.BorderSize = 3;
            three.FlatAppearance.CheckedBackColor = Color.Red;
            three.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            three.FlatAppearance.MouseOverBackColor = Color.White;
            three.FlatStyle = FlatStyle.Flat;
            three.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            three.Location = new Point(158, 214);
            three.Name = "three";
            three.Size = new Size(60, 60);
            three.TabIndex = 12;
            three.Text = "3";
            three.UseVisualStyleBackColor = false;
            three.Click += numClick;
            // 
            // two
            // 
            two.BackColor = Color.OldLace;
            two.FlatAppearance.BorderColor = Color.LightGray;
            two.FlatAppearance.BorderSize = 3;
            two.FlatAppearance.CheckedBackColor = Color.Red;
            two.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            two.FlatAppearance.MouseOverBackColor = Color.White;
            two.FlatStyle = FlatStyle.Flat;
            two.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            two.Location = new Point(90, 214);
            two.Name = "two";
            two.Size = new Size(60, 60);
            two.TabIndex = 11;
            two.Text = "2";
            two.UseVisualStyleBackColor = false;
            two.Click += numClick;
            // 
            // one
            // 
            one.BackColor = Color.OldLace;
            one.FlatAppearance.BorderColor = Color.LightGray;
            one.FlatAppearance.BorderSize = 3;
            one.FlatAppearance.CheckedBackColor = Color.Red;
            one.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            one.FlatAppearance.MouseOverBackColor = Color.White;
            one.FlatStyle = FlatStyle.Flat;
            one.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            one.Location = new Point(22, 214);
            one.Name = "one";
            one.Size = new Size(60, 60);
            one.TabIndex = 10;
            one.Text = "1";
            one.UseVisualStyleBackColor = false;
            one.Click += numClick;
            // 
            // equal
            // 
            equal.BackColor = Color.FromArgb(78, 176, 155);
            equal.FlatAppearance.BorderColor = Color.LightGray;
            equal.FlatAppearance.BorderSize = 3;
            equal.FlatAppearance.CheckedBackColor = Color.Red;
            equal.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            equal.FlatAppearance.MouseOverBackColor = Color.PowderBlue;
            equal.FlatStyle = FlatStyle.Flat;
            equal.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            equal.Location = new Point(291, 214);
            equal.Name = "equal";
            equal.Size = new Size(60, 126);
            equal.TabIndex = 19;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equalClick;
            // 
            // plus
            // 
            plus.BackColor = Color.OldLace;
            plus.FlatAppearance.BorderColor = Color.LightGray;
            plus.FlatAppearance.BorderSize = 3;
            plus.FlatAppearance.CheckedBackColor = Color.Red;
            plus.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            plus.FlatAppearance.MouseOverBackColor = Color.White;
            plus.FlatStyle = FlatStyle.Flat;
            plus.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plus.Location = new Point(225, 280);
            plus.Name = "plus";
            plus.Size = new Size(60, 60);
            plus.TabIndex = 18;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += operatorClick;
            // 
            // dot
            // 
            dot.BackColor = Color.OldLace;
            dot.FlatAppearance.BorderColor = Color.LightGray;
            dot.FlatAppearance.BorderSize = 3;
            dot.FlatAppearance.CheckedBackColor = Color.Red;
            dot.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            dot.FlatAppearance.MouseOverBackColor = Color.White;
            dot.FlatStyle = FlatStyle.Flat;
            dot.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dot.Location = new Point(158, 281);
            dot.Name = "dot";
            dot.Size = new Size(60, 60);
            dot.TabIndex = 17;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = false;
            dot.Click += numClick;
            // 
            // zero
            // 
            zero.BackColor = Color.OldLace;
            zero.FlatAppearance.BorderColor = Color.LightGray;
            zero.FlatAppearance.BorderSize = 3;
            zero.FlatAppearance.CheckedBackColor = Color.Red;
            zero.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            zero.FlatAppearance.MouseOverBackColor = Color.White;
            zero.FlatStyle = FlatStyle.Flat;
            zero.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            zero.Location = new Point(23, 280);
            zero.Name = "zero";
            zero.Size = new Size(126, 60);
            zero.TabIndex = 15;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += numClick;
            // 
            // resultText
            // 
            resultText.BackColor = Color.FloralWhite;
            resultText.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultText.Location = new Point(23, 29);
            resultText.Multiline = true;
            resultText.Name = "resultText";
            resultText.Size = new Size(329, 44);
            resultText.TabIndex = 20;
            resultText.Text = "0";
            resultText.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.kt4;
            ClientSize = new Size(372, 358);
            Controls.Add(resultText);
            Controls.Add(equal);
            Controls.Add(plus);
            Controls.Add(dot);
            Controls.Add(zero);
            Controls.Add(minus);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(C);
            Controls.Add(multiply);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(CE);
            Controls.Add(divine);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button seven;
        private Button eight;
        private Button divine;
        private Button nine;
        private Button CE;
        private Button C;
        private Button multiply;
        private Button six;
        private Button five;
        private Button four;
        private Button minus;
        private Button three;
        private Button two;
        private Button one;
        private Button equal;
        private Button plus;
        private Button dot;
        private Button zero;
        private TextBox resultText;
    }
}

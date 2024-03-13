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
            seven.FlatAppearance.BorderColor = Color.Yellow;
            seven.FlatAppearance.BorderSize = 10;
            seven.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            seven.Location = new Point(22, 78);
            seven.Name = "seven";
            seven.Size = new Size(60, 60);
            seven.TabIndex = 0;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += button_click;
            // 
            // eight
            // 
            eight.FlatAppearance.BorderColor = Color.Yellow;
            eight.FlatAppearance.BorderSize = 10;
            eight.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eight.Location = new Point(88, 78);
            eight.Name = "eight";
            eight.Size = new Size(60, 60);
            eight.TabIndex = 1;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += button_click;
            // 
            // divine
            // 
            divine.FlatAppearance.BorderColor = Color.Yellow;
            divine.FlatAppearance.BorderSize = 10;
            divine.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            divine.Location = new Point(220, 78);
            divine.Name = "divine";
            divine.Size = new Size(60, 60);
            divine.TabIndex = 3;
            divine.Text = "/";
            divine.UseVisualStyleBackColor = true;
            divine.Click += operator_click;
            // 
            // nine
            // 
            nine.FlatAppearance.BorderColor = Color.Yellow;
            nine.FlatAppearance.BorderSize = 10;
            nine.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nine.Location = new Point(154, 78);
            nine.Name = "nine";
            nine.Size = new Size(60, 60);
            nine.TabIndex = 2;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += button_click;
            // 
            // CE
            // 
            CE.FlatAppearance.BorderColor = Color.Yellow;
            CE.FlatAppearance.BorderSize = 10;
            CE.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CE.Location = new Point(286, 144);
            CE.Name = "CE";
            CE.Size = new Size(60, 60);
            CE.TabIndex = 4;
            CE.Text = "CE";
            CE.UseVisualStyleBackColor = true;
            CE.Click += buttonCE;
            // 
            // C
            // 
            C.FlatAppearance.BorderColor = Color.Yellow;
            C.FlatAppearance.BorderSize = 10;
            C.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            C.Location = new Point(286, 78);
            C.Name = "C";
            C.Size = new Size(60, 60);
            C.TabIndex = 9;
            C.Text = "C";
            C.UseVisualStyleBackColor = true;
            C.Click += buttonC;
            // 
            // multiply
            // 
            multiply.FlatAppearance.BorderColor = Color.Yellow;
            multiply.FlatAppearance.BorderSize = 10;
            multiply.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            multiply.Location = new Point(220, 144);
            multiply.Name = "multiply";
            multiply.Size = new Size(60, 60);
            multiply.TabIndex = 8;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += operator_click;
            // 
            // six
            // 
            six.FlatAppearance.BorderColor = Color.Yellow;
            six.FlatAppearance.BorderSize = 10;
            six.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            six.Location = new Point(154, 144);
            six.Name = "six";
            six.Size = new Size(60, 60);
            six.TabIndex = 7;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += button_click;
            // 
            // five
            // 
            five.FlatAppearance.BorderColor = Color.Yellow;
            five.FlatAppearance.BorderSize = 10;
            five.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            five.Location = new Point(88, 144);
            five.Name = "five";
            five.Size = new Size(60, 60);
            five.TabIndex = 6;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += button_click;
            // 
            // four
            // 
            four.FlatAppearance.BorderColor = Color.Yellow;
            four.FlatAppearance.BorderSize = 10;
            four.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            four.Location = new Point(22, 144);
            four.Name = "four";
            four.Size = new Size(60, 60);
            four.TabIndex = 5;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += button_click;
            // 
            // minus
            // 
            minus.FlatAppearance.BorderColor = Color.Yellow;
            minus.FlatAppearance.BorderSize = 10;
            minus.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minus.Location = new Point(220, 210);
            minus.Name = "minus";
            minus.Size = new Size(60, 60);
            minus.TabIndex = 13;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += operator_click;
            // 
            // three
            // 
            three.FlatAppearance.BorderColor = Color.Yellow;
            three.FlatAppearance.BorderSize = 10;
            three.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            three.Location = new Point(154, 210);
            three.Name = "three";
            three.Size = new Size(60, 60);
            three.TabIndex = 12;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += button_click;
            // 
            // two
            // 
            two.FlatAppearance.BorderColor = Color.Yellow;
            two.FlatAppearance.BorderSize = 10;
            two.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            two.Location = new Point(88, 210);
            two.Name = "two";
            two.Size = new Size(60, 60);
            two.TabIndex = 11;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += button_click;
            // 
            // one
            // 
            one.FlatAppearance.BorderColor = Color.Yellow;
            one.FlatAppearance.BorderSize = 10;
            one.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            one.Location = new Point(22, 210);
            one.Name = "one";
            one.Size = new Size(60, 60);
            one.TabIndex = 10;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += button_click;
            // 
            // equal
            // 
            equal.FlatAppearance.BorderColor = Color.Yellow;
            equal.FlatAppearance.BorderSize = 10;
            equal.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            equal.Location = new Point(286, 210);
            equal.Name = "equal";
            equal.Size = new Size(60, 126);
            equal.TabIndex = 19;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            equal.Click += button_equal;
            // 
            // plus
            // 
            plus.FlatAppearance.BorderColor = Color.Yellow;
            plus.FlatAppearance.BorderSize = 10;
            plus.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plus.Location = new Point(220, 276);
            plus.Name = "plus";
            plus.Size = new Size(60, 60);
            plus.TabIndex = 18;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += operator_click;
            // 
            // dot
            // 
            dot.FlatAppearance.BorderColor = Color.Yellow;
            dot.FlatAppearance.BorderSize = 10;
            dot.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dot.Location = new Point(154, 276);
            dot.Name = "dot";
            dot.Size = new Size(60, 60);
            dot.TabIndex = 17;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = true;
            dot.Click += button_click;
            // 
            // zero
            // 
            zero.FlatAppearance.BorderColor = Color.Yellow;
            zero.FlatAppearance.BorderSize = 10;
            zero.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            zero.Location = new Point(22, 276);
            zero.Name = "zero";
            zero.Size = new Size(126, 60);
            zero.TabIndex = 15;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += button_click;
            // 
            // resultText
            // 
            resultText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultText.Location = new Point(22, 41);
            resultText.Name = "resultText";
            resultText.Size = new Size(323, 31);
            resultText.TabIndex = 20;
            resultText.Text = "0";
            resultText.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 346);
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
            Name = "Form1";
            Text = "Form1";
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

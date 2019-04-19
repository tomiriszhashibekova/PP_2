namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.C = new System.Windows.Forms.Button();
            this.plusmins = new System.Windows.Forms.Button();
            this.prosent = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.multipl = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(37, 74);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(51, 50);
            this.C.TabIndex = 0;
            this.C.Text = "AC";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // plusmins
            // 
            this.plusmins.Location = new System.Drawing.Point(81, 74);
            this.plusmins.Name = "plusmins";
            this.plusmins.Size = new System.Drawing.Size(41, 50);
            this.plusmins.TabIndex = 1;
            this.plusmins.Text = "+/-";
            this.plusmins.UseVisualStyleBackColor = true;
            this.plusmins.Click += new System.EventHandler(this.button14_Click);
            // 
            // prosent
            // 
            this.prosent.Location = new System.Drawing.Point(169, 74);
            this.prosent.Name = "prosent";
            this.prosent.Size = new System.Drawing.Size(37, 50);
            this.prosent.TabIndex = 2;
            this.prosent.Text = "%";
            this.prosent.UseVisualStyleBackColor = true;
            this.prosent.Click += new System.EventHandler(this.prosent_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.Color.DarkOrange;
            this.div.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.div.Location = new System.Drawing.Point(250, 74);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(90, 50);
            this.div.TabIndex = 3;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.operator_click_even);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(-4, 121);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(90, 50);
            this.seven.TabIndex = 4;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(81, 121);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(90, 50);
            this.eight.TabIndex = 5;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.button_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(167, 121);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(90, 50);
            this.nine.TabIndex = 6;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.button_Click);
            // 
            // multipl
            // 
            this.multipl.BackColor = System.Drawing.Color.DarkOrange;
            this.multipl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.multipl.Location = new System.Drawing.Point(250, 121);
            this.multipl.Name = "multipl";
            this.multipl.Size = new System.Drawing.Size(90, 50);
            this.multipl.TabIndex = 7;
            this.multipl.Text = "*";
            this.multipl.UseVisualStyleBackColor = false;
            this.multipl.Click += new System.EventHandler(this.operator_click_even);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.Color.DarkOrange;
            this.Equal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Equal.Location = new System.Drawing.Point(250, 257);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(90, 50);
            this.Equal.TabIndex = 18;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-4, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "4";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "5";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 50);
            this.button3.TabIndex = 10;
            this.button3.Text = "6";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOrange;
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(250, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 50);
            this.button4.TabIndex = 11;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.operator_click_even);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(-6, 209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 50);
            this.button5.TabIndex = 12;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(80, 209);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 50);
            this.button6.TabIndex = 13;
            this.button6.Text = "2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(167, 209);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 50);
            this.button7.TabIndex = 14;
            this.button7.Text = "3";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkOrange;
            this.button8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button8.Location = new System.Drawing.Point(250, 209);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 50);
            this.button8.TabIndex = 15;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.operator_click_even);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(-4, 257);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 50);
            this.button9.TabIndex = 16;
            this.button9.Text = "0";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(167, 257);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(90, 50);
            this.button10.TabIndex = 17;
            this.button10.Text = ".";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(80, 257);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(90, 50);
            this.button11.TabIndex = 19;
            this.button11.Text = "sqrt";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 74);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(-4, 74);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(45, 50);
            this.button12.TabIndex = 21;
            this.button12.Text = "C";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(117, 74);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(53, 50);
            this.button13.TabIndex = 22;
            this.button13.Text = "x^2";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(203, 74);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(54, 50);
            this.button14.TabIndex = 23;
            this.button14.Text = "1/x";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.wqqw);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(340, 304);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.multipl);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.div);
            this.Controls.Add(this.prosent);
            this.Controls.Add(this.plusmins);
            this.Controls.Add(this.C);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button plusmins;
        private System.Windows.Forms.Button prosent;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button multipl;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
    }
}



namespace Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonFloat = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.plus_minus = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_exponentiation = new System.Windows.Forms.Button();
            this.button_root = new System.Windows.Forms.Button();
            this.button_result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.num_click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(88, 332);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(70, 70);
            this.button0.TabIndex = 1;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.num_click);
            // 
            // buttonFloat
            // 
            this.buttonFloat.Location = new System.Drawing.Point(12, 332);
            this.buttonFloat.Name = "buttonFloat";
            this.buttonFloat.Size = new System.Drawing.Size(70, 70);
            this.buttonFloat.TabIndex = 2;
            this.buttonFloat.Text = ",";
            this.buttonFloat.UseVisualStyleBackColor = true;
            this.buttonFloat.Click += new System.EventHandler(this.num_click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(227, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(266, 12);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(70, 29);
            this.clear.TabIndex = 4;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 5;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.num_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(164, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 8;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.num_click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 70);
            this.button4.TabIndex = 7;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.num_click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(88, 161);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 70);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.num_click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(164, 161);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 70);
            this.button6.TabIndex = 9;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.num_click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 237);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 70);
            this.button7.TabIndex = 10;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.num_click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(88, 237);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 70);
            this.button8.TabIndex = 11;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.num_click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(164, 237);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 70);
            this.button9.TabIndex = 12;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.num_click);
            // 
            // plus_minus
            // 
            this.plus_minus.Location = new System.Drawing.Point(164, 332);
            this.plus_minus.Name = "plus_minus";
            this.plus_minus.Size = new System.Drawing.Size(70, 70);
            this.plus_minus.TabIndex = 14;
            this.plus_minus.Text = "+/-";
            this.plus_minus.UseVisualStyleBackColor = true;
            this.plus_minus.Click += new System.EventHandler(this.plus_minus_Click);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(266, 85);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(70, 70);
            this.button_plus.TabIndex = 15;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.selecting_an_action);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(266, 161);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(70, 70);
            this.button_minus.TabIndex = 16;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.selecting_an_action);
            // 
            // button_multiplication
            // 
            this.button_multiplication.Location = new System.Drawing.Point(266, 237);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(70, 70);
            this.button_multiplication.TabIndex = 17;
            this.button_multiplication.Text = "*";
            this.button_multiplication.UseVisualStyleBackColor = true;
            this.button_multiplication.Click += new System.EventHandler(this.selecting_an_action);
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(342, 12);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(70, 29);
            this.backspace.TabIndex = 18;
            this.backspace.Text = "<-";
            this.backspace.UseVisualStyleBackColor = true;
            // 
            // button_division
            // 
            this.button_division.Location = new System.Drawing.Point(342, 85);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(70, 70);
            this.button_division.TabIndex = 19;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.selecting_an_action);
            // 
            // button_exponentiation
            // 
            this.button_exponentiation.Location = new System.Drawing.Point(342, 161);
            this.button_exponentiation.Name = "button_exponentiation";
            this.button_exponentiation.Size = new System.Drawing.Size(70, 70);
            this.button_exponentiation.TabIndex = 20;
            this.button_exponentiation.Text = "^";
            this.button_exponentiation.UseVisualStyleBackColor = true;
            this.button_exponentiation.Click += new System.EventHandler(this.selecting_an_action);
            // 
            // button_root
            // 
            this.button_root.Location = new System.Drawing.Point(342, 237);
            this.button_root.Name = "button_root";
            this.button_root.Size = new System.Drawing.Size(70, 70);
            this.button_root.TabIndex = 21;
            this.button_root.Text = "^";
            this.button_root.UseVisualStyleBackColor = true;
            this.button_root.Click += new System.EventHandler(this.selecting_an_action);
            // 
            // button_result
            // 
            this.button_result.Location = new System.Drawing.Point(266, 332);
            this.button_result.Name = "button_result";
            this.button_result.Size = new System.Drawing.Size(146, 70);
            this.button_result.TabIndex = 22;
            this.button_result.Text = "=";
            this.button_result.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 415);
            this.Controls.Add(this.button_result);
            this.Controls.Add(this.button_root);
            this.Controls.Add(this.button_exponentiation);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.button_multiplication);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.plus_minus);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonFloat);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonFloat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button plus_minus;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button_exponentiation;
        private System.Windows.Forms.Button button_root;
        private System.Windows.Forms.Button button_result;
    }
}


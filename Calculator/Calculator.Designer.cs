﻿
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
            this.Parse_It = new System.Windows.Forms.Button();
            this.plus_minus = new System.Windows.Forms.Button();
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
            this.button0.Location = new System.Drawing.Point(88, 357);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(70, 70);
            this.button0.TabIndex = 1;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.num_click);
            // 
            // buttonFloat
            // 
            this.buttonFloat.Location = new System.Drawing.Point(12, 357);
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
            this.textBox1.Size = new System.Drawing.Size(377, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(319, 85);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(70, 70);
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
            // Parse_It
            // 
            this.Parse_It.Location = new System.Drawing.Point(319, 167);
            this.Parse_It.Name = "Parse_It";
            this.Parse_It.Size = new System.Drawing.Size(70, 59);
            this.Parse_It.TabIndex = 13;
            this.Parse_It.Text = "Parse it";
            this.Parse_It.UseVisualStyleBackColor = true;
            this.Parse_It.Click += new System.EventHandler(this.Parse_It_Click);
            // 
            // plus_minus
            // 
            this.plus_minus.Location = new System.Drawing.Point(164, 357);
            this.plus_minus.Name = "plus_minus";
            this.plus_minus.Size = new System.Drawing.Size(70, 70);
            this.plus_minus.TabIndex = 14;
            this.plus_minus.Text = "+/-";
            this.plus_minus.UseVisualStyleBackColor = true;
            this.plus_minus.Click += new System.EventHandler(this.plus_minus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.plus_minus);
            this.Controls.Add(this.Parse_It);
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
        private System.Windows.Forms.Button Parse_It;
        private System.Windows.Forms.Button plus_minus;
    }
}


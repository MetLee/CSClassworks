﻿namespace WindowsFormsApp9
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
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
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 80);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(580, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 80);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(580, 326);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 80);
            this.button4.TabIndex = 5;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(425, 326);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 80);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(276, 326);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 80);
            this.button6.TabIndex = 3;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(580, 428);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 80);
            this.button7.TabIndex = 8;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(425, 428);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 80);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(276, 428);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 80);
            this.button9.TabIndex = 6;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(580, 541);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(82, 80);
            this.button10.TabIndex = 11;
            this.button10.Text = "=";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Calc);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(425, 541);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(88, 80);
            this.button11.TabIndex = 10;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(276, 541);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(82, 80);
            this.button12.TabIndex = 9;
            this.button12.Text = ".";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.AppendDigit);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(731, 541);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(82, 80);
            this.button13.TabIndex = 15;
            this.button13.Text = "/";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.AppendOperation);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(731, 428);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(82, 80);
            this.button14.TabIndex = 14;
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.AppendOperation);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(731, 326);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(82, 80);
            this.button15.TabIndex = 13;
            this.button15.Text = "-";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.AppendOperation);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(731, 209);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(82, 80);
            this.button16.TabIndex = 12;
            this.button16.Text = "+";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.AppendOperation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(266, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 56);
            this.label1.TabIndex = 16;
            this.label1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 674);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label1;
    }
}


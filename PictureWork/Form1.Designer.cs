﻿namespace PictureWork
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
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.OpenBut = new System.Windows.Forms.Button();
            this.WhiteBlackBut = new System.Windows.Forms.Button();
            this.SaveBut = new System.Windows.Forms.Button();
            this.prBut = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox1
            // 
            this.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox1.Location = new System.Drawing.Point(23, 59);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(267, 233);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox2.Location = new System.Drawing.Point(386, 59);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(272, 233);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox2.TabIndex = 1;
            this.picBox2.TabStop = false;
            // 
            // OpenBut
            // 
            this.OpenBut.Location = new System.Drawing.Point(107, 21);
            this.OpenBut.Name = "OpenBut";
            this.OpenBut.Size = new System.Drawing.Size(75, 23);
            this.OpenBut.TabIndex = 2;
            this.OpenBut.Text = "Open";
            this.OpenBut.UseVisualStyleBackColor = true;
            this.OpenBut.Click += new System.EventHandler(this.OpenBut_Click);
            // 
            // WhiteBlackBut
            // 
            this.WhiteBlackBut.Location = new System.Drawing.Point(296, 77);
            this.WhiteBlackBut.Name = "WhiteBlackBut";
            this.WhiteBlackBut.Size = new System.Drawing.Size(84, 23);
            this.WhiteBlackBut.TabIndex = 3;
            this.WhiteBlackBut.Text = "White-Black";
            this.WhiteBlackBut.UseVisualStyleBackColor = true;
            this.WhiteBlackBut.Click += new System.EventHandler(this.ModBut_Click);
            // 
            // SaveBut
            // 
            this.SaveBut.Location = new System.Drawing.Point(485, 21);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(75, 23);
            this.SaveBut.TabIndex = 4;
            this.SaveBut.Text = "Save";
            this.SaveBut.UseVisualStyleBackColor = true;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // prBut
            // 
            this.prBut.Location = new System.Drawing.Point(296, 106);
            this.prBut.Name = "prBut";
            this.prBut.Size = new System.Drawing.Size(84, 28);
            this.prBut.TabIndex = 5;
            this.prBut.Text = "transparency";
            this.prBut.UseVisualStyleBackColor = true;
            this.prBut.Click += new System.EventHandler(this.prBut_Click);
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(308, 140);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(57, 20);
            this.Num1.TabIndex = 7;
            this.Num1.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 372);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.prBut);
            this.Controls.Add(this.SaveBut);
            this.Controls.Add(this.WhiteBlackBut);
            this.Controls.Add(this.OpenBut);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Button OpenBut;
        private System.Windows.Forms.Button WhiteBlackBut;
        private System.Windows.Forms.Button SaveBut;
        private System.Windows.Forms.Button prBut;
        private System.Windows.Forms.NumericUpDown Num1;
    }
}


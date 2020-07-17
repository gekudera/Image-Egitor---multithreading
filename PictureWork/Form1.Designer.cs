namespace PictureWork
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.OpenBut = new System.Windows.Forms.Button();
            this.WhiteBlackBut = new System.Windows.Forms.Button();
            this.SaveBut = new System.Windows.Forms.Button();
            this.prBut = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BlurBut = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox1
            // 
            this.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox1.Location = new System.Drawing.Point(50, 10);
            this.picBox1.Margin = new System.Windows.Forms.Padding(10);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(273, 249);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox2.Location = new System.Drawing.Point(0, 10);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(282, 249);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox2.TabIndex = 1;
            this.picBox2.TabStop = false;
            // 
            // OpenBut
            // 
            this.OpenBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenBut.Location = new System.Drawing.Point(223, 12);
            this.OpenBut.Name = "OpenBut";
            this.OpenBut.Size = new System.Drawing.Size(87, 29);
            this.OpenBut.TabIndex = 2;
            this.OpenBut.Text = "Open";
            this.OpenBut.UseVisualStyleBackColor = true;
            this.OpenBut.Click += new System.EventHandler(this.OpenBut_Click);
            // 
            // WhiteBlackBut
            // 
            this.WhiteBlackBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WhiteBlackBut.Location = new System.Drawing.Point(27, 10);
            this.WhiteBlackBut.Margin = new System.Windows.Forms.Padding(10);
            this.WhiteBlackBut.Name = "WhiteBlackBut";
            this.WhiteBlackBut.Size = new System.Drawing.Size(98, 35);
            this.WhiteBlackBut.TabIndex = 3;
            this.WhiteBlackBut.Text = "White-Black";
            this.WhiteBlackBut.UseVisualStyleBackColor = true;
            this.WhiteBlackBut.Click += new System.EventHandler(this.ModBut_Click);
            // 
            // SaveBut
            // 
            this.SaveBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBut.Location = new System.Drawing.Point(487, 12);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(87, 29);
            this.SaveBut.TabIndex = 4;
            this.SaveBut.Text = "Save";
            this.SaveBut.UseVisualStyleBackColor = true;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // prBut
            // 
            this.prBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prBut.Location = new System.Drawing.Point(27, 61);
            this.prBut.Margin = new System.Windows.Forms.Padding(10);
            this.prBut.Name = "prBut";
            this.prBut.Size = new System.Drawing.Size(98, 34);
            this.prBut.TabIndex = 5;
            this.prBut.Text = "Transparency";
            this.prBut.UseVisualStyleBackColor = true;
            this.prBut.Click += new System.EventHandler(this.prBut_Click);
            // 
            // Num1
            // 
            this.Num1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Num1.Location = new System.Drawing.Point(27, 101);
            this.Num1.Margin = new System.Windows.Forms.Padding(10);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(76, 22);
            this.Num1.TabIndex = 7;
            this.Num1.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(27, 234);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(427, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "%";
            // 
            // BlurBut
            // 
            this.BlurBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BlurBut.Location = new System.Drawing.Point(27, 134);
            this.BlurBut.Margin = new System.Windows.Forms.Padding(10);
            this.BlurBut.Name = "BlurBut";
            this.BlurBut.Size = new System.Drawing.Size(98, 34);
            this.BlurBut.TabIndex = 10;
            this.BlurBut.Text = "Blur";
            this.BlurBut.UseVisualStyleBackColor = true;
            this.BlurBut.Click += new System.EventHandler(this.BlurBut_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Blur Amont:";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar1.Location = new System.Drawing.Point(27, 188);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(10);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(98, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.updateBlur);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.aboutProgramToolStripMenuItem.Text = "About Program";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SaveBut);
            this.splitContainer1.Panel1.Controls.Add(this.OpenBut);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(300, 3, 300, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(809, 353);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.TabIndex = 14;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.picBox1);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(50, 10, 0, 50);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(809, 309);
            this.splitContainer2.SplitterDistance = 323;
            this.splitContainer2.TabIndex = 13;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.WhiteBlackBut);
            this.splitContainer3.Panel1.Controls.Add(this.prBut);
            this.splitContainer3.Panel1.Controls.Add(this.button1);
            this.splitContainer3.Panel1.Controls.Add(this.trackBar1);
            this.splitContainer3.Panel1.Controls.Add(this.Num1);
            this.splitContainer3.Panel1.Controls.Add(this.BlurBut);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Margin = new System.Windows.Forms.Padding(10);
            this.splitContainer3.Panel1.Padding = new System.Windows.Forms.Padding(10, 30, 10, 30);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.picBox2);
            this.splitContainer3.Panel2.Padding = new System.Windows.Forms.Padding(0, 10, 50, 50);
            this.splitContainer3.Size = new System.Drawing.Size(482, 309);
            this.splitContainer3.SplitterDistance = 146;
            this.splitContainer3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 377);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Photo Editor";
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Button OpenBut;
        private System.Windows.Forms.Button WhiteBlackBut;
        private System.Windows.Forms.Button SaveBut;
        private System.Windows.Forms.Button prBut;
        private System.Windows.Forms.NumericUpDown Num1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BlurBut;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label3;
    }
}


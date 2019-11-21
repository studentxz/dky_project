namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.class12 = new buttonex.Class1();
            this.button1 = new System.Windows.Forms.Button();
            this.class11 = new buttonex.Class1();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.class12);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.class11);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 565);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(225, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 16);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // class12
            // 
            this.class12.ForeColor = System.Drawing.Color.OrangeRed;
            this.class12.Location = new System.Drawing.Point(432, 268);
            this.class12.Name = "class12";
            this.class12.Size = new System.Drawing.Size(46, 47);
            this.class12.TabIndex = 8;
            this.class12.Text = "2";
            this.class12.UseVisualStyleBackColor = true;
            this.class12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.class12_MouseDown_1);
            this.class12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.class12_MouseMove_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.ForeColor = System.Drawing.Color.Ivory;
            this.button1.Location = new System.Drawing.Point(611, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 10);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // class11
            // 
            this.class11.ForeColor = System.Drawing.Color.OrangeRed;
            this.class11.Location = new System.Drawing.Point(225, 268);
            this.class11.Name = "class11";
            this.class11.Size = new System.Drawing.Size(46, 47);
            this.class11.TabIndex = 4;
            this.class11.Text = "1";
            this.class11.UseVisualStyleBackColor = true;
            this.class11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.class11_MouseDown);
            this.class11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.class11_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(432, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 92);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(432, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 10);
            this.panel2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(296, 539);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(797, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 565);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "记录";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 589);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private buttonex.Class1 class11;
        private System.Windows.Forms.Button button1;
        private buttonex.Class1 class12;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}


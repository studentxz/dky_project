namespace WindowsFormsApp1
{
    partial class TestUserControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.class11 = new bottonex.Class1();
            this.SuspendLayout();
            // 
            // class11
            // 
            this.class11.BackColor = System.Drawing.Color.LightSalmon;
            this.class11.Location = new System.Drawing.Point(3, 3);
            this.class11.Name = "class11";
            this.class11.Size = new System.Drawing.Size(22, 21);
            this.class11.TabIndex = 0;
            this.class11.Text = "class11";
            this.class11.UseVisualStyleBackColor = false;
            this.class11.Click += new System.EventHandler(this.class11_Click);
            this.class11.Paint += new System.Windows.Forms.PaintEventHandler(this.class11_Paint);
            this.class11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.class11_MouseDown);
            this.class11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.class11_MouseMove);
            // 
            // TestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.class11);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "TestUserControl";
            this.Size = new System.Drawing.Size(28, 27);
            this.Load += new System.EventHandler(this.TestUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private bottonex.Class1 class11;
    }
}

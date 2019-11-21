using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TestUserControl : UserControl
    {
        Point location;
        public TestUserControl()
        {
            InitializeComponent();
        }

        private void TestUserControl_Load(object sender, EventArgs e)
        {

        }
        //public string ButtonName
        //{
        //    get
        //    {
        //        //TODO
        //        return button1.Text;
        //    }
        //    set
        //    {
        //        //TODO
        //        button1.Text = value;
        //    }
        //}


        public event EventHandler BtnTestClick;
        /// <summary>
        /// 测试按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTest_Click(object sender, EventArgs e)
        {
            if (BtnTestClick != null)
            {
                //TODO
                BtnTestClick(sender, e);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void class11_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void class11_Click(object sender, EventArgs e)
        {
          
        }

        private void class11_MouseDown(object sender, MouseEventArgs e)
        {
            location = e.Location;
        }

        private void class11_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            System.Drawing.Drawing2D.GraphicsPath btnPath = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Rectangle newRectangle = btn.ClientRectangle;
            newRectangle.Inflate(-1, -1);
            e.Graphics.DrawEllipse(System.Drawing.Pens.BlanchedAlmond, newRectangle);
            newRectangle.Inflate(-1, -1);
            btnPath.AddEllipse(newRectangle);
            btn.Region = new System.Drawing.Region(btnPath);
        }
    }
}

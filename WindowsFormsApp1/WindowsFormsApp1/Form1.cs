using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Point location;
        int sign=0;
        int startX;     //获取鼠标起始点的X坐标
        int startY;    //获取鼠标起始点的Y坐标
        Graphics g;  //定义Graphics对象实例

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Snow;         //设置窗体背景颜色
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            renderGrid();
        }

        private void class12_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button b = sender as Button;
                b.Location = new Point(b.Location.X + (e.X - location.X), b.Location.Y + (e.Y - location.Y));
            }


        }
        private void renderGrid()
        {
            //全局变量存储最大最小值，作为绘制区域
            Graphics g = this.panel1.CreateGraphics();
            Color color = Color.DarkGray;
           Pen p = new Pen(color, 1);
           p.DashStyle = DashStyle.Dash;
            for (int x = 0; x <= this.panel1.Width; x = x + 20)
            {
                PointF p1 = new PointF(x, 0);
                PointF p2 = new PointF(x, Height);
                g.DrawLine(p, p1, p2);
             }
 
            for (int y = 0; y <= panel1.Height; y = y + 20)
            {
               PointF p1 = new PointF(0, y);
                PointF p2 = new PointF(Width, y);
               g.DrawLine(p, p1, p2);

            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //renderGrid();
        }

       
        private void class11_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button b = sender as Button;
                b.Location = new Point(b.Location.X + (e.X - location.X), b.Location.Y + (e.Y - location.Y));
            }

        }

        private void class11_MouseDown(object sender, MouseEventArgs e)
        {
            location = e.Location;
        }

      
        private void class12_MouseDown_1(object sender, MouseEventArgs e)
        {
            location = e.Location;
        }

        private void class12_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button b = sender as Button;
                b.Location = new Point(b.Location.X + (e.X - location.X), b.Location.Y + (e.Y - location.Y));
            }

        }
      
        /// <summary>
        /// 画直线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            AdjustableArrowCap acc = new AdjustableArrowCap(5, 4);
            g = this.panel1.CreateGraphics();               //创建Graphics对象实例
            Pen p = new Pen(Color.Green, 2);      //设置画笔颜色和宽度
            p.CustomEndCap = acc;
            p.DashStyle = DashStyle.Solid;//画实线
            //p.EndCap = LineCap.ArrowAnchor;//定义尾部为直线
            if (sign == 2)
            {
                g.DrawLine(p, startX, startY, e.X, e.Y);  //绘制直线

            }


        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
          
            if (sign !=0)
            {
                startX = e.X;       //为变量赋值
                startY = e.Y;
                sign = 2;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //g = this.panel1.CreateGraphics();
            //Pen p = new Pen(Color.Blue, 1);       //设置画笔颜色和宽度
            //if (sign == 2)
            //{
            //    g.DrawRectangle(p, e.X, e.Y, 1, 1);    //绘制曲线
            //    sign = 0;
            //}
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sign = 1;
        }
    }
}

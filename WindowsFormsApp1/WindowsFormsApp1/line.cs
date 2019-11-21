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
    public partial class line : UserControl
    {
        public line()
        {
            InitializeComponent();
        }
        //定义委托
        public delegate void BtnClickHandle(object sender, EventArgs e);
        //定义事件
        public event BtnClickHandle UserControlBtnClicked;
        /// <summary>
        /// 测试按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {
            if (UserControlBtnClicked != null)
            {
                //TODO
                UserControlBtnClicked(sender, new EventArgs());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void line_Load(object sender, EventArgs e)
        {

        }
    }
}

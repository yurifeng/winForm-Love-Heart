using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yuri_test_love_heart_180502
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 实现label1控件中的text文本轮播
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //将原字符首位的字符切割放后面,将原字符第二位到最后的部分切割放到前面. 将组合好的新字符串赋值给label1
            //用定时器timer重复该代码.
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }
    }
}

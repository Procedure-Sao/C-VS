using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassCount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Grade gd = new Grade();
        private void Form1_Load(object sender, EventArgs e)
        {
            gd.AddStudent();
            }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int i=1;
         Dictionary<string,Point> ds=gd.DisplayStudent(e.Location);
         foreach (var item in ds.Keys)
         {
		         Button b = new Button();//创建一个新的按钮
                 b.Name = "b" + item;//这是来区别各个按钮的办法
                 b.Text = item;
                 i++;
                 System.Drawing.Point p = new Point(12, 10 + i * 30);//创建一个坐标,用来给新的按钮定位
                 b.Location = p;//把按钮的位置与刚创建的坐标绑定在一起
                 this.Controls.Add(b);
	
        }
              
            
        }
    }
}

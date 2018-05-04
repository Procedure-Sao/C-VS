using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOffice1
{
    public partial class FrmShow : Form
    {
        public FrmShow()
        {
            InitializeComponent();
        }
        public static SE[] messsge = new SE[5];
        private void FrmShow_Load(object sender, EventArgs e)
        {
            SE se1 = new SE();
            se1.Id = "111";
            se1.Name = "王小毛";
            se1.Age = "26";
            se1.Ping = "未评价";
            se1.Defen = "0";
            messsge[0] = se1;

            SE se2 = new SE();
            se2.Id = "222";
            se2.Name = "周新宇";
            se2.Age = "22";
            se2.Ping = "未评价";
            se2.Defen = "0";
            messsge[1] = se2;

            SE se3 = new SE();
            se3.Id = "333";
            se3.Name = "张华";
            se3.Age = "25";
            se3.Ping = "未评价";
            se3.Defen = "0";
            messsge[2] = se3;



            for (int i = 0; i < messsge.Length; i++)
            {
                if (messsge[i]!=null)//判断不为空，如果不判断执行顺序不同，会报空值异常
                {
                    ListViewItem item = new ListViewItem(messsge[i].Id);//将数据赋到listview里
                    item.SubItems.Add(messsge[i].Name);
                    item.SubItems.Add(messsge[i].Age);
                    item.SubItems.Add(messsge[i].Ping);
                    item.SubItems.Add(messsge[i].Defen);
                    listView1.Items.Add(item);
                }
               
            
            }
        }


        private void listView1_Click(object sender, EventArgs e)
        {
            FrmJudge fj = new FrmJudge();
            fj.zhazha=listView1.SelectedItems[0];
            fj.Show();
        }
    }
}

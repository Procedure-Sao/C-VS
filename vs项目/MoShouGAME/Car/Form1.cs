using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //可租用车集合信息
        Dictionary<string, Vehicle> vec = new Dictionary<string, Vehicle>();
        //租用车集合信息
        Dictionary<string, Vehicle> rentvec = new Dictionary<string, Vehicle>();

         //初始值出租
        public void Info(Dictionary<string, Vehicle> dic, ListView lv)
        {                      
            //循环之前先清空
            lv.Items.Clear();  
            //循环绑定         
            foreach (Vehicle item in dic.Values)
            {              
                ListViewItem lv1 = new ListViewItem();
                lv1.Text = item.licensno;
                lv1.SubItems.Add(item.name);
                lv1.SubItems.Add(item.color);
                lv1.SubItems.Add(item.rentdate.ToString());
                lv1.SubItems.Add(item.dailyrent.ToString());
                //判断
                if (item is Truck)
                {
                    lv1.SubItems.Add((item as Truck).Load.ToString());
                }
                else
                {
                    lv1.SubItems.Add("无");
                    
                }
                //总的
                lv.Items.Add(lv1);

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Arc car1 = new Arc("京2T3865","奔驰","黑色",3,210);
            Arc car2 = new Arc("京2G4648", "奥迪", "白色", 3, 280);
            Truck tck1 = new Truck
            {
               
                licensno = "湘B666666",
                name = "东风A5",
                color = "蓝色",
                rentdate = 2000,
                dailyrent = 2,
                Load = 120
            };
            vec.Add(car1.licensno, car1);
            vec.Add(car2.licensno, car2);
            vec.Add(tck1.licensno, tck1);

            Info(vec, listView1);
              //给颜色下拉框赋值
            this.comboBox1.Items.Add("红色");
            this.comboBox1.Items.Add("蓝色");
            this.comboBox1.Items.Add("白色");
            this.comboBox1.Items.Add("黑色");
            this.comboBox1.Items.Add("灰色");

            this.textBox7.Enabled = false;
        }

        public void Info1(Dictionary<string, Vehicle> rentVehicles, ListView list)
        {
            list.Items.Clear();
            foreach (Vehicle item in rentVehicles.Values)
            {
                ListViewItem lv1 = new ListViewItem();
                lv1.Text = item.licensno;
                lv1.SubItems.Add(item.name);
                lv1.SubItems.Add(item.color);
                lv1.SubItems.Add(item.rentdate.ToString());
                lv1.SubItems.Add(item.dailyrent.ToString());
                //判断
                if (item is Truck)
                {
                    lv1.SubItems.Add((item as Truck).Load.ToString());
                }
                else
                {
                    lv1.SubItems.Add("无");

                }
                //总的
                list.Items.Add(lv1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //判断
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一行！");
            }
            else if (this.textBox1.Text == "")
            {
                MessageBox.Show("请输入租用者的名字");
            }
            else
            {
                //这是通过选择车牌号
                string key = listView1.SelectedItems[0].Text;
                //租用者和车牌号绑定在一起
                vec[key].rentuser = this.textBox1.Text;
                //将已租车辆放入到已租集合中
                rentvec.Add(vec[key].licensno, vec[key]);
                //判断是否已经出租
                if (vec.ContainsKey(key))
                {
                    vec.Remove(key);
                }
                //重新绑定listView
                Info(vec, listView1);
                MessageBox.Show("已出租");
                //使用者赋空
                this.textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Info(vec, listView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Info1(rentvec, listView2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择车辆！！");
                return;
            }
            if (this.textBox2.Text == "")
            {
                MessageBox.Show("请输入租用天数！");
                return;
            }
            string key = listView2.SelectedItems[0].Text;
            rentvec[key].yearsofservice = int.Parse(this.textBox2.Text);
            //调用抽象方法
            double totalPrice = rentvec[key].money();
            string msg = string.Format("您的总价是{0}", totalPrice.ToString());
            MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //加入到可租车辆集合里
            vec.Add(rentvec[key].licensno, rentvec[key]);
            //从当前的集合中移除
            if (rentvec.ContainsKey(key))
            {
                rentvec.Remove(key);
            }
            //重新刷新列表
            Info1(rentvec, listView2);
            //租用天数赋空
            this.textBox2.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //友情判断
            if (limousine() == true)
            {
                //遍历车牌号
                foreach (string item in vec.Keys)
                {

                    if (textBox1.Text == item)
                    {

                        MessageBox.Show("该车牌号已经存在");
                        return;
                    }

                }
                Vehicle vs = null;
                if (radioButton1.Checked == true)
                {
                    vs = new Arc();
                }
                else if (radioButton2.Checked == true)
                {
                    Truck tr = new Truck();
                    tr.Load = Convert.ToInt32(textBox7.Text);
                    vs = new Truck();
                    vs = tr;
                }
                //01获取对应文本框中的值,
                vs.licensno = textBox3.Text;//车号
                vs.name = textBox4.Text;//车型
                vs.color = comboBox1.Text;//颜色
                vs.rentdate = Convert.ToInt32(textBox5.Text);//使用时间
                vs.dailyrent = Convert.ToInt32(textBox6.Text);//每日租金  
                vec.Add(vs.licensno, vs);
                uptatetxt();
                MessageBox.Show("添加成功!");
            }
        }
       public bool truck()
        {
            if (radioButton1.Checked == false&& radioButton2.Checked == false)
            {
                MessageBox.Show("请选择车辆类型！");
                return false;
            }
            else if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("请填写完整！！");
                return false;
            }
            else
            {
                return true;  
            }
        }

        //轿车的友情提示
        public bool limousine()
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("请选择车辆类型！");
                return false;
            }
            else if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("请填写完整！！");
                return false;
            }
            else
            {
                return true;
            }
        }
        //轿车
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.textBox7.Enabled = false;
            }
        }
        //卡车
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                this.textBox7.Enabled = true;
            }
        }
        public void uptatetxt()
        {
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            this.comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出程序吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

      

        
    }
}

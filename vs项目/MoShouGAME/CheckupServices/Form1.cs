using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckupServices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<HealthItem> Allitems = new List<HealthItem>();//所有体检项目
        List<HealthItem> items = new List<HealthItem>();//体检中的项目
        Dictionary<string, HealthSet> HealthSet2 = new Dictionary<string, HealthSet>();//套餐集合


        private void button1_Click(object sender, EventArgs e)
        {
            InserttaocanName();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addset();
            MoRen();
            this.comboBox1.Items.Add("请选择");//添加项
            this.comboBox1.Items.Add("入学体检");
            this.comboBox1.SelectedIndex = 0;//索引归为0，显示请选择   

        } 
        #region 添加套餐
        private void InserttaocanName()
        {

            if (this.textBox1.Text.Trim() != null)//非空判断
            {
                HealthSet hcs = new HealthSet();//创建套餐列表类的对象
                HealthSet2.Add(textBox1.Text, hcs);//使用Add方法添加进去
                this.comboBox1.Items.Clear();//先清除项
                this.comboBox1.Items.Add("请选择");//添加项
                foreach (string key in HealthSet2.Keys)//利用foreach循环将用户要添加的套餐名称加到集合中
                {
                    this.comboBox1.Items.Add(key);//加到列表项中
                }
                comboBox1.Text = textBox1.Text;
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("请输入一个套餐名称！");
            }
        }
        #endregion

        #region 绑定项目


        public void addset()
        {
            //HealthSet hcs = new HealthSet();
            HealthItem hci = new HealthItem();
            hci.Name = "身高";
            hci.Miaoshu = "用于检查身高";
            hci.Price = 5;
            Allitems.Add(hci);

            HealthItem hci1 = new HealthItem();
            hci1.Name = "体重";
            hci1.Miaoshu = "用于检查体重";
            hci1.Price = 5;
            Allitems.Add(hci1);

            HealthItem hci2 = new HealthItem();
            hci2.Name = "肝功能";
            hci2.Miaoshu = "用于检查肝功能";
            hci2.Price = 50;
            Allitems.Add(hci2);

            HealthItem hci3 = new HealthItem();
            hci3.Name = "B超";
            hci3.Miaoshu = "用于检查B超";
            hci3.Price = 30;
            Allitems.Add(hci3);

            HealthItem hci4 = new HealthItem();
            hci4.Name = "血糖";
            hci4.Miaoshu = "血糖";
            hci4.Price = 50;
            Allitems.Add(hci4);

            HealthItem hci5 = new HealthItem();
            hci5.Name = "肺活量";
            hci5.Miaoshu = "用于检查肺活量";
            hci5.Price = 15;
            Allitems.Add(hci5);

            this.comboBox2.DataSource = Allitems;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.ValueMember = "Price";
        }
        #endregion

     


        #region 添加
        private void button2_Click_1(object sender, EventArgs e)
        {
            string setname2 = this.comboBox1.Text;
            string setname = this.comboBox2.Text;
            HealthItem hi = new HealthItem();
            int index = this.comboBox2.SelectedIndex;
            if (false)
            {
                MessageBox.Show("不能重复添加");
            }
            else
            {
                for (int i = 0; i < Allitems.Count; i++)
                {
                    if (Allitems[i].Name.Equals(setname))
                    {

                        hi.Name = Allitems[i].Name;
                        hi.Miaoshu = Allitems[i].Miaoshu;
                        hi.Price = Allitems[i].Price;
                        this.items.Add(hi);
                        this.HealthSet2[setname2].CalcPrice();
                        label6.Text = this.HealthSet2[setname2].Price.ToString();
                        dataGridView1.DataSource = new BindingList<HealthItem>(items);
                    }

                }
            }
        }
        #endregion

        #region 删除
         private void button3_Click_1(object sender, EventArgs e)
        {
            //是否选中一行
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult choice = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);
                if (choice == DialogResult.OK)
                {
                    string setname = this.comboBox1.Text;
                    //拿到选中的名字进行删除
                    string name = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (items[i].Name == name)
                        {
                            //执行删除操作
                            items.Remove(items[i]);
                            this.HealthSet2[setname].CalcPrice();
                            label6.Text = this.HealthSet2[setname].Price.ToString();
                            //刷新DataGridView
                            dataGridView1.DataSource = new BindingList<HealthItem>(items);
                            MessageBox.Show("删除成功！");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择一行！");
                    return;
                }
            }
         }
        #endregion

        #region 下拉框事件
         private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
         {
             string setname = this.comboBox1.Text;
             if (setname == "请选择")
             {
                 this.dataGridView1.DataSource = new BindingList<HealthItem>();
                 label4.Text = "";
                 label6.Text = "";
                 return;
             }

             label4.Text = this.HealthSet2[setname].Name;
             label6.Text = this.HealthSet2[setname].Price.ToString();
             this.button3.Enabled = true;
             Updateset(HealthSet2[setname]);
         } 
         #endregion

        #region 初始值
          public void MoRen()
        {
            HealthItem hci = new HealthItem();
            hci.Name = "身高";
            hci.Miaoshu = "用于检查身高";
            hci.Price = 5;

            HealthItem hci1 = new HealthItem();
            hci1.Name = "体重";
            hci1.Miaoshu = "用于检查体重";
            hci1.Price = 5;

            HealthItem hci2 = new HealthItem();
            hci2.Name = "肝功能";
            hci2.Miaoshu = "用于检查肝功能";
            hci2.Price = 50;
            items.Add(hci);
            items.Add(hci1);
            items.Add(hci2);

            HealthSet hst = new HealthSet();
            hst.Name = "入学体检";
            hst.Item = items;
            HealthSet2.Add(hst.Name, hst);
            hst.CalcPrice();

        }
        #endregion

          public void Updateset(HealthSet set)
          {

              this.dataGridView1.DataSource = new BindingList<HealthItem>(set.Item);

          }

    }
}

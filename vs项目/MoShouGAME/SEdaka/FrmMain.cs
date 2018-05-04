using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEdaka
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            
            InitializeComponent();
        }
      public  List<Comboxitems> list = new List<Comboxitems>();//原集合
    

      public void BindGrid(List<Comboxitems> list1) 
      {
        
          dataGridView1.DataSource = new BindingList<Comboxitems>(list1);
          return;
      }

        private void Form1_Load(object sender, EventArgs e)
        {
            Comboxitems cmb = new Comboxitems();
            cmb.Id = "001";
            cmb.Name = "张三";
            cmb.Age = "25";
            cmb.Gender = "男";
            list.Add(cmb);
            Comboxitems cmb1 = new Comboxitems();
            cmb1.Id = "002";
            cmb1.Name = "张三";
            cmb1.Age = "25";
            cmb1.Gender = "男";
            list.Add(cmb1);
            dataGridView1.DataSource = new BindingList<Comboxitems>(list);
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMessage am = new AddMessage();
            am.fm = this;
            am.ShowDialog();
        }
      
        
     

        private void button1_Click(object sender, EventArgs e)
        {
            List<Comboxitems> list3 = new List<Comboxitems>();
           
            foreach (Comboxitems item in list)
            {
                if (item.Id.IndexOf(textBox1.Text.Trim()) != -1)
                {
                    list3.Add(item);
                }
            }
            dataGridView1.DataSource = new BindingList<Comboxitems>(list3);
           
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //是否选中一行
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult choice = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);
                if (choice == DialogResult.OK)
                {
                    //拿到选中的员工号进行删除
                    string id = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].Id == id)
                        {
                            //执行删除操作
                            list.Remove(list[i]);
                            //刷新DataGridView
                            BindGrid(list);
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

            dataGridView1.DataSource = new BindingList<Comboxitems>(list);
        }
        Dictionary<string, Record> RecordList = new Dictionary<string, Record>();
        private void 签到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //验证有选中的一行
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                //确保没有签过到
                string qiandao = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                //MessageBox.Show(qiandao);  
                foreach (string id in RecordList.Keys)
                {
                    if (qiandao == id)
                    {
                        MessageBox.Show("您已经签过到！");
                        return;
                    }
                }
                //执行签到
                Record record = new Record();
                record.ID = qiandao;
                record.Name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//拿到签到人的名字
                record.SignInTime = DateTime.Now;//获取系统当前时间
                this.RecordList.Add(record.ID, record);//添加到签到记录
                MessageBox.Show("签到成功！");
            }
            else
            {
                MessageBox.Show("请选中一行！");
                return;
            }

        }

        private void 签退ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //签退操作
            //确保有选中的行
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                string ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                bool isOut = false;//标志是否已经签过到
                foreach (string key in RecordList.Keys)
                {
                    if (key == ID)
                    {
                        //执行签到，设置签退时间
                        this.RecordList[key].SignOutTime = DateTime.Now;//获得当前系统时间，也就是签退的时间
                        MessageBox.Show("签退成功");
                        isOut = true;
                        break;
                    }
                }
                if (!isOut)
                {
                    MessageBox.Show("很抱歉尚未签到！");
                }
            }
            else
            {
                MessageBox.Show("请选中一行！");
                return;
            }

        }

        private void 打卡记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打卡记录
            //绑定数据源，显示Dictionary
            FrmRecord fr = new FrmRecord();
            fr.RecordList = this.RecordList;//t获得当前的对象，通过this.调用当前对象的属性或者方法，
            fr.Show();

        }
    }
}

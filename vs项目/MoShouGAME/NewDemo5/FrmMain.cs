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
         #region 集合群
        //定义几个检查项目
        HealthItem height, weight, sight, hearing, liverFun, ekg, bWaves, bloodPressure, bloodTest;
        //定义1个系统默认检查套餐“入学体检”
        HealthSet setA;

        //保存原始的Item数据
        Dictionary<string, HealthItem> AllItems = new Dictionary<string, HealthItem>();
        //保存套餐中的Item数据
        Dictionary<string, HealthItem> items = new Dictionary<string, HealthItem>();
        //使用字典保存套餐集合
        public Dictionary<string, HealthSet> HealthSet = new Dictionary<string, HealthSet>(); 
        #endregion

         #region 添加套餐
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text.Trim()))
            {
                MessageBox.Show("请输入套餐名称!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            HealthSet Hch = new HealthSet(textBox1.Text);
            this.HealthSet.Add(this.textBox1.Text.Trim(), Hch);

            this.InitHealthSetList();
            this.comboBox1.SelectedIndex = this.HealthSet.Count;
            
            MessageBox.Show("添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);


        } 
        #endregion

         #region 窗体load
        private void Form1_Load(object sender, EventArgs e)
        {
            this.label4.Text = "";
            this.label6.Text = "";
            this.button2.Enabled = false;
            this.button3.Enabled = false;

            //初始化所有检查项目
            InitItems();
            //初始化默认套餐
            InitSets();
            //加载套餐列表
            InitHealthSetList();

        }  
        #endregion

         #region 绑定项目

        /// <summary>
        /// 创建所有检查项目，并保存在AllItems集合中
        /// </summary>
        public void InitItems()
        {
            //创建Item对象并保存到集合中 --注意如果使用List<T> 必须与下拉列表中的索引一致
            height = new HealthItem("身高", 5, "用于检查身高.");
            weight = new HealthItem("体重", 5, "用于检查体重.");
            sight = new HealthItem("视力", 10, "用于检查视力.");
            hearing = new HealthItem("听力", 10, "用于检查听力.");
            liverFun = new HealthItem("肝功能", 50, "用于检查肝功能.");
            bWaves = new HealthItem("B超", 30, "用于检查B超.");
            ekg = new HealthItem("心电图", 50, "用于检查心电图.");
            bloodPressure = new HealthItem("血压", 20, "用于检查血压.");
            bloodTest = new HealthItem("血常规", 20, "用于检查血常规.");
            AllItems.Add(height.Name, height);
            AllItems.Add(weight.Name, weight);
            AllItems.Add(sight.Name, sight);
            AllItems.Add(hearing.Name, hearing);
            AllItems.Add(liverFun.Name, liverFun);
            AllItems.Add(bWaves.Name, bWaves);
            AllItems.Add(ekg.Name, ekg);
            AllItems.Add(bloodPressure.Name, bloodPressure);
            AllItems.Add(bloodTest.Name, bloodTest);

            comboBox2.Items.Add("请选择");
            comboBox2.SelectedIndex = 0;
            foreach (var item in AllItems.Keys)
            {
                this.comboBox2.Items.Add(item);
            }

        }
   
     
        #endregion

         #region 添加
        private void button2_Click_1(object sender, EventArgs e)
        {
            #region 输入判断
            if (this.comboBox2.SelectedIndex == 0)
            {
                MessageBox.Show("请选择一个项目。");
                return;
            }

            string cboSetText = this.comboBox1.Text;
            if (cboSetText == "请选择")
            {
                MessageBox.Show("请选择套餐！");
                return;
            }
            #endregion
            #region 添加操作
            int index = this.comboBox2.SelectedIndex - 1;
            string wantAdd = this.comboBox2.Text;
            if (!this.HealthSet[cboSetText].Item.Keys.ToList().Contains(wantAdd))
            {
                //添加检查项
                this.HealthSet[cboSetText].Item.Add(wantAdd, AllItems[wantAdd]);
                //重新计算总价格
                this.HealthSet[cboSetText].CalcPrice();
                //更新
                UpdateSet(this.HealthSet[cboSetText]);
                this.label4.Text = this.HealthSet[cboSetText].Name;  //刷新窗体集合A名称
                this.label6.Text = this.HealthSet[cboSetText].Price.ToString();    //刷新集合A价格
                MessageBox.Show("添加成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("该项目存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
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
                    string setName = this.comboBox1.Text;
                    //获取选中检查项目的索引
                    int index = this.dataGridView1.SelectedRows[0].Index;
                    string key = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                    //删除检察项
                    this.HealthSet[setName].Item.Remove(key);

                    //重新计算价格
                    this.HealthSet[setName].CalcPrice();
                    //更新DataGridView显示
                    UpdateSet(HealthSet[setName]);
                    //重设标签显示
                    label4.Text = this.HealthSet[setName].Name;
                    label6.Text = this.HealthSet[setName].Price.ToString();
                    MessageBox.Show("删除成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
         private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
         {
             string setName = this.comboBox1.Text;
             if (setName == "请选择")
             {
                 this.dataGridView1.DataSource = new BindingList<HealthItem>();
                 label4.Text = "";
                 label6.Text = "";
                 return;
             }
             //设置套餐名称
             label4.Text = this.HealthSet[setName].Name;
             //设置套餐总价
             label6.Text = this.HealthSet[setName].Price.ToString();
             //更新套餐检查项目
             UpdateSet(HealthSet[setName]);
             //设置删除按钮为“可用状态”
             this.button3.Enabled = true;
         }

         private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (this.comboBox2.Text != "请选择")
             {
                 this.button2.Enabled = true;
             }
             else
             {
                 this.button2.Enabled = false;
             }
         }
         #endregion

         #region 初始值

         /// <summary>
         /// 生成默认套餐数据
         /// </summary>
         private void InitSets()
         {
             //创建1种默认套餐对象
             items = new Dictionary<string, HealthItem>();
             items.Add(height.Name, height);
             items.Add(weight.Name, weight);
             items.Add(liverFun.Name, liverFun);

             setA = new HealthSet("入学体检", items);
             //计算套餐价格
             setA.CalcPrice();
             this.HealthSet.Add("入学体检", setA);
         }
        #endregion

         #region 加载体检套餐
         /// <summary>
         /// 加载体检套餐
         /// </summary>
         public void InitHealthSetList()
         {
             this.comboBox1.Items.Clear();
             this.comboBox1.Items.Add("请选择");

             foreach (string key in this.HealthSet.Keys)
             {
                 this.comboBox1.Items.Add(key);
             }
             this.comboBox1.SelectedIndex = 0;
         } 
         #endregion

         #region 刷新数据源
         private void UpdateSet(HealthSet set)
         {
             //刷新数据源
             this.dataGridView1.DataSource = new BindingList<HealthItem>(set.Item.Values.ToList());
         } 
         #endregion

       

     
    }
}

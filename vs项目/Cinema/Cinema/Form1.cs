using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema;

namespace Cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public string key = "";
        public int setrows = 7;
        public int seatline = 5;
        Dictionary<string, Label> labels = new Dictionary<string, Label>();
        Cinemas cm = new Cinemas();
        private void Form1_Load(object sender, EventArgs e)
        {
            zuowei();
        }

        #region 动态生成
       
        public void zuowei()
        {
            for (int i = 0; i < setrows; i++)
            {
                for (int j = 0; j < seatline; j++)
                {
                    Label lab = new Label();
                    lab.BackColor = Color.Yellow;
                    lab.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    lab.AutoSize = false;
                    lab.Size = new System.Drawing.Size(50, 25);
                    lab.Text = (j + 1).ToString() + "-" + (i + 1).ToString();
                    lab.TextAlign = ContentAlignment.MiddleCenter;

                    lab.Location = new Point(40 + (i * 80), 50 + (j * 32));
                    lab.Click += new System.EventHandler(label_Click);
                    tabPage2.Controls.Add(lab);
                    labels.Add(lab.Text, lab);
                    Seat seat = new Seat((j + 1).ToString() + "-" + (i + 1).ToString(), Color.Yellow);
                    cm.seats.Add(seat.SeatNum, seat);
                }
            }
        } 
        #endregion


        #region 树状菜单获取
        public void intrv()
        {
            string namem = string.Empty;
            TreeNode node = null;
            foreach (ScheduleItem item in cm.Schedules.Dis.Values)
            {
                if (item.Movies.Name != namem)
                {
                    node = new TreeNode(item.Movies.Name);
                    treeView1.Nodes.Add(node);
                }
                TreeNode tn = new TreeNode(item.Time);
                node.Nodes.Add(tn);
                namem = item.Movies.Name;
            }
        } 
        #endregion

        private void 重新获取影片信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearSeat();
            cm.Schedules.ShowMxl();
            intrv(); ;
        }

        private void label_Click(object sender, EventArgs e)
        {
           
            try
            {
                string seatnum = ((Label)sender).Text.ToString();
                string customername = this.textBox1.Text.ToString();
                int discount = 0;
                string type = "";
                if (this.radioButton3.Checked)
                {
                  
                    type = "student";
                    if (this.comboBox1.Text == null)
                    {
                        MessageBox.Show("请输入折扣数", "提示");
                        return;
                    }
                    else
                    {
                        discount = int.Parse(this.comboBox1.Text);
                    }
                }
                else if (this.radioButton2.Checked)
                {
                    if (string.IsNullOrEmpty(this.textBox1.Text))
                    {
                        MessageBox.Show("请输入赠送者姓名", "提示");
                        return;
                    }
                    else
                    {
                        type = "free";
                    }
                }
                Ticket newtk = TicketUtil.CreateTicket(cm.Schedules.dis[key],cm.seats[seatnum],discount,customername,type);
               
                    if (cm.seats[seatnum].Color == Color.Yellow)
                {
                    //打印

                    DialogResult result = MessageBox.Show("是否购买?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        cm.seats[seatnum].Color = Color.Red;
                        UpdateSeat();
                       
                        cm.SoldTickets.Add(newtk);
                        label14.Text = newtk.CalcPrice();
                        newtk.Print();
                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    //显示当前售出票的信息
                    foreach (Ticket item in cm.SoldTickets)
                    {
                        //判断是否为同场次、同电影、同座位号
                        if (item.Seat.SeatNum == seatnum && item.ScheduleItem.Time == treeView1.SelectedNode.Text && item.ScheduleItem.Movies.Name == treeView1.SelectedNode.Parent.Text)
                        {
                            item.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            }
        /// <summary>
        /// 清空座位
        /// </summary>
        private void ClearSeat()
        {
            foreach (Seat seat in cm.seats.Values)
            {
                seat.Color = Color.Yellow;
            }
        }

        private void UpdateSeat()
        {
            //根据影院类里面的座位来更新座位的颜色
            foreach (string key in cm.seats.Keys)
            {
                labels[key].BackColor = cm.seats[key].Color;
            }
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            #region 动态加载影片信息
            Movie movie = new Movie();
            if (treeView1.SelectedNode.Level != 0)
            {
                string time = this.treeView1.SelectedNode.Text;
                ScheduleItem item = cm.Schedules.Dis[time];
                //演员
                label6.Text = item.Movies.Actor;
                //导演
                label4.Text = item.Movies.Director;
                label12.Text = item.Movies.Price.ToString();
                this.label8.Text = item.Movies.Type.ToString();
                //片名
                label2.Text = treeView1.SelectedNode.Parent.Text;
                //时间
                key = treeView1.SelectedNode.Text;
                label10.Text = treeView1.SelectedNode.Text;
                //图片
                pictureBox1.Image = Image.FromFile(label2.Text + ".jpg");
                groupBox1.Visible = true;
                label14.Visible = false;
            }
            #endregion
            ClearSeat();
            foreach (Ticket ticket in cm.SoldTickets)
            {
                foreach (Seat seat in cm.seats.Values)
                {
                    if ((ticket.ScheduleItem.Time ==key) && (ticket.Seat.SeatNum == seat.SeatNum))
                    {
                        seat.Color = Color.Red;
                    }
                }
                
            }
            UpdateSeat();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.Text = "";
            this.comboBox1.Enabled = false;
            this.textBox1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.Enabled = false;
            this.comboBox1.Text ="";
            this.textBox1.Enabled = true;
            label14.Text = "0";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.Enabled = true;
            this.comboBox1.Text = "7";
            this.textBox1.Enabled = false;
            this.textBox1.Text = "";
            if (this.label12.Text!="")
            {
                int price = int.Parse(this.label12.Text);
                int discount = int.Parse(this.comboBox1.Text);
                this.label14.Text = (price*discount/10).ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //根据当前选中的电影，设置“优惠价”
            if (label13.Text != "")
            {
                int price = Convert.ToInt32(label5.Text);
                int discount = Convert.ToInt32(comboBox1.Text);
                label14.Text = (price * discount / 10).ToString();
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否保存当前销售状态?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                //退出时保存Cinema对象
                cm.Say();
            }
        }

        private void 继续销售影票ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断放映列表是否为空
            if (cm.Schedules.dis.Count == 0)
            {
                cm.Schedules.ShowMxl();
            }
            intrv();
            cm.Load();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cm.Say();
            this.Close();
        }
    }
}

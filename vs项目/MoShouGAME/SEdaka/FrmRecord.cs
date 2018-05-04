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
    public partial class FrmRecord : Form
    {
        public FrmRecord()
        {
            InitializeComponent();
        }
         public  FrmMain fm{get;set;}//主窗体对象
        public Dictionary<string, Record> RecordList; 
        private void FrmRecord_Load(object sender, EventArgs e)
        {

            this.dataGridView1.AutoGenerateColumns = false;//去掉多余的列  
            //打卡记录
            //绑定数据源，显示Dictionary
            BindingSource bs = new BindingSource();
            bs.DataSource =RecordList.Values;
            this.dataGridView1.DataSource = bs;
            Rows();//打印行数
                    
      

        }
        /// <summary>
        /// 打印显示行数
        /// </summary>
        public void Rows()
        {
            int row = this.dataGridView1.RowCount;//拿到行数
            this.label1.Text = "共有" + row + "条打卡记录";
        }
    }
}

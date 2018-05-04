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
    public partial class AddMessage : Form
    {
        public AddMessage()
        {
            InitializeComponent();
        }
          public  FrmMain fm{get;set;}
        private void button1_Click(object sender, EventArgs e)
        {
        
           // List<Comboxitems> list2=new List<Comboxitems>();
            try
            {
                Comboxitems cmb = new Comboxitems();
                cmb.Id = textBox1.Text.Trim();
                cmb.Name = textBox3.Text.Trim();
                cmb.Age = textBox2.Text.Trim();
                cmb.Gender = comboBox1.Text.Trim();
                
                foreach (Comboxitems item in fm.list)
                {
                    if (item.Id == cmb.Id)
                    {
                        MessageBox.Show("此工号已经存在！");
                        return;
                    }
                }
                fm.list.Add(cmb);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally 
            {
               
                fm.BindGrid(fm.list);
            }
           
        }
    }
}

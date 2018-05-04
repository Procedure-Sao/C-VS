using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            string sum = textBox2.Text;
            string panduan = comboBox1.Text;
            Number cal = SimpleFactory.sf(panduan);
            cal.Num =Convert.ToDouble(num);
            cal.Sum = Convert.ToDouble(sum);
            try
            {
                textBox3.Text = cal.cal().ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myschool
{
    public partial class huanyingcs : Form
    {
        public huanyingcs()
        {
            InitializeComponent();
        }
        public string name;
       

        private void huanyingcs_Load(object sender, EventArgs e)
        {
            label1.Text += name;
        }
    }
}

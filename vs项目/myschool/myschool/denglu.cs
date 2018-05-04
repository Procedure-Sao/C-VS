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
    public partial class denglu : Form
    {
        public denglu()
        {
            InitializeComponent();
        }

        private void denglu_Click(object sender, EventArgs e)
        {
            if (this.BackColor==Color.Red)
            {
                this.BackColor=Color.Yellow;

            }
            else if (this.BackColor == Color.Yellow)
            {
                this.BackColor = Color.Blue;
            }
            else if (this.BackColor == Color.Blue)
            {
                this.BackColor = Color.Green;
            }
            else {
                this.BackColor =Color.Red;
            }
        }

        private void denglu_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            

        }


        public string name;


    }
}

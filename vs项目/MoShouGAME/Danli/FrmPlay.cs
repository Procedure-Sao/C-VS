using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Danli
{
    public partial class FrmPlay : Form
    {
        private FrmPlay()
        {
            InitializeComponent();
        }
        private static FrmPlay fp;
        public string url;

        public void play() 
        {
            Player1.URL = url;
        }

        public static FrmPlay dui()
        {
            if (fp==null)
            {
                fp = new FrmPlay();
            }
            return fp;
        }

        private void FrmPlay_Load(object sender, EventArgs e)
        {
            fp = null;
        }
    }


}

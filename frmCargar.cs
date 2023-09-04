using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryValdezIE
{
    public partial class frmCargar : Form
    {
        public frmCargar()
        {
            InitializeComponent();
            circularProgressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 1;

            if (circularProgressBar1.Value == 100)
            {
                timer1.Enabled = false;

                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }
    }
}

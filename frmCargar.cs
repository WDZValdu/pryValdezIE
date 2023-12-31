﻿using System;
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
        private string varUsuario;
        private string varCategoria;
        public frmCargar(string usuario, string varCat)
        {
            InitializeComponent();
            circularProgressBar1.Value = 0;
            varUsuario = usuario;
            varCategoria = varCat;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 4;

            if (circularProgressBar1.Value == 100)
            {
                timer1.Enabled = false;

                this.Hide();
                frmPrincipal form1 = new frmPrincipal(varUsuario, varCategoria);
                form1.Show();
            }
        }
    }
}

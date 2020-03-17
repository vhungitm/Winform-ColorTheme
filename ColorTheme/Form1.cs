using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorTheme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void theme1_Click(object sender, EventArgs e)
        {
            bunifuColorTransition1.ProgessValue = 0;
            bunifuColorTransition1.Color1 = header.BackColor;
            bunifuColorTransition1.Color2 = ((Panel)sender).BackColor;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bunifuColorTransition1.ProgessValue < 100)
            {
                loader.Visible = true; 

                bunifuColorTransition1.ProgessValue++;
                header.BackColor = bunifuColorTransition1.Value;
                pp.ProgressColor = header.BackColor;
                pp.ForeColor = header.BackColor;
                pp.Value = bunifuColorTransition1.ProgessValue;
            }
            else {
                loader.Visible = false;

            }
        }
    }
}

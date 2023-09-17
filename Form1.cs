using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_LR_VODA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbbut5.Visible = false;

            b05.FlatStyle = FlatStyle.Flat;
            b1.FlatStyle = FlatStyle.Flat;
            b15.FlatStyle = FlatStyle.Flat;
            b5.FlatStyle = FlatStyle.Flat;
            b19.FlatStyle = FlatStyle.Flat;
            bstaroy.FlatStyle = FlatStyle.Flat;
            bbeztary.FlatStyle = FlatStyle.Flat;

            b05.FlatAppearance.BorderSize = 1;
            b1.FlatAppearance.BorderSize = 1;
            b15.FlatAppearance.BorderSize = 1;
            b5.FlatAppearance.BorderSize = 1;
            b19.FlatAppearance.BorderSize = 1;
            bstaroy.FlatAppearance.BorderSize = 1;
            bbeztary.FlatAppearance.BorderSize = 1;

            b05.FlatAppearance.BorderColor = Color.IndianRed;
            b1.FlatAppearance.BorderColor = Color.IndianRed;
            b5.FlatAppearance.BorderColor = Color.IndianRed;
            b15.FlatAppearance.BorderColor = Color.IndianRed;
            b19.FlatAppearance.BorderColor = Color.IndianRed;
            bstaroy.FlatAppearance.BorderColor = Color.IndianRed;
            bbeztary.FlatAppearance.BorderColor = Color.IndianRed;

            groupBoxLitrazh.Visible = false;
            groupBoxTara.Visible = false;
        }

        private void pb1tab_Click(object sender, EventArgs e)
        {
            pb1tab.Visible = false;
            groupBoxLitrazh.Visible = true;
        }

        private void b05_Click(object sender, EventArgs e)
        {
            groupBoxTara.Visible = true;
        }

        private void b15_Click(object sender, EventArgs e)
        {
            groupBoxTara.Visible = true;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            groupBoxTara.Visible = true;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            groupBoxTara.Visible = true;
        }

        private void b19_Click(object sender, EventArgs e)
        {
            groupBoxTara.Visible = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            groupBoxTara.Visible = false;
            groupBoxLitrazh.Visible = false;
            pb1tab.Visible = true;
        }
    }
}

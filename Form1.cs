using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_LR_VODA
{
    public partial class Form1 : Form
    {
        int credit;
        double litr;
        public Form1()
        {
            InitializeComponent();
            credit = 0;
            litr = 0;
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
            groupBoxCard.Visible = false;
            labelFakeCredit.Visible = false;
            labelCredit.Visible = false;
        }

        private void pb1tab_Click(object sender, EventArgs e)
        {
            pb1tab.Visible = false;
            groupBoxLitrazh.Visible = true;
        }

        private void b05_Click(object sender, EventArgs e)
        {
            groupBoxTara.Visible = true;
            litr = 0.5;
        }

        private void b15_Click(object sender, EventArgs e)
        {
            groupBoxTara.Visible = true;
            litr = 1.5;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            groupBoxTara.Visible = true;
            litr = 5;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            groupBoxTara.Visible = true;
            litr = 1;
        }

        private void b19_Click(object sender, EventArgs e)
        {
            groupBoxTara.Visible = true;
            litr = 19;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            groupBoxTara.Visible = false;
            groupBoxLitrazh.Visible = false;
            groupBoxCard.Visible = false;
            labelCredit.Visible = false;
            pb1tab.Visible = true;
        }

        private void bstaroy_Click(object sender, EventArgs e)
        {
            groupBoxCard.Visible = true;
            switch (litr)
            {
                case 1:
                    credit = 50; break;
                case 0.5:
                    credit = 35; break;                
                case 1.5:
                    credit = 65; break;
                case 5:
                    credit = 110; break;
                case 19:
                    credit = 250; break;
                default:
                    labelFakeCredit.Visible = true;
                    Thread.Sleep(4000);
                    exit_Click(sender, e);
                    labelFakeCredit.Visible = false;
                    break;
            }
            labelCredit.Visible = true;
            labelCredit.Text = $"Credit = {Convert.ToString(credit)}";
        }

        private void bbeztary_Click(object sender, EventArgs e)
        {
            groupBoxCard.Visible = true;
            switch (litr)
            {
                case 1:
                    credit = 35; break;
                case 0.5:
                    credit = 20; break;
                case 1.5:
                    credit = 45; break;
                case 5:
                    credit = 66; break;
                case 19:
                    credit = 95; break;
                default:
                    labelFakeCredit.Visible = true;
                    Thread.Sleep(4000);
                    exit_Click(sender, e);
                    labelFakeCredit.Visible = false;
                    break;
            }
            labelCredit.Visible = true;
            labelCredit.Text = $"Credit = {Convert.ToString(credit)}";
        }
    }
}

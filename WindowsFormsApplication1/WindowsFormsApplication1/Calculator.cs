using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calculator : UserControl
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            var parent1 = this.Parent as Form1;
            var regpan = parent1.register1;
            var userpan = parent1.userControl11;
            var homepan = parent1.home1;
            var withpan = parent1.withheldCalc1;
            var planpan = parent1.planner1;

            planpan.Show();
            this.Hide();
            TaxPan.Hide();
            conpan.Hide();
        }

        private void usercon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (conpan.Visible)
            {
                conpan.Hide();
            }
            else
            {
                conpan.Show();
            }
        }

        private void Vbtn_Click(object sender, EventArgs e)
        {
            if (TaxPan.Visible)
            {
                TaxPan.Hide();
            }
            else
            {
                TaxPan.Show();
            }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent1 = this.Parent as Form1;



            var regpan = parent1.register1;
            var userpan = parent1.userControl11;
            var homepan = parent1.home1;
            regpan.Hide();
            userpan.Show();
            this.Hide();
            TaxPan.Hide();
            conpan.Hide();
        }

        private void Withlib_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent1 = this.Parent as Form1;



            var regpan = parent1.register1;
            var userpan = parent1.userControl11;
            var homepan = parent1.home1;
            var withpan = parent1.withheldCalc1;
            withpan.Show();
            this.Hide();
            TaxPan.Hide();
            conpan.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var parent1 = this.Parent as Form1;
            var regpan = parent1.register1;
            var userpan = parent1.userControl11;
            var homepan = parent1.home1;
            var withpan = parent1.withheldCalc1;
            var planpan = parent1.planner1;

            homepan.Show();
            this.Hide();
            TaxPan.Hide();
            conpan.Hide();
        }
    }
}

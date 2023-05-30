using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Planner : UserControl
    {
        public Planner()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var parent1 = this.Parent as Form1;
            var regpan = parent1.register1;
            var userpan = parent1.userControl11;
            var homepan = parent1.home1;
            var withpan = parent1.withheldCalc1;
            var planpan = parent1.planner1;

            withpan.Show();
            this.Hide();

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

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent1 = this.Parent as Form1;



            var regpan = parent1.register1;
            var userpan = parent1.userControl11;
            var homepan = parent1.home1;
            regpan.Hide();
            userpan.Show();
            this.Hide();
            conpan.Hide();
        }

        private void IncTax_Click(object sender, EventArgs e)
        {

        }
        public void cck(string calinctax) {
            IncTax.Text = calinctax;
        }
        public void cck2(string calinctax)
        {
            usercon.Text = "Welcome, " + calinctax;
        }
        public void setDataToMonth(string calIn, string month)
        {
            if (month.Equals("January"))
            {
                JanTax.Text = calIn;
            }
            else if (month.Equals("Febuary"))
            {
                FebTax.Text = calIn;
            }
            else if (month.Equals("March"))
            {
                MarTax.Text = calIn;
            }
            else if (month.Equals("April"))
            {
                AprTax.Text = calIn;
            }
            else if (month.Equals("May"))
            {
                MayTax.Text = calIn;
            }
            else if (month.Equals("June"))
            {
                JunTax.Text = calIn;
            }
            else if (month.Equals("July"))
            {
                JulTax.Text = calIn;
            }
            else if (month.Equals("August"))
            {
                AugTax.Text = calIn;
            }
            else if (month.Equals("September"))
            {
                SepTax.Text = calIn;
            }
            else if (month.Equals("October"))
            {
                OctTax.Text = calIn;
            }
            else if (month.Equals("November"))
            {
                NovTax.Text = calIn;
            }
            else if (month.Equals("December"))
            {
                DecTax.Text = calIn;
            }
            else { 
            
            }
        }
    } 
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            
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
        public void cck(string calinctax)
        {
            usercon.Text = "Welcome, "+calinctax;
        }
        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent1 = this.Parent as Form1;



            var regpan = parent1.register1;
            var userpan = parent1.userControl11;
            var homepan = parent1.home1;
            regpan.Hide();
            userpan.Show();
            homepan.Hide();
            conpan.Hide();
        }

        private void TaxCalBtn_Click(object sender, EventArgs e)
        {
            var parent1 = this.Parent as Form1;



            var regpan = parent1.register1;
            var userpan = parent1.userControl11;
            var homepan = parent1.home1;
            var inctax = parent1.calculator1;
            inctax.Show();
            homepan.Hide();

        }

        private void planBtn_Click(object sender, EventArgs e)
        {
            var parent1 = this.Parent as Form1;



            var regpan = parent1.register1;
            var userpan = parent1.userControl11;
            var homepan = parent1.home1;
            var inctax = parent1.calculator1;
            var planpan = parent1.planner1;
            planpan.Show();
            this.Hide();
        }
       

    }
}

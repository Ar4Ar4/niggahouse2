using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        public void cck(string calinctax)
        {
            usercon.Text = "Welcome, " + calinctax;
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

        private void subtn_Click(object sender, EventArgs e)
        {
            var parent1 = this.Parent as Form1;
            
            double meep = Convert.ToDouble(inctxtbox.Text);
            double oggy = TaxTab(meep);
            //-------------
            double br1 = socialservices(oggy);
            double br2 = economic(oggy);
            double br3 = debt(oggy);
            double br4 = defense(oggy);
            double br5 = genpub(oggy);
            double br6 = others(oggy);    
            //--------------

            TaxLab.Text = oggy.ToString("C", new CultureInfo("en-PH"));
            solLab.Text = ttSol(meep);
            TaxPer.Text = perdisp(meep);
            //-------------
            SocSerLab.Text = br1.ToString("C", new CultureInfo("en-PH"));
            EcoSerLab.Text = br2.ToString("C", new CultureInfo("en-PH"));
            DebSerLab.Text = br3.ToString("C", new CultureInfo("en-PH"));
            DefLab.Text = br4.ToString("C", new CultureInfo("en-PH"));
            GenLab.Text = br5.ToString("C", new CultureInfo("en-PH"));
            OLab.Text = br6.ToString("C", new CultureInfo("en-PH"));
            //--------------
            parent1.wensis(TaxLab.Text);

        }
        public static double TaxTab(double inc)
        {

            if (inc <= 250000)
            {
                return 0;
            }
            else if (inc <= 400000)
            {
                return (inc - 250000) * 0.20;//display 20% of the excess over P250,000
            }
            else if (inc <= 800000)
            {
                return 30000 + (inc - 400000) * 0.25;//display P30,000 + 25% of the excess over P400,000
            }
            else if (inc <= 2000000)
            {
                return 130000 + (inc - 800000) * 0.30;//display P130,000 + 30% of the excess over P800,000
            }
            else if (inc <= 8000000)
            {
                return 490000 + (inc - 2000000) * 0.32;//display P490,000 + 32% of the excess over P2,000,000
            }
            else
            {
                return 2410000 + (inc - 8000000) * 0.35;//display P2,410,000 + 35% of the excess over P8,000,000
            }

        }
        public static string ttSol(double inc)
        {

            if (inc <= 250000)
            {
                return "---";
            }
            else if (inc <= 400000)
            {
                return "20% of the excess over P250,000";
            }
            else if (inc <= 800000)
            {
                return "P30,000 + 25% of the excess over P400,000";
            }
            else if (inc <= 2000000)
            {
                return "P130,000 + 30% of the excess over P800,000";
            }
            else if (inc <= 8000000)
            {
                return "P490,000 + 32% of the excess over P2,000,000";
            }
            else
            {
                return "P2,410,000 + 35% of the excess over P8,000,000";
            }

        }
       
        public static string perdisp(double inc)
        {

            if (inc <= 250000)
            {
                return "---";
            }
            else if (inc <= 400000)
            {
                return "20%";
            }
            else if (inc <= 800000)
            {
                return "25%";
            }
            else if (inc <= 2000000)
            {
                return "30%";
            }
            else if (inc <= 8000000)
            {
                return "32%";
            }
            else
            {
                return "35%";
            }

        }
        public static double socialservices(double weem) {

            return weem * 0.36;

        }
        public static double economic(double weem)
        {

            return weem * 0.27;

        }
        public static double debt(double weem)
        {

            return weem * 0.21;

        }
        public static double defense(double weem)
        {

            return weem * 0.07;

        }
        public static double genpub(double weem)
        {

            return weem * 0.06;

        }
        public static double others(double weem)
        {

            return weem * 0.03;

        }
    }
}

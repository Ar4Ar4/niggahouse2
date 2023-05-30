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
    public partial class withheldCalc : UserControl
    {
        public withheldCalc()
        {
            InitializeComponent();
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

        private void IncLib_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var parent1 = this.Parent as Form1;



            var regpan = parent1.register1;
            var userpan = parent1.userControl11;
            var homepan = parent1.home1;
            var withpan = parent1.withheldCalc1;
            var incpan = parent1.calculator1;
            incpan.Show();
            this.Hide();
            TaxPan.Hide();
            conpan.Hide();
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
        public void cck(string calinctax)
        {
            usercon.Text = "Welcome, " + calinctax;
        }
        private void subtn_Click(object sender, EventArgs e)
        {
            var parent1 = this.Parent as Form1;
            double meep = Convert.ToDouble(withbox.Text);
            double oggy = mowonthly(meep);
            double oggy2 = semowo(meep);

            wTaxLab.Text = oggy.ToString("C", new CultureInfo("en-PH"));
            if (semiCheck.Checked==true)
            {
                double br1 = socialservices(oggy2);
                double br2 = economic(oggy2);
                double br3 = debt(oggy2);
                double br4 = defense(oggy2);
                double br5 = genpub(oggy2);
                double br6 = others(oggy2);
                //--------------------------------
                SocSerLab.Text = br1.ToString("C", new CultureInfo("en-PH"));
                EcoSerLab.Text = br2.ToString("C", new CultureInfo("en-PH"));
                DebSerLab.Text = br3.ToString("C", new CultureInfo("en-PH"));
                DefLab.Text = br4.ToString("C", new CultureInfo("en-PH"));
                GenLab.Text = br5.ToString("C", new CultureInfo("en-PH"));
                OLab.Text = br6.ToString("C", new CultureInfo("en-PH"));
                //---------------------------------------------------------
                wTaxLab.Text = oggy2.ToString("C", new CultureInfo("en-PH"));
                solLab.Text = semoo(meep);
                wTaxPer.Text= semoo2(meep);
                parent1.wensis2(wTaxLab.Text, monthBox.Text);
            }
            else
            {
                double br1 = socialservices(oggy);
                double br2 = economic(oggy);
                double br3 = debt(oggy);
                double br4 = defense(oggy);
                double br5 = genpub(oggy);
                double br6 = others(oggy);
                //--------------------------------
                SocSerLab.Text = br1.ToString("C", new CultureInfo("en-PH"));
                EcoSerLab.Text = br2.ToString("C", new CultureInfo("en-PH"));
                DebSerLab.Text = br3.ToString("C", new CultureInfo("en-PH"));
                DefLab.Text = br4.ToString("C", new CultureInfo("en-PH"));
                GenLab.Text = br5.ToString("C", new CultureInfo("en-PH"));
                OLab.Text = br6.ToString("C", new CultureInfo("en-PH"));
                //---------------------------------------------------------
                wTaxLab.Text = oggy.ToString("C", new CultureInfo("en-PH"));
                solLab.Text = mowon(meep);
                wTaxPer.Text = mowon2(meep);
                parent1.wensis2(wTaxLab.Text, monthBox.Text);
            }
        }
        public static double mowonthly(double moninc)
        {
            double withholdingTax = 0;

            if (moninc <= 20833)
            {
                withholdingTax = 0;
            }
            else if (moninc <= 33332)
            {
                withholdingTax = (moninc - 20833) * 0.15;//display 0.00 +15% over ₱20,833
            }
            else if (moninc <= 66666)
            {
                withholdingTax = 1875 + (moninc - 33333) * 0.20;//display ₱1,875.00 +20% over ₱33,333
            }
            else if (moninc <= 166666)
            {
                withholdingTax = 8541.80 + (moninc - 66667) * 0.25;// display ₱8,541.80 +25% over ₱66,667
            }
            else if (moninc <= 666666)
            {
                withholdingTax = 33541.80 + (moninc - 166667) * 0.30;// display ₱33,541.80 +30% over ₱166,667
            }
            else
            {
                withholdingTax = 183541.80 + (moninc - 666667) * 0.35;// display ₱183,541.80 +35% over ₱666,667
            }
            return withholdingTax;

        }
        public static double semowo(double moninc)
        {
            double withholdingTax = 0;

            if (moninc <= 10416.50)
            {
                withholdingTax = 0;
            }
            else if (moninc <= 16666)
            {
                withholdingTax = (moninc - 10417) * 0.15;//display 0.00 +15% over ₱10,417
            }
            else if (moninc <= 33333)
            {
                withholdingTax = 937.50 + (moninc - 16667) * 0.20;// display ₱937.50 +20% over ₱16,667
            }
            else if (moninc <= 83333)
            {
                withholdingTax = 4270.70 + (moninc - 33333) * 0.25;//display ₱4,270.70 +25% over ₱33,333
            }
            else if (moninc <= 333333)
            {
                withholdingTax = 16770.70 + (moninc - 83333) * 0.30;// display ₱16,770.70 +30% over ₱83,333
            }
            else
            {
                withholdingTax = 91770.70 + (moninc - 333333) * 0.35;//display ₱91,770.70 +35% over ₱333,333
            }

            return withholdingTax;

        }
        //----------------------------------------------------------------------------
        public static string mowon(double moninc)
        {
            string withholdingTax;

            if (moninc <= 20833)
            {
                withholdingTax = "---";
            }
            else if (moninc <= 33332)
            {
                withholdingTax = "0.00 +15% over ₱20,833";
            }
            else if (moninc <= 66666)
            {
                withholdingTax = "₱1,875.00 +20% over ₱33,333";
            }
            else if (moninc <= 166666)
            {
                withholdingTax = "₱8,541.80 +25% over ₱66,667";
            }
            else if (moninc <= 666666)
            {
                withholdingTax = "₱33,541.80 +30% over ₱166,667";
            }
            else
            {
                withholdingTax = "₱183,541.80 +35% over ₱666,667";
            }
            return withholdingTax;

        }
        public static string mowon2(double moninc)
        {
           

            if (moninc <= 20833)
            {
                return "---";
            }
            else if (moninc <= 33332)
            {
                return "15%";
            }
            else if (moninc <= 66666)
            {
                return "20%";
            }
            else if (moninc <= 166666)
            {
                return "25%";
            }
            else if (moninc <= 666666)
            {
                return "30%";
            }
            else
            {
                return "35%";
            }
           

        }
        //-----------------------------------------------------------------------
        public static string semoo(double moninc)
        {
            string withholdingTax;

            if (moninc <= 10416.50)
            {
                withholdingTax = "---";
            }
            else if (moninc <= 16666)
            {
                withholdingTax = "0.00 +15% over ₱10,417";
            }
            else if (moninc <= 33333)
            {
                withholdingTax = "₱937.50 +20% over ₱16,667";
            }
            else if (moninc <= 83333)
            {
                withholdingTax = "₱4,270.70 +25% over ₱33,333";
            }
            else if (moninc <= 333333)
            {
                withholdingTax = "₱16,770.70 +30% over ₱83,333";
            }
            else
            {
                withholdingTax = "₱91,770.70 +35% over ₱333,333";
            }

            return withholdingTax;

        }
        public static string semoo2(double moninc)
        {
           

            if (moninc <= 10416.50)
            {
                return "---";
            }
            else if (moninc <= 16666)
            {
                return "15%";
            }
            else if (moninc <= 33333)
            {
                return "20%";
            }
            else if (moninc <= 83333)
            {
                return "25%";
            }
            else if (moninc <= 333333)
            {
                return "30%";
            }
            else
            {
                return "35%";
            }

        }
        //------------------------------------
        public static double socialservices(double weem)
        {

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

        private void semiCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void wTaxPer_Click(object sender, EventArgs e)
        {

        }
    }
}

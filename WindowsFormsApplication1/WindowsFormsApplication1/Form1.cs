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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
           
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }
        public void wensis(string calinctax) { 
            Planner planner = this.planner1;
            planner.cck(calinctax);
        }
        public void wensis2(string calinctax2, string month)
        {
            Planner planner = this.planner1;
            planner.setDataToMonth(calinctax2, month);
        }

        public void wensis3(string calinctax3)
        {
            Home hom = this.home1;
            Calculator cal = this.calculator1;
            withheldCalc wcal = this.withheldCalc1;    
            Planner planner = this.planner1;    
            hom.cck(calinctax3);
            cal.cck(calinctax3);
            wcal.cck(calinctax3);
            planner.cck2(calinctax3);
        }

    }
}

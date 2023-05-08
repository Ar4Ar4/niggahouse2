using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var parent2 = this.Parent as Form1;



            var regpan = parent2.register1;
            var userpan = parent2.userControl11;
            regpan.Hide();
            userpan.Show();
        }
    }
}

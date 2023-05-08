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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


           var parent1 = this.Parent as Form1;

            

           var regpan = parent1.register1;
           var userpan = parent1.userControl11;
           regpan.Show();
           userpan.Hide();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LogSubBtn_Click(object sender, EventArgs e)
        {
            var parent1 = this.Parent as Form1;



            var regpan = parent1.register1;
            var userpan = parent1.userControl11;
            var homepan = parent1.home1;
            regpan.Hide();
            userpan.Hide();
            homepan.Show();
        }
    }
}

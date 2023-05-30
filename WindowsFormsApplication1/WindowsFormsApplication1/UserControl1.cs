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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApplication1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


           var parent1 = this.Parent as Form1;

            

           var regpan = parent1.register1;
           var userpan = parent1.userControl11;
            usernbox.Text = "";
            passwbox.Text = "";
            regpan.Show();
           userpan.Hide();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       

        private void LogSubBtn_Click(object sender, EventArgs e)
        {
            var parent1 = this.Parent as Form1;
           // var parent2 = this.Parent as Home;

            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + usernbox.Text + "' and password='" + passwbox.Text + "'";
            cmd = new OleDbCommand(login, con);
   

            OleDbDataReader dr = cmd.ExecuteReader();
            


            if (dr.Read() == true)
            {
       
                usernbox.Text = "";
                passwbox.Text = "";
                shopach.Checked = false;
                string username = dr["username"].ToString();
                //MessageBox.Show(username, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                parent1.wensis3(username);
                var regpan = parent1.register1;
                var userpan = parent1.userControl11;
                var homepan = parent1.home1;
               // string username = 
               

                regpan.Hide();
                userpan.Hide();
                homepan.Show();
                con.Close();    
            }
            else {
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernbox.Text = "";
                passwbox.Text = ""; 
                usernbox.Focus();
                con.Close();

            }


          /*  var regpan = parent1.register1;
            var userpan = parent1.userControl11;
            var homepan = parent1.home1;
            regpan.Hide();
            userpan.Hide();
            homepan.Show();*/
        }

        private void shopach_CheckedChanged(object sender, EventArgs e)
        {
            if (shopach.Checked)
            {
                passwbox.PasswordChar = '\0';
            }
            else
            {
                passwbox.PasswordChar = '*';
            }
        }
    }
}

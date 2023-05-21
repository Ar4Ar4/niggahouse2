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
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var parent2 = this.Parent as Form1;
            if (namebox.Text == "" && tinbox.Text == "" && passbox.Text == "" && userbox.Text == "" && emailbox.Text == "")
            {
                MessageBox.Show("all fields are empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (passbox.Text == reppass.Text) {
                con.Open();
                string reg = "INSERT INTO tbl_users VALUES ('" + userbox.Text + "','" + passbox.Text + "')";
                cmd = new OleDbCommand(reg, con);
                cmd.ExecuteNonQuery();  
                con.Close();

                MessageBox.Show("Your account has been created","Registration Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                userbox.Text = "";
                passbox.Text = "";
                reppass.Text = "";
                namebox.Text = "";
                emailbox.Text = "";
                tinbox.Text = "";
                var regpan = parent2.register1;
                var userpan = parent2.userControl11;
                regpan.Hide();
                userpan.Show();

            }
            else
            {
                MessageBox.Show("Password does not match","Registration Failed", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                passbox.Text = "";
                reppass.Text = "";
                passbox.Focus();    
            }


            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void emailbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tinbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void shopach_CheckedChanged(object sender, EventArgs e)
        {
            if (shopach.Checked) {
                passbox.PasswordChar = '\0';
                reppass.PasswordChar = '\0';
            }
            else {
                passbox.PasswordChar = '*';
                reppass.PasswordChar = '*';
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            userbox.Text = "";
            passbox.Text = "";
            reppass.Text = "";
            namebox.Text = "";
            emailbox.Text = "";
            tinbox.Text = "";
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            var parent2 = this.Parent as Form1;
            var regpan = parent2.register1;
            var userpan = parent2.userControl11;
            regpan.Hide();
            userpan.Show();


        }
    }
}

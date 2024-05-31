using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevOps
{
    public partial class Screen_Register : Form
    {
        //Database connection
        SqlConnection connecion = new SqlConnection("server=192.168.1.184; database=MYDataBase; integrated security=true");


        public Screen_Register()
        {
            InitializeComponent();
        }

        private void chshowpasswordR_CheckedChanged(object sender, EventArgs e)
        {
            if (chshowpasswordR.Checked)
            {
                txtpasswordR.PasswordChar = '\0';
            }
            else
            {
                txtpasswordR.PasswordChar = '•';
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try 
            {
                connecion.Open();
                

                string script = ("insert into Register(firstname,lastname,email,password) values('" + txtfirstname.Text + "','" + txtlastname.Text + "','" + txtemail.Text + "','" + txtpasswordR.Text + "')");
                SqlCommand send = new SqlCommand(script, connecion);
                send.ExecuteNonQuery();

                MessageBox.Show("User registered sucessful");
                txtfirstname.Clear();
                txtlastname.Clear();
                txtemail.Clear();
                txtpasswordR.Clear();

                connecion.Close(); 
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Has ocurred an error");
            }
        }
    }
}

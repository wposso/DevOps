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
    public partial class Screen_Reload : Form
    {
        //Database connection
        SqlConnection connecion = new SqlConnection("server=ADMINSYSTEM; database=MYDataBase; integrated security=true");


        public Screen_Reload()
        {
            InitializeComponent();
        }

        private void chpasswordreload_CheckedChanged(object sender, EventArgs e)
        {
            if (chpasswordreload.Checked)
            {
                txtpasswordreload.PasswordChar = '\0';
            }
            else
            {
                txtpasswordreload.PasswordChar = '•';
            }
        }

        private void btnloginreload_Click(object sender, EventArgs e)
        {
            try
            {
                connecion.Open();

                SqlCommand script = new SqlCommand("select email,password from Register where email='" + txtemailreload.Text + "' and password='" + txtpasswordreload.Text + "'", connecion);
                SqlDataReader reader = script.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Welcome to yor system");
                    txtemailreload.Clear();
                    txtpasswordreload.Clear();


                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                    txtemailreload.Clear();
                    txtpasswordreload.Clear();
                }
                connecion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Has error ocurred");
                txtemailreload.Clear();
                txtpasswordreload.Clear();
            }
        }

        private void pnlreload_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

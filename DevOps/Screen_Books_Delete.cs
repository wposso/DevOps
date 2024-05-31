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
    public partial class Screen_Books_Delete : Form
    {
        //Database connection
        SqlConnection connection = new SqlConnection("server=192.168.1.184; database=MYDataBase; integrated security=true");


        public Screen_Books_Delete()
        {
            InitializeComponent();

            //Control lblError .visible
            txtBDid.Click += new EventHandler(lblError_txtID);
            txtBDid.Click += new EventHandler(lblSaved_txtID);
        }

        private void btnBDback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBDsave_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string script = ("delete Books where ID = " + txtBDid.Text + "");
                SqlCommand send = new SqlCommand(script, connection);
                send.ExecuteNonQuery();
                connection.Close();
                lblDbooksaved.Visible = true;
                txtBDid.Clear();

            }
            catch (Exception ex)
            {
                lblUicon.Visible = true;
                lblDbookerror.Visible = true;
            }

        }

        //Control lblSaved .visible
        private void lblError_txtID(object sender, EventArgs e)
        {
            if (lblUicon.Visible && lblDbookerror.Visible == true)
            {
                lblUicon.Visible = false;
                lblDbookerror.Visible = false;
            }
        }
        private void lblSaved_txtID(object sender, EventArgs e)
        {
            if (lblDbooksaved.Visible == true)
            {
                lblDbooksaved.Visible = false;

            }
        }

        private void Screen_Books_Delete_Load(object sender, EventArgs e)
        {
            txtBDid.Clear();
        }
    }
}

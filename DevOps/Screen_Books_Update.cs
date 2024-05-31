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
    public partial class Screen_Books_Update : Form
    {

        //Database connection
        SqlConnection connection = new SqlConnection("server=192.168.1.184; database=MYDataBase; integrated security=true");


        public Screen_Books_Update()
        {
            InitializeComponent();

            //Control lblSaved .visible
            txtBUid.Click += new EventHandler(lblsaved_txtID);
            txtBUtittle.Click += new EventHandler(lblsaved_txtID);
            txtBUauthor.Click += new EventHandler(lblsaved_txtID);

            //Control lblError .visible
            txtBUid.Click += new EventHandler(lblError_txtID);
            txtBUtittle.Click += new EventHandler(lblError_txtTittle);
            txtBUauthor.Click += new EventHandler(lblError_txtAuthor);
        }

        private void btnBUback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Screen_Books_Update_Load(object sender, EventArgs e)
        {

        }

        private void btnBUsave_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string script = ("update Books set tittle = '" + txtBUtittle.Text + "', author = '" + txtBUauthor.Text + "' where id = " + txtBUid.Text + "");
                SqlCommand send = new SqlCommand(script, connection);
                send.ExecuteNonQuery();
                connection.Close();

                lblUbooksaved.Visible = true;
                txtBUid.Clear();
                txtBUtittle.Clear();
                txtBUauthor.Clear();
            }
            catch 
            {
                lblUicon.Visible = true;
                lblUbookerror.Visible = true;
                txtBUid.Clear();
                txtBUtittle.Clear();
                txtBUauthor.Clear();
            }   
        }

        //Control lblsaved .visible
        private void lblsaved_txtID(object sender, EventArgs e) 
        {
            if(lblUbooksaved.Visible == true) 
            {
                lblUbooksaved.Visible = false;
            }
        }

        private void lblsaved_txtTittle(object sender, EventArgs e)
        {
            if (lblUbooksaved.Visible == true)
            {
                lblUbooksaved.Visible = false;
            }
        }

        private void lblsaved_txtAuthor(object sender, EventArgs e)
        {
            if (lblUbooksaved.Visible == true)
            {
                lblUbooksaved.Visible = false;
            }
        }

        //Control lblError .visible
        private void lblError_txtAuthor(object sender, EventArgs e)
        {
            if (lblUbookerror.Visible && lblUicon.Visible == true)
            {
                lblUbookerror.Visible = false;
                lblUicon.Visible = false;
            }
        }
        private void lblError_txtID(object sender, EventArgs e)
        {
            if (lblUbookerror.Visible && lblUicon.Visible == true)
            {
                lblUbookerror.Visible = false;
                lblUicon.Visible = false;
            }
        }
        private void lblError_txtTittle(object sender, EventArgs e)
        {
            if (lblUbookerror.Visible && lblUicon.Visible == true)
            {
                lblUbookerror.Visible = false;
                lblUicon.Visible = false;
            }
        }
    }
}

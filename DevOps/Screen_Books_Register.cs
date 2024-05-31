using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevOps
{
    public partial class Screen_Books_Register : Form
    {
        //Database connection
        SqlConnection connection = new SqlConnection("server=192.168.1.184; database=MYDataBase; integrated security=true");


        public Screen_Books_Register()
        {
            InitializeComponent();

            //EventHandler .visible
            txtBtittle.Click += new EventHandler(txtBtittle_Click);
            txtBauthor.Click += new EventHandler(txtBauthor_Click);
            txtBtittle.Click += new EventHandler(txtBEtittle_Click);
            txtBauthor.Click += new EventHandler(txtBEauthor_Click);
        }

        private void TxtBauthor_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //References
        private Screen_Books_Load screen_books_load;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBback_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void Screen_Books_Register_Load(object sender, EventArgs e)
        {

        }

        private void btnBsave_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string script = ("insert into Books(ID, Tittle, Author, isbusy) values(" + txtBid.Text+",'" + txtBtittle.Text + "','" + txtBauthor.Text + "',0)");
                SqlCommand send = new SqlCommand(script, connection);
                send.ExecuteNonQuery();

                txtBauthor.Clear();
                txtBid.Clear();
                txtBtittle.Clear();
                connection.Close();

                if(lblbooksaved.Visible == false) 
                { 
                    lblbooksaved.Visible = true;
                }
                else 
                {
                    lblbooksaved.Visible = true;
                }

            }
            catch (Exception ex) 
            {
                
                txtBauthor.Clear();
                txtBid.Clear();
                txtBtittle.Clear();

                if(lblbookerror.Visible && lblicon.Visible == false) 
                {
                    lblbookerror.Visible = true;
                    lblicon.Visible = true;
                }
                else 
                {
                    lblbookerror.Visible = false;
                    lblicon.Visible = false;
                }
            }

            
            
        }

        //Control lblsaved .visible
        private void txtBtittle_Click(object sender, EventArgs e) 
        {
            if(lblbooksaved.Visible == true) 
            { 
                lblbooksaved.Visible=false;
            }
        }

        private void txtBauthor_Click(object sender, EventArgs e) 
        {
            if(lblbooksaved.Visible == true) 
            {
                lblbooksaved.Visible = false;
            }
        }

        //Control lblerror .visible
        private void txtBEtittle_Click (object sender, EventArgs e) 
        {
            if(lblbookerror.Visible && lblicon.Visible== true) 
            {
                lblbookerror.Visible = false;
                lblicon.Visible = false;
            }
        }

        private void txtBEauthor_Click(Object sender, EventArgs e) 
        {
            if(lblbookerror.Visible && lblicon.Visible == true) 
            {
                lblbookerror.Visible = false;
                lblicon.Visible = false;
            }
        }
    }
}

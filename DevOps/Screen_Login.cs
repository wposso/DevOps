using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Data.SqlClient;

namespace DevOps
{
    public partial class Screen_Login : Form
    {
        //Database connection
        SqlConnection connection = new SqlConnection("server=192.168.1.184; database=MYDataBase; integrated security=true");

        public Screen_Login()
        {
            InitializeComponent();
            txtemail.Click += new EventHandler(txtemail_Click);
            txtpasswordL.Click += new EventHandler(txtpasswordL_Click);
        }

    

        //References
        Screen_Register screen_register = new Screen_Register();
        Screen_Reload Screen_Reload = new Screen_Reload();
        Screen_Dashboard Screen_Dashboard = new Screen_Dashboard();

        //Variables
        private bool isPasswordVisible = false;

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();

            lblShowpassword.Click += new EventHandler(lblShowPassword_Click);
        }

        private void btnminimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Control lblloginhere .visible
        private void OpenLogin(object screen_login)
        {
            this.pnlload.Controls.Clear();
            Form B = Screen_Reload as Form;
            B.TopLevel = false;
            B.Dock = DockStyle.Fill;
            this.pnlload.Controls.Add(B);
            this.pnlload.Tag = B;
            B.Show();
        }

        //Control lblaccount .visible
        private void OpenRegister(object screen_register)
        {
            //if(pnlload.Controls.Count > 0)
            //    pnlload.Controls.RemoveAt(0);
            this.pnlload.Controls.Clear();
            Form A = screen_register as Form;
            A.TopLevel = false;
            A.Dock = DockStyle.Fill;
            this.pnlload.Controls.Add(A);
            this.pnlload.Tag = A;
            A.Show();
        }
        private void lblaccount_Click(object sender, EventArgs e)
        {
            OpenRegister(new Screen_Register());

            if (lblaccount.Visible && label4.Visible == true)
            {
                if (lblgetstarted.Visible == true)
                {
                    lblgetstarted.Visible = false;
                    lblregister.Visible = true;
                }
                else
                {
                    lblgetstarted.Visible = true;
                    lblregister.Visible = false;
                }

                lblaccount.Visible = false;
                label4.Visible = false;
                lblloginhere.Visible = true;
                label5.Visible = true;
            }
            else
            {

                lblaccount.Visible = true;
                label4.Visible = true;
                lblloginhere.Visible = false;
                label5.Visible = false;
            }
        }



        private void lblloginhere_Click_1(object sender, EventArgs e)
        {
            OpenLogin(new Screen_Login());

            if (lblloginhere.Visible && label5.Visible == true)
            {
                if (lblregister.Visible == true)
                {
                    lblregister.Visible = false;
                    lblgetstarted.Visible = true;
                }
                else
                {
                    lblregister.Visible = true;
                    lblgetstarted.Visible = false;
                }

                lblloginhere.Visible = false;
                label5.Visible = false;
                lblaccount.Visible = true;
                label4.Visible = true;
            }
            else
            {

                lblloginhere.Visible = true;
                label5.Visible = true;
                lblaccount.Visible = false;
                label4.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chshowpassword.Checked)
            {
                txtpasswordL.PasswordChar = '\0';
            }
            else
            {
                txtpasswordL.PasswordChar = '•';
            }
        }

        private void pnlload_Paint(object sender, PaintEventArgs e)
        {

        }

        //Control lblinvalidcredentials .visible
        private void txtemail_Click(object sender, EventArgs e)
        {
            lblerrorcredentials1.Visible = false;
            lblerrorcredentials2.Visible = false;
        }

        private void txtpasswordL_Click(object sender, EventArgs e)
        {
            lblerrorcredentials1.Visible = false;
            lblerrorcredentials2.Visible = false;
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                SqlCommand script = new SqlCommand("select email,password from Register where email='" + txtemail.Text + "' and password='" + txtpasswordL.Text + "'", connection);
                SqlDataReader reader = script.ExecuteReader();
                if (reader.HasRows)
                {
                    this.Hide();

                    Screen_Dashboard.Show();
                    txtemail.Clear();
                    txtpasswordL.Clear();


                }
                else
                {
                    lblerrorcredentials1.Visible = true;
                    lblerrorcredentials2.Visible = true;
                    txtemail.Clear();
                    txtpasswordL.Clear();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Has error ocurred");
                txtemail.Clear();
                txtpasswordL.Clear();
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtpasswordL_TextChanged(object sender, EventArgs e)
        {

        }

        private void Screen_Login_Load(object sender, EventArgs e)
        {

        }

        private void lblShowpassword_Click(object sender, EventArgs e)
        {
            
        }

        private void lblShowPassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtpasswordL.PasswordChar = isPasswordVisible ? '\0' : '•';
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevOps
{
    public partial class Screen_Dashboard : Form
    {
        public Screen_Dashboard()
        {
            InitializeComponent();
        }

        //References
        private Screen_Login screen_login;
        Screen_Books_Load screen_books_load = new Screen_Books_Load();

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();

            screen_login = new Screen_Login();
            screen_login.Show();
        }

        //Control Books_Load .visible
        private void OpenBooksLoad(object screen_books_load)
        {
            if (pnlDload.Controls.Count > 0)
                pnlDload.Controls.RemoveAt(0);
            Form A = screen_books_load as Form;
            A.TopLevel = false;
            A.Dock = DockStyle.Fill;
            this.pnlDload.Controls.Add(A);
            this.pnlDload.Tag = A;
            A.Show();
        }
        private void Screen_Dashboard_Load(object sender, EventArgs e)
        {
            lblDloans.Location = new Point(134, 389);
            lblDLicon.Location = new Point(51, 374);
        }

        private void label1_Click(object sender, EventArgs e)
        {


            if (pnlDL.Visible == false)
            {
                pnlDL.Visible = true;
                lblDloans.Location = new Point(134, 489);
                lblDLicon.Location = new Point(51, 474);
            }
            else
            {
                pnlDL.Visible = false;
                lblDloans.Location = new Point(134, 389);
                lblDLicon.Location = new Point(51, 374);
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnDbooks_Click(object sender, EventArgs e)
        {
            OpenBooksLoad(new Screen_Books_Load());
        }
    }
}

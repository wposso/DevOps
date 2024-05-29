using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            screen_login.Show();
        }
    }
}

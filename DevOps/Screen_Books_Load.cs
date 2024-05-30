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
    public partial class Screen_Books_Load : Form
    {

        //Database connection
        SqlConnection connection = new SqlConnection("server=ADMINSYSTEM; database=MYDataBase; integrated security=true");


        public Screen_Books_Load()
        {
            InitializeComponent();
        }

        private void dtgBooksLoad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Screen_Books_Load_Load(object sender, EventArgs e)
        {
            connection.Open();

            try
            {
                SqlCommand script = new SqlCommand("select ID,tittle,autor,busy from Books", connection);
                DataTable dataTable = new DataTable();
                SqlDataReader reader = script.ExecuteReader();
                dataTable.Load(reader);
                dtgBooksLoad.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Has ocurred an error");
            }

        }

        private void dtgdemo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

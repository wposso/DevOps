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
        SqlConnection connection = new SqlConnection("server=192.168.1.184; database=MYDataBase; integrated security=true");


        public Screen_Books_Load()
        {
            InitializeComponent();

        }

        //References
        Screen_Books_Register screen_books_register = new Screen_Books_Register();
        Screen_Books_Update screen_books_update = new Screen_Books_Update();
        Screen_Books_Delete screen_books_delete = new Screen_Books_Delete();

        private void dtgBooksLoad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Screen_Books_Load_Load(object sender, EventArgs e)
        {
            connection.Open();

            try
            {
                SqlCommand script = new SqlCommand("select * from Books", connection);
                DataTable dataTable = new DataTable();
                SqlDataReader reader = script.ExecuteReader();
                dataTable.Load(reader);
                dtgBooksLoad.DataSource = dataTable;
                foreach (DataGridViewColumn column in dtgBooksLoad.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Has ocurred an error");
            }

            connection.Close();

            //Reload Screens
            

        }

        private void dtgdemo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            screen_books_register.Show();

        }

        //This Button reload DataGridView
        private void btnreloadview_Click(object sender, EventArgs e)
        {
            connection.Open();

            try
            {
                SqlCommand script = new SqlCommand("select * from Books", connection);
                DataTable dataTable = new DataTable();
                SqlDataReader reader = script.ExecuteReader();
                dataTable.Load(reader);
                dtgBooksLoad.DataSource = dataTable;
                foreach (DataGridViewColumn column in dtgBooksLoad.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Has ocurred an error");
            }

            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            screen_books_update.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            screen_books_delete.Show();
        }
    }
}

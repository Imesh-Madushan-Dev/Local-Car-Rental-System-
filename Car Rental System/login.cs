using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FInal_Project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=finalProject;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string Query = "SELECT * FROM login WHERE username = @uname AND password = @pass";


            SqlCommand find = new SqlCommand(Query, conn);

            find.Parameters.AddWithValue("@uname", txtusername.Text);
            find.Parameters.AddWithValue("@pass", txtpassword.Text);

            SqlDataReader reader = find.ExecuteReader();

            if (reader.HasRows)
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                

            }
            else
            {
                MessageBox.Show("Login Failed..!");
                reader.Close();
            }
        }
    }
}

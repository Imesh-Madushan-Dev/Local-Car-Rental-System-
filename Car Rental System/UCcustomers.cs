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

namespace FInal_Project
{
    public partial class UCcustomers : UserControl
    {
        public UCcustomers()
        {
            InitializeComponent();
        }

        string dbpath = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=finalProject;Integrated Security=True";


        public void dgvloadercus()
        {
            SqlConnection conn = new SqlConnection(dbpath);
            conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * from customers ", conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvcustomers.DataSource = dt;

            conn.Close();
        }

        private void UCcustomers_Load(object sender, EventArgs e)
        {
            dgvloadercus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbpath);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("insert into customers (nic, name, address, contact) values (@nic, @name, @address, @contact)", conn);
            cmd1.Parameters.AddWithValue("@nic", txtnic.Text);
            cmd1.Parameters.AddWithValue("@name", txtname.Text);
            cmd1.Parameters.AddWithValue("@address", txtaddress.Text);
            cmd1.Parameters.AddWithValue("@contact", txtcontact.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Customer Data Saved..!");
            txtnic.Clear();
            txtname.Clear();
            txtaddress.Clear();
            txtcontact.Clear();
            conn.Close();


            dgvloadercus();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbpath);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("UPDATE customers SET name = @name, address = @address, contact = @contact WHERE nic = @nic", conn);
            cmd1.Parameters.AddWithValue("@nic", txtnic.Text);
            cmd1.Parameters.AddWithValue("@name", txtname.Text);
            cmd1.Parameters.AddWithValue("@address", txtaddress.Text);
            cmd1.Parameters.AddWithValue("@contact", txtcontact.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Customer Data Updated..!");
            txtnic.Clear();
            txtname.Clear();
            txtaddress.Clear();
            txtcontact.Clear();
            conn.Close();

            dgvloadercus();
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbpath);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("DELETE FROM customers WHERE nic = @nic", conn);
            cmd1.Parameters.AddWithValue("@nic", txtnic.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Customer Data Deleted");
            txtnic.Clear();
            conn.Close();

            dgvloadercus();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            (dgvcustomers.DataSource as DataTable).DefaultView.RowFilter = string.Format("nic LIKE '{0}%'", txtsearch.Text);
        }
    }
}

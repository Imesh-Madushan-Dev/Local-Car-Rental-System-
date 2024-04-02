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
using System.Xml.Linq;

namespace FInal_Project
{
    public partial class UCvehicles : UserControl
    {
        public UCvehicles()
        {
            InitializeComponent();
        }

        public void dgvloader()
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=finalProject;Integrated Security=True");
            conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * from vehicles ", conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvvehicles.DataSource = dt;

            conn.Close();
        }

        string dbpath = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=finalProject;Integrated Security=True";

        private void UCvehicles_Load(object sender, EventArgs e)
        {
            dgvloader();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbpath);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("insert into vehicles (vehicleID, model, ownerN, category, contact) values (@id, @model ,@ownerN, @category, @contact)", conn);
            cmd1.Parameters.AddWithValue("@id", txtID.Text);
            cmd1.Parameters.AddWithValue("@model", txtmodel.Text);
            cmd1.Parameters.AddWithValue("@ownerN", txtownername.Text);
            cmd1.Parameters.AddWithValue("@category", txtcategory.Text);
            cmd1.Parameters.AddWithValue("@contact", txtcontact.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Customer Data Saved..!");
            txtID.Clear();
            txtmodel.Clear();
            txtownername.Clear();
            txtcategory.Clear();
            txtcontact.Clear();
            conn.Close();


            dgvloader();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbpath);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("UPDATE vehicles SET  model = @model,ownerN = @ownerN, category = @category, contact = @contact WHERE vehicleID = @id", conn);
            cmd1.Parameters.AddWithValue("@id", txtID.Text);
            cmd1.Parameters.AddWithValue("@model", txtmodel.Text);
            cmd1.Parameters.AddWithValue("@ownerN", txtownername.Text);
            cmd1.Parameters.AddWithValue("@category", txtcategory.Text);
            cmd1.Parameters.AddWithValue("@contact", txtcontact.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Customer Data Updated..!");
            txtID.Clear();
            txtmodel.Clear();
            txtownername.Clear();
            txtcategory.Clear();
            txtcontact.Clear();
            conn.Close();

            dgvloader();
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbpath);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("DELETE FROM vehicles WHERE vehicleID = @id", conn);
            cmd1.Parameters.AddWithValue("@id", txtID.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Vehicle Data Deleted");
            txtID.Clear();
            conn.Close();

            dgvloader();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            (dgvvehicles.DataSource as DataTable).DefaultView.RowFilter = string.Format("vehicleID LIKE '{0}%'", txtsearch.Text);
        }
    }
}

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
    public partial class UCreservation : UserControl
    {
        public UCreservation()
        {
            InitializeComponent();
        }

        public void dgvloaderres()
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=finalProject;Integrated Security=True");
            conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * from Reservations ", conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvreservations.DataSource = dt;

            conn.Close();
        }

        string dbpath = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=finalProject;Integrated Security=True";

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbpath);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("insert into Reservations (cusNIC, vehicleID, rentalType, amount, [from], [to]) values (@nic, @id, @Rtype ,@amount, @from, @to)", conn);
            cmd1.Parameters.AddWithValue("@id", txtID.Text);
            cmd1.Parameters.AddWithValue("@nic", txtnic.Text);
            cmd1.Parameters.AddWithValue("@Rtype", txtRtype.Text);
            cmd1.Parameters.AddWithValue("@amount", txtamount.Text);
            cmd1.Parameters.AddWithValue("@from", dtpfrom.Text);
            cmd1.Parameters.AddWithValue("@to", dtpto.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Reservation Saved..!");
            txtID.Clear();
            txtnic.Clear();
            txtamount.Clear();
            txtRtype.Clear();
            conn.Close();

            dgvloaderres();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbpath);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("UPDATE Reservations SET  vehicleID = @id, rentalType = @Rtype, amount = @amount, [from] = @from, [to] = @to WHERE cusNIC=@nic", conn);
            cmd1.Parameters.AddWithValue("@id", txtID.Text);
            cmd1.Parameters.AddWithValue("@Rtype", txtRtype.Text);
            cmd1.Parameters.AddWithValue("@amount", txtamount.Text);
            cmd1.Parameters.AddWithValue("@nic", txtnic.Text);
            cmd1.Parameters.AddWithValue("@from", dtpfrom.Text);
            cmd1.Parameters.AddWithValue("@to", dtpto.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Reservation Updated..!");
            txtID.Clear();
            txtnic.Clear();
            txtamount.Clear();
            txtRtype.Clear();
            conn.Close();

            dgvloaderres();
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(dbpath);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("DELETE FROM Reservations WHERE cusNIC=@nic", conn);
            cmd1.Parameters.AddWithValue("@nic", txtnic.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Reservation Deleted");
            txtnic.Clear();
            conn.Close();

            dgvloaderres();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            (dgvreservations.DataSource as DataTable).DefaultView.RowFilter = string.Format("cusNIC LIKE '{0}%'", txtsearch.Text);
        }

        private void UCreservation_Load(object sender, EventArgs e)
        {
            dgvloaderres();
        }
    }
}

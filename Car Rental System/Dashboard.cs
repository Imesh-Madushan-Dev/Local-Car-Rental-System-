using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInal_Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnreservations_Click(object sender, EventArgs e)
        {
            uCreservation1.BringToFront();
            uCreservation1.Show();
        }

        private void btnvehicles_Click(object sender, EventArgs e)
        {
            uCvehicles1.BringToFront();
            uCvehicles1.Show();
        }

        private void btncustomers_Click(object sender, EventArgs e)
        {
            uCcustomers1.BringToFront();
            uCcustomers1.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uCvehicles1.Hide(); 
            uCcustomers1.Hide();
            uCreservation1.Hide();
        }
    } }

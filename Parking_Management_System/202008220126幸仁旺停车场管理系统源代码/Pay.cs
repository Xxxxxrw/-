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

namespace Parking_Management_System
{
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-8REIU0L3;Initial Catalog=Parking;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select top(1)Cartime from Moneynote order by piece desc", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            L3.Text = dt.Rows[0][0].ToString();

            Con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select top(1)MoneyPay from Moneynote order by piece desc", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            L5.Text = dt.Rows[0][0].ToString();

            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            User u = new User();
            
            u.Show();
            this.Hide();
            Con.Close();

        }
    }
}

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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-8REIU0L3;Initial Catalog=Parking;Integrated Security=True");
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            User user = new User();
            user.Show();
            this.Hide();
            Con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string adm = "幸仁旺";
        int password =123456;
        private void button1_Click(object sender, EventArgs e)
        {
            if(AdnameTb.Text==adm && Convert.ToInt32(PasswordTb.Text)==password)
            {
                Con.Open();
                Cwinf cw = new Cwinf();
                cw.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("信息有误！");
            }
        }
    }
}

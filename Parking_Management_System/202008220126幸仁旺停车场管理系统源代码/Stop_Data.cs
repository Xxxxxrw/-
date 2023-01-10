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
    public partial class Stop_Data : Form
    {
        public Stop_Data()
        {
            InitializeComponent();
            populate(); 
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-8REIU0L3;Initial Catalog=Parking;Integrated Security=True");
        private void populate()
        {
            if (Con.State != ConnectionState.Open)
                Con.Open();
            string query = "select * from Stop ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CwDGVN1.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void Reset()
        {
            CwnoTb1.Text = "";
            CarnoTb1.Text = "";
            CarinTb.Text = "";
            CaroutTb.Text = "";
            CaratTb.Text = "";
            TimetypeTb.Text = "";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveBtn1_Click(object sender, EventArgs e)
        {
            if (CwnoTb1.Text == "" || CarnoTb1.Text == "" || CarinTb.Text == "" || CaratTb.Text == "" || CaroutTb.Text == "" || TimetypeTb.Text == "")
            {
                MessageBox.Show("信息缺失！！！");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Stop values('" + CwnoTb1.Text + "','" + CarnoTb1.Text + "','" + CarinTb.Text + "','" + CaroutTb.Text + "','" + CaratTb.Text + "','" + TimetypeTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("信息保存成功！");
                    populate();
                    Reset();
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void UpdateBtn2_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void DeleteBtn1_Click(object sender, EventArgs e)
        {
            if (CwnoTb1.Text == "" || CarnoTb1.Text == "" || CarinTb.Text == "" || CaratTb.Text == "" || CaroutTb.Text == "" || TimetypeTb.Text == "")
            {
                MessageBox.Show("信息缺失！！！");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = " delete from Stop where Cwno='" + CwnoTb1.Text + "' and Carno='" + CarnoTb1.Text + "'and Carin='" + CarinTb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("信息删除成功！");
                    populate();
                    //Reset();
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            Login log = new Login();
            log.Show();
            this.Hide();
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Con.Open();
            Cwinf log = new Cwinf();
            log.Show();
            this.Hide();
            Con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Con.Open();
            Other log = new Other();
            log.Show();
            this.Hide();
            Con.Close();
        }
    }
}

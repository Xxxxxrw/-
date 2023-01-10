using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Parking_Management_System
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-8REIU0L3;Initial Catalog=Parking;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from Cw_can";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CwDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void Filter()
        {

            string query = "select * from Cw_can where Cwpace='" + Cb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            Con.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CwDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            CarnoTb.Text = "";
            CarsbTb.Text = "";
            CarcolorTb.Text = "";
            CwTb.Text = "";
            CarinTb.Text = "";
            TimetypeTb.Text = "";
            
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(CarnoTb.Text=="")
            {
                MessageBox.Show("车牌号信息缺失");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Car values('" + CarnoTb.Text + "','" + CarsbTb.Text + "','" + CarcolorTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("车辆信息添加成功");
                    Con.Close();
                    Reset();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            if (CarnoTb.Text == "" || CwTb.Text == "" || CarinTb.Text == "" || TimetypeTb.Text == "")
            {
                MessageBox.Show("停车信息缺失!!");
            }
            else
            {
                try
                {

                    string query = "insert into Stop(Cwno,Carno,Carin,Timetype) values('" + CwTb.Text + "','" + CarnoTb.Text + "','" + CarinTb.Text + "','" + TimetypeTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("停车信息添加成功");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CarnoTb1.Text==""||CaroutTb.Text=="")
            {
                MessageBox.Show("信息缺失!!!");
            }
            else
            {
                try
                {

                    string query = "update Stop set Carat=1,Carout='"+CaroutTb.Text+"' where Carno='"+CarnoTb1.Text+"'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("停车信息更改成功");
                    Pay pay = new Pay();
                    pay.Show();
                    this.Hide();
                    Con.Close();
                    CarnoTb1.Text = "";
                    CaroutTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn1_Click(object sender, EventArgs e)
        {
            if (CarnoTb.Text == ""||CwTb.Text ==""||CarinTb.Text == ""||TimetypeTb.Text =="")
            {
                MessageBox.Show("信息缺失!!!");
            }
            else
            {
                try
                {
                    
                    string query = "insert into Stop(Cwno,Carno,Carin,Timetype) values('"+CwTb.Text+"','" + CarnoTb.Text + "','" + CarinTb.Text + "','"+TimetypeTb.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("停车信息添加成功");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimetypeTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarinTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CwDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CwTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarcolorTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarsbTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarnoTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
            Cb.Text = "全部分区";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CwDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}

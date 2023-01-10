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
namespace Parking_Management_System
{
    public partial class Other : Form
    {
        public Other()
        {
            InitializeComponent();
            populate();
            populate2();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-8REIU0L3;Initial Catalog=Parking;Integrated Security=True");
        private void populate()
        {
            if (Con.State != ConnectionState.Open)
                Con.Open();
            string query = "select * from  Moneyt";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MONDGVN.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populate2()
        {
            if (Con.State != ConnectionState.Open)
                Con.Open();
            string query = "select * from  Moneynote";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MonDGVN2.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Update2Btn_Click(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {
            Con.Open();
            Cwinf log = new Cwinf();
            log.Show();
            this.Hide();
            Con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Con.Open();
            Stop_Data log = new Stop_Data();
            log.Show();
            this.Hide();
            Con.Close();
        }

        private void STb1_TextChanged(object sender, EventArgs e)
        {






        }

        private void Select_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(MoneyPay)\r\nfrom Moneynote M2\r\nwhere M2.Piece in\r\n(select top(select count(*) from Stop where Carout>'"+TimeText1.Text+"') M1.piece\r\nfrom Moneynote M1\r\norder by M1.piece desc)", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            L1.Text = dt.Rows[0][0].ToString()+'元';

            Con.Close();
        }

        private void CwDGVN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update1Btn_Click(object sender, EventArgs e)
        {
            if (Tb1.Text == ""||Tb2.Text == "")
            {
                MessageBox.Show("信息缺失！！！");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update  Moneyt set Timetype='"+Tb1.Text+"',Montime='"+Tb2.Text+ "' where Timetype='"+Tb1.Text+"'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("信息修改成功！");
                    populate();
                    
                    Con.Close();
                    Tb1.Text = "";
                    Tb2.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void L1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Stop where Carout>'"+TimeText2.Text+"'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            L2.Text = dt.Rows[0][0].ToString()+'次';

            Con.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (PieceTb.Text=="")
            {
                MessageBox.Show("信息有误！！！");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Moneynote where piece='" + PieceTb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("信息删除成功！");
                    populate2();
                    PieceTb.Text = "";
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
    
}
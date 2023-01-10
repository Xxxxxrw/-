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
    public partial class Cwinf : Form
    {
        public Cwinf()
        {
            InitializeComponent();
            populate();
        }
        
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-8REIU0L3;Initial Catalog=Parking;Integrated Security=True");
        private void populate()
        {
            if(Con.State != ConnectionState.Open)
              Con.Open();
            string query = "select * from Ffed ";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con); 
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CwDGVN.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Filter()
        {
            
            string query = "select * from Ffed where Cwpace='" + Cb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            Con.Open();
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CwDGVN.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            CwnoTb.Text = "";
            CwpaceTb.Text = "";
            CwtypeTb.Text = "";
            CarnoTb.Text = "";
            CarnameTb.Text = "";
            CaraddTb.Text = "";
            CartelTb.Text = "";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(CwnoTb.Text==""||CwpaceTb.Text==""||CwtypeTb.Text=="")
            {
                MessageBox.Show("信息缺失！！！");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Ffed values('"+CwnoTb.Text+"','"+CwpaceTb.Text+"','"+CwtypeTb.Text+"','"+CarnoTb.Text+"','"+CarnameTb.Text+"','"+CaraddTb.Text+"','"+CartelTb.Text+"')";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("信息保存成功！");
                    populate();
                    Reset();
                    Con.Close();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CwDGVN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Update2Btn_Click(object sender, EventArgs e)
        {
            populate();
            Cb.Text = "全部分区";
        }
     
        private void CwDGVN_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CwnoTb.Text = CwDGVN.SelectedRows[0].Cells[0].Value.ToString();
            CwpaceTb.Text = CwDGVN.SelectedRows[0].Cells[1].Value.ToString();
            CwtypeTb.Text = CwDGVN.SelectedRows[0].Cells[2].Value.ToString();
            CarnoTb.Text = CwDGVN.SelectedRows[0].Cells[3].Value.ToString();
            CarnameTb.Text = CwDGVN.SelectedRows[0].Cells[4].Value.ToString();
            CaraddTb.Text = CwDGVN.SelectedRows[0].Cells[5].Value.ToString();
            CartelTb.Text = CwDGVN.SelectedRows[0].Cells[6].Value.ToString();
           
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (CwnoTb.Text == "" || CwpaceTb.Text == "" || CwtypeTb.Text == "")
            {
                MessageBox.Show("信息错误！！！");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Ffed where Cwno='"+CwnoTb.Text+"'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("信息删除成功！");
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

        private void Update1Btn_Click(object sender, EventArgs e)
        {
            if (CwnoTb.Text == "" || CwpaceTb.Text == "" || CwtypeTb.Text == "")
            {
                MessageBox.Show("信息缺失！！！");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update  Ffed set Cwno='" + CwnoTb.Text + "',Cwpace='"+CwpaceTb.Text+"',Cwtype='"+CwtypeTb.Text+"',Carno='"+CarnoTb.Text+"',Carname='"+CarnameTb.Text+"',Caradd='"+CaraddTb.Text+"',Cartel='"+CartelTb.Text+"' where Cwno='"+CwnoTb.Text+"'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("信息修改成功！");
                    populate();
                    Reset();
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    Con.Close();
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

        private void label4_Click(object sender, EventArgs e)
        {
            Con.Open();
            Stop_Data log = new Stop_Data();
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

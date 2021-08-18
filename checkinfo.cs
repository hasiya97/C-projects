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

namespace Hotel_Reservation_System
{
    public partial class checkinfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HotelReservationSystem.mdf;Integrated Security=True;Connect Timeout=30");

        public checkinfo()
        {
            InitializeComponent();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(guna2DataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Cus_Registration set nic='" + nicno.Text + "',Firstname='" + fname.Text + "',Lastname='" + lname.Text + "',Gender='" + gender.Text + "',Contactno='" + cno.Text + "',Date='" + date.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("info updated");


                
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            checkinfo_Load(this, null);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
             int i = 0;
             con.Open();
             SqlCommand cmd = con.CreateCommand();
             cmd.CommandType = CommandType.Text;
             cmd.CommandText = "select * from Cus_Registration where nic='" + nicno.Text + "'";
             cmd.ExecuteNonQuery();
             DataTable dt = new DataTable();
             SqlDataAdapter sda = new SqlDataAdapter(cmd);
             sda.Fill(dt);
             i = Convert.ToInt32(dt.Rows.Count.ToString());
             con.Close();


             if (i == 0)
             {
                 MessageBox.Show("Nic no found");
             }
             else
             {
                 foreach (DataRow dr in dt.Rows)
                 {
                     fname.Text = dr["Firstname"].ToString();
                     lname.Text = dr["Lastname"].ToString();
                     gender.Text = dr["Gender"].ToString();
                     cno.Text = dr["Contactno"].ToString();
                     date.Text = dr["Date"].ToString();

                 }
             }



            
        }

        private void lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkinfo_Load(object sender, EventArgs e)// view info 
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select id, nic, Firstname, Lastname, Contactno, Gender, Date from Cus_Registration";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                guna2DataGridView1.DataSource = dt;


                con.Close();
            }
            catch (Exception se)
            {
                MessageBox.Show("" + se);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(guna2DataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " select * from Cus_Registration where id= " +i+ " ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    nicno.Text = dr["nic"].ToString();
                    fname.Text = dr["Firstname"].ToString();
                    lname.Text = dr["Lastname"].ToString();
                    cno.Text = dr["Contactno"].ToString();
                    gender.Text = dr["Gender"].ToString();
                    date.Text = dr["Date"].ToString();
                    
                }

                con.Close();


            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(guna2DataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " select * from Cus_Registration where id= " + i + " ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    nicno.Text = dr["nic"].ToString();
                    fname.Text = dr["Firstname"].ToString();
                    lname.Text = dr["Lastname"].ToString();
                    cno.Text = dr["Contactno"].ToString();
                    gender.Text = dr["Gender"].ToString();
                    date.Text = dr["Date"].ToString();

                }

                con.Close();


            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(guna2DataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from Cus_Registration where Firstname='" + fname.Text + "',Lastname='" + lname.Text + "',Contactno='" + cno.Text + "',Gender='" + gender.Text + "',Date='" + date.Text + "' where id=" + i + "";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Records updated sucessfully");
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(guna2DataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " select * from Cus_Registration where id= " + i + " ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    nicno.Text = dr["nic"].ToString();
                    fname.Text = dr["Firstname"].ToString();
                    lname.Text = dr["Lastname"].ToString();
                    cno.Text = dr["Contactno"].ToString();
                    gender.Text = dr["Gender"].ToString();
                    date.Text = dr["Date"].ToString();

                }

                con.Close();


            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(guna2DataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " select * from Cus_Registration where id= " + i + " ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    nicno.Text = dr["nic"].ToString();
                    fname.Text = dr["Firstname"].ToString();
                    lname.Text = dr["Lastname"].ToString();
                    cno.Text = dr["Contactno"].ToString();
                    gender.Text = dr["Gender"].ToString();
                    date.Text = dr["Date"].ToString();

                }

                con.Close();


            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message);
            }
        }
    }
}

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
    public partial class AddRoom : Form // windows form class
    {

        function fn = new function();
        String query;


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HotelReservationSystem.mdf;Integrated Security=True;Connect Timeout=30");
        int count = 0;
        public AddRoom()
        {
            InitializeComponent();
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {

            

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);


            query = "select * from Room"; //Display from Room table DB
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {


           
            if (txtroomno.Text != "" && txtroomtype.Text != "" && txtbedtype.Text != "" && txtdatein.Text != "" && txtdateout.Text != "" && txtpersons.Text != "")
            {
                String Roomno = txtroomno.Text;
                String Roomtype = txtroomtype.Text;
                String Bedtype = txtbedtype.Text;
                String Datein = txtdatein.Text;
                String Dateofdepature = txtdateout.Text;
                String Noofpersons = txtpersons.Text;
                String price = txtprice.Text;
                String Nights = txtNights.Text;
               

                query = "insert into Room (Roomno,Roomtype,Bedtype,Datein,Dateofdeparture,Noofpersons,price,Nights) values ('"+Roomno+"','"+Roomtype+"','"+Bedtype+"','"+Datein+"','"+Dateofdepature+"','"+Noofpersons+"','"+price+"','"+Nights+"')";
                fn.setData(query, "Room Added");

                AddRoom_Load(this, null);
            }
            else
            {
                MessageBox.Show("Fill All Fields.","Warning !!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(DataGridView1.SelectedCells[0].Value.ToString());
            MessageBox.Show(i.ToString());
            try
            {
               
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " select * from Room where id="+i+"";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                


                foreach (DataRow dr in dt.Rows)
                {
                    txtroomno.Text = dr["Roomno"].ToString();
                    txtroomtype.Text = dr["Roomtype"].ToString();
                    txtbedtype.Text = dr["Bedtype"].ToString();
                    txtdatein.Text = dr["Datein"].ToString();
                    txtdateout.Text = dr["Dateofdeparture"].ToString();
                    txtpersons.Text = dr["Noofpersons"].ToString();

                }
                



            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {


            int i;
            i = Convert.ToInt32(DataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Room set Roomno='"+txtroomno.Text +"',Roomtype='"+txtroomtype.Text+"',Bedtype='"+txtbedtype.Text+"',Datein='"+txtdatein.Text+"',Dateofdeparture='"+txtdateout.Text+"',Noofpersons='"+txtpersons.Text+"' where id="+i+"";
                cmd.ExecuteNonQuery();
                AddRoom_Load(this, null);
                MessageBox.Show("Room info updated");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(DataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                //con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from Room where id='"+i+"';  ";
                cmd.ExecuteNonQuery();
               // con.Close();
                MessageBox.Show("Records updated sucessfully");
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message);
            }

            AddRoom_Load(this, null);
            /*int i;
            i = Convert.ToInt32(DataGridView1.SelectedCells[0].Value.ToString());
            try
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete Room set Roomno='" + txtroomno.Text + "',Roomtype='" + txtroomtype.Text + "',Bedtype='" + txtbedtype.Text + "',Datein='" + txtdatein.Text + "',Dateofdeparture='" + txtdateout.Text + "',Noofpersons='" + txtpersons.Text + "' where id=" + i + "";
                cmd.ExecuteNonQuery();
                AddRoom_Load(this, null);
                MessageBox.Show("Room info Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
            b.Show();
            this.Hide();
        }
    }
}

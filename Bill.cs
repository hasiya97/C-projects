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
    public partial class Bill : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HotelReservationSystem.mdf;Integrated Security=True;Connect Timeout=30");

        public Bill()
        {
            InitializeComponent();
        }
        public double total;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Room where Roomno='" + txtrid.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            con.Close();
            if (i == 0)
            {
                MessageBox.Show("RoomNo not available");
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                   txtrid.Text = dr["Roomno"].ToString();
                    txtrprice.Text = dr["price"].ToString();
                    txttotnights.Text = dr["Nights"].ToString();
                    
                }

            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)// calculation of bill
        {
            int price = int.Parse(txtrprice.Text);
            int Nights = int.Parse(txttotnights.Text);
            total = price * Nights;
            txttot.Text = "" + total.ToString();
        }

        private void guna2Button2_Click(object sender, EventArgs e)//print receipt view
        {
            txtResult.Clear();
            txtResult.Text += "**************************************************************************\n";
            txtResult.Text += "*******************        Bill Receipt                 ****************************\n";
            txtResult.Text += "**************************************************************************\n";
            txtResult.Text += "Date :" + DateTime.Now + "\n\n";
            //txtResult.Text += "Item code: " + itmcode.Text + "\n\n";
            txtResult.Text += "RoomNo: " + txtrid.Text + "\n\n";
            txtResult.Text += "Room price: " + txtrprice.Text + "\n\n";
            txtResult.Text += "No of Nights: " + txttotnights.Text + "\n\n";
            txtResult.Text += "Total: " + txttot.Text + "\n\n";

        }

        private void txttotnights_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }
    }
}

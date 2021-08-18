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
    public partial class Check_in : Form
    {
        public Check_in()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e) // search available rooms by using the date
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HotelReservationSystem.mdf;Integrated Security=True;Connect Timeout=30");
            string sql = "select * from  available where date='" + guna2TextBox1.Text + "';";
            SqlCommand ccc = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = ccc.ExecuteReader();
                while (myreader.Read())
                {
                  string date = myreader.GetString(0);
                    string Single = myreader.GetString(1);
                    string Double = myreader.GetString(2);
                    string AC = myreader.GetString(3);
                    string NonAC = myreader.GetString(4);
                    guna2TextBox1.Text = date;
                    guna2TextBox2.Text = Single;
                    guna2TextBox3.Text = Double;
                    guna2TextBox4.Text = AC;
                    guna2TextBox5.Text = NonAC;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Check_in_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            AddRoom ar = new AddRoom();
            ar.Show();
            this.Hide();
        }
    }
}


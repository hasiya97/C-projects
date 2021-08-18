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
    public partial class Registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HotelReservationSystem.mdf;Integrated Security=True;Connect Timeout=30");
        int count = 0;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e) // connection open and closing for sql connection
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            panel1.BackColor = Color.FromArgb(200, 0, 0, 0); // reduces the background opacity
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " insert into Cus_Registration values('" + txtnic.Text + "','" + txtlame.Text + "','" + txtfname.Text + "','" + txtcno.Text + "','" + txtgender.Text + "','" + txtuname.Text + "','" + txtpass.Text + "','" + txtcpass.Text + "','" +Convert.ToDateTime(guna2DateTimePicker1.Text)+ "','" + txtage.Text + "')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            if (count == 0)
            {
                MessageBox.Show("");
            }
            else
            {
                this.Hide();
                Login lg = new Login();
                lg.Show();
                MessageBox.Show("Registration Successful");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

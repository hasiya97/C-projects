using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Check_in ci = new Check_in();
            ci.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            AddRoom ad = new AddRoom();
            ad.Show();
           
        }

        private void guna2ImageButton1_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddRoom ad = new AddRoom();
            ad.Hide();
            this.Show();
        }

        private void guna2ImageButton1_MouseClick(object sender, MouseEventArgs e)
        {
            AddRoom ad = new AddRoom();
            ad.Hide();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRoom ad = new AddRoom();
            ad.Show();
            
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Welcomepage wpg = new Welcomepage();
            wpg.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddRoom ar = new AddRoom();
            ar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Check_in ci = new Check_in();
            ci.Show();
            this.Hide();
        }
    }
}

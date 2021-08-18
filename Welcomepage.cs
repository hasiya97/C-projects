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
    public partial class Welcomepage : Form
    {
        public Welcomepage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Welcomepage_Load(object sender, EventArgs e)
        {
           // var dd = this.PointToScreen(panel2.Location);
          //  dd = pictureBox3.PointToClient(dd);
           // panel2.Parent = pictureBox3;
           // panel2.Location = dd;
           // panel2.BackColor = Color.FromArgb(200, 0, 0, 0);
            timer1.Start();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            progressbar hh = new progressbar();
            hh.Show();
        }
    }
}

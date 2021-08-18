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
    public partial class progressbar : Form
    {
        public progressbar()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                pictureBox3.Width += 2;
                if (pictureBox3.Width >= 600)
                {
                    timer1.Stop();
                    Registration ll = new Registration();
                    ll.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void progressbar_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

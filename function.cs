using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Reservation_System
{
    class function
    {
        protected SqlConnection getConnection()
        {
            //SqlConnection con = new SqlConnection();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HotelReservationSystem.mdf;Integrated Security=True;Connect Timeout=30");
            //con.ConnectionString = "Data Source=(LocalDB)/MSSQLLocalDB;AttachDbFilename=D:/HotelReservationSystem.mdf;Integrated Security=True;Connect Timeout=30";
            return con;
        }
        public DataSet getData(String query) //Get Data from Database
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query, String message) // This method used for CRUD operation.
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(" '"+message+"'","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

           
        }   

    }
}


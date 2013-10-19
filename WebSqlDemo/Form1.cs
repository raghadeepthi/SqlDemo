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

namespace WebSqlDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDBConnection_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Helper.ConnectionString;
            try
            {
                con.Open();
                MessageBox.Show("Connected..");
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception " + ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

            }
        }

        private void btnConnectionPooling_Click(object sender, EventArgs e)
        {
            //Demonstrate Connection pooling
            SqlConnection[] cons = new SqlConnection[100];
            for (int i= 0; i < cons.Length ; i++)
            {
                cons[i] = new SqlConnection(Helper.ConnectionString); //Creating 100 SqlConnection connection
                cons[i].Open();
              // cons[i].Close(); // if the connection is not closed then application hangs even if makes more than 100 connections to DB
                
            }
        }
    }
}

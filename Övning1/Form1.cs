using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Övning1
{
    public partial class Form1 : Form
    {
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=..\Resor.mdf;Integrated Security=True";
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jacjon0310\source\repos\Object Orianterat(1)\Övning1\Resor.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSök_Click(object sender, EventArgs e)
        {
            lbxResor.Items.Clear();
            string query = $"SELECT Destination, AntalDagar FROM Resor WHERE Namn ='{tbxNamn.Text}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lbxResor.Items.Add($"{reader.GetString(0).Trim()}, {reader.GetInt32(1)}");
                        }
                    }
                }
            }
        }

        private void BtnBoka_Click(object sender, EventArgs e)
        {
            string query = $"INSERT Resor(Namn, Destination, AntalDagar) VALUES('{tbxKund.Text}','{tbxDestination.Text}','{tbxAntalDagar.Text}')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                };
            }
        }
    }
}

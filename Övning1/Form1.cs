using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects Second Drive\School Shit\Object Orianterat\Övning1\Resor.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSök_Click(object sender, EventArgs e)
        {
            
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

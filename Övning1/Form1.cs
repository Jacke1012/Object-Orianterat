using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Parser;

namespace Övning1
{
    public partial class Form1 : Form
    {
        string skolConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jacjon0310\source\repos\Object Orianterat(1)\Övning1\Resor.mdf;Integrated Security=True";

        //string hemConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects Second Drive\School Shit\Object Orianterat\Övning1\Resor.mdf;Integrated Security=True";
        string hemConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Resor.mdf;Integrated Security=True";

        string connectionString;

        List<Resa> resor = new List<Resa>();

        public Form1()
        {
            InitializeComponent();
            connectionString = hemConnection;
        }



        private void BtnSök_Click(object sender, EventArgs e)
        {
            lbxResor.Items.Clear();
            lbxResor.Items.AddRange(resor.Where(x => x.namn == tbxNamn.Text).ToArray());
        }

        private void BtnBoka_Click(object sender, EventArgs e)
        {
            double temp;
            if (TryParse.Double(tbxAntalDagar, out temp))
            {
                string query = $"INSERT Resor(Namn, Destination, AntalDagar) VALUES('{tbxKund.Text}','{tbxDestination.Text}','{temp}')";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    };
                }

                MessageBox.Show("Resand är bokad", "Bekräftelse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FetchFromDB();

                tbxKund.Clear(); ;
                tbxDestination.Clear();
                tbxAntalDagar.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FetchFromDB();
        }

        private void FetchFromDB()
        {
            string query = $"SELECT Namn,Destination, AntalDagar FROM Resor";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        resor.Clear();
                        while (reader.Read())
                        {
                            resor.Add(new Resa(reader.GetString(0).Trim(), reader.GetString(1).Trim(), reader.GetInt32(2)));
                        }
                    }
                }
            }
        }
    }
}

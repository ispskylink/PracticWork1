using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PracticWork1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = null;
        SqlDataReader reader = null;
        bool isDbOpen;
        string serverName;
        string DBName;
       
        string connectionString = @"Data Source=CR5-00\SQLEXPRESS; Initial Catalog=Library; Integrated Security=sspi;";
        public Form1()
        {
            InitializeComponent();
            isDbOpen = false;
            serverName = string.Empty;
            DBName = string.Empty;
            
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = tbServer.Text;
            builder.InitialCatalog = tbDBName.Text;
            builder.IntegratedSecurity = true;
            conn = new SqlConnection();
            conn.ConnectionString = builder.ConnectionString;
            try
            {
                conn.Open();
                isDbOpen = true;
                bConnect.Enabled = false;
                bDisconnect.Enabled = true;
            }
            catch(SqlException)
            {
                MessageBox.Show("Error connection");
                isDbOpen = false;
                bConnect.Enabled = true;
                bDisconnect.Enabled = true;
            }
        }

        private void bDisconnect_Click(object sender, EventArgs e)
        {
                conn.Close();
                bConnect.Enabled = true;
                bDisconnect.Enabled = false;
           
        }

        private void bGetData_Click(object sender, EventArgs e)
        {
            lbView.Items.Clear();
            SqlCommand command = new SqlCommand("select * from authors", conn);
            reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                // fieldCount - количество полей
                //for (; i < reader.FieldCount; i++)
                //{
                //    //Получить имя поля
                //    Console.Write(reader.GetName(i).ToString() + " ");
                //}
                //Console.WriteLine("\n");
             //  lvOutput.Items.Add(reader["il"] == null ? "Null" : "NotNull");

                //Console.WriteLine(reader[0]+ " "+ reader[1]+ " "+reader[2]);
                lbView.Items.Add(reader["id"] + " " + reader["firstName"] + " " + reader["lastName"] + " " + reader["countryId"]);
            }
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            string insertQuery = "insert into Authors values(@p1,@p2,@p3)";
            SqlCommand command = new SqlCommand(insertQuery, conn);
            command.Parameters.Add("@p1", SqlDbType.VarChar).Value = tbName.Text;
            command.Parameters.Add("@p2", SqlDbType.VarChar).Value = tbSurname.Text;
            command.Parameters.Add("@p3", SqlDbType.Int).Value = Int32.Parse(tbCountry.Text);
            command.ExecuteNonQuery();


        }
    }
}

using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERLANDINO_DSAL01E.Database
{
    internal class DB_Class
    {
        string connectionString = null;
        public SqlConnection connection;
        public SqlCommand command;
        public DataSet dset;
        public SqlDataAdapter adaptersql;
        public string sql = null;

        // Initialize the database connection
        public void initiate_connection()
        {
            connectionString = "Data Source=LAPTOP-CDS0O04L\\SQLEXPRESS;Initial Catalog=SampleDatabaseDB;Trusted_Connection=True;TrustServerCertificate=True";
            connection = new SqlConnection(connectionString);
        }

        // Execute an insert or non-query command
        public void insert_command()
        {
            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery(); // Run the SQL command
        }

        // Prepare a new SQL command
        public void new_command()
        {
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;
        }

        // Prepare the adapter for a SELECT command
        public void select_command()
        {
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
        }

        // Fill the dataset with data from the database
        public void data_set()
        {
            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");
        }

        // Clear the input textboxes
        public void clear_inputs(TextBox picture_path_txtbox, TextBox student_num_txtbox, TextBox student_name_txtbox, TextBox department_txtbox)
        {
            picture_path_txtbox.Clear();
            student_num_txtbox.Clear();
            student_name_txtbox.Clear();
            department_txtbox.Clear();
        }

        // Set the default image in a PictureBox
        public void default_image(PictureBox pictureBox1)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\fla10\\source\\repos\\diceyxzc\\BERLANDINO_3rd_YEAR_DSAL01E" +
                "\\BERLANDINO-DSAL01E\\Resources\\default_user.jpg");
        }
    }
}

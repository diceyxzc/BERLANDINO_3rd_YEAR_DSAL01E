using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BERLANDINO_DSAL01E.Database.Main_DB_Classes
{
    internal class loginDb_dbconnections
    {
        public String login_connectionString = null;
        public SqlConnection login_sql_connection;
        public SqlCommand login_sql_command;
        public DataSet login_sql_dataset;
        public SqlDataAdapter login_sql_dataadapter;
        public string login_sql = null;

        public void login_connString()
        {
            // Establishes a connection from C# forms to the SQL Server Database
            login_sql_connection = new SqlConnection();
            login_connectionString = "Data Source=LAPTOP-CDS0O04L\\SQLEXPRESS;Initial Catalog=POSDB;Trusted_Connection=True;TrustServerCertificate=True";

            login_sql_connection = new SqlConnection(login_connectionString);
            login_sql_connection.ConnectionString = login_connectionString;

            login_sql_connection.Open();
        }

        public void login_cmd() // Function codes that support MS SQL query
        {
            login_sql_command = new SqlCommand(login_sql, login_sql_connection);
            login_sql_command.CommandType = CommandType.Text;
        }

        public void login_sqladapterSelect() // Function codes for mediating between C# language and the MS SQL SELECT Command
        {
            login_sql_dataadapter = new SqlDataAdapter();
            login_sql_dataadapter.SelectCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }

        public void login_sqladapterInsert() // Function codes for mediating between C# language and the MS SQL INSERT Command
        {
            login_sql_dataadapter = new SqlDataAdapter();
            login_sql_dataadapter.InsertCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }

        public void login_sqladapterDelete() // Function codes for mediating between C# language and the MS SQL DELETE Command
        {
            login_sql_dataadapter = new SqlDataAdapter();
            login_sql_dataadapter.DeleteCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }

        public void login_sqladapterUpdate() // Function codes for mediating between C# language and the MS SQL UPDATE Command
        {
            login_sql_dataadapter = new SqlDataAdapter();
            login_sql_dataadapter.UpdateCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }

        public void login_sqldatasetSelect() // Mirroring the contents of the database inside the MS SQL going to C#/Visual Studio
        {
            login_sql_dataset = new DataSet();
            login_sql_dataadapter.Fill(login_sql_dataset, "pos_empRegTbl");
        }
    }
}

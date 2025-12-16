using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BERLANDINO_DSAL01E.Database.Main_DB_Classes
{
    internal class employee_dbconnection
    {
        public String employee_connectionString = null;
        public SqlConnection employee_sql_connection;
        public SqlCommand employee_sql_command;
        public DataSet employee_sql_dataset;
        public SqlDataAdapter employee_sql_dataadapter;
        public string employee_sql = null;

        public void employee_connString()
        {
            // Establishes a connection from C# forms to the SQL Server Database
            employee_sql_connection = new SqlConnection();
            employee_connectionString = "Data Source=172.20.10.8;Initial Catalog=POSDB;User Id=sa;Password=calvin123;TrustServerCertificate=True;";

            employee_sql_connection = new SqlConnection(employee_connectionString);
            employee_sql_connection.ConnectionString = employee_connectionString;

           employee_sql_connection.Open();
        }

        public void employee_cmd() // Function code that supports the MS SQL query
        {
            employee_sql_command = new SqlCommand(employee_sql, employee_sql_connection);
            employee_sql_command.CommandType = CommandType.Text;
        }

        public void employee_sqladapterSelect() // Function codes for mediating between C# language and the MS SQL SELECT Command
        {
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.SelectCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
        }

        public void employee_sqladapterInsert() // Function codes for mediating between C# language and the MS SQL INSERT Command
        {
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.InsertCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
        }

        public void employee_sqladapterDelete() // Function codes for mediating between C# language and the MS SQL DELETE Command
        {
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.DeleteCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
        }

        public void employee_sqladapterUpdate() // Function codes for mediating between C# language and the MS SQL UPDATE Command
        {
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.UpdateCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
        }

        public void employee_sqldatasetSelect() // Mirroring the contents of the database inside the MS SQL going to C#/Visual Studio
        {
            employee_sql_dataset = new DataSet();
            employee_sql_dataadapter.Fill(employee_sql_dataset, "pos_empRegTbl");
        }
    }
}
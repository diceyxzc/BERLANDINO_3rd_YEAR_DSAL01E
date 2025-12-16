using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BERLANDINO_DSAL01E.Database.Main_DB_Classes
{
    internal class payroll_dbconnection
    {
        public String payroll_connectionString = null;
        public SqlConnection payroll_sql_connection;
        public SqlCommand payroll_sql_command;
        public DataSet payroll_sql_dataset;
        public SqlDataAdapter payroll_sql_dataadapter;
        public string payroll_sql = null;

        public void payroll_connString()
        {
            // Establishes a connection from C# forms to the SQL Server Database
            payroll_sql_connection = new SqlConnection();
            payroll_connectionString = "Data Source=172.20.10.8;Initial Catalog=POSDB;User Id=sa;Password=calvin123;TrustServerCertificate=True;";

            payroll_sql_connection = new SqlConnection(payroll_connectionString);
            payroll_sql_connection.ConnectionString = payroll_connectionString;

            payroll_sql_connection.Open();
        }

        public void payroll_cmd() // Function codes that support the MS SQL query
        {
            payroll_sql_command = new SqlCommand(payroll_sql, payroll_sql_connection);
            payroll_sql_command.CommandType = CommandType.Text;
        }

        public void payroll_sqladapterSelect() // Function codes for mediating between C# language and the MS SQL SELECT Command
        {
            payroll_sql_dataadapter = new SqlDataAdapter();
            payroll_sql_dataadapter.SelectCommand = payroll_sql_command;
            payroll_sql_command.ExecuteNonQuery();
        }

        public void payroll_sqladapterInsert() // Function codes for mediating between C# language and the MS SQL INSERT Command
        {
            payroll_sql_dataadapter = new SqlDataAdapter();
            payroll_sql_dataadapter.InsertCommand = payroll_sql_command;
            payroll_sql_command.ExecuteNonQuery();
        }

        public void payroll_sqladapterDelete() // Function codes for mediating between C# language and the MS SQL DELETE Command
        {
            payroll_sql_dataadapter = new SqlDataAdapter();
            payroll_sql_dataadapter.DeleteCommand = payroll_sql_command;
            payroll_sql_command.ExecuteNonQuery();
        }

        public void payroll_sqladapterUpdate() // Function codes for mediating between C# language and the MS SQL UPDATE Command
        {
            payroll_sql_dataadapter = new SqlDataAdapter();
            payroll_sql_dataadapter.UpdateCommand = payroll_sql_command;
            payroll_sql_command.ExecuteNonQuery();
        }

        public void payroll_sqldatasetSelect() // Mirroring the contents of the database inside the MS SQL going to C#/Visual Studio
        {
            payroll_sql_dataset = new DataSet();
            payroll_sql_dataadapter.Fill(payroll_sql_dataset, "pos_empRegTbl");
        }
    }
}
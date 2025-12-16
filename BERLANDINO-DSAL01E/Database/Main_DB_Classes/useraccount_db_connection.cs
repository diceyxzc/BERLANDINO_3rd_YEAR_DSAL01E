using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BERLANDINO_DSAL01E.Database.Main_DB_Classes
{
    internal class useraccount_db_connection
    {
        public String useraccount_connectionString = null;
        public SqlConnection useraccount_sql_connection;
        public SqlCommand useraccount_sql_command;
        public DataSet useraccount_sql_dataset;
        public SqlDataAdapter useraccount_sql_dataadapter;
        public string useraccount_sql = null;

        public void useraccount_connString()
        {
            // Establishes a connection from C# forms to the SQL Server Database
            useraccount_sql_connection = new SqlConnection();
            useraccount_connectionString = "Data Source=172.20.10.8;Initial Catalog=POSDB;User Id=sa;Password=calvin123;TrustServerCertificate=True;";

            useraccount_sql_connection = new SqlConnection(useraccount_connectionString);
            useraccount_sql_connection.ConnectionString = useraccount_connectionString;

            useraccount_sql_connection.Open();
        }

        public void useraccount_cmd() // Function codes that support the MS SQL query
        {
            useraccount_sql_command = new SqlCommand(useraccount_sql, useraccount_sql_connection);
            useraccount_sql_command.CommandType = CommandType.Text; 
        }

        public void useraccount_sqladapterSelect() // Function codes for mediating between C# language and the MS SQL SELECT Command
        {
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.SelectCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqladapterInsert() // Function codes for mediating between C# language and the MS SQL INSERT Command
        {
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.InsertCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqladapterDelete() // Function codes for mediating between C# language and the MS SQL DELETE Command
        {
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.DeleteCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqladapterUpdate() // Function codes for mediating between C# language and the MS SQL UPDATE Command
        {
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.UpdateCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqldatasetSelect() // Mirroring the contents of the database inside MS SQL to C#/Visual Studio
        {
            useraccount_sql_dataset = new DataSet();
            useraccount_sql_dataadapter.Fill(useraccount_sql_dataset, "pos_empRegTbl");
        }

        public void useraccount_sqldatasetSelect_Account() // Mirroring the contents of the database inside MS SQL to C#/Visual Studio
        {
            useraccount_sql_dataset = new DataSet();
            useraccount_sql_dataadapter.Fill(useraccount_sql_dataset, "useraccountTbl");
        }
    }
}
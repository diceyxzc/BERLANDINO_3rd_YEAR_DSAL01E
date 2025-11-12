using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BERLANDINO_DSAL01E.Database.Main_DB_Classes
{
    internal class pos_dbconnection
    {
        public String pos_connectionString = null;
        public SqlConnection pos_sql_connection;
        public SqlCommand pos_sql_command;
        public DataSet pos_sql_dataset;
        public SqlDataAdapter pos_sql_dataadapter;
        public string pos_sql = null;

        public void pos_connString()
        {
            // Establishes a connection from C# forms to the SQL Server Database
            pos_sql_connection = new SqlConnection();
            pos_connectionString = "Data Source=LAPTOP-CDS0O04L\\SQLEXPRESS;Initial Catalog=POSDB;Trusted_Connection=True;TrustServerCertificate=True";

            pos_sql_connection = new SqlConnection(pos_connectionString);
            pos_sql_connection.ConnectionString = pos_connectionString;

            pos_sql_connection.Open();
        }

        public void pos_cmd() // Function codes that support the MS SQL query
        {
            pos_sql_command = new SqlCommand(pos_sql, pos_sql_connection);
            pos_sql_command.CommandType = CommandType.Text;
        }

        public void pos_sqladapterSelect() // Function codes for mediating between C# language and the MS SQL SELECT Command
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.SelectCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }

        public void pos_sqladapterInsert() // Function codes for mediating between C# language and the MS SQL INSERT Command
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.InsertCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }

        public void pos_sqladapterDelete() // Function codes for mediating between C# language and the MS SQL DELETE Command
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.DeleteCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }

        public void pos_sqladapterUpdate() // Function codes for mediating between C# language and the MS SQL UPDATE Command
        {
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.UpdateCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }

        public void pos_sql_datasetSelect() // Mirroring the contents of the database inside the MS SQL going to C#/Visual Studio
        {
           pos_sql_dataset = new DataSet();
           pos_sql_dataadapter.Fill(pos_sql_dataset, "pos_nameTbl");
        }

        public void pos_sqldatasetSelectSales() // Mirroring the contents of the database inside the MS SQL going to C#/Visual Studio for Sales Table
        {
            pos_sql_dataset = new DataSet();
            pos_sql_dataadapter.Fill(pos_sql_dataset, "salesTbl");
        }

        public void pos_select()
        {
            pos_sql = "SELECT * FROM pos_nameTbl " +
                      "INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
                      "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id";
        }

        public void pos_select_cashier()
        {
            pos_sql = "SELECT * FROM pos_nameTbl " +
                      "INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
                      "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id " +
                      "WHERE pos_nameTbl.pos_id = 1";
        }

        public void pos_select_cashier2()
        {
            pos_sql = "SELECT * FROM pos_nameTbl " +
                      "INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
                      "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id " +
                      "WHERE pos_nameTbl.pos_id = 2";
        }

        public void pos_select_cashier_display()
        {
            pos_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_surname, pos_terminal_no, account_type " +
                      "FROM pos_empRegTbl " +
                      "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id " +
                      "WHERE account_type = 'Administrator'";
        }

        public void pos_select_cashier_SelectDisplay()
        {
            pos_sql_dataset = new DataSet();
            pos_sql_dataadapter.Fill(pos_sql_dataset, "pos_empRegTbl");
        }
    }
}
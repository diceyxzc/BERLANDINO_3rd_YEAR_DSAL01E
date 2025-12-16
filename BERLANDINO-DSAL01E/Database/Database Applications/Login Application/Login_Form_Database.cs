using BERLANDINO_DSAL01E.Database.Activities;
using BERLANDINO_DSAL01E.Database.Main_DB_Classes;
using Lesson_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERLANDINO_DSAL01E.Lesson_5
{
    public partial class Login_Form_Database : Form
    {
        private String username1, password1, user_level;
        employee_dbconnection emp_db_connect = new employee_dbconnection();
        loginDb_dbconnections login_db_connect = new loginDb_dbconnections();
        private bool isPasswordVisible = false;

        private void cleartextboxes()
        {
            username_txtbox.Clear();
            username_txtbox.Focus();
            password_txtbox.Clear();
        }

        public Login_Form_Database()
        {
            login_db_connect.login_connString();
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            login_db_connect.login_sql =
            "SELECT pos_empRegTbl.emp_id, emp_fname, emp_surname, username, password, account_type, pos_terminal_no " +
            "FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id " +
            "WHERE username = '"+ username_txtbox.Text +"' AND password = '"+ password_txtbox.Text +"'";
            login_db_connect.login_cmd();
            login_db_connect.login_sqladapterSelect();
            login_db_connect.login_sqldatasetSelect();
            username1 = login_db_connect.login_sql_dataset.Tables[0].Rows[0][3].ToString();
            password1 = login_db_connect.login_sql_dataset.Tables[0].Rows[0][4].ToString();
            user_level = login_db_connect.login_sql_dataset.Tables[0].Rows[0][5].ToString();

            // User authentication
            if ((username1 == username_txtbox.Text) & (password1 == password_txtbox.Text))
            {
                // Admin Form
                if (user_level == "Administrator")
                {
                    MessageBox.Show("Welcome to Admin Page!");
                    MDI_ADMIN adminfrm = new MDI_ADMIN();
                    adminfrm.Show();
                    cleartextboxes();
                    this.Hide();
                }

                // POS Cashier 1
                if (user_level == "Cashier_1")
                {
                    MessageBox.Show("Welcome to POS Cashier 1 Page!");
                    POS_Cashier_1 adminfrm = new POS_Cashier_1();
                    adminfrm.Show();
                    cleartextboxes();
                    this.Hide();
                }

                // Sales Report 
                if (user_level == "Sales Reports")
                {
                    MessageBox.Show("Welcome to Sales Report Page!");
                    Sales_Report adminfrm = new Sales_Report();
                    adminfrm.Show();
                    cleartextboxes();
                    this.Hide();
                }

                // POS Cashier 2
                if (user_level == "Cashier_2")
                {
                    MessageBox.Show("Welcome to POS Cashier 2 Page!");
                    POS_Cashier_2 adminfrm = new POS_Cashier_2();
                    adminfrm.Show();
                    cleartextboxes();
                    this.Hide();
                }

                // Employee Registration
                if (user_level == "Employee Registration Manager")
                {
                    MessageBox.Show("Welcome to Employee Registration Page!");
                    Employee_Registration adminfrm = new Employee_Registration();
                    adminfrm.Show();
                    cleartextboxes();
                    this.Hide();
                }

                // Employee Registration Reports
                if (user_level == "Employee Registration Report")
                {
                    MessageBox.Show("Welcome to Employee Registration Reports Page!");
                    Employee_Report adminfrm = new Employee_Report();
                    adminfrm.Show();
                    cleartextboxes();
                    this.Hide();
                }

                // Payroll Registration
                if (user_level == "Payroll Registration Manager")
                {
                    MessageBox.Show("Welcome to Payroll_Registration Page!");
                    Payroll_Registration adminfrm = new Payroll_Registration();
                    adminfrm.Show();
                    cleartextboxes();
                    this.Hide();
                }

                // Payroll Registration Report
                if (user_level == "Payroll Registration Report")
                {
                    MessageBox.Show("Welcome to Payroll Reports Page!");
                    Payroll_Report adminfrm = new Payroll_Report();
                    adminfrm.Show();
                    cleartextboxes();
                    this.Hide();
                }

                // User Account Reports
                if (user_level == "User Account Report")
                {
                    MessageBox.Show("Welcome to User Account Reports Page!");
                    User_Account_Report adminfrm = new User_Account_Report();
                    adminfrm.Show();
                    cleartextboxes();
                    this.Hide();
                }

                // User Account Manager
                if (user_level == "User Account Manager")
                {
                    MessageBox.Show("Welcome to User Account Manager Page!");
                    User_Account_Registration adminfrm = new User_Account_Registration();
                    adminfrm.Show();
                    cleartextboxes();
                    this.Hide();
                }
        }
            else
                // In case of failed login
                MessageBox.Show("Invalid User Account!");
            username_txtbox.Clear();
            password_txtbox.Clear();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            // CLoses Program
            this.Close();
        }

        private void Login_Example_Load(object sender, EventArgs e)
        {
            // Maximize
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}

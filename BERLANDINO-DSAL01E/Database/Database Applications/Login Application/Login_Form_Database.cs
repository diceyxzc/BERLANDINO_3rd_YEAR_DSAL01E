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

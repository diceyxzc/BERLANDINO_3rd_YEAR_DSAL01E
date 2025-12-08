using BERLANDINO_DSAL01E.Database.Main_DB_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BERLANDINO_DSAL01E.Database.Activities
{
    public partial class User_Account_Report : Form
    {
        useraccount_db_connection useraccount_db_connect = new useraccount_db_connection();
        public User_Account_Report()
        {
            useraccount_db_connect.useraccount_connString();
            InitializeComponent();
        }

        private void PopulateOptionCombo()
        {
            option_combo.Items.Clear(); // clear any existing items

            option_combo.Items.Add("user_id");
            option_combo.Items.Add("employee_number");
            option_combo.Items.Add("surname");
            option_combo.Items.Add("firstname");
            option_combo.Items.Add("active");
            option_combo.Items.Add("deactivate");

            // Optionally, set default selection
            option_combo.SelectedIndex = 0; // selects the first item by default
        }

        private void user_account_select()
        {
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterSelect();
            useraccount_db_connect.useraccount_sqldatasetSelect();
            dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
        }

        private void cleartextboxes()
        {
            option_combo.Text = "";
            option_input_txtbox.Clear();
            option_combo.Focus();
        }

        private void cleartextboxes1()
        {
            option_input_txtbox.Clear();
            option_input_txtbox.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateOptionCombo();
            useraccount_db_connect.useraccount_sql =
            "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, " +
            "position, user_id, username, password, user_status, account_type FROM pos_empRegTbl " +
            "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
            user_account_select();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (option_combo.Text == "user_id")
            {
                useraccount_db_connect.useraccount_sql =
                "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, " +
                "position, user_id, username, password, user_status, account_type FROM pos_empRegTbl " +
                "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id " +
                "WHERE user_id = '"+ option_input_txtbox.Text +"'";
                user_account_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "employee_number")
            {
                useraccount_db_connect.useraccount_sql =
                "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, " +
                "position, user_id, username, password, user_status, account_type FROM pos_empRegTbl " +
                "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id " +
                "WHERE pos_empRegTbl.emp_id = '"+ option_input_txtbox.Text +"'";
                user_account_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "surname")
            {
                useraccount_db_connect.useraccount_sql =
                "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, " +
                "position, user_id, username, password, user_status, account_type FROM pos_empRegTbl " +
                "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id " +
                "WHERE emp_surname = '"+ option_input_txtbox.Text +"'";
                user_account_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "firstname")
            {
                useraccount_db_connect.useraccount_sql =
                "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, " +
                "position, user_id, username, password, user_status, account_type FROM pos_empRegTbl " +
                "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id " +
                "WHERE emp_fname = '"+ option_input_txtbox.Text +"'";
                user_account_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "active")
            {
                useraccount_db_connect.useraccount_sql =
                "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, " +
                "position, user_id, username, password, user_status, account_type FROM pos_empRegTbl " +
                "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id " +
                "WHERE user_status = '"+ option_input_txtbox.Text +"'";
                user_account_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "deactivate")
            {
                useraccount_db_connect.useraccount_sql =
                "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, " +
                "position, user_id, username, password, user_status, account_type FROM pos_empRegTbl " +
                "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id " +
                "WHERE user_status = '"+ option_input_txtbox.Text +"'";
                user_account_select();
                cleartextboxes1();
            }
            else
            {
                MessageBox.Show("No Available Record Found!");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            useraccount_db_connect.useraccount_sql =
            "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, " +
            "position, user_id, username, password, user_status, account_type FROM pos_empRegTbl " +
            "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
            user_account_select();
            cleartextboxes();
        }
    }
}

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
    public partial class Employee_Report : Form
    {
        payroll_dbconnection payroll_db_connect = new payroll_dbconnection();
        public Employee_Report()
        {
            payroll_db_connect.payroll_connString();
            InitializeComponent();
        }

        private void PopulateOptionCombo()
        {
            option_combo.Items.Clear(); // clear any existing items

            option_combo.Items.Add("employee_number");
            option_combo.Items.Add("surname");
            option_combo.Items.Add("firstname");
            option_combo.Items.Add("department");
            option_combo.Items.Add("designation");
            option_combo.Items.Add("zipcode");
            option_combo.Items.Add("province");
            option_combo.Items.Add("city");

            // Optionally, set default selection
            option_combo.SelectedIndex = 0; // selects the first item by default
        }

        private void emp_select()
        {
            payroll_db_connect.payroll_cmd();
            payroll_db_connect.payroll_sqladapterSelect();
            payroll_db_connect.payroll_sqldatasetSelect();
            dataGridView1.DataSource = payroll_db_connect.payroll_sql_dataset.Tables[0];
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
            payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl";
            emp_select();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (option_combo.Text == "employee_number")
            {
                payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE emp_id = '"+ option_input_txtbox.Text +"'";
                emp_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "surname")
            {
                payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE emp_surname = '"+ option_input_txtbox.Text +"'";
                emp_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "firstname")
            {
                payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE emp_fname = '"+ option_input_txtbox.Text +"'";
                emp_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "department")
            {
                payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE emp_department = '"+ option_input_txtbox.Text +"'";
                emp_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "designation")
            {
                payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE position = '"+ option_input_txtbox.Text +"'";
                emp_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "zipcode")
            {
                payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE add_zipcode = '"+ option_input_txtbox.Text +"'";
                emp_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "province")
            {
                payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE add_province = '"+ option_input_txtbox.Text +"'";
                emp_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "city")
            {
                payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl WHERE add_city = '"+ option_input_txtbox.Text +"'";
                emp_select();
                cleartextboxes1();
            }
            else
            {
                MessageBox.Show("No Available Record Found!");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            payroll_db_connect.payroll_sql = "SELECT * FROM pos_empRegTbl";
            emp_select();
            cleartextboxes();
        }
    }
}

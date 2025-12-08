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
    public partial class Payroll_Report : Form
    {
        payroll_dbconnection payroll_db_connect = new payroll_dbconnection();
        public Payroll_Report()
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
            option_combo.Items.Add("gross_income");
            option_combo.Items.Add("net_income");
            option_combo.Items.Add("pay_date");

            // Optionally, set default selection
            option_combo.SelectedIndex = 0; // selects the first item by default
        }

        private void payroll_select()
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
            payroll_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, " +
            "basic_rate_hr, basic_no_of_hrs_cutoff, basic_income_per_cutoff, " +
            "honorarium_rate_hr, honorarium_no_of_hrs_cutoff, honorarium_income_per_cutoff, " +
            "other_rate_hr, other_no_of_hrs_cutoff, other_income_per_cutoff, " +
            "sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, " +
            "sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, " +
            "gross_income, net_income, pay_date " +
            "FROM pos_empRegTbl INNER JOIN payrollTbl ON pos_empRegTbl.emp_id = payrollTbl.emp_id ";
            payroll_select();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (option_combo.Text == "employee_number")
            {
                payroll_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, " +
                "basic_rate_hr, basic_no_of_hrs_cutoff, basic_income_per_cutoff, " +
                "honorarium_rate_hr, honorarium_no_of_hrs_cutoff, honorarium_income_per_cutoff, " +
                "other_rate_hr, other_no_of_hrs_cutoff, other_income_per_cutoff, " +
                "sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, " +
                "sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, " +
                "gross_income, net_income, pay_date " +
                "FROM pos_empRegTbl INNER JOIN payrollTbl ON pos_empRegTbl.emp_id = payrollTbl.emp_id " +
                "WHERE pos_empRegTbl.emp_id = '"+ option_input_txtbox.Text +"'";
                payroll_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "surname")
            {
                payroll_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, " +
                "basic_rate_hr, basic_no_of_hrs_cutoff, basic_income_per_cutoff, " +
                "honorarium_rate_hr, honorarium_no_of_hrs_cutoff, honorarium_income_per_cutoff, " +
                "other_rate_hr, other_no_of_hrs_cutoff, other_income_per_cutoff, " +
                "sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, " +
                "sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, " +
                "gross_income, net_income, pay_date " +
                "FROM pos_empRegTbl INNER JOIN payrollTbl ON pos_empRegTbl.emp_id = payrollTbl.emp_id " +
                "WHERE pos_empRegTbl.emp_surname = '"+ option_input_txtbox.Text +"'";
                payroll_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "firstname")
            {
                payroll_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, " +
                "basic_rate_hr, basic_no_of_hrs_cutoff, basic_income_per_cutoff, " +
                "honorarium_rate_hr, honorarium_no_of_hrs_cutoff, honorarium_income_per_cutoff, " +
                "other_rate_hr, other_no_of_hrs_cutoff, other_income_per_cutoff, " +
                "sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, " +
                "sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, " +
                "gross_income, net_income, pay_date " +
                "FROM pos_empRegTbl INNER JOIN payrollTbl ON pos_empRegTbl.emp_id = payrollTbl.emp_id " +
                "WHERE pos_empRegTbl.emp_fname = '"+ option_input_txtbox.Text +"'";
                payroll_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "gross_income")
            {
                payroll_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, " +
                "basic_rate_hr, basic_no_of_hrs_cutoff, basic_income_per_cutoff, " +
                "honorarium_rate_hr, honorarium_no_of_hrs_cutoff, honorarium_income_per_cutoff, " +
                "other_rate_hr, other_no_of_hrs_cutoff, other_income_per_cutoff, " +
                "sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, " +
                "sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, " +
                "gross_income, net_income, pay_date " +
                "FROM pos_empRegTbl INNER JOIN payrollTbl ON pos_empRegTbl.emp_id = payrollTbl.emp_id " +
                "WHERE payrollTbl.gross_income = '"+ option_input_txtbox.Text +"'";
                payroll_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "net_income")
            {
                payroll_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, " +
                "basic_rate_hr, basic_no_of_hrs_cutoff, basic_income_per_cutoff, " +
                "honorarium_rate_hr, honorarium_no_of_hrs_cutoff, honorarium_income_per_cutoff, " +
                "other_rate_hr, other_no_of_hrs_cutoff, other_income_per_cutoff, " +
                "sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, " +
                "sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, " +
                "gross_income, net_income, pay_date " +
                "FROM pos_empRegTbl INNER JOIN payrollTbl ON pos_empRegTbl.emp_id = payrollTbl.emp_id " +
                "WHERE payrollTbl.net_income = '"+ option_input_txtbox.Text +"'";
                payroll_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "pay_date")
            {
                payroll_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, " +
                "basic_rate_hr, basic_no_of_hrs_cutoff, basic_income_per_cutoff, " +
                "honorarium_rate_hr, honorarium_no_of_hrs_cutoff, honorarium_income_per_cutoff, " +
                "other_rate_hr, other_no_of_hrs_cutoff, other_income_per_cutoff, " +
                "sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, " +
                "sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, " +
                "gross_income, net_income, pay_date " +
                "FROM pos_empRegTbl INNER JOIN payrollTbl ON pos_empRegTbl.emp_id = payrollTbl.emp_id " +
                "WHERE payrollTbl.pay_date = '"+ option_input_txtbox.Text +"'";
                payroll_select();
                cleartextboxes1();
            }
            else
            {
                MessageBox.Show("No Available Record Found!");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            payroll_db_connect.payroll_sql = "SELECT emp_fname, emp_mname, emp_surname, " +
            "basic_rate_hr, basic_no_of_hrs_cutoff, basic_income_per_cutoff, " +
            "honorarium_rate_hr, honorarium_no_of_hrs_cutoff, honorarium_income_per_cutoff, " +
            "other_rate_hr, other_no_of_hrs_cutoff, other_income_per_cutoff, " +
            "sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, " +
            "sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, " +
            "gross_income, net_income, pay_date " +
            "FROM pos_empRegTbl INNER JOIN payrollTbl ON pos_empRegTbl.emp_id = payrollTbl.emp_id ";
            payroll_select();
            cleartextboxes();
        }
    }
}

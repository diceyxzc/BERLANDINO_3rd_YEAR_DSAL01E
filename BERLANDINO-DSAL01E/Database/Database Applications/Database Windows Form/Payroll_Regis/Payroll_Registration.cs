using BERLANDINO_DSAL01E.Database.Class_Forms;
using BERLANDINO_DSAL01E.Database.Main_DB_Classes;
using BERLANDINO_DSAL01E.Lesson_8.Class_Forms;
using BERLANDINO_DSAL01E.Lesson_9.Class_Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BERLANDINO_DSAL01E
{
    public partial class Payroll_Registration : Form
    {
        // Access Payroll_Functions and shared Variables
        payroll_dbconnection payroll_db_connect = new payroll_dbconnection();
        DB_POS_Payroll_Class payroll_class = new DB_POS_Payroll_Class();
        Price_Variables variables = new Price_Variables();

        private void cleartextboxes()
        {
            employee_num_txtbox.Clear();
            first_name_txtbox.Clear();
            middle_name_txtbox.Clear();
            surname_txtbox.Clear();
            civil_status_txtbox.Clear();
            designation_txtbox.Clear();
            num_dependepts_txtbox.Clear();
            emp_status_txtbox.Clear();
            department_txtbox.Clear();
            basic_net_income_txtbox.Clear();
            basic_numhrs_txtbox.Clear();
            basic_rate_txtbox.Clear();
            hono_net_income_txtbox.Clear();
            hono_numhrs_txtbox.Clear();
            hono_rate_txtbox.Clear();
            other_net_income_txtbox.Clear();
            other_numhrs_txtbox.Clear();
            other_rate_txtbox.Clear();
            net_income_txtbox.Clear();
            gross_income_txtbox.Clear();
            sss_contrib_txtbox.Clear();
            pagibig_contrib_txtbox.Clear();
            philhealth_contrib_txtbox.Clear();
            tax_contrib_txtbox.Clear();
            sss_loan_txtbox.Clear();
            FSD_loan_txtbox.Clear();
            FS_loan_txtbox.Clear();
            other_loan_txtbox.Clear();
            sal_loan_txtbox.Clear();
            pagibig_loan_txtbox.Clear();
            total_deduc_txtbox.Clear();
            emp_pic.Image = Image.FromFile("C:\\Users\\fla10\\source\\repos\\diceyxzc\\BERLANDINO_3rd_YEAR_DSAL01E\\BERLANDINO-DSAL01E\\Resources\\default_user.jpg");
        }

        public Payroll_Registration()
        {
            payroll_db_connect.payroll_connString();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Disable textboxes for calculated values
            basic_net_income_txtbox.Enabled = false;
            hono_net_income_txtbox.Enabled = false;
            other_net_income_txtbox.Enabled = false;
            gross_income_txtbox.Enabled = false;
            net_income_txtbox.Enabled = false;
            total_deduc_txtbox.Enabled = false;
            sss_contrib_txtbox.Enabled = false;
            philhealth_contrib_txtbox.Enabled = false;
            pagibig_contrib_txtbox.Enabled = false;
            tax_contrib_txtbox.Enabled = false;

            // Initialize contributions and loans to 0.00
            sss_loan_txtbox.Text = "0.00";
            pagibig_loan_txtbox.Text = "0.00";
            FSD_loan_txtbox.Text = "0.00";
            FS_loan_txtbox.Text = "0.00";
            sal_loan_txtbox.Text = "0.00";
            other_loan_txtbox.Text = "0.00";

            // Setup other deductions combo box
            other_loan_combo.Text = "Select Other Deductions";
            other_loan_combo.Items.Add("Other 1");
            other_loan_combo.Items.Add("Other 2");
            other_loan_combo.Items.Add("Other 3");
            other_loan_combo.Items.Add("Other 4");

            // Hide hidden picture path textbox
            picpathTxtbox.Hide();
        }

        // Basic Pay computation
        private void basic_numhrs_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(basic_numhrs_txtbox.Text)) return;
            try
            {
                payroll_class.Basic_Convert_Textboxes(basic_rate_txtbox, basic_numhrs_txtbox, variables);
                basic_net_income_txtbox.Text = variables.basic_netincome.ToString("n");
            }
            catch
            {
                MessageBox.Show("Invalid input in Basic Hours. Please enter a number.");
                basic_numhrs_txtbox.Clear();
                basic_numhrs_txtbox.Focus();
            }
        }

        // Honorarium computation
        private void hono_numhrs_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(hono_numhrs_txtbox.Text)) return;
            try
            {
                payroll_class.Hono_Convert_Textboxes(hono_numhrs_txtbox, hono_rate_txtbox, variables);
                hono_net_income_txtbox.Text = variables.hono_netincome.ToString("n");
            }
            catch
            {
                MessageBox.Show("Invalid input in Honorarium Hours. Please enter a valid number.");
                hono_numhrs_txtbox.Clear();
                hono_numhrs_txtbox.Focus();
            }
        }

        // Other Income computation
        private void other_numhrs_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(other_numhrs_txtbox.Text)) return;
            try
            {
                payroll_class.Other_Convert_Textboxes(other_numhrs_txtbox, other_rate_txtbox, variables);
                other_net_income_txtbox.Text = variables.other_netincome.ToString("n");
                gross_income_txtbox.Text = variables.gross_income.ToString("n");
            }
            catch
            {
                MessageBox.Show("Invalid input in Other Income Hours. Please enter a valid number.");
                other_numhrs_txtbox.Clear();
                other_numhrs_txtbox.Focus();
            }
        }

        // Open File Dialog for Employee Image
        private void browse_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";
            openFileDialog.Title = "Select Employee Picture";
            openFileDialog.ShowDialog();

            variables.picpath = openFileDialog.FileName;
            picpathTxtbox.Text = variables.picpath;
            emp_pic.Image = Image.FromFile(openFileDialog.FileName);
        }

        // Clear specific fields for new employee
        private void new_button_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        // Print payslip to another form
        private void print_payslip_button_Click(object sender, EventArgs e)
        {
            L8_Activity3_Prnt print1 = new L8_Activity3_Prnt();
            print1.prntDisplayListbox.Items.AddRange(this.payslip_view_listbox.Items);
            print1.prntDisplayListbox.Font = new Font("Courier New", 12, FontStyle.Regular);
            print1.Show();
        }

        // Calculate total deductions and net income
        private void calc_button_Click(object sender, EventArgs e)
        {
            try
            {
                payroll_class.Converting_Compute_Textboxes(
                    sss_contrib_txtbox, pagibig_contrib_txtbox, philhealth_contrib_txtbox,
                    tax_contrib_txtbox, sss_loan_txtbox, pagibig_loan_txtbox, sal_loan_txtbox,
                    FS_loan_txtbox, FSD_loan_txtbox, other_loan_txtbox, variables
                );

                payroll_class.Compute_Total_And_Net(variables);

                total_deduc_txtbox.Text = variables.total_deduction.ToString("n");
                net_income_txtbox.Text = variables.net_income.ToString("n");
            }
            catch
            {
                MessageBox.Show("Invalid input detected. Please check all contribution and loan fields.");
            }
        }

        // Preview payslip in the listbox
        private void preview_payslip_Click(object sender, EventArgs e)
        {
            // Employee Information
            payroll_class.Display_Employee_Info(
                payslip_view_listbox,
                first_name_txtbox,
                middle_name_txtbox,
                surname_txtbox,
                designation_txtbox,
                emp_status_txtbox,
                department_txtbox,
                pay_date_picker
            );
            payslip_view_listbox.Items.Add(new string('-', 75));

            // Pay Rates
            payroll_class.Display_Pay_Rates(
                payslip_view_listbox,
                basic_numhrs_txtbox,
                basic_rate_txtbox,
                basic_net_income_txtbox,
                hono_numhrs_txtbox,
                hono_rate_txtbox,
                hono_net_income_txtbox,
                other_numhrs_txtbox,
                other_rate_txtbox,
                other_net_income_txtbox
            );
            payslip_view_listbox.Items.Add(new string('-', 75));

            // Contributions & Loans
            payroll_class.Display_Contrib_Loan(
                payslip_view_listbox,
                sss_contrib_txtbox,
                philhealth_contrib_txtbox,
                pagibig_contrib_txtbox,
                tax_contrib_txtbox,
                sss_loan_txtbox,
                pagibig_loan_txtbox,
                FSD_loan_txtbox,
                FS_loan_txtbox,
                sal_loan_txtbox,
                other_loan_txtbox
            );
            payslip_view_listbox.Items.Add(new string('-', 75));

            // Total Dues
            payroll_class.Display_Total_Dues(
                payslip_view_listbox,
                total_deduc_txtbox,
                gross_income_txtbox,
                net_income_txtbox
            );
        }

        // Close the form
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            payroll_db_connect.payroll_sql = "INSERT INTO payrollTbl " +
            "(basic_rate_hr, basic_no_of_hrs_cutoff, basic_income_per_cutoff, " +
            "honorarium_rate_hr, honorarium_no_of_hrs_cutoff, honorarium_income_per_cutoff, " +
            "other_rate_hr, other_no_of_hrs_cutoff, other_income_per_cutoff, " +
            "sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, " +
            "sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, " +
            "gross_income, net_income, emp_id, pay_date) " +
            "VALUES ('" + basic_rate_txtbox.Text + "', '" + basic_numhrs_txtbox.Text + "', '" + basic_net_income_txtbox.Text + "', " +
            "'" + hono_rate_txtbox.Text + "', '" + hono_numhrs_txtbox.Text + "', '" + hono_net_income_txtbox.Text + "', " +
            "'" + other_rate_txtbox.Text + "', '" + other_numhrs_txtbox.Text + "', '" + other_net_income_txtbox.Text + "', " +
            "'" + sss_contrib_txtbox.Text + "', '" + philhealth_contrib_txtbox.Text + "', '" + pagibig_contrib_txtbox.Text + "', '" + tax_contrib_txtbox.Text + "', " +
            "'" + sss_loan_txtbox.Text + "', '" + pagibig_loan_txtbox.Text + "', '" + FSD_loan_txtbox.Text + "', '" + FS_loan_txtbox.Text + "', '" + sal_loan_txtbox.Text + "', '" + other_loan_txtbox.Text + "', '" + total_deduc_txtbox.Text + "', " +
            "'" + gross_income_txtbox.Text + "', '" + net_income_txtbox.Text + "', '" + employee_num_txtbox.Text + "', '" + pay_date_picker.Text + "')";
            payroll_db_connect.payroll_cmd();
            payroll_db_connect.payroll_sqladapterInsert();
            cleartextboxes();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            payroll_db_connect.payroll_sql = "UPDATE payrollTbl SET " +
            "basic_rate_hr = '" + basic_rate_txtbox.Text + "', " +
            "basic_no_of_hrs_cutoff = '" + basic_numhrs_txtbox.Text + "', " +
            "basic_income_per_cutoff = '" + basic_net_income_txtbox.Text + "', " +
            "honorarium_rate_hr = '" + hono_rate_txtbox.Text + "', " +
            "honorarium_no_of_hrs_cutoff = '" + hono_numhrs_txtbox.Text + "', " +
            "honorarium_income_per_cutoff = '" + hono_net_income_txtbox.Text + "', " +
            "other_rate_hr = '" + other_rate_txtbox.Text + "', " +
            "other_no_of_hrs_cutoff = '" + other_numhrs_txtbox.Text + "', " +
            "other_income_per_cutoff = '" + other_net_income_txtbox.Text + "', " +
            "sss_contrib = '" + sss_contrib_txtbox.Text + "', " +
            "philhealth_contrib = '" + philhealth_contrib_txtbox.Text + "', " +
            "pagibig_contrib = '" + pagibig_contrib_txtbox.Text + "', " +
            "tax_contrib = '" + tax_contrib_txtbox.Text + "', " +
            "sss_loan = '" + sss_loan_txtbox.Text + "', " +
            "pagibig_loan = '" + pagibig_loan_txtbox.Text + "', " +
            "fac_savings_deposit = '" + FSD_loan_txtbox.Text + "', " +
            "fac_savings_loan = '" + FS_loan_txtbox.Text + "', " +
            "salary_loan = '" + sal_loan_txtbox.Text + "', " +
            "other_loans = '" + other_loan_txtbox.Text + "', " +
            "total_deductions = '" + total_deduc_txtbox.Text + "', " +
            "gross_income = '" + gross_income_txtbox.Text + "', " +
            "net_income = '" + net_income_txtbox.Text + "', " +
            "pay_date = '" + pay_date_picker.Text + "' " +
            "WHERE emp_id = '" + employee_num_txtbox.Text + "' AND pay_date = '"+ pay_date_picker.Text +"'";
            payroll_db_connect.payroll_cmd();
            payroll_db_connect.payroll_sqladapterUpdate();
            cleartextboxes();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            payroll_db_connect.payroll_sql = "DELETE FROM payrollTbl WHERE payrollTbl.emp_id = '"+ employee_num_txtbox.Text +"'";
            payroll_db_connect.payroll_cmd();
            payroll_db_connect.payroll_sqladapterDelete();
            cleartextboxes();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            payroll_db_connect.payroll_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_status, position, emp_no_of_dependents, " +
            "emp_work_status, emp_department, picpath, " +
            "basic_rate_hr, basic_no_of_hrs_cutoff, basic_income_per_cutoff, " +
            "honorarium_rate_hr, honorarium_no_of_hrs_cutoff, honorarium_income_per_cutoff, " +
            "other_rate_hr, other_no_of_hrs_cutoff, other_income_per_cutoff, " +
            "sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, " +
            "sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, " +
            "gross_income, net_income, pay_date " +
            "FROM pos_empRegTbl INNER JOIN payrollTbl ON pos_empRegTbl.emp_id = payrollTbl.emp_id " +
            "WHERE payrollTbl.emp_id = '" + employee_num_txtbox.Text + "' AND payrollTbl.pay_date = '" + pay_date_picker.Text + "'";
            payroll_db_connect.payroll_cmd();
            payroll_db_connect.payroll_sqladapterSelect();
            payroll_db_connect.payroll_sqldatasetSelect();

            // Employee Information
            first_name_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][1].ToString();
            middle_name_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][2].ToString();
            surname_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][3].ToString();
            civil_status_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][4].ToString();
            designation_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][5].ToString();
            emp_status_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][6].ToString();
            num_dependepts_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][7].ToString();
            department_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][8].ToString();
            picpathTxtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][9].ToString();
            emp_pic.Image = Image.FromFile(picpathTxtbox.Text);

            // Basic Pay
            basic_rate_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][10].ToString();
            basic_numhrs_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][11].ToString();
            basic_net_income_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][12].ToString();

            // Honorarium
            hono_rate_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][13].ToString();
            hono_numhrs_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][14].ToString();
            hono_net_income_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][15].ToString();

            // Other Income
            other_rate_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][16].ToString();
            other_numhrs_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][17].ToString();
            other_net_income_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][18].ToString();

            // Contributions
            sss_contrib_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][19].ToString();
            philhealth_contrib_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][20].ToString();
            pagibig_contrib_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][21].ToString();
            tax_contrib_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][22].ToString();

            // Loans
            sss_loan_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][23].ToString();
            pagibig_loan_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][24].ToString();
            FSD_loan_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][25].ToString();
            FS_loan_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][26].ToString();
            sal_loan_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][27].ToString();
            other_loan_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][28].ToString();

            // Totals
            total_deduc_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][29].ToString();
            gross_income_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][30].ToString();
            net_income_txtbox.Text = payroll_db_connect.payroll_sql_dataset.Tables[0].Rows[0][31].ToString();
        }
    }
}

using BERLANDINO_DSAL01E.Lesson_8.Class_Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BERLANDINO_DSAL01E
{
    public partial class L9_Activity3 : Form
    {
        #region Class-Level Instances
        // Access Payroll_Functions and shared Variables
        Payroll_Functions functions_payroll = new Payroll_Functions();
        Variables variables = new Variables();
        #endregion

        #region Form Initialization
        public L9_Activity3()
        {
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
        #endregion

        #region Payroll Calculation Handlers
        // Basic Pay computation
        private void basic_numhrs_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(basic_numhrs_txtbox.Text)) return;
            try
            {
                functions_payroll.Basic_Convert_Textboxes(basic_rate_txtbox, basic_numhrs_txtbox, variables);
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
                functions_payroll.Hono_Convert_Textboxes(hono_numhrs_txtbox, hono_rate_txtbox, variables);
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
                functions_payroll.Other_Convert_Textboxes(other_numhrs_txtbox, other_rate_txtbox, variables);
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
        #endregion

        #region File Handling
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
        #endregion

        #region Form Actions
        // Clear all input fields (Cancel)
        private void cancel_button_Click(object sender, EventArgs e)
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
            pagibig_loan_txtbox.Clear();
            total_deduc_txtbox.Clear();
        }

        // Clear specific fields for new employee
        private void new_button_Click(object sender, EventArgs e)
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
            basic_numhrs_txtbox.Clear();
            basic_rate_txtbox.Clear();
            hono_numhrs_txtbox.Clear();
            hono_rate_txtbox.Clear();
            other_numhrs_txtbox.Clear();
            other_rate_txtbox.Clear();
            sss_contrib_txtbox.Clear();
            pagibig_contrib_txtbox.Clear();
            philhealth_contrib_txtbox.Clear();
            tax_contrib_txtbox.Clear();
            sss_loan_txtbox.Clear();
            pagibig_loan_txtbox.Clear();
        }

        // Print payslip to another form
        private void print_payslip_button_Click(object sender, EventArgs e)
        {
            L9_Activity3_Prnt print1 = new L9_Activity3_Prnt();
            print1.prntDisplayListbox.Items.AddRange(this.payslip_view_listbox.Items);
            print1.prntDisplayListbox.Font = new Font("Courier New", 12, FontStyle.Regular);
            print1.Show();
        }

        // Calculate total deductions and net income
        private void calc_button_Click(object sender, EventArgs e)
        {
            try
            {
                functions_payroll.Converting_Compute_Textboxes(
                    sss_contrib_txtbox, pagibig_contrib_txtbox, philhealth_contrib_txtbox,
                    tax_contrib_txtbox, sss_loan_txtbox, pagibig_loan_txtbox, sal_loan_txtbox,
                    FS_loan_txtbox, FSD_loan_txtbox, other_loan_txtbox, variables
                );

                functions_payroll.Compute_Total_And_Net(variables);

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
            functions_payroll.Display_Employee_Info(
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
            functions_payroll.Display_Pay_Rates(
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
            functions_payroll.Display_Contrib_Loan(
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
            functions_payroll.Display_Total_Dues(
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
        #endregion
    }
}

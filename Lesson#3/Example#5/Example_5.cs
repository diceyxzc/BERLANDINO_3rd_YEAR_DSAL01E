using Lesson_3.Example_5;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson_3
{
    public partial class Example5 : Form
    {
        // Declaration of Global Variables
        private string picpath;
        private Double basic_netincome = 0.00,
            basic_numhrs = 0.00,
            basic_rate = 0.00,
            hono_netincome = 0.00,
            hono_numhrs = 0.00,
            hono_rate = 0.00,
            other_netincome = 0.00,
            other_numhrs = 0.00,
            other_rate = 0.00;
        private Double netincome = 0.00,
            gross_income = 0.00,
            sss_contrib = 0.00,
            pagibig_contrib = 0.00,
            philhealth_contrib = 0.00,
            tax_contrib = 0.00;
        private Double sss_loan = 0.00,
            pagibig_loan = 0.00,
            salary_loan = 0.00,
            salary_savings = 0.00,
            faculty_sav_loan = 0.00,
            other_deduction = 0.00,
            total_deduction = 0.00,
            total_contrib = 0.00,
            total_loan = 0.00;

        private void other_numhrs_txtbox_TextChanged(object sender, EventArgs e)
        {
            other_numhrs = Convert.ToDouble(other_numhrs_txtbox.Text);
            other_rate = Convert.ToDouble(other_rate_txtbox.Text);
            other_netincome = other_numhrs * other_rate;
            other_net_income_txtbox.Text = other_netincome.ToString("n");
            gross_income = basic_netincome + hono_netincome + other_netincome;
            gross_income_txtbox.Text = gross_income.ToString("n");
        }

        private void hono_numhrs_txtbox_TextChanged(object sender, EventArgs e)
        {
            hono_numhrs = Convert.ToDouble(hono_numhrs_txtbox.Text);
            hono_rate = Convert.ToDouble(hono_rate_txtbox.Text);
            hono_netincome = hono_numhrs * hono_rate;
            hono_net_income_txtbox.Text = hono_netincome.ToString("n");
        }

        private void basic_numhrs_txtbox_TextChanged_1(object sender, EventArgs e)
        {
            basic_rate = Convert.ToDouble(basic_rate_txtbox.Text);
            basic_numhrs = Double.Parse(basic_numhrs_txtbox.Text);
            basic_netincome = basic_numhrs * basic_rate;
            basic_net_income_txtbox.Text = basic_netincome.ToString("n");
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";
            openFileDialog.Title = "Select Employee Picture";
            openFileDialog.ShowDialog();
            picpath = openFileDialog.FileName;
            picpathTxtbox.Text = picpath;
            emp_pic.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
        }

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
        }

        private void print_payslip_button_Click(object sender, EventArgs e)
        {
            // codes for calling the other form to the current form 
            Example_5_Prnt print1 = new Example_5_Prnt();

            // codes for displaying the contents of the listbox from other form to the current form
            print1.prntDisplayListbox.Items.AddRange(this.payslip_view_listbox.Items);

            // code for displaying the other form
            print1.Show();
        }

        public Example5()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Codes for disabling
            basic_net_income_txtbox.Enabled = false;
            hono_net_income_txtbox.Enabled = false;
            other_net_income_txtbox.Enabled = false;
            gross_income_txtbox.Enabled = false;
            net_income_txtbox.Enabled = false;
            total_deduc_txtbox.Enabled = false;
            sss_contrib_txtbox.Text = "0.00";
            philhealth_contrib_txtbox.Text = "0.00";
            pagibig_contrib_txtbox.Text = "0.00";
            tax_contrib_txtbox.Text = "0.00";
            sss_loan_txtbox.Text = "0.00";
            pagibig_loan_txtbox.Text = "0.00";
            FSD_loan_txtbox.Text = "0.00";
            FS_loan_txtbox.Text = "0.00";
            sal_loan_txtbox.Text = "0.00";
            other_loan_txtbox.Text = "0.00";
            other_loan_combo.Text = "Select Other Deductions";
            other_loan_combo.Items.Add("Other 1");
            other_loan_combo.Items.Add("Other 2");
            other_loan_combo.Items.Add("Other 3");
            other_loan_combo.Items.Add("Other 4");
            picpathTxtbox.Hide();
        }

        private void calc_button_Click(object sender, EventArgs e)
        {
            /* codes for converting input data from textboxes as string to numeric
               codes for putting data from textboxes to variables */
            sss_contrib = Convert.ToDouble(sss_contrib_txtbox.Text);
            pagibig_contrib = Convert.ToDouble(pagibig_contrib_txtbox.Text);
            philhealth_contrib = Convert.ToDouble(philhealth_contrib_txtbox.Text);
            tax_contrib = Convert.ToDouble(tax_contrib_txtbox.Text);
            sss_loan = Convert.ToDouble(sss_loan_txtbox.Text);
            pagibig_loan = Convert.ToDouble(pagibig_contrib_txtbox.Text);
            salary_loan = Convert.ToDouble(sal_loan_txtbox.Text);
            faculty_sav_loan = Convert.ToDouble(FS_loan_txtbox.Text);
            salary_savings = Convert.ToDouble(FSD_loan_txtbox.Text);
            other_deduction = Convert.ToDouble(other_loan_txtbox.Text);

            // formula to compute the desired data to be computed
            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
            total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salary_savings + other_deduction;
            total_deduction = total_contrib + total_loan;

            // codes for converting numeric data to string and displayed it inside the textboxes
            total_deduc_txtbox.Text = total_deduction.ToString("n");
            netincome = gross_income - total_deduction;
            net_income_txtbox.Text = netincome.ToString("n");
        }

        private void preview_payslip_Click(object sender, EventArgs e)
        {
            // payslip_view_listbox.Items.Add("");
            payslip_view_listbox.Items.Add("Employee Number: " + "" + employee_num_txtbox.Text);
            payslip_view_listbox.Items.Add("First Name: " + "" + first_name_txtbox.Text);
            payslip_view_listbox.Items.Add("Middle Name: " + "" + middle_name_txtbox.Text);
            payslip_view_listbox.Items.Add("Surname: " + "" + surname_txtbox.Text);
            payslip_view_listbox.Items.Add("Designation: " + "" + designation_txtbox.Text);
            payslip_view_listbox.Items.Add("Employee Status: " + "" + emp_status_txtbox.Text);
            payslip_view_listbox.Items.Add("Department: " + "" + department_txtbox.Text);
            payslip_view_listbox.Items.Add("Pay Date: " + "" + pay_date_picker.Text);

            payslip_view_listbox.Items.Add(new string('-', 75));

            payslip_view_listbox.Items.Add("BP Num. of Hrs.: " + "" + basic_numhrs_txtbox.Text);
            payslip_view_listbox.Items.Add("BP Rate / Hr.: " + "" + basic_rate_txtbox.Text);
            payslip_view_listbox.Items.Add("Basic Pay Income: " + "" + basic_net_income_txtbox.Text);
            payslip_view_listbox.Items.Add("HI Num. of Hrs.: " + "" + hono_numhrs_txtbox.Text);
            payslip_view_listbox.Items.Add("HI Rate / Hr.: " + "" + hono_rate_txtbox.Text);
            payslip_view_listbox.Items.Add("Honorarium Income: " + "" + hono_net_income_txtbox.Text);
            payslip_view_listbox.Items.Add("OTI Num. of Hrs.: " + "" + other_numhrs_txtbox.Text);
            payslip_view_listbox.Items.Add("OTI Rate / Hr.: " + "" + other_rate_txtbox.Text);
            payslip_view_listbox.Items.Add("Other Income: " + "" + other_net_income_txtbox.Text);

            payslip_view_listbox.Items.Add(new string('-', 75));

            payslip_view_listbox.Items.Add("SSS Contribution: " + "" + sss_contrib_txtbox.Text);
            payslip_view_listbox.Items.Add("Philhealth Contribution: " + "" + philhealth_contrib_txtbox.Text);
            payslip_view_listbox.Items.Add("Pagibig Contribution: " + "" + pagibig_contrib_txtbox.Text);
            payslip_view_listbox.Items.Add("Tax Contribution: " + "" + tax_contrib_txtbox.Text);
            payslip_view_listbox.Items.Add("SSS Loan: " + "" + sss_loan_txtbox.Text);
            payslip_view_listbox.Items.Add("Pagibig Loan: " + "" + pagibig_loan_txtbox.Text);
            payslip_view_listbox.Items.Add("Faculty Savings Deposit: " + "" + FSD_loan_txtbox.Text);
            payslip_view_listbox.Items.Add("Faculty Savings Loan: " + "" + FSD_loan_txtbox.Text);
            payslip_view_listbox.Items.Add("Salary Loan: " + "" + sal_loan_txtbox.Text);
            payslip_view_listbox.Items.Add("Other Loan: " + "" + other_loan_txtbox.Text);

            payslip_view_listbox.Items.Add(new string('-', 75));

            payslip_view_listbox.Items.Add("Total Deduction: " + "" + total_deduc_txtbox.Text);
            payslip_view_listbox.Items.Add("Gross Income: " + "" + gross_income_txtbox.Text);
            payslip_view_listbox.Items.Add("Net Income: " + "" + net_income_txtbox.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

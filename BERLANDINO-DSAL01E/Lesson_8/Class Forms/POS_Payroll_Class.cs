using BERLANDINO_DSAL01E.Lesson_8.Class_Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BERLANDINO_DSAL01E.Lesson_9.Class_Forms
{
    internal class POS_Payroll_Class
    {
        Variables variables = new Variables();

        #region Payroll Class 1
        // Sets clears quantity textbox and focuses on it for user input
        public void focus_quantity
            (
            TextBox qty_txtbox
            )
        {
            qty_txtbox.Clear();
            qty_txtbox.Focus();
        }

        // Functions for Ordering Systems
        public void SetPriceItemValue
            (
            TextBox item_name_txtbox,
            TextBox price_txtbox,
            string item_name,
            string price
            )
        {
            item_name_txtbox.Text = item_name;
            price_txtbox.Text = price;
        }
        // Function for getting quantity and price from textboxes and converting them to appropriate data types
        public void qty_price_convert
            (
            TextBox itemquantitytxtbox,
            TextBox priceTextbox,
            Variables vars
            )
        {
            vars.quantity = Convert.ToInt32(itemquantitytxtbox.Text);
            vars.price = Convert.ToDouble(priceTextbox.Text);
        }

        // Function for computing discount amount and discounted total 
        public void computation_Formula_and_DislpayData
            (
            TextBox discountamounttxtbox,
            TextBox discountedtxtbox,
            Variables vars
            )
        {
            vars.discounted_amt = (vars.quantity * vars.price - vars.discount_amt);
            discountamounttxtbox.Text = vars.discount_amt.ToString("n");
            discountedtxtbox.Text = vars.discounted_amt.ToString("n");
        }

        // Function for converting total values from textboxes to appropriate data types
        public void convert_total
            (
            TextBox qty_txtbox,
            TextBox discountamounttxtbox,
            TextBox discountedtxtbox,
            TextBox cashrenderedtxtbox,
            Variables vars
            )
        {
            vars.quantity = Convert.ToInt32(qty_txtbox.Text);
            vars.discount_amt = Convert.ToDouble(discountamounttxtbox.Text);
            vars.discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
            vars.cash_given = Convert.ToDouble(cashrenderedtxtbox.Text);
        }

        // Function for calculating total values
        public void calculate_total
            (
            Variables vars
            )
        {
            vars.qty_total += vars.quantity;
            vars.discount_totalgiven += vars.discount_amt;
            vars.discounted_total += vars.discounted_amt;
            vars.change = vars.cash_given - vars.discounted_amt;
        }
        #endregion

        #region Payroll Class 2        
        // Aligns bundles and in ListBox for better readability
        public void AddToDisplayList_Others
            (
            object textSource,
            TextBox valueBox,
            ListBox listBox
            )
        {
            string labelText = "";

            // Handle different control types gracefully
            if (textSource is CheckBox cb)
                labelText = cb.Text;
            else if (textSource is RadioButton rb)
                labelText = rb.Text;
            else if (textSource is string s)
                labelText = s;
            else
                labelText = textSource?.ToString() ?? "";

            // Format and add to ListBox
            string line = string.Format("{0,-34}{1,10}", labelText, valueBox.Text);
            listBox.Items.Add(line);
        }

        // Aligns Cechkboxes in ListBox for better readability
        public void AddToDisplayList
            (
            CheckBox item_name,
            TextBox priceBox,
            ListBox displayListBox
            )
        {
            displayListBox.Font = new Font("Courier New", 12, FontStyle.Regular);
            string itemLine = string.Format("{0,-34}{1,10}", item_name.Text, priceBox.Text);
            displayListBox.Items.Add(itemLine);
        }

        // Sets price and discount values in textboxes
        public void price_dics_func
            (
            TextBox disc_txtbox,
            TextBox price_txtbox,
            string discountamount,
            string price
            )
        {
            price_txtbox.Text = price;
            disc_txtbox.Text = discountamount;
        }

        // Calculates 15% discount for bundles A and B
        public void bundle_ab_comp
            (TextBox price_txtbox,
            TextBox disc_txtbox,
            Variables vars
            )
        {
            variables.price_total = Convert.ToDouble(price_txtbox.Text);
            variables.disc_amnt = variables.price_total * 0.15;
            disc_txtbox.Text = variables.disc_amnt.ToString("n");
        }

        // Converts textbox values to numeric types for calculations
        public void price_qty_disc_convert
            (
            TextBox price_txtbox,
            TextBox qty_txtbox,
            TextBox disc_txtbox,
            Variables vars
            )
        {
            vars.price = Convert.ToDouble(price_txtbox.Text);
            vars.quantity = Convert.ToInt32(qty_txtbox.Text);
            vars.disc_amnt = Convert.ToDouble(disc_txtbox.Text);
        }

        // Calculates total amount, cash given, and change
        public void total_amt_cash_given
            (
            TextBox totalamounttxtbox,
            TextBox cashgiventextbox,
            Variables vars
            )
        {
            vars.total_amount = (vars.quantity * vars.price) - vars.disc_amnt;
            totalamounttxtbox.Text = vars.total_amount.ToString("n");
            vars.cash_given = Convert.ToDouble(cashgiventextbox.Text);
            vars.change = vars.cash_given - vars.total_amount;
        }
        #endregion

        #region Payroll Class
        // Convert basic pay input fields
        public void Basic_Convert_Textboxes(TextBox basic_rate_txtbox, TextBox basic_numhrs_txtbox, Variables vars)
        {
            vars.basic_rate = Convert.ToDouble(basic_rate_txtbox.Text);
            vars.basic_numhrs = Convert.ToDouble(basic_numhrs_txtbox.Text);
            vars.basic_netincome = vars.basic_numhrs * vars.basic_rate;
        }

        // Convert honorarium input fields
        public void Hono_Convert_Textboxes(TextBox hono_numhrs_txtbox, TextBox hono_rate_txtbox, Variables vars)
        {
            vars.hono_numhrs = Convert.ToDouble(hono_numhrs_txtbox.Text);
            vars.hono_rate = Convert.ToDouble(hono_rate_txtbox.Text);
            vars.hono_netincome = vars.hono_numhrs * vars.hono_rate;
        }

        // Convert other income input fields
        public void Other_Convert_Textboxes(TextBox other_numhrs_txtbox, TextBox other_rate_txtbox, Variables vars)
        {
            vars.other_numhrs = Convert.ToDouble(other_numhrs_txtbox.Text);
            vars.other_rate = Convert.ToDouble(other_rate_txtbox.Text);
            vars.other_netincome = vars.other_numhrs * vars.other_rate;

            // Compute gross income
            vars.gross_income = vars.basic_netincome + vars.hono_netincome + vars.other_netincome;
        }

        // Convert contribution and loan inputs
        public void Converting_Compute_Textboxes(
            TextBox sss_contrib_txtbox, TextBox pagibig_contrib_txtbox, TextBox philhealth_contrib_txtbox,
            TextBox tax_contrib_txtbox, TextBox sss_loan_txtbox, TextBox pagibig_loan_txtbox, TextBox sal_loan_txtbox,
            TextBox FS_loan_txtbox, TextBox FSD_loan_txtbox, TextBox other_loan_txtbox, Variables vars)
        {
            vars.sss_loan = Convert.ToDouble(sss_loan_txtbox.Text);
            vars.pagibig_loan = Convert.ToDouble(pagibig_loan_txtbox.Text);
            vars.salary_loan = Convert.ToDouble(sal_loan_txtbox.Text);
            vars.faculty_sav_loan = Convert.ToDouble(FS_loan_txtbox.Text);
            vars.salary_savings = Convert.ToDouble(FSD_loan_txtbox.Text);
            vars.other_deduction = Convert.ToDouble(other_loan_txtbox.Text);

            // SSS Contribution
            if (vars.gross_income < 5250)
            {
                vars.sss_contrib = 250.00;
            }
            else
            {
                vars.sss_contrib = 250.00;
                for (double i = 5250; i <= vars.gross_income && vars.sss_contrib < 1750; i += 500)
                {
                    vars.sss_contrib += 25;
                }
            }
            sss_contrib_txtbox.Text = vars.sss_contrib.ToString("n");

            // Pag-IBIG Contribution
            if (vars.gross_income <= 1500)
            {
                vars.pagibig_contrib = vars.gross_income * 0.01;
            }
            else if (vars.gross_income > 1500)
            {
                vars.pagibig_contrib = vars.gross_income * 0.02;
            }
            if (vars.pagibig_contrib > 200)
            {
                vars.pagibig_contrib = 200;
            }
            pagibig_contrib_txtbox.Text = vars.pagibig_contrib.ToString("n");


            // PhilHealth Contribution
            if (vars.gross_income <= 10000)
            {
                vars.philhealth_contrib = 0.00;
            }
            else if (vars.gross_income > 10000 && vars.gross_income <= 100000)
            {
                vars.philhealth_contrib = vars.gross_income * 0.05;
            }
            else
            {
                vars.philhealth_contrib = 0.00;
            }
            philhealth_contrib_txtbox.Text = vars.philhealth_contrib.ToString("n");

            // Tax Contribution Calculations
            if (vars.gross_income <= 250000 / 24)
            {
                vars.tax_contrib = 0.00;
            }
            else if (vars.gross_income > 10416.67 && vars.gross_income <= 16666.67)
            {
                vars.tax_contrib = (((vars.gross_income * 24) - 250000) * 0.15) / 24;
            }
            else if (vars.gross_income > 16666.67 && vars.gross_income <= 33333.33)
            {
                vars.tax_contrib = ((((vars.gross_income * 24) - 400000) * 0.20) + 30000) / 24;
            }
            else if (vars.gross_income > 33333.33 && vars.gross_income <= 83333.33)
            {
                vars.tax_contrib = ((((vars.gross_income * 24) - 800000) * 0.25) + 130000) / 24;
            }
            else if (vars.gross_income > 83333.33 && vars.gross_income <= 333333.33)
            {
                vars.tax_contrib = ((((vars.gross_income * 24) - 2000000) * 0.30) + 490000) / 24;
            }
            else
            {
                vars.tax_contrib = ((((vars.gross_income * 24) - 8000000) * 0.35) + 2410000) / 24;
            }
            tax_contrib_txtbox.Text = vars.tax_contrib.ToString("n");
        }

        // Compute totals (deductions, net income)
        public void Compute_Total_And_Net(Variables vars)
        {
            vars.total_deduction =
                vars.sss_contrib + vars.pagibig_contrib + vars.philhealth_contrib +
                vars.tax_contrib + vars.sss_loan + vars.pagibig_loan +
                vars.salary_loan + vars.faculty_sav_loan +
                vars.salary_savings + vars.other_deduction;

            vars.net_income = vars.gross_income - vars.total_deduction;
        }

        // Display Employee Information
        public void Display_Employee_Info(ListBox listBox,
            TextBox first_name_txtbox, TextBox middle_name_txtbox, TextBox surname_txtbox,
            TextBox designation_txtbox, TextBox emp_status_txtbox, TextBox department_txtbox, DateTimePicker pay_date_picker)
        {
            listBox.Font = new Font("Courier New", 10, FontStyle.Regular);
            int labelWidth = 30; // uniform spacing for left column
            listBox.Items.Add($"Calvin Payroll Summary Receipt");
            listBox.Items.Add(new string('-', 75));
            listBox.Items.Add($"{"First Name:".PadRight(labelWidth)}{first_name_txtbox.Text}");
            listBox.Items.Add($"{"Middle Name:".PadRight(labelWidth)}{middle_name_txtbox.Text}");
            listBox.Items.Add($"{"Surname:".PadRight(labelWidth)}{surname_txtbox.Text}");
            listBox.Items.Add($"{"Designation:".PadRight(labelWidth)}{designation_txtbox.Text}");
            listBox.Items.Add($"{"Employee Status:".PadRight(labelWidth)}{emp_status_txtbox.Text}");
            listBox.Items.Add($"{"Department:".PadRight(labelWidth)}{department_txtbox.Text}");
            listBox.Items.Add($"{"Pay Date:".PadRight(labelWidth)}{pay_date_picker.Value:MM/dd/yyyy}");
        }

        // Display Pay Rates
        public void Display_Pay_Rates(ListBox listBox,
            TextBox basic_numhrs_txtbox, TextBox basic_rate_txtbox, TextBox basic_net_income_txtbox,
            TextBox hono_numhrs_txtbox, TextBox hono_rate_txtbox, TextBox hono_net_income_txtbox,
            TextBox other_numhrs_txtbox, TextBox other_rate_txtbox, TextBox other_net_income_txtbox)
        {
            listBox.Font = new Font("Courier New", 10, FontStyle.Regular);
            int labelWidth = 30;
            listBox.Items.Add($"{"Basic Num. of Hrs.:".PadRight(labelWidth)}{basic_numhrs_txtbox.Text}");
            listBox.Items.Add($"{"Basic Rate/Hr.:".PadRight(labelWidth)}{basic_rate_txtbox.Text}");
            listBox.Items.Add($"{"Basic Pay Income:".PadRight(labelWidth)}{basic_net_income_txtbox.Text}");
            listBox.Items.Add(new string('-', 75));
            listBox.Items.Add($"{"Honorarium Hrs.:".PadRight(labelWidth)}{hono_numhrs_txtbox.Text}");
            listBox.Items.Add($"{"Honorarium Rate/Hr.:".PadRight(labelWidth)}{hono_rate_txtbox.Text}");
            listBox.Items.Add($"{"Honorarium Income:".PadRight(labelWidth)}{hono_net_income_txtbox.Text}");
            listBox.Items.Add(new string('-', 75));
            listBox.Items.Add($"{"Other Income Hrs.:".PadRight(labelWidth)}{other_numhrs_txtbox.Text}");
            listBox.Items.Add($"{"Other Rate/Hr.:".PadRight(labelWidth)}{other_rate_txtbox.Text}");
            listBox.Items.Add($"{"Other Income:".PadRight(labelWidth)}{other_net_income_txtbox.Text}");
        }

        // Display Contributions and Loans
        public void Display_Contrib_Loan(ListBox listBox,
            TextBox sss_contrib_txtbox, TextBox philhealth_contrib_txtbox, TextBox pagibig_contrib_txtbox,
            TextBox tax_contrib_txtbox, TextBox sss_loan_txtbox, TextBox pagibig_loan_txtbox,
            TextBox FSD_loan_txtbox, TextBox FS_loan_txtbox, TextBox sal_loan_txtbox, TextBox other_loan_txtbox)
        {
            listBox.Font = new Font("Courier New", 10, FontStyle.Regular);
            int labelWidth = 30;
            listBox.Items.Add($"{"SSS Contribution:".PadRight(labelWidth)}{sss_contrib_txtbox.Text}");
            listBox.Items.Add($"{"PhilHealth Contribution:".PadRight(labelWidth)}{philhealth_contrib_txtbox.Text}");
            listBox.Items.Add($"{"Pag-IBIG Contribution:".PadRight(labelWidth)}{pagibig_contrib_txtbox.Text}");
            listBox.Items.Add($"{"Tax Contribution:".PadRight(labelWidth)}{tax_contrib_txtbox.Text}");
            listBox.Items.Add(new string('-', 75));
            listBox.Items.Add($"{"SSS Loan:".PadRight(labelWidth)}{sss_loan_txtbox.Text}");
            listBox.Items.Add($"{"Pag-IBIG Loan:".PadRight(labelWidth)}{pagibig_loan_txtbox.Text}");
            listBox.Items.Add($"{"Faculty Savings Deposit:".PadRight(labelWidth)}{FSD_loan_txtbox.Text}");
            listBox.Items.Add($"{"Faculty Savings Loan:".PadRight(labelWidth)}{FS_loan_txtbox.Text}");
            listBox.Items.Add($"{"Salary Loan:".PadRight(labelWidth)}{sal_loan_txtbox.Text}");
            listBox.Items.Add($"{"Other Loan:".PadRight(labelWidth)}{other_loan_txtbox.Text}");
        }

        // Display Totals
        public void Display_Total_Dues(ListBox listBox,
            TextBox total_deduc_txtbox, TextBox gross_income_txtbox, TextBox net_income_txtbox)
        {
            listBox.Font = new Font("Courier New", 10, FontStyle.Regular);
            int labelWidth = 30;
            listBox.Items.Add($"{"Total Deduction:".PadRight(labelWidth)}{total_deduc_txtbox.Text}");
            listBox.Items.Add($"{"Gross Income:".PadRight(labelWidth)}{gross_income_txtbox.Text}");
            listBox.Items.Add($"{"Net Income:".PadRight(labelWidth)}{net_income_txtbox.Text}");
        }
        #endregion Class
    }
}

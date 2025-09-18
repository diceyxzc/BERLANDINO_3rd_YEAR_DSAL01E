using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_3.Exam
{
    public partial class Prelim_Lesson_5 : Form
    {

        public Prelim_Lesson_5()
        {
            InitializeComponent();
        }

        // Declaration of Global Variables
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
            pagibig_contrib = 200.00,
            philhealth_contrib = 0.00,
            tax_contrib = 0.00;

        private Double sss_loan = 0.00,
            pagibig_loan = 0.00,
            salary_loan = 0.00,
            faculty_sav_loan = 0.00,
            faculty_sav_dep = 0.00,
            other_deduction = 0.00,
            total_deduction = 0.00,
            total_contrib = 0.00,
            total_loan = 0.00;

        private void Form1_Load(object sender, EventArgs e)
        {
            sss_contrib_txtbox.Enabled = false;
            philhealth_contrib_txtbox.Enabled = false;
            pagibig_contrib_txtbox.Enabled = false;
            tax_contrib_txtbox.Enabled = false;
            basic_net_income_txtbox.Enabled = false;
            hono_net_income_txtbox.Enabled = false;
            other_net_income_txtbox.Enabled = false;
            net_income_txtbox.Enabled = false;
            gross_income_txtbox.Enabled = false;
            total_deduc_txtbox.Enabled = false;
        }

        private void gross_income_btn_Click(object sender, EventArgs e)
        {
            // convert into numeric variables
            basic_rate = Convert.ToDouble(basic_rate_txtbox.Text);
            basic_numhrs = Double.Parse(basic_numhrs_txtbox.Text);
            basic_netincome = basic_numhrs * basic_rate;
            basic_net_income_txtbox.Text = basic_netincome.ToString("n");

            hono_numhrs = Convert.ToDouble(hono_numhrs_txtbox.Text);
            hono_rate = Convert.ToDouble(hono_rate_txtbox.Text);
            hono_netincome = hono_numhrs * hono_rate;
            hono_net_income_txtbox.Text = hono_netincome.ToString("n");

            other_numhrs = Convert.ToDouble(other_numhrs_txtbox.Text);
            other_rate = Convert.ToDouble(other_rate_txtbox.Text);
            other_netincome = other_numhrs * other_rate;
            other_net_income_txtbox.Text = other_netincome.ToString("n");

            gross_income = basic_netincome + hono_netincome + other_netincome;
            gross_income_txtbox.Text = gross_income.ToString("n");

            pagibig_contrib_txtbox.Text = pagibig_contrib.ToString("n");

            // tax contrib
            if (gross_income <= 250000 / 24)
            {
                tax_contrib = 0.00;
            }
            else if (gross_income > 10416.67 && gross_income <= 16666.67)
            {
                tax_contrib = (((gross_income * 24) - 250000) * 0.20) / 24;
            }
            else if (gross_income > 16666.67 && gross_income <= 33333.33)
            {
                tax_contrib = ((((gross_income * 24) - 400000) * 0.25) + 30000) / 24;
            }
            else if (gross_income > 33333.33 && gross_income <= 83333.33)
            {
                tax_contrib = ((((gross_income * 24) - 800000) * 0.30) + 130000) / 24;
            }
            else if (gross_income > 83333.33 && gross_income <= 333333.33)
            {
                tax_contrib = ((((gross_income * 24) - 2000000) * 0.32) + 490000) / 24;
            }
            else
            {
                tax_contrib = ((((gross_income * 24) - 8000000) * 0.35) + 2410000) / 24;
            }
            tax_contrib_txtbox.Text = tax_contrib.ToString("N");


            // philhealth contrib
            if (gross_income <= 10000)
            {
                philhealth_contrib = 0.00;
            }
            else if (gross_income > 10000 && gross_income <= 100000)
            {
                philhealth_contrib = gross_income * 0.05;
            }
            else
            {
                philhealth_contrib = 0.00;
            }
            philhealth_contrib_txtbox.Text = philhealth_contrib.ToString("n");

            // sss contrib
            if (gross_income < 5250)
            {
                sss_contrib = 760.00;
            }
            else if (gross_income >= 5250 && gross_income < 5750)
            {
                sss_contrib = 835.00;
            }
            else if (gross_income >= 5750 && gross_income < 6250)
            {
                sss_contrib = 910.00;
            }
            else if (gross_income >= 6250 && gross_income < 6750)
            {
                sss_contrib = 985.00;
            }
            else if (gross_income >= 6750 && gross_income < 7250)
            {
                sss_contrib = 1060.00;
            }
            else if (gross_income >= 7250 && gross_income < 7750)
            {
                sss_contrib = 1135.00;
            }
            else if (gross_income >= 7750 && gross_income < 8250)
            {
                sss_contrib = 1210.00;
            }
            else if (gross_income >= 8250 && gross_income < 8750)
            {
                sss_contrib = 1285.00;
            }
            else if (gross_income >= 8750 && gross_income < 9250)
            {
                sss_contrib = 1360.00;
            }
            else if (gross_income >= 9250 && gross_income < 9750)
            {
                sss_contrib = 1435.00;
            }
            else if (gross_income >= 9750 && gross_income < 10250)
            {
                sss_contrib = 1510.00;
            }
            else if (gross_income >= 10250 && gross_income < 10750)
            {
                sss_contrib = 1585.00;
            }
            else if (gross_income >= 10750 && gross_income < 11250)
            {
                sss_contrib = 1660.00;
            }
            else if (gross_income >= 11250 && gross_income < 11750)
            {
                sss_contrib = 1735.00;
            }
            else if (gross_income >= 11750 && gross_income < 12250)
            {
                sss_contrib = 1810.00;
            }
            else if (gross_income >= 12250 && gross_income < 12750)
            {
                sss_contrib = 1885.00;
            }
            else if (gross_income >= 12750 && gross_income < 13250)
            {
                sss_contrib = 1960.00;
            }
            else if (gross_income >= 13250 && gross_income < 13750)
            {
                sss_contrib = 2035.00;
            }
            else if (gross_income >= 13750 && gross_income < 14250)
            {
                sss_contrib = 2110.00;
            }
            else if (gross_income >= 14250 && gross_income < 14750)
            {
                sss_contrib = 2185.00;
            }
            else if (gross_income >= 14750 && gross_income < 15250)
            {
                sss_contrib = 2280.00;
            }
            else if (gross_income >= 15250 && gross_income < 15750)
            {
                sss_contrib = 2355.00;
            }
            else if (gross_income >= 15750 && gross_income < 16250)
            {
                sss_contrib = 2430.00;
            }
            else if (gross_income >= 16250 && gross_income < 16750)
            {
                sss_contrib = 2505.00;
            }
            else if (gross_income >= 16750 && gross_income < 17250)
            {
                sss_contrib = 2580.00;
            }
            else if (gross_income >= 17250 && gross_income < 17750)
            {
                sss_contrib = 2655.00;
            }
            else if (gross_income >= 17750 && gross_income < 18250)
            {
                sss_contrib = 2730.00;
            }
            else if (gross_income >= 18250 && gross_income < 18750)
            {
                sss_contrib = 2785.00;
            }
            else if (gross_income >= 18750 && gross_income < 19250)
            {
                sss_contrib = 2880.00;
            }
            else if (gross_income >= 19250 && gross_income < 19750)
            {
                sss_contrib = 2955.00;
            }
            else if (gross_income >= 19750 && gross_income < 20250)
            {
                sss_contrib = 3030.00;
            }
            else if (gross_income >= 20250 && gross_income < 20750)
            {
                sss_contrib = 3105.00;
            }
            else if (gross_income >= 20750 && gross_income < 21250)
            {
                sss_contrib = 3180.00;
            }
            else if (gross_income >= 21250 && gross_income < 21750)
            {
                sss_contrib = 3255.00;
            }
            else if (gross_income >= 21750 && gross_income < 22250)
            {
                sss_contrib = 3330.00;
            }
            else if (gross_income >= 22250 && gross_income < 22750)
            {
                sss_contrib = 3405.00;
            }
            else if (gross_income >= 22750 && gross_income < 23250)
            {
                sss_contrib = 3480.00;
            }
            else if (gross_income >= 23250 && gross_income < 23750)
            {
                sss_contrib = 3555.00;
            }
            else if (gross_income >= 23750 && gross_income < 24250)
            {
                sss_contrib = 3630.00;
            }
            else if (gross_income >= 24250 && gross_income < 24750)
            {
                sss_contrib = 3705.00;
            }
            else if (gross_income >= 24750 && gross_income < 25250)
            {
                sss_contrib = 3780.00;
            }
            else if (gross_income >= 25250 && gross_income < 25750)
            {
                sss_contrib = 3855.00;
            }
            else if (gross_income >= 25750 && gross_income < 26250)
            {
                sss_contrib = 3930.00;
            }
            else if (gross_income >= 26250 && gross_income < 26750)
            {
                sss_contrib = 4005.00;
            }
            else if (gross_income >= 26750 && gross_income < 27250)
            {
                sss_contrib = 4080.00;
            }
            else if (gross_income >= 27250 && gross_income < 27750)
            {
                sss_contrib = 4155.00;
            }
            else if (gross_income >= 27750 && gross_income < 28250)
            {
                sss_contrib = 4230.00;
            }
            else if (gross_income >= 28250 && gross_income < 28750)
            {
                sss_contrib = 4305.00;
            }
            else if (gross_income >= 28750 && gross_income < 29250)
            {
                sss_contrib = 4380.00;
            }
            else if (gross_income >= 29250 && gross_income < 29750)
            {
                sss_contrib = 4455.00;
            }
            else if (gross_income >= 29750 && gross_income < 30250)
            {
                sss_contrib = 4530.00;
            }
            else if (gross_income >= 30250 && gross_income < 30750)
            {
                sss_contrib = 4605.00;
            }
            else if (gross_income >= 30750 && gross_income < 31250)
            {
                sss_contrib = 4680.00;
            }
            else if (gross_income >= 31250 && gross_income < 31750)
            {
                sss_contrib = 4755.00;
            }
            else if (gross_income >= 31750 && gross_income < 32250)
            {
                sss_contrib = 4830.00;
            }
            else if (gross_income >= 32250 && gross_income < 32750)
            {
                sss_contrib = 4905.00;
            }
            else if (gross_income >= 32750 && gross_income < 33250)
            {
                sss_contrib = 4980.00;
            }
            else if (gross_income >= 33250 && gross_income < 33750)
            {
                sss_contrib = 5055.00;
            }
            else if (gross_income >= 33750 && gross_income < 34250)
            {
                sss_contrib = 5130.00;
            }
            else if (gross_income >= 34250 && gross_income < 34750)
            {
                sss_contrib = 5205.00;
            }
            else
            {
                sss_contrib = 5280.00;
            }
            sss_contrib_txtbox.Text = sss_contrib.ToString("n");

            /* codes for converting input data from textboxes as string to numeric
               codes for putting data from textboxes to variables */
            sss_contrib = Convert.ToDouble(sss_contrib_txtbox.Text);
            philhealth_contrib = Convert.ToDouble(philhealth_contrib_txtbox.Text);
            tax_contrib = Convert.ToDouble(tax_contrib_txtbox.Text);

            sss_loan = Convert.ToDouble(sss_loan_txtbox.Text);
            pagibig_loan = Convert.ToDouble(pagibig_loan_txtbox.Text);
            faculty_sav_loan = Convert.ToDouble(FS_loan_txtbox.Text);
            faculty_sav_dep = Convert.ToDouble(FSD_loan_txtbox.Text);
            salary_loan = Convert.ToDouble(sal_loan_txtbox.Text);
            other_deduction = Convert.ToDouble(other_loan_txtbox.Text);

            total_loan = sss_loan + pagibig_loan + faculty_sav_loan + faculty_sav_dep + salary_loan + other_deduction;
            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
            total_deduction = total_contrib + total_loan;
            total_deduc_txtbox.Text = total_deduction.ToString("n");
        }

        private void net_income_button_Click(object sender, EventArgs e)
        {
            // formula to compute the desired data to be computed
            netincome = gross_income - total_deduction;
            net_income_txtbox.Text = netincome.ToString("n");
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Prelim_Exam_Prnt print = new Prelim_Exam_Prnt();
            print.employee_code.Text = employee_num_txtbox.Text;
            print.employee_name.Text = first_name_txtbox.Text + " " + middle_name_txtbox.Text + " " + surname_txtbox.Text;
            print.department_name.Text = department_txtbox.Text;
            print.cut_off_name.Text = pay_date_picker.Text;
            print.pay_period.Text = pay_date_picker.Text;
            print.basic_pay.Text = basic_net_income_txtbox.Text;
            print.overtime_pay.Text = other_net_income_txtbox.Text;
            print.hono_pay.Text = hono_net_income_txtbox.Text;
            print.tax_deduc.Text = tax_contrib_txtbox.Text;
            print.sss_contrib.Text = sss_contrib_txtbox.Text;
            print.hdmf_contrib.Text = pagibig_contrib_txtbox.Text;
            print.philhealth_contrib.Text = philhealth_contrib_txtbox.Text;
            print.total_earnings.Text = gross_income_txtbox.Text;
            print.total_deductions.Text = total_deduc_txtbox.Text;
            print.gross_earnings.Text = gross_income_txtbox.Text;
            print.deductions.Text = total_deduc_txtbox.Text;
            print.net_pay.Text = net_income_txtbox.Text;
            print.Show();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            basic_numhrs_txtbox.Clear();
            basic_rate_txtbox.Clear();
            hono_numhrs_txtbox.Clear();
            hono_rate_txtbox.Clear();
            other_numhrs_txtbox.Clear();
            other_rate_txtbox.Clear();
            sss_loan_txtbox.Clear();
            pagibig_loan_txtbox.Clear();
            FS_loan_txtbox.Clear();
            FSD_loan_txtbox.Clear();
            sal_loan_txtbox.Clear();
            other_loan_txtbox.Clear();
            employee_num_txtbox.Clear();
            qual_dependents_txtbox.Clear();
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            employee_num_txtbox.Clear();
            department_txtbox.Clear();
            designation_txtbox.Clear();
            first_name_txtbox.Clear();
            middle_name_txtbox.Clear();
            surname_txtbox.Clear();
            civil_status_txtbox.Clear();
            qual_dependents_txtbox.Clear();
            emp_status_txtbox.Clear();
            basic_numhrs_txtbox.Clear();
            basic_rate_txtbox.Clear();
            hono_numhrs_txtbox.Clear();
            hono_rate_txtbox.Clear();
            other_numhrs_txtbox.Clear();
            other_rate_txtbox.Clear();
            sss_loan_txtbox.Clear();
            pagibig_loan_txtbox.Clear();
            FS_loan_txtbox.Clear();
            FSD_loan_txtbox.Clear();
            sal_loan_txtbox.Clear();
            other_loan_txtbox.Clear();
            employee_num_txtbox.Clear();
            qual_dependents_txtbox.Clear();
            basic_net_income_txtbox.Clear();
            hono_net_income_txtbox.Clear();
            other_net_income_txtbox.Clear();
            gross_income_txtbox.Clear();
            net_income_txtbox.Clear();
            sss_contrib_txtbox.Clear();
            philhealth_contrib_txtbox.Clear();
            pagibig_contrib_txtbox.Clear();
            tax_contrib_txtbox.Clear();
            total_deduc_txtbox.Clear();
        }
    }
}

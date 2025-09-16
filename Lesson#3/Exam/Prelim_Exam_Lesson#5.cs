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
            salary_savings = 0.00,
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
            first_name_txtbox.Enabled = false;
            middle_name_txtbox.Enabled = false;
            surname_txtbox.Enabled = false;
            civil_status_txtbox.Enabled = false;
            emp_status_txtbox.Enabled = false;
            net_income_txtbox.Enabled = false;
            gross_income_txtbox.Enabled = false;
            total_deduc_txtbox.Enabled = false;

        }

        private void net_income_button_Click(object sender, EventArgs e)
        {
            /* codes for converting input data from textboxes as string to numeric
               codes for putting data from textboxes to variables */
            sss_loan = Convert.ToDouble(sss_loan_txtbox.Text);
            pagibig_loan = Convert.ToDouble(pagibig_contrib_txtbox.Text);
            salary_loan = Convert.ToDouble(sal_loan_txtbox.Text);
            faculty_sav_loan = Convert.ToDouble(FS_loan_txtbox.Text);
            faculty_sav_dep = Convert.ToDouble(FSD_loan_txtbox.Text);
            salary_savings = Convert.ToDouble(FSD_loan_txtbox.Text);
            other_deduction = Convert.ToDouble(other_loan_txtbox.Text);

            // formula to compute the desired data to be computed
            total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + faculty_sav_dep + salary_savings + other_deduction;
            total_deduc_txtbox.Text = total_loan.ToString("n");
        }

        private void gross_income_btn_Click(object sender, EventArgs e)
        {
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
            if (gross_income <= 250000)
            {
                tax_contrib = 0.00;
            }
            else if (gross_income > 250000 && gross_income <= 400000)
            {
                tax_contrib = (gross_income - 250000) * 0.15;
            }
            else if (gross_income > 400000 && gross_income <= 800000)
            {
                tax_contrib = (gross_income - 400000) * .20 + 22500;
            }
            else if (gross_income > 800000 && gross_income <= 2000000)
            {
                tax_contrib = (gross_income - 800000) * 0.25 + 102500;
            }
            else if (gross_income > 2000000 && gross_income <= 8000000)
            {
                tax_contrib = (gross_income - 2000000) * 0.30 + 402500;
            }
            else
            {
                tax_contrib = (gross_income - 8000000) + 2202500;
            }
            tax_contrib_txtbox.Text = tax_contrib.ToString("n");

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
                sss_contrib = 2560.00;
            }
            else if (gross_income >= 17250 && gross_income < 17750)
            {
                sss_contrib = 2635.00;
            }
            else if (gross_income >= 17750 && gross_income < 18250)
            {
                sss_contrib = 2710.00;
            }
            else if (gross_income >= 18250 && gross_income < 18750)
            {
                sss_contrib = 2785.00;
            }
            else if (gross_income >= 18750 && gross_income < 19250)
            {
                sss_contrib = 2860.00;
            }
            else if (gross_income >= 19250 && gross_income < 19750)
            {
                sss_contrib = 2935.00;
            }
            else if (gross_income >= 19750 && gross_income < 20250)
            {
                sss_contrib = 3010.00;
            }
            else if (gross_income >= 20250 && gross_income < 20750)
            {
                sss_contrib = 3085.00;
            }
            else if (gross_income >= 20750 && gross_income < 21250)
            {
                sss_contrib = 3160.00;
            }
            else if (gross_income >= 21250 && gross_income < 21750)
            {
                sss_contrib = 3235.00;
            }
            else if (gross_income >= 21750 && gross_income < 22250)
            {
                sss_contrib = 3310.00;
            }
            else if (gross_income >= 22250 && gross_income < 22750)
            {
                sss_contrib = 3385.00;
            }
            else if (gross_income >= 22750 && gross_income < 23250)
            {
                sss_contrib = 3460.00;
            }
            else if (gross_income >= 23250 && gross_income < 23750)
            {
                sss_contrib = 3535.00;
            }
            else if (gross_income >= 23750 && gross_income < 24250)
            {
                sss_contrib = 3610.00;
            }
            else if (gross_income >= 24250 && gross_income < 24750)
            {
                sss_contrib = 3685.00;
            }
            else if (gross_income >= 24750 && gross_income < 25250)
            {
                sss_contrib = 3760.00;
            }
            else if (gross_income >= 25250 && gross_income < 25750)
            {
                sss_contrib = 3835.00;
            }
            else if (gross_income >= 25750 && gross_income < 26250)
            {
                sss_contrib = 3910.00;
            }
            else if (gross_income >= 26250 && gross_income < 26750)
            {
                sss_contrib = 3985.00;
            }
            else if (gross_income >= 26750 && gross_income < 27250)
            {
                sss_contrib = 4060.00;
            }
            else if (gross_income >= 27250 && gross_income < 27750)
            {
                sss_contrib = 4135.00;
            }
            else if (gross_income >= 27750 && gross_income < 28250)
            {
                sss_contrib = 4210.00;
            }
            else if (gross_income >= 28250 && gross_income < 28750)
            {
                sss_contrib = 4285.00;
            }
            else if (gross_income >= 28750 && gross_income < 29250)
            {
                sss_contrib = 4360.00;
            }
            else if (gross_income >= 29250 && gross_income < 29750)
            {
                sss_contrib = 4435.00;
            }
            else if (gross_income >= 29750 && gross_income < 30250)
            {
                sss_contrib = 4510.00;
            }
            else if (gross_income >= 30250 && gross_income < 30750)
            {
                sss_contrib = 4585.00;
            }
            else if (gross_income >= 30750 && gross_income < 31250)
            {
                sss_contrib = 4660.00;
            }
            else if (gross_income >= 31250 && gross_income < 31750)
            {
                sss_contrib = 4735.00;
            }
            else if (gross_income >= 31750 && gross_income < 32250)
            {
                sss_contrib = 4810.00;
            }
            else if (gross_income >= 32250 && gross_income < 32750)
            {
                sss_contrib = 4885.00;
            }
            else if (gross_income >= 32750 && gross_income < 33250)
            {
                sss_contrib = 4960.00;
            }
            else if (gross_income >= 33250 && gross_income < 33750)
            {
                sss_contrib = 5035.00;
            }
            else if (gross_income >= 33750 && gross_income < 34250)
            {
                sss_contrib = 5110.00;
            }
            else if (gross_income >= 34250 && gross_income < 34750)
            {
                sss_contrib = 5185.00;
            }
            else // ₱35,000 and above
            {
                sss_contrib = 5260.00;
            }
        }

        private void net_income_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }


        public Prelim_Lesson_5()
        {
            InitializeComponent();
        }

        private void first_name_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void other_numhrs_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hono_numhrs_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void basic_numhrs_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

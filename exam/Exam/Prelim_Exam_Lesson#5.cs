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
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

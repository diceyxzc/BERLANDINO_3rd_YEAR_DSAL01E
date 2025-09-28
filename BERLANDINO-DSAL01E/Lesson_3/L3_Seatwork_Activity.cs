using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERLANDINO_DSAL01E.Lesson_3
{
    public partial class L3_Seatwork_Activity : Form
    {
        public L3_Seatwork_Activity()
        {
            InitializeComponent();
            program_dropbox.Items.Add("Bachelor of Science in Architecture");
            program_dropbox.Items.Add("Bachelor of Science in Aeronautical Engineering");
            program_dropbox.Items.Add("Bachelor of Science in Civil Engineering");
            program_dropbox.Items.Add("Bachelor of Science in Computer Engineering");
            program_dropbox.Items.Add("Bachelor of Science in Electrical Engineering");
            program_dropbox.Items.Add("Bachelor of Science in Electronics Engineering");
            program_dropbox.Items.Add("Bachelor of Science in Industrial Engineering");
            program_dropbox.Items.Add("Bachelor of Science in Mechanical Engineering");

            year_lvl_dropbox.Items.Add("1st Year");
            year_lvl_dropbox.Items.Add("2nd Year");
            year_lvl_dropbox.Items.Add("3rd Year");
            year_lvl_dropbox.Items.Add("4th Year");

            scholar_dropbox.Items.Add("Full");
            scholar_dropbox.Items.Add("Partial");
            scholar_dropbox.Items.Add("None");

            mode_dropbox.Items.Add("Installment");
        }

        private void L3_Seatwork_Activity_Load(object sender, EventArgs e)
        {
            creditUnit1.Enabled = false;
            creditUnit2.Enabled = false;
            creditUnit3.Enabled = false;
            creditUnit4.Enabled = false;
            creditUnit5.Enabled = false;
            creditUnit6.Enabled = false;
            creditUnit7.Enabled = false;
            total_credit_units_txtbox.Enabled = false;

            tuition_fee_txtbox.Enabled = false;
            misc_txtbox.Enabled = false;
            comp_fee_txtbox.Enabled = false;
            sap_fee_txtbox.Enabled = false;
            cisco_fee_txtbox.Enabled = false;
            booklet_fee_txtbox.Enabled = false;
            total_other_fee_txtbox.Enabled = false;

            total_tuition_misc_txtbox.Enabled = false;
            mode_payment_txtbox.Enabled = false;
            installment_charge_txtbox.Enabled = false;
            downpayment_txtbox.Enabled = false;
            installment1_txtbox.Enabled = false;
            installment2_txtbox.Enabled = false;
            installment3_txtbox.Enabled = false;
            amount_due_txtbox.Enabled = false;
            grand_total_txtbox.Enabled = false;
            discount_txtbox.Enabled = false;
        }

        private void lecUnit1_TextChanged(object sender, EventArgs e)
        {
            if (lecUnit1.Text == "") return;
            labUnit1.Focus();
        }

        private void lecUnit2_TextChanged(object sender, EventArgs e)
        {
            if (lecUnit2.Text == "") return;
            labUnit2.Focus();
        }

        private void lecUnit3_TextChanged(object sender, EventArgs e)
        {
            if (lecUnit3.Text == "") return;
            labUnit3.Focus();
        }

        private void lecUnit4_TextChanged(object sender, EventArgs e)
        {
            if (lecUnit4.Text == "") return;
            labUnit4.Focus();
        }

        private void lecUnit5_TextChanged(object sender, EventArgs e)
        {
            if (lecUnit5.Text == "") return;
            labUnit5.Focus();
        }

        private void lecUnit6_TextChanged(object sender, EventArgs e)
        {
            if (lecUnit6.Text == "") return;
            labUnit6.Focus();
        }

        private void lecUnit7_TextChanged(object sender, EventArgs e)
        {
            if (lecUnit7.Text == "") return;
            labUnit7.Focus();
        }

        int creditUnit_1, lecunit_1, labunit_1;
        private void labUnit1_TextChanged(object sender, EventArgs e)
        {
            if (labUnit1.Text == "") return;
            lecunit_1 = Convert.ToInt32(lecUnit1.Text);
            labunit_1 = Convert.ToInt32(labUnit1.Text);
            creditUnit_1 = lecunit_1 + labunit_1;

            creditUnit1.Text = creditUnit_1.ToString();
            lecUnit2.Focus();
        }

        int creditUnit_2, lecunit_2, labunit_2;
        private void labUnit2_TextChanged(object sender, EventArgs e)
        {
            if (labUnit2.Text == "") return;
            lecunit_2 = Convert.ToInt32(lecUnit2.Text);
            labunit_2 = Convert.ToInt32(labUnit2.Text);
            creditUnit_2 = lecunit_2 + labunit_2;

            creditUnit2.Text = creditUnit_2.ToString();
            lecUnit3.Focus();
        }

        int creditUnit_3, lecunit_3, labunit_3;
        private void labUnit3_TextChanged(object sender, EventArgs e)
        {
            if (labUnit3.Text == "") return;
            lecunit_3 = Convert.ToInt32(lecUnit3.Text);
            labunit_3 = Convert.ToInt32(labUnit3.Text);
            creditUnit_3 = lecunit_3 + labunit_3;

            creditUnit3.Text = creditUnit_3.ToString();
            lecUnit4.Focus();
        }

        int creditUnit_4, lecunit_4, labunit_4;
        private void labUnit4_TextChanged(object sender, EventArgs e)
        {
            if (labUnit4.Text == "") return;
            lecunit_4 = Convert.ToInt32(lecUnit4.Text);
            labunit_4 = Convert.ToInt32(labUnit4.Text);
            creditUnit_4 = lecunit_4 + labunit_4;

            creditUnit4.Text = creditUnit_4.ToString();
            lecUnit5.Focus();
        }

        int creditUnit_5, lecunit_5, labunit_5;
        private void labUnit5_TextChanged(object sender, EventArgs e)
        {
            if (labUnit5.Text == "") return;
            lecunit_5 = Convert.ToInt32(lecUnit5.Text);
            labunit_5 = Convert.ToInt32(labUnit5.Text);
            creditUnit_5 = lecunit_5 + labunit_5;

            creditUnit5.Text = creditUnit_5.ToString();
            lecUnit6.Focus();
        }

        int creditUnit_6, lecunit_6, labunit_6;
        private void labUnit6_TextChanged(object sender, EventArgs e)
        {
            if (labUnit6.Text == "") return;
            lecunit_6 = Convert.ToInt32(lecUnit6.Text);
            labunit_6 = Convert.ToInt32(labUnit6.Text);
            creditUnit_6 = lecunit_6 + labunit_6;

            creditUnit6.Text = creditUnit_6.ToString();
            lecUnit7.Focus();
        }

        int creditUnit_7, lecunit_7, labunit_7;
        private void labUnit7_TextChanged(object sender, EventArgs e)
        {
            if (labUnit7.Text == "") return;
            lecunit_7 = Convert.ToInt32(lecUnit7.Text);
            labunit_7 = Convert.ToInt32(labUnit7.Text);
            creditUnit_7 = lecunit_7 + labunit_7;

            creditUnit7.Text = creditUnit_7.ToString();
        }

        private double lec_fee = 1500.00,
            sap_fee = 2000.00,
            lab_fee = 2500.00,
            cisco_fee = 4500.00,
            booklet_fee = 450.00,
            downpayment_fee = 8000.00;
        private void compute_fees_btn_Click(object sender, EventArgs e)
        {
            int total_units, total_lec_units, total_lab_units;
            double tuition_fee, comp_fee, other_fee, tuition_other_fees, installment_fee;

            total_units = creditUnit_1 + creditUnit_2 + creditUnit_3 + creditUnit_4 + creditUnit_5 + creditUnit_6 + creditUnit_7;
            total_credit_units_txtbox.Text = total_units.ToString();

            total_lec_units = lecunit_1 + lecunit_2 + lecunit_3 + lecunit_4 + lecunit_5 + lecunit_6 + lecunit_7;
            tuition_fee = lec_fee * total_lec_units;
            tuition_fee_txtbox.Text = tuition_fee.ToString("n");

            total_lab_units = labunit_1 + labunit_2 + labunit_3 + labunit_4 + labunit_5 + labunit_6 + labunit_7;
            comp_fee = total_lab_units * lab_fee;
            comp_fee_txtbox.Text = comp_fee.ToString("n");
            sap_fee_txtbox.Text = sap_fee.ToString("n");
            cisco_fee_txtbox.Text = cisco_fee.ToString("n");
            booklet_fee_txtbox.Text = booklet_fee.ToString("n");

            other_fee = comp_fee + sap_fee + cisco_fee + booklet_fee;
            misc_txtbox.Text = other_fee.ToString("n");
            total_other_fee_txtbox.Text = other_fee.ToString("n");

            tuition_other_fees = tuition_fee + other_fee;
            total_tuition_misc_txtbox.Text = tuition_other_fees.ToString("n");

            mode_payment_txtbox.Text = mode_dropbox.Text;
            downpayment_txtbox.Text = downpayment_fee.ToString("n");

            installment_fee = tuition_other_fees / 3;
            installment1_txtbox.Text = installment_fee.ToString("n");
            installment2_txtbox.Text = installment_fee.ToString("n");
            installment3_txtbox.Text = installment_fee.ToString("n");
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_student_info_btn_Click(object sender, EventArgs e)
        {
            student_name_txtbox.Clear();
            student_num_txtbox.Clear();
            program_dropbox.Text = "";
            year_lvl_dropbox.Text = "";
            scholar_dropbox.Text = "";
            mode_dropbox.Text = "";
        }

        private void clear_sched_btn_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();

            // lecUnit textboxes
            lecUnit1.Clear();
            lecUnit2.Clear();
            lecUnit3.Clear();
            lecUnit4.Clear();
            lecUnit5.Clear();
            lecUnit6.Clear();
            lecUnit7.Clear();

            // labUnit textboxes
            labUnit1.Clear();
            labUnit2.Clear();
            labUnit3.Clear();
            labUnit4.Clear();
            labUnit5.Clear();
            labUnit6.Clear();
            labUnit7.Clear();

            // creditUnit textboxes
            creditUnit1.Clear();
            creditUnit2.Clear();
            creditUnit3.Clear();
            creditUnit4.Clear();
            creditUnit5.Clear();
            creditUnit6.Clear();
            creditUnit7.Clear();
            total_credit_units_txtbox.Clear();

            textBox46.Clear();
            textBox47.Clear();
            textBox48.Clear();
            textBox49.Clear();
            textBox50.Clear();
            textBox51.Clear();
            textBox52.Clear();
            textBox53.Clear();
            textBox54.Clear();
            textBox55.Clear();
            textBox56.Clear();
            textBox57.Clear();
            textBox58.Clear();
            textBox59.Clear();
            textBox60.Clear();
            textBox61.Clear();
            textBox62.Clear();
            textBox63.Clear();
            textBox64.Clear();
            textBox65.Clear();
            textBox66.Clear();

        }
    }
}

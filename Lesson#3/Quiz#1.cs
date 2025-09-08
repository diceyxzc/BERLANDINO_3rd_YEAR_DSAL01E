using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Student_Information_System
{
    public partial class Lesson_2_Activity : Form
    {

        private void Lesson_2_Activity_Load(object sender, EventArgs e)
        {
            total_num_units_txt.Enabled = false;
            total_tuition_txt.Enabled = false;
            credit_units_list.Enabled = false;
            total_misc_txt.Enabled = false;
            total_tuition_fees_txt.Enabled = false;
            credit_units_txt.Enabled = false;

            
            total_tuition_txt2.Enabled = false;
            total_misc_txt2.Enabled = false;
            cisco_lab_txt2.Enabled = false;
            comp_lab_fee_txt.Enabled = false;
            total_other_fees_txt.Enabled = false;
            exam_booklet_txt2.Enabled = false;
            total_num_units_txt2.Enabled = false;
            total_tuition_fees_txt2.Enabled = false;
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            student_picture.Image = Image.FromFile(browse_txtbox.Text);
        }

        public Lesson_2_Activity()
        {
            InitializeComponent();
            uni_programs.Items.Add("Bachelor of Science in Architecture");
            uni_programs.Items.Add("Bachelor of Science in Aeronautical Engineering");
            uni_programs.Items.Add("Bachelor of Science in Civil Engineering");
            uni_programs.Items.Add("Bachelor of Science in Computer Engineering");
            uni_programs.Items.Add("Bachelor of Science in Electrical Engineering");
            uni_programs.Items.Add("Bachelor of Science in Electronics Engineering");
            uni_programs.Items.Add("Bachelor of Science in Industrial Engineering");
            uni_programs.Items.Add("Bachelor of Science in Mechanical Engineering");
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            course_number_txt.Clear();
            course_code_txt.Clear();
            course_desc_txt.Clear();
            unit_lec_txt.Clear();
            unit_lab_txt.Clear();
            time_txt.Clear();
            day_txt.Clear();
            credit_units_txt.Clear();
            lab_fee_txt.Clear();
            cisco_lab_txt.Clear();
            exam_booklet_txt.Clear();
        }

        int total_units;
        double lab_fee_sum, cisco_fee_sum, booklet_fee_sum;
        private void submit_button_Click(object sender, EventArgs e)
        {

            int total_credits, unit_lec, unit_lab, credit_units;
            double lab_fee, cisco_fee, booklet_fee;

            unit_lec = Convert.ToInt32(unit_lec_txt.Text);
            unit_lab = Convert.ToInt32(unit_lab_txt.Text);
            total_credits = unit_lec + unit_lab;

            unit_lec = Convert.ToInt32(unit_lec_txt.Text);
            unit_lab = Convert.ToInt32(unit_lab_txt.Text);
            credit_units = unit_lec + unit_lab;

            credit_units_txt.Text = credit_units.ToString("n");

            total_units += credit_units;
            total_num_units_txt.Text = total_units.ToString("n");

            number_list.Items.Add(course_number_txt.Text);
            course_code_list.Items.Add(course_code_txt.Text);
            course_desc_List.Items.Add(course_desc_txt.Text);
            unit_lec_list.Items.Add(unit_lec_txt.Text);
            unit_lab_list.Items.Add(unit_lab_txt.Text);
            time_list.Items.Add(time_txt.Text);
            day_list.Items.Add(day_txt.Text);
            credit_units_list.Items.Add(total_credits);

            lab_fee = Convert.ToInt32(lab_fee_txt.Text);
            lab_fee_sum += lab_fee;

            cisco_fee = Convert.ToInt32(cisco_lab_txt.Text);
            cisco_fee_sum += cisco_fee;

            booklet_fee = Convert.ToInt32(exam_booklet_txt.Text);
            booklet_fee_sum += booklet_fee;

            comp_lab_fee_txt.Text = lab_fee_sum.ToString("n");
            cisco_lab_txt2.Text = cisco_fee_sum.ToString("n");
            exam_booklet_txt2.Text = booklet_fee_sum.ToString("n");
        }

        private void calc_tuition_fee_btn_Click(object sender, EventArgs e)
        {
            double total_tuition_fee, tuition_fee, total_misc, total_tuition_fees;
            tuition_fee = 1700.00;

            total_tuition_fee = total_units * tuition_fee;
            total_tuition_txt.Text = total_tuition_fee.ToString("n");

            total_misc = lab_fee_sum + cisco_fee_sum + booklet_fee_sum;
            total_misc_txt.Text = total_misc.ToString("n");

            total_tuition_fees = total_tuition_fee + total_misc;
            total_tuition_fees_txt.Text = total_tuition_fees.ToString("n");

            total_tuition_txt2.Text = total_tuition_txt.Text;
            total_misc_txt2.Text = total_misc_txt.Text;
            total_other_fees_txt.Text = total_misc_txt.Text;
            total_num_units_txt2.Text = total_num_units_txt.Text;
            total_tuition_fees_txt2.Text = total_tuition_fees_txt.Text;
        }
    }
}

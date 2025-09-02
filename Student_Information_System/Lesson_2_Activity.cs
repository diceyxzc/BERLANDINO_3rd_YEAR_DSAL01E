using System;
using System.Drawing;
using System.Windows.Forms;

namespace Student_Information_System
{
    public partial class Lesson_2_Activity : Form
    {

        private void Lesson_2_Activity_Load(object sender, EventArgs e)
        {
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
            student_name_txt.Clear();
            student_num_txt.Clear();
            yr_level_txt.Clear();
            scholar_txt.Clear();
            course_number_txt.Clear();
            course_code_txt.Clear();
            course_desc_txt.Clear();
            unit_lec_txt.Clear();
            unit_lab_txt.Clear();
            time_txt.Clear();
            day_txt.Clear();
            credit_units_txt.Clear();
            total_num_units_txt.Clear();
            lab_fee_txt.Clear();
            total_tuition_txt.Clear();
            total_misc_txt.Clear();
            cisco_lab_txt.Clear();
            exam_booklet_txt.Clear();
            total_tuition_fees_txt.Clear();
            total_tuition_txt2.Clear();
            total_misc_txt2.Clear();
            comp_lab_fee_txt.Clear();
            cisco_lab_txt2.Clear();
            exam_booklet_txt2.Clear();
            total_other_fees_txt.Clear();
            total_num_units_txt2.Clear();
            total_tuition_fees_txt2.Clear();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            number_list.Items.Add(course_number_txt.Text);
            course_code_list.Items.Add(course_code_txt.Text);
            course_desc_List.Items.Add(course_desc_txt.Text);
            unit_lec_list.Items.Add(unit_lec_txt.Text);
            unit_lab_list.Items.Add(unit_lab_txt.Text);
            credit_units_list.Items.Add(credit_units_txt.Text);
            time_list.Items.Add(time_txt.Text);
            day_list.Items.Add(day_txt.Text);

            total_tuition_txt2.Text = total_tuition_txt.Text;
            total_misc_txt2.Text = total_misc_txt.Text;
            comp_lab_fee_txt.Text = lab_fee_txt.Text;
            cisco_lab_txt2.Text = cisco_lab_txt.Text;
            exam_booklet_txt2.Text = exam_booklet_txt.Text;
            total_num_units_txt2.Text = total_num_units_txt.Text;
            total_tuition_fees_txt2.Text = total_tuition_fees_txt.Text;
        }

        private void course_number_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

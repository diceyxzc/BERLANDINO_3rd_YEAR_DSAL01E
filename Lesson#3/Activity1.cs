using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_3
{
    public partial class Activity1 : Form
    {
        public Activity1()
        {
            InitializeComponent();
        }

        private void sum_button_Click(object sender, EventArgs e)
        {
            double first_num, second_num, third_num, fourth_num, sum;

            first_num = Convert.ToDouble(first_input.Text);
            second_num = Convert.ToDouble(second_input.Text);
            third_num = Convert.ToDouble(third_input.Text);
            fourth_num = Convert.ToDouble(fourth_input.Text);

            sum = first_num + second_num + third_num + fourth_num;

            display_txt.Text = sum.ToString("n");
        }

        private void diff_button_Click(object sender, EventArgs e)
        {
            double first_num, second_num, third_num, fourth_num, sum;

            first_num = Convert.ToDouble(first_input.Text);
            second_num = Convert.ToDouble(second_input.Text);
            third_num = Convert.ToDouble(third_input.Text);
            fourth_num = Convert.ToDouble(fourth_input.Text);

            sum = first_num - second_num - third_num - fourth_num;

            display_txt.Text = sum.ToString("n");
        }

        private void product_button_Click(object sender, EventArgs e)
        {
            double first_num, second_num, third_num, fourth_num, sum;

            first_num = Convert.ToDouble(first_input.Text);
            second_num = Convert.ToDouble(second_input.Text);
            third_num = Convert.ToDouble(third_input.Text);
            fourth_num = Convert.ToDouble(fourth_input.Text);

            sum = first_num * second_num * third_num * fourth_num;

            display_txt.Text = sum.ToString("n");
        }

        private void quotient_button_Click(object sender, EventArgs e)
        {
            double first_num, second_num, third_num, fourth_num, sum;

            first_num = Convert.ToDouble(first_input.Text);
            second_num = Convert.ToDouble(second_input.Text);
            third_num = Convert.ToDouble(third_input.Text);
            fourth_num = Convert.ToDouble(fourth_input.Text);

            sum = (first_num + second_num) / (third_num + fourth_num);

            display_txt.Text = sum.ToString("n");
        }

        private void Activity1_Load(object sender, EventArgs e)
        {
            display_txt.Enabled = false;
        }
    }
}

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
    public partial class Prelim_Exam_Prnt : Form
    {
        public Prelim_Exam_Prnt()
        {
            InitializeComponent();
        }

        private void Prelim_Exam_Prnt_Load(object sender, EventArgs e)
        {
            company_name.Text = "Lyceum of the Philippines University Cavite";
            hono_adust.Text = "0.00";
            sub_lab.Text = "0.00";
            tardy_pay.Text = "0.00";
            totaL_overtime.Text = "0.00";
            sss_wisp_contrib.Text = "750.00";
        }
    }
}

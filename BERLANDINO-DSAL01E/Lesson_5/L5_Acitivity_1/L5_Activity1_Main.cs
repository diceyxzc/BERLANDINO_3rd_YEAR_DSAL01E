using BERLANDINO_DSAL01E.Exam;
using Lesson_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERLANDINO_DSAL01E.Lesson_5
{
    public partial class L5_Activity1_Main : Form
    {
        public L5_Activity1_Main()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        // Lesson 3 Activities
        private void jEEPOSIncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load in L3_Activity2
            L3_Activity2 newMDIChild = new L3_Activity2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void jeePOSOrderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load in L3_Activity3
            L3_Activity3 newMDIChild = new L3_Activity3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void simplePOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load in L3_Activity4
            L3_Activity4 newMDIChild = new L3_Activity4();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
        private void jEEPOSIncToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Load in L3_Activity2
            L3_Activity2 newMDIChild = new L3_Activity2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void jEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load in L3_Activity3
            L3_Activity3 newMDIChild = new L3_Activity3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit Program
            this.Close();
        }

        private void payrollApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load in L3_Activity5
            L3_Activity5 newMDIChild = new L3_Activity5();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void employeeRegistrationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load in Prelim_Exam
            L3_Prelim_Exam newMDIChild = new L3_Prelim_Exam();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Vertical Layout
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Horizontal Layout
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cascade Layout
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
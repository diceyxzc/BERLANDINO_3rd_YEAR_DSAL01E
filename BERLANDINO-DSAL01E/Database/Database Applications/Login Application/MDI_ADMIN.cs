using BERLANDINO_DSAL01E.Database;
using BERLANDINO_DSAL01E.Database.Activities;
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
    public partial class MDI_ADMIN : Form
    {
        public MDI_ADMIN()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        // POS
        private void jEEPOSIncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load in Cashier_1
            POS_Cashier_1 newMDIChild = new POS_Cashier_1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void jeePOSOrderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load in Cashier_2
            POS_Cashier_2 newMDIChild = new POS_Cashier_2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void POSAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load in POS ADMIN
            POS_Admin newMDIChild = new POS_Admin();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        // PAYROLL
        private void payrollAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load in PAYROLL ADMIN
            Payroll_Registration newMDIChild = new Payroll_Registration();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        // EMPLOYEE REGISTRATION
        private void employeeRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load in EMPLOYEE REGISTRATION ADMIN
            Employee_Registration newMDIChild = new Employee_Registration();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        // USER ACCOUNT ADMIN
        private void userAccountAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load in USER ACCOUNT ADMIN
            User_Account_Registration newMDIChild = new User_Account_Registration();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        // REPORTS
        private void employeeReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load in EMPLOYEE REPORTS
            Employee_Report newMDIChild = new Employee_Report();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void payrollReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load in PAYROLL REPORTS
            Payroll_Report newMDIChild = new Payroll_Report();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load in SALES REPORTS
            Sales_Report newMDIChild = new Sales_Report();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void userAccountReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load in USER ACCOUNT REPORTS
            User_Account_Registration newMDIChild = new User_Account_Registration();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        // WINDOWS
        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        // LOGOUT
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Form_Database loginfrm = new Login_Form_Database();
            loginfrm.Show();
            this.Close();
        }

        // OTHERS
        private void dBExample1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load in DB Example 1
            DB_Example1 newMDIChild = new DB_Example1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
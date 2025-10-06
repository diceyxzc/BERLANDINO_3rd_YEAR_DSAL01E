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
    public partial class L5_Activity1 : Form
    {
        public L5_Activity1()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // User authentication
            if (username_txtbox.Text == "2023-2-02178" & password_txtbox.Text == "calvin123")
            {
                // Admin Form
                MessageBox.Show("Welcome to Admin Page!");
                L5_Activity1_Main adminfrm = new L5_Activity1_Main();
                adminfrm.Show();
                this.Hide();
            }
            else if (username_txtbox.Text == "cashier" & password_txtbox.Text == "cashier123")
            {
                // Cashier Form
                MessageBox.Show("Welcome to Cashier Page!");
                L3_Activity2 cashierfrm = new L3_Activity2();
                cashierfrm.Show();
                this.Hide();
            }
            else if (username_txtbox.Text == "cashier1" & password_txtbox.Text == "cashier111")
            {
                // Cashier 1 Form
                MessageBox.Show("Welcome to Cashier 1 Page!");
                L8_Activity1 cashier1frm = new L8_Activity1();
                cashier1frm.Show();
                this.Hide();
            }
            else if (username_txtbox.Text == "payroll" & password_txtbox.Text == "payroll111")
            {
                // Payroll Form
                MessageBox.Show("Welcome to Payroll Page!");
                L3_Activity5 payrollfrm = new L3_Activity5();
                payrollfrm.Show();
                this.Hide();
            }
            else
                // In case of failed login
                MessageBox.Show("Invalid User Account!");
                username_txtbox.Clear();
                password_txtbox.Clear();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            // CLoses Program
            this.Close();
        }

        private void Login_Example_Load(object sender, EventArgs e)
        {
            // Maximize
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}

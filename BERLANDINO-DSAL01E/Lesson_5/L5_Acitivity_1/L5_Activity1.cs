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
            string username, password;
            username = "ella";
            password = "calvin123";
            if (username_txtbox.Text == username & password_txtbox.Text == password)
            {
                MessageBox.Show("Welcome!!");
                L5_Activity1_Main adminfrm = new L5_Activity1_Main();
                adminfrm.Show();
                this.Hide();
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Example_Load(object sender, EventArgs e)
        {

        }
    }
}

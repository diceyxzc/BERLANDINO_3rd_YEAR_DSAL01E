using System;
using System.Windows.Forms;

namespace BERLANDINO_DSAL01E.Lesson_4
{
    public partial class L4_Activity1 : Form
    {
        private double amount_paid, price, cash_given, change;
        private int quantity;

        public L4_Activity1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            change_txtbox.Enabled = false;
            amount_paid_txtbox.Enabled = false;
            this.Location = new Point(0, 0); // code for the location of the form once the program run by x and y axis
            this.Size = Screen.PrimaryScreen.WorkingArea.Size; // code for the size of the form to be displayed once the program runs
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 1
            itemnameTextbox.Text = "Breakfast Meal B";
            priceTextbox.Text = "121.30";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Friend Meal A";
            priceTextbox.Text = "391.90";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Double Value Meal A";
            priceTextbox.Text = "191.00";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Family Combo Meal B";
            priceTextbox.Text = "799.30";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Breakfast Meal A";
            priceTextbox.Text = "91.30";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Breakfast Meal C";
            priceTextbox.Text = "191.30";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Pasta Meal 101";
            priceTextbox.Text = "98.00";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Family Combo Meal A";
            priceTextbox.Text = "999.90";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Chicken Meal A";
            priceTextbox.Text = "177.30";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Lunch Value Meal 1";
            priceTextbox.Text = "199.10";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Double Palaboc Meal";
            priceTextbox.Text = "120.50";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Chicken Meal 2";
            priceTextbox.Text = "191.30";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Pancake Value Meal A";
            priceTextbox.Text = "97.30";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Breakfast Meal D";
            priceTextbox.Text = "133.30";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Lunch Value Meal B";
            priceTextbox.Text = "191.30";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void qty_txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
            if (qty_txtbox.Text == "") return;
            price = Convert.ToDouble(priceTextbox.Text);
            quantity = Convert.ToInt32(qty_txtbox.Text);
            amount_paid = price * quantity;
            amount_paid_txtbox.Text = "₱ " + amount_paid.ToString("n");
            cash_given_txtbox.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Data Input!");
                qty_txtbox.Clear();
                qty_txtbox.Focus();
            }
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            try
            {
                cash_given = Convert.ToDouble(cash_given_txtbox.Text);
                change = cash_given - amount_paid;
                change_txtbox.Text = "₱ " + change.ToString("n");
                MessageBox.Show("Successfully Computed!");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Data Input!");
                cash_given_txtbox.Clear();
                cash_given_txtbox.Focus();
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            // Code for clearing or emptying the value of the Text property of a textbox
            qty_txtbox.Clear();
            itemnameTextbox.Clear();
            priceTextbox.Clear();
            amount_paid_txtbox.Clear();
            cash_given_txtbox.Clear();
            change_txtbox.Clear();
        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            // Code for closing the execution of the Windows Form Application
            this.Close();
        }
    }
}

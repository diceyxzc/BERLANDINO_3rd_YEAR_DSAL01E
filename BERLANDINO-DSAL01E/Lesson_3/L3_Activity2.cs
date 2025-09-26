using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERLANDINO_DSAL01E
{
    public partial class L3_Activity2 : Form
    {
        public L3_Activity2()
        {
            InitializeComponent();
        }

        private void Activity2_Part2_Load(object sender, EventArgs e)
        {
            // Codes for disabling the textboxes
            itemnameTextbox.Enabled = false;
            priceTextbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            discountamounttxtbox.Enabled = false;

            // Codes for inserting name of the image inside the label tool
            label14.Text = "Breakfast Meal B";
            label15.Text = "Friend Meal A";
            label16.Text = "Double Value Meal A";
            label17.Text = "Family Combo Meal B";
            label18.Text = "Breakfast Meal A";
            label19.Text = "Breakfast Meal C";
            label20.Text = "Pasta Meal 101";
            label21.Text = "Family Combo Meal A";
            label22.Text = "Chicken Meal A";
            label23.Text = "Lunch Value Meal 1";
            label24.Text = "Double Palaboc Meal";
            label25.Text = "Chicken Meal 2";
            label26.Text = "Pancake Value Meal A";
            label27.Text = "Breakfast Meal D";
            label28.Text = "Lunch Value Meal B";
            label29.Text = "Ceasar Salad";
            label30.Text = "Tuna Ceasar Salad";
            label31.Text = "Chicken Two Piece";
            label32.Text = "Mojos Meal";
            label33.Text = "Full Creamy Pizza";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 1
            itemnameTextbox.Text = "Breakfast Meal B";
            priceTextbox.Text = "121.30";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Friend Meal A";
            priceTextbox.Text = "391.90";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Double Value Meal A";
            priceTextbox.Text = "191.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Family Combo Meal B";
            priceTextbox.Text = "799.30";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Breakfast Meal A";
            priceTextbox.Text = "91.30";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Breakfast Meal C";
            priceTextbox.Text = "191.30";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Pasta Meal 101";
            priceTextbox.Text = "98.00";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Family Combo Meal A";
            priceTextbox.Text = "999.90";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Chicken Meal A";
            priceTextbox.Text = "177.30";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Lunch Value Meal 1";
            priceTextbox.Text = "199.10";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Double Palaboc Meal";
            priceTextbox.Text = "120.50";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Chicken Meal 2";
            priceTextbox.Text = "191.30";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Pancake Value Meal A";
            priceTextbox.Text = "97.30";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Breakfast Meal D";
            priceTextbox.Text = "133.30";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Lunch Value Meal B";
            priceTextbox.Text = "191.30";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Ceasar Salad";
            priceTextbox.Text = "151.00";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Tuna Ceasar Salad";
            priceTextbox.Text = "160.30";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Chicken Two Piece";
            priceTextbox.Text = "231.00";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Mojos Meal";
            priceTextbox.Text = "120.60";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a textbox 2
            itemnameTextbox.Text = "Full Creamy Pizza";
            priceTextbox.Text = "350.30";
        }

        private void senior_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of variables within a method a of an object
            int qty;
            double price, discount_amt, discounted_amt;

            // Conver string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(itemquantitytxtbox.Text);
            price = Convert.ToDouble(priceTextbox.Text);

            // Create a formula needed for computation
            discount_amt = (qty * price) * 0.30;
            discounted_amt = (qty * price) - discount_amt;

            // Converting numeric data to string and display it inside the textboxes
            discountamounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            // Codes for unchecking the other radio buttons in the interface once the senior citizen method executed
            disc_radio_button.Checked = false;
            emp_radio_button.Checked = false;
            nodisc_radio_button.Checked = false;
        }

        private void disc_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of variables within a method a of an object
            int qty;
            double price, discount_amt, discounted_amt;

            // Conver string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(itemquantitytxtbox.Text);
            price = Convert.ToDouble(priceTextbox.Text);

            // Create a formula needed for computation
            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;

            // Converting numeric data to string and display it inside the textboxes
            discountamounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            // Codes for unchecking the other radio buttons in the interface once the senior citizen method executed
            senior_radio_button.Checked = false;
            emp_radio_button.Checked = false;
            nodisc_radio_button.Checked = false;
        }

        private void emp_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of variables within a method a of an object
            int qty;
            double price, discount_amt, discounted_amt;

            // Conver string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(itemquantitytxtbox.Text);
            price = Convert.ToDouble(priceTextbox.Text);

            // Create a formula needed for computation
            discount_amt = (qty * price) * 0.15;
            discounted_amt = (qty * price) - discount_amt;

            // Converting numeric data to string and display it inside the textboxes
            discountamounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            // Codes for unchecking the other radio buttons in the interface once the senior citizen method executed
            senior_radio_button.Checked = false;
            disc_radio_button.Checked = false;
            nodisc_radio_button.Checked = false;
        }

        private void nodisc_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of variables within a method a of an object
            int qty;
            double price, discount_amt, discounted_amt;

            // Conver string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(itemquantitytxtbox.Text);
            price = Convert.ToDouble(priceTextbox.Text);

            // Create a formula needed for computation
            discount_amt = (qty * price) * 0;
            discounted_amt = (qty * price) - discount_amt;

            // Converting numeric data to string and display it inside the textboxes
            discountamounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            // Codes for unchecking the other radio buttons in the interface once the senior citizen method executed
            senior_radio_button.Checked = false;
            disc_radio_button.Checked = false;
            emp_radio_button.Checked = false;
        }

        double qty_total, discount_totalgiven, discounted_total;
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            // Declaration of varaibles with data types
            int qty;
            double discount_amt, discounted_amt, cash_rendered, change;
            

            qty = Convert.ToInt32(itemquantitytxtbox.Text);
            discount_amt = Convert.ToDouble(discountamounttxtbox.Text);
            discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
            cash_rendered = Convert.ToDouble(cashrenderedtxtbox.Text);

            /* Codes to accumulate the value of the quantity, discount give and discounted amount 
               from one transaction to another. */
            qty_total += qty;
            discount_totalgiven += discount_amt;
            discounted_total += discounted_amt;
            change = cash_rendered - discounted_amt;

            // Convert string data form textboxes to numeric and place it as value of the variable
            qty_totaltxtbox.Text = qty_total.ToString();
            discount_totaltxtbox.Text = discount_totalgiven.ToString("n");
            discounted_totaltxtbox.Text = discounted_total.ToString("n");
            changetxtbox.Text = change.ToString("n");
            cashrenderedtxtbox.Text = cash_rendered.ToString("n");
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            itemnameTextbox.Clear();
            itemquantitytxtbox.Clear();
            priceTextbox.Clear();
            discountamounttxtbox.Clear();
            discountedtxtbox.Clear();
            cashrenderedtxtbox.Clear();
            changetxtbox.Clear();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            qty_totaltxtbox.Clear();
            discount_totaltxtbox.Clear();
            discounted_totaltxtbox.Clear();
            cashrenderedtxtbox.Clear();
            changetxtbox.Clear();
        }

        private void extiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

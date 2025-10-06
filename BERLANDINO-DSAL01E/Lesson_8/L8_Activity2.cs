using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERLANDINO_DSAL01E
{
    public partial class L8_Activity2 : Form
    {
        public L8_Activity2()
        {
            InitializeComponent();
        }

        // Declare global variables
        int qty;
        double price, discounted_amt, discount_amt;

        // Whenever a menu item is clicked, it will auto-focus to quantity textbox
        private void focus_quantity()
        {
            itemquantitytxtbox.Clear();
            itemquantitytxtbox.Focus();
        }

        // Converts quantity and price
        private void qty_price_convert()
        {
            qty = Convert.ToInt32(itemquantitytxtbox.Text);
            price = Convert.ToDouble(priceTextbox.Text);
        }
        
        // Discounted amount calculation and convert it to textbox
        private void discounted_amount()
        {
            discounted_amt = (qty * price) - discount_amt;

            // Converting numeric data to string and display it inside the textboxes
            discountamounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
        }

        // Sets the name and price of the item
        public void price_item_text(string itemname, string price)
        {
            itemnameTextbox.Text = itemname;
            priceTextbox.Text = price;
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

        // All pictureboxes operates in the same function price_item_text() and focus_quantity()
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            price_item_text(label14.Text, "121.30");
            focus_quantity();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_text(label15.Text, "391.90");
            focus_quantity();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_text(label16.Text, "191.90");
            focus_quantity();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_text(label17.Text, "799.30");
            focus_quantity();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_text(label18.Text, "91.30");
            focus_quantity();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_text(label19.Text, "191.30");
            focus_quantity();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_text(label20.Text, "98.00");
            focus_quantity();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_text(label21.Text, "999.90");
            focus_quantity();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_text(label22.Text, "177.30");
            focus_quantity();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_text(label23.Text, "199.10");
            focus_quantity();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_text(label24.Text, "120.50");
            focus_quantity();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_text(label25.Text, "191.30");
            focus_quantity();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_text(label26.Text, "97.30");
            focus_quantity();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_text(label27.Text, "133.30");
            focus_quantity();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_text(label28.Text, "191.30");
            focus_quantity();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_text(label29.Text, "151.00");
            focus_quantity();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_text(label30.Text, "160.30");
            focus_quantity();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_text(label31.Text, "231.00");
            focus_quantity();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_text(label32.Text, "120.60");
            focus_quantity();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_text(label33.Text, "455.90");
            focus_quantity();
        }

        private void senior_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                /* Calls quantity price converter for the discount amount
                and calls the discounted_amount to convert calculated amount to text */
                qty_price_convert();
                discount_amt = (qty * price) * 0.30;
                discounted_amount();

                // Codes for unchecking the other radio buttons in the interface once the senior citizen method executed
                disc_radio_button.Checked = false;
                emp_radio_button.Checked = false;
                nodisc_radio_button.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid!");
                focus_quantity();
            }
        }

        private void disc_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                /* Calls quantity price converter for the discount amount
                and calls the discounted_amount to convert calculated amount to text */
                qty_price_convert();
                discount_amt = (qty * price) * 0.10;
                discounted_amount();

                // Codes for unchecking the other radio buttons in the interface once the senior citizen method executed
                senior_radio_button.Checked = false;
                emp_radio_button.Checked = false;
                nodisc_radio_button.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid!");
                focus_quantity();
            }
        }

        private void emp_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                /* Calls quantity price converter for the discount amount
                and calls the discounted_amount to convert calculated amount to text */
                qty_price_convert();
                discount_amt = (qty * price) * 0.15;
                discounted_amount();

                // Codes for unchecking the other radio buttons in the interface once the senior citizen method executed
                senior_radio_button.Checked = false;
                disc_radio_button.Checked = false;
                nodisc_radio_button.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid!");
                focus_quantity();
            }
        }

        private void nodisc_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of variables within a method a of an object
            int qty;
            double price, discount_amt, discounted_amt;

            try
            {
                // Convert string data from textboxes to numeric and place it as value of the variable
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
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid!");
                itemquantitytxtbox.Clear();
                itemquantitytxtbox.Focus();
            }
        }

        double qty_total, discount_totalgiven, discounted_total;
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            // Declaration of varaibles with data types
            int qty;
            double discount_amt, discounted_amt, cash_rendered, change;

            try
            {
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
            catch (Exception)
            {
                MessageBox.Show("Make sure cash given textbox is not Empty/Invalid!");
                cashrenderedtxtbox.Clear();
                cashrenderedtxtbox.Focus();
            }
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

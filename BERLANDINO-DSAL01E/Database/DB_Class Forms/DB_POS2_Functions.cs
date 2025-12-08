using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BERLANDINO_DSAL01E.Database.Class_Forms
{
    internal class DB_POS2_Functions
    {
        // Instance of Variables class for shared data
        Price_Variables variables = new Price_Variables();

        /// Sets clears quantity textbox and focuses on it for user input
        public void focus_quantity
            (
            TextBox qty_txtbox
            )
        {
            qty_txtbox.Clear();
            qty_txtbox.Focus();
        }

        // Aligns bundles and in ListBox for better readability
        public void AddToDisplayList_Others
            (
            object textSource, 
            TextBox valueBox, 
            ListBox listBox
            )
        {
            string labelText = "";

            // Handle different control types gracefully
            if (textSource is CheckBox cb)
                labelText = cb.Text;
            else if (textSource is RadioButton rb)
                labelText = rb.Text;
            else if (textSource is string s)
                labelText = s;
            else
                labelText = textSource?.ToString() ?? "";

            // Format and add to ListBox
            string line = string.Format("{0,-34}{1,10}", labelText, valueBox.Text);
            listBox.Items.Add(line);
        }

        // Aligns Cechkboxes in ListBox for better readability
        public void AddToDisplayList
            (
            CheckBox item_name, 
            TextBox priceBox, 
            ListBox displayListBox
            )
        {
            displayListBox.Font = new Font("Courier New", 12, FontStyle.Regular);
            string itemLine = string.Format("{0,-34}{1,10}", item_name.Text, priceBox.Text);
            displayListBox.Items.Add(itemLine);
        }

        /// Sets price and discount values in textboxes
        public void price_dics_func
            (
            TextBox disc_txtbox, 
            TextBox price_txtbox, 
            string discountamount, 
            string price
            )
        {
            price_txtbox.Text = price;
            disc_txtbox.Text = discountamount;
        }

        /// Calculates 15% discount for bundles A and B
        public void bundle_ab_comp
            (TextBox price_txtbox, 
            TextBox disc_txtbox, 
            Price_Variables vars
            )
        {
            variables.price_total = Convert.ToDouble(price_txtbox.Text);
            variables.disc_amnt = variables.price_total * 0.15;
            disc_txtbox.Text = variables.disc_amnt.ToString("n");
        }

        /// Converts textbox values to numeric types for calculations
        public void price_qty_disc_convert
            (
            TextBox price_txtbox, 
            TextBox qty_txtbox, 
            TextBox disc_txtbox, 
            Price_Variables vars
            )
        {
            vars.price = Convert.ToDouble(price_txtbox.Text);
            vars.quantity = Convert.ToInt32(qty_txtbox.Text);
            vars.disc_amnt = Convert.ToDouble(disc_txtbox.Text);
        }

        /// Calculates total amount, cash given, and change
        public void total_amt_cash_given
            (
            TextBox totalamounttxtbox, 
            TextBox cashgiventextbox, 
            Price_Variables vars
            )
        {
            vars.total_amount = (vars.quantity * vars.price) - vars.disc_amnt;
            totalamounttxtbox.Text = vars.total_amount.ToString("n");
            vars.cash_given = Convert.ToDouble(cashgiventextbox.Text);
            vars.change = vars.cash_given - vars.total_amount;
        }
    }
}
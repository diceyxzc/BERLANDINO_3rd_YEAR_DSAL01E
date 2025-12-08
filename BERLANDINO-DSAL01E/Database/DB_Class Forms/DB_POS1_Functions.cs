using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BERLANDINO_DSAL01E.Database.Class_Forms
{
    internal class DB_POS1_Functions
    {
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

        // Functions for Ordering Systems
        public void SetPriceItemValue
            (
            TextBox item_name_txtbox, 
            TextBox price_txtbox, 
            string item_name, 
            string price
            )
        {
            item_name_txtbox.Text = item_name;
            price_txtbox.Text = price;
        }
        // Function for getting quantity and price from textboxes and converting them to appropriate data types
        public void qty_price_convert
            (
            TextBox itemquantitytxtbox, 
            TextBox priceTextbox,
            Price_Variables vars
            )
        {
            vars.quantity = Convert.ToInt32(itemquantitytxtbox.Text);
            vars.price = Convert.ToDouble(priceTextbox.Text);
        }

        // Function for computing discount amount and discounted total 
        public void computation_Formula_and_DislpayData
            (
            TextBox discountamounttxtbox, 
            TextBox discountedtxtbox,
            Price_Variables vars
            )
        {
            vars.discounted_amt = (vars.quantity * vars.price - vars.discount_amt);
            discountamounttxtbox.Text = vars.discount_amt.ToString("n");
            discountedtxtbox.Text = vars.discounted_amt.ToString("n");
        }

        // Function for converting total values from textboxes to appropriate data types
        public void convert_total
            (
            TextBox qty_txtbox, 
            TextBox discountamounttxtbox, 
            TextBox discountedtxtbox, 
            TextBox cashrenderedtxtbox, 
            Price_Variables vars
            )
        {
            vars.quantity = Convert.ToInt32(qty_txtbox.Text);
            vars.discount_amt = Convert.ToDouble(discountamounttxtbox.Text);
            vars.discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
            vars.cash_given = Convert.ToDouble(cashrenderedtxtbox.Text);
        }

        // Function for calculating total values
        public void calculate_total
            (
            Price_Variables vars
            )
        {
            vars.qty_total += vars.quantity;
            vars.discount_totalgiven += vars.discount_amt;
            vars.discounted_total += vars.discounted_amt;
            vars.change = vars.cash_given - vars.discounted_amt;
        }
    }
}

using BERLANDINO_DSAL01E.Lesson_8.Class_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERLANDINO_DSAL01E
{
    public partial class L9_Activity2 : Form
    {
        public L9_Activity2()
        {
            InitializeComponent();
        }

        #region Class References
        // Instances of helper classes for POS operations and variable handling
        POS1_Functions functions_pos1 = new POS1_Functions();
        Variables variables = new Variables();
        #endregion

        #region Form Load
        private void Activity2_Part2_Load(object sender, EventArgs e)
        {
            // Disable user editing for computed/output fields
            item_name_txtbox.Enabled = false;
            price_txtbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            discountamounttxtbox.Enabled = false;

            // Assign menu item names to labels
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
        #endregion

        #region PictureBox Event Handlers (Menu Selections)
        // Each PictureBox sets the selected item's name and price, then focuses the quantity textbox.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label14.Text, "121.30");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label15.Text, "141.30");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label16.Text, "391.90");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label17.Text, "191.90");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label18.Text, "799.30");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label19.Text, "91.30");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label20.Text, "191.30");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label21.Text, "98.00");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label22.Text, "999.90");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label23.Text, "177.30");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label24.Text, "199.10");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label25.Text, "120.50");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label26.Text, "191.30");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label27.Text, "97.30");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label28.Text, "133.30");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label29.Text, "191.30");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label30.Text, "151.00");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label31.Text, "160.30");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label32.Text, "231.00");
            functions_pos1.focus_quantity(qty_txtbox);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            functions_pos1.SetPriceItemValue(item_name_txtbox, price_txtbox, label33.Text, "455.90");
            functions_pos1.focus_quantity(qty_txtbox);
        }
        #endregion

        #region Discount Radio Buttons
        // Calculates discounts and updates display fields based on selected discount type.

        private void senior_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Apply 30% discount for senior citizens
                functions_pos1.qty_price_convert(qty_txtbox, price_txtbox, variables);
                variables.discount_amt = (variables.quantity * variables.price) * 0.30;
                functions_pos1.computation_Formula_and_DislpayData(discountamounttxtbox, discountedtxtbox, variables);

                // Uncheck other discount types
                disc_radio_button.Checked = false;
                emp_radio_button.Checked = false;
                nodisc_radio_button.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid!");
                functions_pos1.focus_quantity(qty_txtbox);
            }
        }

        private void disc_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Apply 10% discount for regular promotions
                functions_pos1.qty_price_convert(qty_txtbox, price_txtbox, variables);
                variables.discount_amt = (variables.quantity * variables.price) * 0.10;
                functions_pos1.computation_Formula_and_DislpayData(discountamounttxtbox, discountedtxtbox, variables);

                // Uncheck other discount types
                senior_radio_button.Checked = false;
                emp_radio_button.Checked = false;
                nodisc_radio_button.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid!");
                functions_pos1.focus_quantity(qty_txtbox);
            }
        }

        private void emp_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Apply 15% employee discount
                functions_pos1.qty_price_convert(qty_txtbox, price_txtbox, variables);
                variables.discount_amt = (variables.quantity * variables.price) * 0.15;
                functions_pos1.computation_Formula_and_DislpayData(discountamounttxtbox, discountedtxtbox, variables);

                // Uncheck other discount types
                senior_radio_button.Checked = false;
                disc_radio_button.Checked = false;
                nodisc_radio_button.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid!");
                functions_pos1.focus_quantity(qty_txtbox);
            }
        }

        private void nodisc_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // No discount applied
                functions_pos1.qty_price_convert(qty_txtbox, price_txtbox, variables);
                variables.discount_amt = (variables.quantity * variables.price) * 0;
                functions_pos1.computation_Formula_and_DislpayData(discountamounttxtbox, discountedtxtbox, variables);

                // Uncheck other discount types
                senior_radio_button.Checked = false;
                disc_radio_button.Checked = false;
                emp_radio_button.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid!");
                functions_pos1.focus_quantity(qty_txtbox);
            }
        }
        #endregion

        #region Calculation and Utility Buttons
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert text fields to numeric values
                functions_pos1.convert_total(qty_txtbox, discountamounttxtbox, discountedtxtbox, cashrenderedtxtbox, variables);

                // Accumulate transaction totals
                functions_pos1.calculate_total(variables);

                // Display totals and computed change
                qty_totaltxtbox.Text = variables.qty_total.ToString();
                discount_totaltxtbox.Text = variables.discount_totalgiven.ToString("n");
                discounted_totaltxtbox.Text = variables.discounted_total.ToString("n");
                changetxtbox.Text = variables.change.ToString("n");
                cashrenderedtxtbox.Text = variables.cash_rendered.ToString("n");
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
            // Clear current transaction fields
            item_name_txtbox.Clear();
            qty_txtbox.Clear();
            price_txtbox.Clear();
            discountamounttxtbox.Clear();
            discountedtxtbox.Clear();
            cashrenderedtxtbox.Clear();
            changetxtbox.Clear();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Clear accumulated totals
            qty_totaltxtbox.Clear();
            discount_totaltxtbox.Clear();
            discounted_totaltxtbox.Clear();
            cashrenderedtxtbox.Clear();
            changetxtbox.Clear();
        }

        private void extiBtn_Click(object sender, EventArgs e)
        {
            // Exit the form
            this.Close();
        }
        #endregion
    }
}

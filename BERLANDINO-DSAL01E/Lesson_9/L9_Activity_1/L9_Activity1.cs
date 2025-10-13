using BERLANDINO_DSAL01E.Lesson_8.Class_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERLANDINO_DSAL01E
{
    public partial class L9_Activity1 : Form
    {
        #region Class Accessing
        // Helper classes for POS operations
        POS2_Functions functions_pos2 = new POS2_Functions();
        Variables variables = new Variables();
        #endregion

        #region Constructor
        public L9_Activity1()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Load Event
        private void Activity2_Part2_Load(object sender, EventArgs e)
        {
            // Disable textboxes (read-only fields)
            price_txtbox.Enabled = false;
            disc_txtbox.Enabled = false;
            disced_txtbox.Enabled = false;
            bills_txtbox.Enabled = false;
            total_qty_txtbox.Enabled = false;
            change_txtbox.Enabled = false;

            // Set labels for pizza checkboxes (checkBox1 to checkBox20)
            checkBox1.Text = "Hawaiian";
            checkBox2.Text = "New York Style";
            checkBox3.Text = "Pepperoni";
            checkBox4.Text = "Cauliflower Crush";
            checkBox5.Text = "Dominos";
            checkBox6.Text = "Pizza Special A";
            checkBox7.Text = "Pizza Special B";
            checkBox8.Text = "Pizza Special C";
            checkBox9.Text = "Pizza Special D";
            checkBox10.Text = "Pizza Barbecue";
            checkBox11.Text = "Piza 1";
            checkBox12.Text = "Pizza 2";
            checkBox13.Text = "Pizza 3";
            checkBox14.Text = "Pizza 4";
            checkBox15.Text = "Pizza 5";
            checkBox16.Text = "Pizza 6";
            checkBox17.Text = "Pizza 7";
            checkBox18.Text = "Pizza 8";
            checkBox19.Text = "Pizza 9";
            checkBox20.Text = "Amanos Pizza";

            // Disable bundle checkboxes (enabled only when bundle is selected)
            A_Chicken_CheckBox.Enabled = false;
            A_Fries_CheckBox.Enabled = false;
            A_Coke_CheckBox.Enabled = false;
            A_Sides_CheckBox.Enabled = false;
            A_Special_CheckBox.Enabled = false;
            B_HaloHalo_Checkbox.Enabled = false;
            B_Chicken_Checkbox.Enabled = false;
            B_Carbonara_Checkbox.Enabled = false;
            B_Fries_Checkbox.Enabled = false;
            B_Hawaiian_Checkbox.Enabled = false;
        }
        #endregion

        #region Bundle Selection Events
        private void bundle_A_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            // Change form background color for Bundle A theme
            this.BackColor = Color.LightCyan;

            // Deselect Bundle B
            bundle_B_rdbtn.Checked = false;

            // Display Bundle A image in picture box
            display_picbox.Image = Image.FromFile("C:\\Users\\fla10\\source\\repos\\diceyxzc\\BERLANDINO_3rd_YEAR_DSAL01E" +
                "\\BERLANDINO-DSAL01E\\Resources\\Food Bundle A.jpeg");

            // Check all Bundle A items
            A_Chicken_CheckBox.Checked = true;
            A_Fries_CheckBox.Checked = true;
            A_Coke_CheckBox.Checked = true;
            A_Sides_CheckBox.Checked = true;
            A_Special_CheckBox.Checked = true;

            // Uncheck all Bundle B items
            B_HaloHalo_Checkbox.Checked = false;
            B_Chicken_Checkbox.Checked = false;
            B_Carbonara_Checkbox.Checked = false;
            B_Fries_Checkbox.Checked = false;
            B_Hawaiian_Checkbox.Checked = false;

            // Set price and calculate discount for Bundle A
            price_txtbox.Text = "1,000.00";
            functions_pos2.bundle_ab_comp(price_txtbox, disc_txtbox, variables);

            // Add Bundle A details to display listbox
            functions_pos2.AddToDisplayList_Others(bundle_A_rdbtn, price_txtbox, displayListBox);
            functions_pos2.AddToDisplayList_Others("      Discount Amount:", disc_txtbox, displayListBox);

            // Set focus to quantity textbox for user input
            functions_pos2.focus_quantity(qty_txtbox);
        }

        private void bundle_B_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            // Change form background color for Bundle B theme
            this.BackColor = Color.LightBlue;

            // Deselect Bundle A
            bundle_A_rdbtn.Checked = false;

            // Display Bundle B image in picture box
            display_picbox.Image = Image.FromFile("C:\\Users\\fla10\\source\\repos\\diceyxzc\\BERLANDINO_3rd_YEAR_DSAL01E" +
                "\\BERLANDINO-DSAL01E\\Resources\\Food Bundle B.jpg");

            // Check all Bundle B items
            B_HaloHalo_Checkbox.Checked = true;
            B_Chicken_Checkbox.Checked = true;
            B_Carbonara_Checkbox.Checked = true;
            B_Fries_Checkbox.Checked = true;
            B_Hawaiian_Checkbox.Checked = true;

            // Uncheck all Bundle A items
            A_Chicken_CheckBox.Checked = false;
            A_Fries_CheckBox.Checked = false;
            A_Coke_CheckBox.Checked = false;
            A_Sides_CheckBox.Checked = false;
            A_Special_CheckBox.Checked = false;

            // Set price and calculate discount for Bundle B
            price_txtbox.Text = "1,299.00";
            functions_pos2.bundle_ab_comp(price_txtbox, disc_txtbox, variables);

            // Add Bundle B details to display listbox
            functions_pos2.AddToDisplayList_Others(bundle_B_rdbtn, price_txtbox, displayListBox);
            functions_pos2.AddToDisplayList_Others("      Discount Amount:", disc_txtbox, displayListBox);

            // Set focus to quantity textbox for user input
            functions_pos2.focus_quantity(qty_txtbox);
        }
        #endregion

        #region Button Click Events
        private void calculate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Calculate change based on cash given and total amount
                functions_pos2.total_amt_cash_given(bills_txtbox, cash_txtbox, variables);

                // Display calculated values in textboxes
                change_txtbox.Text = variables.change.ToString("n");
                cash_txtbox.Text = variables.cash_given.ToString("n");

                // Add final billing details to listbox
                displayListBox.Items.Add("--------------------------------------------");
                functions_pos2.AddToDisplayList_Others("Total No. of Items:", total_qty_txtbox, displayListBox);
                functions_pos2.AddToDisplayList_Others("Total Bills:", bills_txtbox, displayListBox);
                functions_pos2.AddToDisplayList_Others("Cash Given:", cash_txtbox, displayListBox);
                displayListBox.Items.Add("--------------------------------------------");
                functions_pos2.AddToDisplayList_Others("Change:", change_txtbox, displayListBox);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter Valid Data in Cash Given Textbox!");
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Create instance of print form
                L9_Activity1_Prnt print = new L9_Activity1_Prnt();

                // Transfer listbox contents to print form
                print.prntDisplayListBox.Items.AddRange(this.displayListBox.Items);
                print.prntDisplayListBox.Font = new Font("Courier New", 12, FontStyle.Regular);

                // Show print preview form
                print.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Error opening print window!");
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove selected item from listbox
                displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select an item to remove!");
            }
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Uncheck all bundle radio buttons
                bundle_A_rdbtn.Checked = false;
                bundle_B_rdbtn.Checked = false;

                // Reset picture box to default image
                display_picbox.Image = Image.FromFile("C:\\Users\\fla10\\source\\repos\\diceyxzc\\BERLANDINO_3rd_YEAR_DSAL01E\\" +
                    "BERLANDINO-DSAL01E\\Resources\\default_user.jpg");

                // Uncheck all Bundle A checkboxes
                A_Chicken_CheckBox.Checked = false;
                A_Fries_CheckBox.Checked = false;
                A_Coke_CheckBox.Checked = false;
                A_Sides_CheckBox.Checked = false;
                A_Special_CheckBox.Checked = false;

                // Uncheck all Bundle B checkboxes
                B_HaloHalo_Checkbox.Checked = false;
                B_Chicken_Checkbox.Checked = false;
                B_Carbonara_Checkbox.Checked = false;
                B_Fries_Checkbox.Checked = false;
                B_Hawaiian_Checkbox.Checked = false;

                // Uncheck all pizza checkboxes (checkBox1 to checkBox20)
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
                checkBox19.Checked = false;
                checkBox20.Checked = false;

                // Clear all textboxes
                qty_txtbox.Clear();
                price_txtbox.Clear();
                disc_txtbox.Clear();
                disced_txtbox.Clear();
                bills_txtbox.Clear();
                total_qty_txtbox.Clear();
                cash_txtbox.Clear();
                change_txtbox.Clear();

                // Clear the display listbox
                displayListBox.Items.Clear();
                variables.qty_total = 0;
                variables.total_amount = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error resetting form!");
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }
        #endregion

        #region Textbox Modifier Events
        private void qty_txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Exit if quantity textbox is empty
                if (qty_txtbox.Text == "") return;

                // Convert and calculate price, quantity, and discount
                functions_pos2.price_qty_disc_convert(price_txtbox, qty_txtbox, disc_txtbox, variables);

                // Calculate discounted amount for current item
                variables.discounted_amt = (variables.price * variables.quantity) - variables.disc_amnt;

                // Update total quantity
                variables.qty_total += variables.quantity;
                total_qty_txtbox.Text = variables.qty_total.ToString("n");

                // Update total bill amount
                variables.total_amount += variables.discounted_amt;
                bills_txtbox.Text = variables.total_amount.ToString("n");
                disced_txtbox.Text = variables.discounted_amt.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Select a Product / Enter Valid Data in Quantity Textbox!");
                functions_pos2.focus_quantity(qty_txtbox);
            }
        }
        #endregion

        #region Checkbox Events for Bundles
        // Hawaiian - ₱500.99
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "500.99");
            functions_pos2.AddToDisplayList(checkBox1, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // New York Style - ₱550.00
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "550.00");
            functions_pos2.AddToDisplayList(checkBox2, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // Pepperoni - ₱600.99
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "600.99");
            functions_pos2.AddToDisplayList(checkBox3, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // Cauliflower Crush - ₱700.50
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "700.50");
            functions_pos2.AddToDisplayList(checkBox4, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // Dominos - ₱500.00
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "500.00");
            functions_pos2.AddToDisplayList(checkBox5, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // Pizza Special A - ₱750.00
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "750.00");
            functions_pos2.AddToDisplayList(checkBox6, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // Pizza Special B - ₱700.00
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "700.00");
            functions_pos2.AddToDisplayList(checkBox7, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // Pizza Special C - ₱850.00
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "850.00");
            functions_pos2.AddToDisplayList(checkBox8, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // Pizza Special D - ₱450.00
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "450.00");
            functions_pos2.AddToDisplayList(checkBox9, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // Pizza Barbecue - ₱650.00
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "650.00");
            functions_pos2.AddToDisplayList(checkBox10, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // Piza 1 - ₱575.00
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "575.00");
            functions_pos2.AddToDisplayList(checkBox11, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // Pizza 2 - ₱575.00
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "575.00");
            functions_pos2.AddToDisplayList(checkBox12, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // Pizza 3 - ₱575.00
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "575.00");
            functions_pos2.AddToDisplayList(checkBox13, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // Pizza 4 - ₱575.00
        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "575.00");
            functions_pos2.AddToDisplayList(checkBox14, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // Pizza 5 - ₱575.00
        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "575.00");
            functions_pos2.AddToDisplayList(checkBox15, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // Pizza 6 - ₱575.00
        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "575.00");
            functions_pos2.AddToDisplayList(checkBox16, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // Pizza 7 - ₱575.00
        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "575.00");
            functions_pos2.AddToDisplayList(checkBox17, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // Pizza 8 - ₱575.00
        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "575.00");
            functions_pos2.AddToDisplayList(checkBox18, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // Pizza 9 - ₱575.00
        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "575.00");
            functions_pos2.AddToDisplayList(checkBox19, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }

        // Amanos Pizza - ₱575.00
        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            functions_pos2.price_dics_func(disc_txtbox, price_txtbox, "0.00", "575.00");
            functions_pos2.AddToDisplayList(checkBox20, price_txtbox, displayListBox);
            functions_pos2.focus_quantity(qty_txtbox);
        }
        #endregion
    }
}
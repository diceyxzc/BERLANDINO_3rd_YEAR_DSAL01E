using BERLANDINO_DSAL01E.Database.Class_Forms;
using BERLANDINO_DSAL01E.Database.Main_DB_Classes;
using BERLANDINO_DSAL01E.Lesson_8.Class_Forms;
using BERLANDINO_DSAL01E.Lesson_9.Class_Forms;
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
    public partial class POS_Cashier_2 : Form
    {
        // Helper classes for POS operations
        pos_dbconnection posdb_connect = new pos_dbconnection();
        DB_POS_Payroll_Class pos2_class_functions = new DB_POS_Payroll_Class();
        Price_Variables variables = new Price_Variables();

        public POS_Cashier_2()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
        }

        private void Activity2_Part2_Load(object sender, EventArgs e)
        {
            // Disable textboxes (read-only fields)
            price_txtbox.Enabled = false;
            disc_txtbox.Enabled = false;
            disced_txtbox.Enabled = false;
            bills_txtbox.Enabled = false;
            total_qty_txtbox.Enabled = false;
            change_txtbox.Enabled = false;

            // Codes for retrieving images from the database adn displaying them in picture box
            posdb_connect.pos_select_cashier1();
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_sql_datasetSelect();

            checkBox1.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
            checkBox2.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
            checkBox3.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
            checkBox4.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
            checkBox5.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
            checkBox6.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
            checkBox7.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
            checkBox8.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
            checkBox9.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
            checkBox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
            checkBox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
            checkBox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
            checkBox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
            checkBox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
            checkBox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
            checkBox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
            checkBox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
            checkBox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
            checkBox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
            checkBox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

            picpathtxtbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
            pictureBox1.Image = Image.FromFile(picpathtxtbox1.Text);

            picpathtxtbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
            pictureBox2.Image = Image.FromFile(picpathtxtbox2.Text);

            picpathtxtbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
            pictureBox3.Image = Image.FromFile(picpathtxtbox3.Text);

            picpathtxtbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
            pictureBox4.Image = Image.FromFile(picpathtxtbox4.Text);

            picpathtxtbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
            pictureBox5.Image = Image.FromFile(picpathtxtbox5.Text);

            picpathtxtbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
            pictureBox6.Image = Image.FromFile(picpathtxtbox6.Text);

            picpathtxtbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
            pictureBox7.Image = Image.FromFile(picpathtxtbox7.Text);

            picpathtxtbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
            pictureBox8.Image = Image.FromFile(picpathtxtbox8.Text);

            picpathtxtbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
            pictureBox9.Image = Image.FromFile(picpathtxtbox9.Text);

            picpathtxtbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
            pictureBox10.Image = Image.FromFile(picpathtxtbox10.Text);

            picpathtxtbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
            pictureBox11.Image = Image.FromFile(picpathtxtbox11.Text);

            picpathtxtbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
            pictureBox12.Image = Image.FromFile(picpathtxtbox12.Text);

            picpathtxtbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
            pictureBox13.Image = Image.FromFile(picpathtxtbox13.Text);

            picpathtxtbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
            pictureBox14.Image = Image.FromFile(picpathtxtbox14.Text);

            picpathtxtbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
            pictureBox15.Image = Image.FromFile(picpathtxtbox15.Text);

            picpathtxtbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
            pictureBox16.Image = Image.FromFile(picpathtxtbox16.Text);

            picpathtxtbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
            pictureBox17.Image = Image.FromFile(picpathtxtbox17.Text);

            picpathtxtbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
            pictureBox18.Image = Image.FromFile(picpathtxtbox18.Text);

            picpathtxtbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
            pictureBox19.Image = Image.FromFile(picpathtxtbox19.Text);

            picpathtxtbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
            pictureBox20.Image = Image.FromFile(picpathtxtbox20.Text);

            price1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
            price2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
            price3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
            price4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
            price5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
            price6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
            price7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
            price8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
            price9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
            price10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
            price11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
            price12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
            price13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
            price14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
            price15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
            price16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
            price17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
            price18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
            price19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
            price20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][65].ToString();

            picpathtxtbox1.Hide(); picpathtxtbox2.Hide(); picpathtxtbox3.Hide();
            picpathtxtbox4.Hide(); picpathtxtbox5.Hide(); picpathtxtbox6.Hide();
            picpathtxtbox7.Hide(); picpathtxtbox8.Hide(); picpathtxtbox9.Hide();
            picpathtxtbox10.Hide(); picpathtxtbox11.Hide(); picpathtxtbox12.Hide();
            picpathtxtbox13.Hide(); picpathtxtbox14.Hide(); picpathtxtbox15.Hide();
            picpathtxtbox16.Hide(); picpathtxtbox17.Hide(); picpathtxtbox18.Hide();
            picpathtxtbox19.Hide(); picpathtxtbox20.Hide();

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
            pos2_class_functions.bundle_ab_comp(price_txtbox, disc_txtbox, variables);

            // Add Bundle A details to display listbox
            pos2_class_functions.AddToDisplayList_Others(bundle_A_rdbtn, price_txtbox, displayListBox);
            pos2_class_functions.AddToDisplayList_Others("      Discount Amount:", disc_txtbox, displayListBox);

            // Set focus to quantity textbox for user input
            pos2_class_functions.focus_quantity(qty_txtbox);
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
            pos2_class_functions.bundle_ab_comp(price_txtbox, disc_txtbox, variables);

            // Add Bundle B details to display listbox
            pos2_class_functions.AddToDisplayList_Others(bundle_B_rdbtn, price_txtbox, displayListBox);
            pos2_class_functions.AddToDisplayList_Others("      Discount Amount:", disc_txtbox, displayListBox);

            // Set focus to quantity textbox for user input
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Calculate change based on cash given and total amount
                pos2_class_functions.total_amt_cash_given(bills_txtbox, cash_txtbox, variables);

                // Display calculated values in textboxes
                change_txtbox.Text = variables.change.ToString("n");
                cash_txtbox.Text = variables.cash_given.ToString("n");

                // Add final billing details to listbox
                displayListBox.Items.Add("--------------------------------------------");
                pos2_class_functions.AddToDisplayList_Others("Total No. of Items:", total_qty_txtbox, displayListBox);
                pos2_class_functions.AddToDisplayList_Others("Total Bills:", bills_txtbox, displayListBox);
                pos2_class_functions.AddToDisplayList_Others("Cash Given:", cash_txtbox, displayListBox);
                displayListBox.Items.Add("--------------------------------------------");
                pos2_class_functions.AddToDisplayList_Others("Change:", change_txtbox, displayListBox);
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
                L8_Activity1_Prnt print = new L8_Activity1_Prnt();

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

        private void qty_txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Exit if quantity textbox is empty
                if (qty_txtbox.Text == "") return;

                // Convert and calculate price, quantity, and discount
                pos2_class_functions.price_qty_disc_convert(price_txtbox, qty_txtbox, disc_txtbox, variables);

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
                pos2_class_functions.focus_quantity(qty_txtbox);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price1.Text);
            pos2_class_functions.AddToDisplayList(checkBox1, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price2.Text);
            pos2_class_functions.AddToDisplayList(checkBox2, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price3.Text);
            pos2_class_functions.AddToDisplayList(checkBox3, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price4.Text);
            pos2_class_functions.AddToDisplayList(checkBox4, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price5.Text);
            pos2_class_functions.AddToDisplayList(checkBox5, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price6.Text);
            pos2_class_functions.AddToDisplayList(checkBox6, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price7.Text);
            pos2_class_functions.AddToDisplayList(checkBox7, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price8.Text);
            pos2_class_functions.AddToDisplayList(checkBox8, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price9.Text);
            pos2_class_functions.AddToDisplayList(checkBox9, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price10.Text);
            pos2_class_functions.AddToDisplayList(checkBox10, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price11.Text);
            pos2_class_functions.AddToDisplayList(checkBox11, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price12.Text);
            pos2_class_functions.AddToDisplayList(checkBox12, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price13.Text);
            pos2_class_functions.AddToDisplayList(checkBox13, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price14.Text);
            pos2_class_functions.AddToDisplayList(checkBox14, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price15.Text);
            pos2_class_functions.AddToDisplayList(checkBox15, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price16.Text);
            pos2_class_functions.AddToDisplayList(checkBox16, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price17.Text);
            pos2_class_functions.AddToDisplayList(checkBox17, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price18.Text);
            pos2_class_functions.AddToDisplayList(checkBox18, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price19.Text);
            pos2_class_functions.AddToDisplayList(checkBox19, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            pos2_class_functions.price_dics_func(disc_txtbox, price_txtbox, "0.00", price20.Text);
            pos2_class_functions.AddToDisplayList(checkBox20, price_txtbox, displayListBox);
            pos2_class_functions.focus_quantity(qty_txtbox);
        }
    }
}
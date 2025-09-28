using BERLANDINO_DSAL01E.Lesson_3.L3_Activity_3;
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

namespace Lesson_3
{
    public partial class L3_Activity3 : Form
    {
        /* Codes for declaring variables that is accessible to the whole form
         and can be access for one subject to another. */
        private double total_amount = 0;
        private int total_qty = 0;

        public L3_Activity3()
        {
            InitializeComponent();
        }

        private void Activity2_Part2_Load(object sender, EventArgs e)
        {
            // Disabling Textboxes
            price_txtbox.Enabled = false;
            disc_txtbox.Enabled = false;
            disced_txtbox.Enabled = false;
            bills_txtbox.Enabled = false;
            total_qty_txtbox.Enabled = false;
            change_txtbox.Enabled = false;

            // Labeling the Textboxes
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

            // Codes to disable the checkboxes
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
            double price, disc_amnt;

            // code for changing the form background
            this.BackColor = Color.LightCyan;

            // code for bundle B not to be seelcted
            bundle_B_rdbtn.Checked = false;

            // inserting image inside the picturebox
            display_picbox.Image = Image.FromFile("C:\\Users\\fla10\\source\\repos\\Student_Information_System" +
                "\\BERLANDINO-DSAL01E\\Resources\\Food Bundle A.jpeg");

            // codes to check the checkboxes
            A_Chicken_CheckBox.Checked = true;
            A_Fries_CheckBox.Checked = true;
            A_Coke_CheckBox.Checked = true;
            A_Sides_CheckBox.Checked = true;
            A_Special_CheckBox.Checked = true;

            // codes to uncheck checkboxes
            B_HaloHalo_Checkbox.Checked = false;
            B_Chicken_Checkbox.Checked = false;
            B_Carbonara_Checkbox.Checked = false;
            B_Fries_Checkbox.Checked = false;
            B_Hawaiian_Checkbox.Checked = false;

            // codes for displaying data inside the textboxes
            price_txtbox.Text = "1,000.00";
            price = Convert.ToDouble(price_txtbox.Text);
            disc_amnt = price * 0.15;
            disc_txtbox.Text = disc_amnt.ToString("n");

            // codes for inserting data inside the listbox
            displayListBox.Items.Add(bundle_A_rdbtn.Text.PadRight(76) + price_txtbox.Text);
            displayListBox.Items.Add("      Discount Amount: ".PadRight(73) + disc_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void bundle_B_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            // code for changing the form background
            this.BackColor = Color.LightBlue;

            // code for bundle B not to be seelcted
            bundle_A_rdbtn.Checked = false;

            // inserting image inside the picturebox
            display_picbox.Image = Image.FromFile("C:\\Users\\fla10\\source\\repos\\Student_Information_System" +
                "\\BERLANDINO-DSAL01E\\Resources\\Food Bundle B.jpg");

            // codes to uncheck checkboxes
            B_HaloHalo_Checkbox.Checked = true;
            B_Chicken_Checkbox.Checked = true;
            B_Carbonara_Checkbox.Checked = true;
            B_Fries_Checkbox.Checked = true;
            B_Hawaiian_Checkbox.Checked = true;

            // codes to check the checkboxes
            A_Chicken_CheckBox.Checked = false;
            A_Fries_CheckBox.Checked = false;
            A_Coke_CheckBox.Checked = false;
            A_Sides_CheckBox.Checked = false;
            A_Special_CheckBox.Checked = false;


            // codes for displaying data inside the textboxes
            price_txtbox.Text = "1,299.00";
            disc_txtbox.Text = "194.85";

            // codes for inserting data inside the listbox
            displayListBox.Items.Add(bundle_B_rdbtn.Text.PadRight(76) + price_txtbox.Text);
            displayListBox.Items.Add("      Discount Amount: ".PadRight(73) + disc_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            double cash_given, change, total_amount_paid;
            cash_given = Convert.ToDouble(cash_txtbox.Text);
            total_amount_paid = Convert.ToDouble(bills_txtbox.Text);
            change = cash_given - total_amount_paid;

            change_txtbox.Text = change.ToString("n");
            displayListBox.Items.Add("Total Bills: ".PadRight(80)  + bills_txtbox.Text);
            displayListBox.Items.Add("Cash Given: ".PadRight(80)  +  change_txtbox.Text);
            displayListBox.Items.Add("Change: ".PadRight(80) + change_txtbox.Text);
            displayListBox.Items.Add("Total No. of Items: ".PadRight(80) + total_qty_txtbox.Text);
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            // Codes for calling the other form connected to the current form
            L3_Activity3_Prnt print = new L3_Activity3_Prnt();

            // Codes for displaying the contents of the listbox from other form to the current form
            print.prntDisplayListBox.Items.AddRange(this.displayListBox.Items);

            // Codes for displaying the other form
            print.Show();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            // codes to remove selected data inside the listbox
            displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            // codes to uncheck all given checkboxes
            bundle_A_rdbtn.Checked = false;
            bundle_B_rdbtn.Checked = false;

            // code for inserting default image inside the picturebox
            display_picbox.Image = Image.FromFile("C:\\Users\\fla10\\source\\repos\\Student_Information_System" +
                "\\BERLANDINO-DSAL01E\\Resources\\Default Image.png");

            A_Chicken_CheckBox.Checked = false;
            A_Fries_CheckBox.Checked = false;
            A_Coke_CheckBox.Checked = false;
            A_Sides_CheckBox.Checked = false;
            A_Special_CheckBox.Checked = false;
            B_HaloHalo_Checkbox.Checked = false;
            B_Chicken_Checkbox.Checked = false;
            B_Carbonara_Checkbox.Checked = false;
            B_Fries_Checkbox.Checked = false;
            B_Hawaiian_Checkbox.Checked = false;

            // codes for clearing the checkboxes/textboxes
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
            qty_txtbox.Clear();
            price_txtbox.Clear();
            disc_txtbox.Clear();
            disced_txtbox.Clear();
            bills_txtbox.Clear();
            total_qty_txtbox.Clear();
            cash_txtbox.Clear();
            change_txtbox.Clear();

            // removing the contents of a listbox
            displayListBox.Items.Clear();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qty_txtbox_TextChanged(object sender, EventArgs e)
        {
            double price, discounted_amount, discount_amount;
            int qty;

            if (qty_txtbox.Text == "") return;
            price = Convert.ToDouble(price_txtbox.Text);
            qty = Convert.ToInt32(qty_txtbox.Text);
            discount_amount = Convert.ToDouble(disc_txtbox.Text);
            discounted_amount = (price * qty) - discount_amount;

            total_qty += qty;
            total_qty_txtbox.Text = total_qty.ToString();

            total_amount += discounted_amount;
            bills_txtbox.Text = total_amount.ToString("n");
            disced_txtbox.Text = discounted_amount.ToString("n");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "500.99";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox1.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "550.00";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox2.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "600.99";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox3.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "700.50";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox4.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "500.00";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox5.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "750.00";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox6.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "700.00";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox7.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "850.00";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox8.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "450.00";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox9.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "650.00";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox10.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "575.00";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox11.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "575.00";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox12.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "575.00";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox13.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "575.00";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox14.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "575.00";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox15.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "575.00";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox16.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "575.00";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox17.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "575.00";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox18.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "575.00";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox19.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            price_txtbox.Text = "575.00";
            disc_txtbox.Text = "0.00";

            price = Convert.ToDouble(price_txtbox.Text);
            displayListBox.Items.Add(checkBox20.Text.PadRight(80) + price_txtbox.Text);

            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }
    }
}

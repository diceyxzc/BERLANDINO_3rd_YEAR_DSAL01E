using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_3
{
    public partial class Example_3 : Form
    {
        // codes for declaring variables that is accessible to the whole form and can be access from one object to another.
        private double total_amount = 0;
        private int total_qty = 0;
        public Example_3()
        {
            InitializeComponent();
        }
        private void Example_3_Load(object sender, EventArgs e)
        {
            // disabling radiobuttons
            foodB_rdbtn.Checked = false;
            foodA_rdbtn.Checked = false;


            // disabling textboxes
            price_txtbox.Enabled = false;
            discountamount_txtbox.Enabled = false;
            discountedamount_txtbox.Enabled = false;
            totalbills_txtbox.Enabled = false;
            totalqty_txtbox.Enabled = false;
            change_txtbox.Enabled = false;

            // disabling checkboxes
            A_FriedChickenCheckBox.Checked = false;
            A_KFCSpecialRiceCheckBox.Checked = false;
            A_SaltBreadCheckBox.Checked = false;
            A_LargeFriesCheckBox.Checked = false;
            A_SweetCornCheckBox.Checked = false;
            B_IcedTeaCheckBox.Checked = false;
            B_JollyChickenCheckBox.Checked = false;
            B_PeachMangoPieCheckBox.Checked = false;
            B_PlainRiceCheckBox.Checked = false;
            B_RegularFriesCheckBox.Checked = false;
        }

        private void calculatebills_btn_Click(object sender, EventArgs e)
        {
            double cash_given, change, total_amount_paid;

            cash_given = Convert.ToDouble(cashgiven_txtbox.Text);
            total_amount_paid = Convert.ToDouble(totalbills_txtbox.Text);
            change = cash_given - total_amount_paid;

            change_txtbox.Text = change.ToString("n");

            display_listbox.Items.Add("Cash Given: " + " ₱" + cashgiven_txtbox.Text);
            display_listbox.Items.Add("Change: " + " ₱" + change_txtbox.Text); 
            display_listbox.Items.Add("Total No. of Items: " + totalqty_txtbox.Text);
            display_listbox.Items.Add("===================================");
        }

        private void foodA_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            // code for Food Bundle A not to be selected if Food Bundle A is selected
            foodB_rdbtn.Checked = false;

            // code for changing the form background color to light cyan
            this.BackColor = Color.LightCyan;

            // Inserting image inside the picture box
            display_picbox.Image = Properties.Resources.FoodBundlesA;

            // codes to check the checkboxes if Food Bundle A is selected
            A_FriedChickenCheckBox.Checked = true;
            A_KFCSpecialRiceCheckBox.Checked = true;
            A_SaltBreadCheckBox.Checked = true;
            A_LargeFriesCheckBox.Checked = true;
            A_SweetCornCheckBox.Checked = true;

            // codes to uncheck the checkboxes if Food Bundle A is selected
            B_IcedTeaCheckBox.Checked = false;
            B_JollyChickenCheckBox.Checked = false;
            B_PeachMangoPieCheckBox.Checked = false;
            B_PlainRiceCheckBox.Checked = false;
            B_RegularFriesCheckBox.Checked = false;

            // codes for displaying data isnde the textboxes
            price_txtbox.Text = "1000.00";
            discountamount_txtbox.Text = "200.00";
            price = Convert.ToDouble(price_txtbox.Text);

            // codes for inserting data inside the listbox
            display_listbox.Items.Add(foodA_rdbtn.Text + "                                  " + price_txtbox.Text);
            display_listbox.Items.Add("        Discount Amount:                      " + discountamount_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void foodB_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            // code for Food Bundle A not to be selected if Food Bundle A is selected
            foodA_rdbtn.Checked = false;

            // code for changing the form background color to light cyan
            this.BackColor = Color.LightBlue;

            // Inserting image inside the picture box
            display_picbox.Image = Properties.Resources.FoodBundlesB;

            // codes to check the checkboxes if Food Bundle A is selected
            A_FriedChickenCheckBox.Checked = false;
            A_KFCSpecialRiceCheckBox.Checked = false;
            A_SaltBreadCheckBox.Checked = false;
            A_LargeFriesCheckBox.Checked = false;
            A_SweetCornCheckBox.Checked = false;

            // codes to uncheck the checkboxes if Food Bundle A is selected
            B_IcedTeaCheckBox.Checked = true;
            B_JollyChickenCheckBox.Checked = true;
            B_PeachMangoPieCheckBox.Checked = true;
            B_PlainRiceCheckBox.Checked = true;
            B_RegularFriesCheckBox.Checked = true;

            // codes for displaying data inside the textboxes
            price_txtbox.Text = "1299.00";
            discountamount_txtbox.Text = "194.85";
            price = Convert.ToDouble(price_txtbox.Text);

            // codes for inserting data inside the listbox
            display_listbox.Items.Add(foodB_rdbtn.Text + "                                  " + price_txtbox.Text);
            display_listbox.Items.Add("        Discount Amount:                      " + discountamount_txtbox.Text);
            qty_txtbox.Text = "0";
            qty_txtbox.Focus();
        }

        private void printtransaction_btn_Click(object sender, EventArgs e)
        {
            // codes for calling the other form connected to the current form
            Lesson_3.Example_3_Print_Form print = new Lesson_3.Example_3_Print_Form();
            // codes for displaying the contents of the listbox from other form to the current form 
            print.printdisplay_listbox.Items.AddRange(this.display_listbox.Items);
            // codes for displaying the other form
            print.Show();
        }

        private void removeorder_btn_Click(object sender, EventArgs e)
        {
            // codes for removing the selected item inside the listbox
            display_listbox.Items.RemoveAt(display_listbox.SelectedIndex);
        }

        private void new_btn_Click(object sender, EventArgs e)
        {

            // codes to uncheck all given checkboxes
            foodA_rdbtn.Checked = false;
            foodB_rdbtn.Checked = false;

            this.BackColor = Color.WhiteSmoke;

            // code for inserting default image inside the picture box
            display_picbox.Image = Properties.Resources.defaultimage;

            // codes for clearing the checkboxes and textboxes
            A_FriedChickenCheckBox.Checked = false;
            A_KFCSpecialRiceCheckBox.Checked = false;
            A_SaltBreadCheckBox.Checked = false;
            A_LargeFriesCheckBox.Checked = false;
            A_SweetCornCheckBox.Checked = false;
            B_IcedTeaCheckBox.Checked = false;
            B_JollyChickenCheckBox.Checked = false;
            B_PeachMangoPieCheckBox.Checked = false;
            B_PlainRiceCheckBox.Checked = false;
            B_RegularFriesCheckBox.Checked = false;

            // codes for clearing the textboxes and checkboxes
            price_txtbox.Clear();
            qty_txtbox.Text = "0";
            discountamount_txtbox.Clear();
            discountedamount_txtbox.Clear();
            totalbills_txtbox.Clear();
            totalqty_txtbox.Clear();
            cashgiven_txtbox.Clear();
            change_txtbox.Clear();


            angusbeefshawarma_checkbox.Checked = false;
            creamyspinach_checkbox.Checked = false;
            creamyspinachamericana_checkbox.Checked = false;
            baconglazed_checkbox.Checked = false;
            hawaiiandelight_checkbox.Checked = false;
            pizzabianca_checkbox.Checked = false;
            scallopandshrimp_checkbox.Checked = false;
            specialpizza_checkbox.Checked = false;
            trufflefourcheese_checkbox.Checked = false;
            pepperoni_checkbox.Checked = false;
            trufflegreens_checkbox.Checked = false;
            spinachandmushroom_checkbox.Checked = false;
            spinachandglazed_checkbox.Checked = false;
            scallopandprimo_checkbox.Checked = false;
            hiprotein_checkbox.Checked = false;
            garlicandcheese_checkbox.Checked = false;
            classiccheese_checkbox.Checked = false;
            bellybuster_checkbox.Checked = false;
            classicbeefandonion_checkbox.Checked = false;
            managerschoice_checkbox.Checked = false;

            // removing the contens of a listbox
            display_listbox.Items.Clear();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int qty = 0;
        double price, discounted_amount, discount_amount;
        private void qty_txtbox_TextChanged(object sender, EventArgs e)
        {
            qty = Convert.ToInt32(qty_txtbox.Text);
            price = Convert.ToDouble(price_txtbox.Text);

            discount_amount = Convert.ToDouble(discountamount_txtbox.Text);
            discounted_amount = (price * qty) - discount_amount;

            total_qty += qty;

            totalqty_txtbox.Text = total_qty.ToString();
            total_amount += discounted_amount;

            totalbills_txtbox.Text = total_amount.ToString("n");
            discountedamount_txtbox.Text = discounted_amount.ToString("n");
        }
        private void angusbeefshawarma_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "469.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(angusbeefshawarma_checkbox.Text + "                      " + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }

        private void creamyspinach_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "399.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(creamyspinach_checkbox.Text + "                                  " + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }

        private void creamyspinachamericana_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "1324.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(creamyspinachamericana_checkbox.Text + "                                  " + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }

        private void baconglazed_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "1339.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(baconglazed_checkbox.Text + "" + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }

        private void hawaiiandelight_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "1204.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(hawaiiandelight_checkbox.Text + "" + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }

        private void pizzabianca_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "1324.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(pizzabianca_checkbox.Text + "" + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }

        private void scallopandshrimp_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "1339.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(scallopandshrimp_checkbox.Text + "" + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }

        private void specialpizza_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "399.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(specialpizza_checkbox.Text + "" + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }

        private void trufflefourcheese_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "1204.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(trufflefourcheese_checkbox.Text + "" + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }

        private void pepperoni_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "369.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(pepperoni_checkbox.Text + "" + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }

        private void trufflegreens_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "399.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(trufflegreens_checkbox.Text + "" + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }

        private void spinachandmushroom_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "1339.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(spinachandmushroom_checkbox.Text + "" + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }

        private void spinachandglazed_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "469.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(spinachandglazed_checkbox.Text + "" + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }

        private void scallopandprimo_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "469.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(scallopandprimo_checkbox.Text + "" + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }
        private void hiprotein_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "1324.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(hiprotein_checkbox.Text + "" + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }

        private void garlicandcheese_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "369.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(garlicandcheese_checkbox.Text + "" + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }

        private void classiccheese_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "299.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(classiccheese_checkbox.Text + "" + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }

        private void bellybuster_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "469.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(bellybuster_checkbox.Text + "" + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }

        private void classicbeefandonion_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "369.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(classicbeefandonion_checkbox.Text + "" + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }

        private void managerschoice_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // codes to declare a variable with specific data type
            double price;

            // codes for putting text property value of the textbox
            discountamount_txtbox.Text = "0.00";
            price_txtbox.Text = "399.00";

            // codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(price_txtbox.Text);

            // codes to insert text propert value of a checkbox inside the listbox
            display_listbox.Items.Add(managerschoice_checkbox.Text + "" + price_txtbox.Text);

            // codes for putting text property value of the textbox
            qty_txtbox.Text = "0";

            // codes for the cursor inside the textbox once the event of the object triggered
            qty_txtbox.Focus();
        }
    }
}

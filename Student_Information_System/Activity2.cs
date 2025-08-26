using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_System
{
    public partial class Activity2 : Form
    {
        public Activity2()
        {
            InitializeComponent();
        }

        private void Activity2_Load(object sender, EventArgs e)
        {
            // Codes for disabling the textboxes
            itemnameTextbox.Enabled = false;
            priceTextbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;

            // Codes for inserting name of the image inside the label tool
            label14.Text = "Breakfast Meal B";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void newBtn_Click(object sender, EventArgs e)
        {
            // Code for clearing or emptying the value of the Text property of a textbox
            itemnameTextbox.Clear();
            priceTextbox.Clear();
        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            // Code for closing the execution of the Windows Form Application
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}

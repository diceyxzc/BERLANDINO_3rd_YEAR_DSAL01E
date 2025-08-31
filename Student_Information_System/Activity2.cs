using System;
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

        private void groupBox1_Enter(object sender, EventArgs e)
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

        private void itemnameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

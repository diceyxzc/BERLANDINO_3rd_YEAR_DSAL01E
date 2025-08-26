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
    public partial class Activity3 : Form
    {
        public Activity3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Activity3_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGoldenrodYellow;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Code for chaning the form background
            this.BackColor = Color.LightCyan;

            // Code for food bundle B not to be selected
            foodBRdbtn.Checked = false;

            // Inserting image inside the picturebox
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\fla10\\source\\repos\\diceyxzc\\" +
                "Student_Information_System\\Student_Information_System\\Images\\Food Bundle A.jpeg");

            // Cods to check the checkboxes
            A_FriedChickenCheckBox.Checked = true;
            A_FriesCheckBox.Checked = true;
            A_CokeCheckBox.Checked = true;
            A_SideDishesCheckBox.Checked = true;
            A_SpecialPizzaCheckBox.Checked = true;

            // Codes to uncheck checkboxes
            B_HaloHaloCheckBox.Checked = false;
            B_ChickenCheckBox.Checked = false;
            B_CarbonaraCheckBox.Checked = false;
            B_FriesCheckBox.Checked = false;
            B_HawaiianCheckBox.Checked = false;

            // Codes for displaying data inside the textboxes
            priceTxtBox.Text = "₱ 1,000.000";
            discountTxtBox.Text = "(20% of the Price) ₱ 200.00";
        }

        private void foodBRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            // Code for chaning the form background
            this.BackColor = Color.LightBlue;

            // Code for food bundle A not to be selected
            foodARdbtn.Checked = false;

            // Inserting image inside the picturebox
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\fla10\\source\\repos\\diceyxzc\\" +
                "Student_Information_System\\Student_Information_System\\Images\\Food Bundle B.jpg");

            // Cods to check the checkboxes
            B_HaloHaloCheckBox.Checked = true;
            B_ChickenCheckBox.Checked = true;
            B_CarbonaraCheckBox.Checked = true;
            B_FriesCheckBox.Checked = true;
            B_HawaiianCheckBox.Checked = true;

            // Codes to uncheck checkboxes
            A_FriedChickenCheckBox.Checked = false;
            A_FriesCheckBox.Checked = false;
            A_CokeCheckBox.Checked = false;
            A_SideDishesCheckBox.Checked = false;
            A_SpecialPizzaCheckBox.Checked = false;

            // Codes for displaying data inside the textboxes
            priceTxtBox.Text = "₱ 1,299.000";
            discountTxtBox.Text = "(20% of the Price) ₱ 194.85";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGoldenrodYellow;
            // Codes to uncheck all given checkboxes
            foodARdbtn.Checked = false;
            foodBRdbtn.Checked = false;

            // Code for inserting the default image inside the picturebox
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\fla10\\source\\repos\\diceyxzc\\" +
                "Student_Information_System\\Student_Information_System\\Images\\Default Image.png");
            
            // Codes to uncheck checkboxes food bundle A
            A_FriedChickenCheckBox.Checked = false;
            A_FriesCheckBox.Checked = false;
            A_CokeCheckBox.Checked = false;
            A_SideDishesCheckBox.Checked = false;
            A_SpecialPizzaCheckBox.Checked = false;

            // Codes to uncheck checkboxes food bundle B
            B_HaloHaloCheckBox.Checked = false;
            B_ChickenCheckBox.Checked = false;
            B_CarbonaraCheckBox.Checked = false;
            B_FriesCheckBox.Checked = false;
            B_HawaiianCheckBox.Checked = false;

            // Codes to clearing the textboes
            priceTxtBox.Clear();
            discountTxtBox.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

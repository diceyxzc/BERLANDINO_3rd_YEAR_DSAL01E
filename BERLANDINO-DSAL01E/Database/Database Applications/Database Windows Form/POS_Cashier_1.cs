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
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERLANDINO_DSAL01E
{
    public partial class POS_Cashier_1 : Form
    {
        #region Class & DB References
        // Instances of helper classes for POS operations and variable handling
        DB_POS_Payroll_Class pos1_class_functions = new DB_POS_Payroll_Class();
        Price_Variables db_variables = new Price_Variables();

        // Databsase connection instance 
        pos_dbconnection posdb_connect = new pos_dbconnection();
        Price_Item_Value price_item_value = new Price_Item_Value();
        #endregion

        private void clear_txtboses()
        {
            item_name_txtbox.Clear();
            qty_txtbox.Clear();
            price_txtbox.Clear();
            discountamounttxtbox.Clear();
            discountedtxtbox.Clear();
            cashrenderedtxtbox.Clear();
            changetxtbox.Clear();
            qty_totaltxtbox.Clear();
            discounted_totaltxtbox.Clear();
            discount_totaltxtbox.Clear();
        }

        public POS_Cashier_1()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
        }

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

            // Codes for hiding the picture locations
            picpathtxtbox1.Hide(); picpathtxtbox2.Hide(); picpathtxtbox3.Hide(); picpathtxtbox4.Hide();
            picpathtxtbox5.Hide(); picpathtxtbox6.Hide(); picpathtxtbox7.Hide(); picpathtxtbox8.Hide();
            picpathtxtbox9.Hide(); picpathtxtbox10.Hide(); picpathtxtbox11.Hide(); picpathtxtbox12.Hide();
            picpathtxtbox13.Hide(); picpathtxtbox14.Hide(); picpathtxtbox15.Hide(); picpathtxtbox16.Hide();
            picpathtxtbox17.Hide(); picpathtxtbox18.Hide(); picpathtxtbox19.Hide(); picpathtxtbox20.Hide();

            // Codes for retrieving data from the database
            posdb_connect.pos_select_cashier();
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_sql_datasetSelect();

            // Codes for throwing data from tables inside the database to the textboxes
            name1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
            name2.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
            name3.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
            name4.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
            name5.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
            name6.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
            name7.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
            name8.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
            name9.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
            name10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
            name11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
            name12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
            name13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
            name14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
            name15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
            name16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
            name17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
            name18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
            name19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
            name20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

            picpathtxtbox1.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
            pictureBox1.Image    = Image.FromFile(picpathtxtbox1.Text);

            picpathtxtbox2.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
            pictureBox2.Image    = Image.FromFile(picpathtxtbox2.Text);

            picpathtxtbox3.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
            pictureBox3.Image    = Image.FromFile(picpathtxtbox3.Text);

            picpathtxtbox4.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
            pictureBox4.Image    = Image.FromFile(picpathtxtbox4.Text);

            picpathtxtbox5.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
            pictureBox5.Image    = Image.FromFile(picpathtxtbox5.Text);

            picpathtxtbox6.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
            pictureBox6.Image    = Image.FromFile(picpathtxtbox6.Text);

            picpathtxtbox7.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
            pictureBox7.Image    = Image.FromFile(picpathtxtbox7.Text);

            picpathtxtbox8.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
            pictureBox8.Image    = Image.FromFile(picpathtxtbox8.Text);

            picpathtxtbox9.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
            pictureBox9.Image    = Image.FromFile(picpathtxtbox9.Text);

            picpathtxtbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
            pictureBox10.Image   = Image.FromFile(picpathtxtbox10.Text);

            picpathtxtbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
            pictureBox11.Image   = Image.FromFile(picpathtxtbox11.Text);

            picpathtxtbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
            pictureBox12.Image   = Image.FromFile(picpathtxtbox12.Text);

            picpathtxtbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
            pictureBox13.Image   = Image.FromFile(picpathtxtbox13.Text);

            picpathtxtbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
            pictureBox14.Image   = Image.FromFile(picpathtxtbox14.Text);

            picpathtxtbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
            pictureBox15.Image   = Image.FromFile(picpathtxtbox15.Text);

            picpathtxtbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
            pictureBox16.Image   = Image.FromFile(picpathtxtbox16.Text);

            picpathtxtbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
            pictureBox17.Image   = Image.FromFile(picpathtxtbox17.Text);

            picpathtxtbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
            pictureBox18.Image   = Image.FromFile(picpathtxtbox18.Text);

            picpathtxtbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
            pictureBox19.Image   = Image.FromFile(picpathtxtbox19.Text);

            picpathtxtbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
            pictureBox20.Image   = Image.FromFile(picpathtxtbox20.Text);

            Price1.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
            Price2.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
            Price3.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
            Price4.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
            Price5.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
            Price6.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
            Price7.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
            Price8.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
            Price9.Text  = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
            Price10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
            Price11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
            Price12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
            Price13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
            Price14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
            Price15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
            Price16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
            Price17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
            Price18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
            Price19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
            Price20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][65].ToString();

            posdb_connect.pos_select_cashier_display();
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_select_cashier_SelectDisplay();

            Terminal_No_lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
            emp_id_lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][0].ToString();
            firstname_lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][1].ToString();
            surname_lbl.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
            DateTime dataTime = DateTime.Now;
            data_time_lbl.Text = dataTime.ToString("MM/dd/yyyy HH:mm:ss");
        }
        #endregion

        #region PictureBox Event Handlers (Menu Selections)
        // Each PictureBox sets the selected item's name and price, then focuses the quantity textbox.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name1.Text, Price1.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name2.Text, Price2.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name3.Text, Price3.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name4.Text, Price4.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name5.Text, Price5.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name6.Text, Price6.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name7.Text, Price7.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name8.Text, Price8.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name9.Text, Price9.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name10.Text, Price10.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name11.Text, Price11.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name12.Text, Price12.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name13.Text, Price13.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name14.Text, Price14.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name15.Text, Price15.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name16.Text, Price16.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name17.Text, Price17.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name18.Text, Price18.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name19.Text, Price19.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pos1_class_functions.SetPriceItemValue(item_name_txtbox, price_txtbox, name20.Text, Price20.Text);
            pos1_class_functions.focus_quantity(qty_txtbox);
        }
        #endregion

        #region Discount Radio Buttons
        // Calculates discounts and updates display fields based on selected discount type.

        private void senior_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Apply 30% discount for senior citizens
                pos1_class_functions.qty_price_convert(qty_txtbox, price_txtbox, db_variables);
                db_variables.discount_amt = (db_variables.quantity * db_variables.price) * 0.30;
                pos1_class_functions.computation_Formula_and_DislpayData(discountamounttxtbox, discountedtxtbox, db_variables);

                // Uncheck other discount types
                disc_radio_button.Checked = false;
                emp_radio_button.Checked = false;
                nodisc_radio_button.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid!");
                pos1_class_functions.focus_quantity(qty_txtbox);
            }
        }

        private void disc_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Apply 10% discount for regular promotions
                pos1_class_functions.qty_price_convert(qty_txtbox, price_txtbox, db_variables);
                db_variables.discount_amt = (db_variables.quantity * db_variables.price) * 0.10;
                pos1_class_functions.computation_Formula_and_DislpayData(discountamounttxtbox, discountedtxtbox, db_variables);

                // Uncheck other discount types
                senior_radio_button.Checked = false;
                emp_radio_button.Checked = false;
                nodisc_radio_button.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid!");
                pos1_class_functions.focus_quantity(qty_txtbox);
            }
        }

        private void emp_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Apply 15% employee discount
                pos1_class_functions.qty_price_convert(qty_txtbox, price_txtbox, db_variables);
                db_variables.discount_amt = (db_variables.quantity * db_variables.price) * 0.15;
                pos1_class_functions.computation_Formula_and_DislpayData(discountamounttxtbox, discountedtxtbox, db_variables);

                // Uncheck other discount types
                senior_radio_button.Checked = false;
                disc_radio_button.Checked = false;
                nodisc_radio_button.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid!");
                pos1_class_functions.focus_quantity(qty_txtbox);
            }
        }

        private void nodisc_radio_button_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // No discount applied
                pos1_class_functions.qty_price_convert(qty_txtbox, price_txtbox, db_variables);
                db_variables.discount_amt = (db_variables.quantity * db_variables.price) * 0;
                pos1_class_functions.computation_Formula_and_DislpayData(discountamounttxtbox, discountedtxtbox, db_variables);

                // Uncheck other discount types
                senior_radio_button.Checked = false;
                disc_radio_button.Checked = false;
                emp_radio_button.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is Invalid!");
                pos1_class_functions.focus_quantity(qty_txtbox);
            }
        }
        #endregion

        #region Calculation and Utility Buttons
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert text fields to numeric values
                pos1_class_functions.convert_total(qty_txtbox, discountamounttxtbox, discountedtxtbox, cashrenderedtxtbox, db_variables);

                // Accumulate transaction totals
                pos1_class_functions.calculate_total(db_variables);

                // Display totals and computed change
                qty_totaltxtbox.Text = db_variables.qty_total.ToString();
                discount_totaltxtbox.Text = db_variables.discount_totalgiven.ToString("n");
                discounted_totaltxtbox.Text = db_variables.discounted_total.ToString("n");
                changetxtbox.Text = db_variables.change.ToString("n");
                cashrenderedtxtbox.Text = db_variables.cash_rendered.ToString("n");
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

        private void enter_btn_Click(object sender, EventArgs e)
        {
            if (senior_radio_button.Checked == true)
            {
                posdb_connect.pos_sql = "INSERT INTO salesTbl " +
                "(product_name, product_price, product_quantity_per_transaction, discount_option, discount_amount_per_transaction, discounted_amount_per_transaction," +
                "summary_total_quantity, summary_total_disc_given, summary_total_discounted_amount, terminal_no, time_date, emp_id)" +
                "VALUES ('"+ item_name_txtbox.Text +"', '"+ qty_txtbox.Text +"', '"+ price_txtbox.Text +"', '"+ senior_radio_button.Text +"'," +
                "'"+ discountamounttxtbox.Text +"', '"+ discountedtxtbox.Text +"', '"+ qty_totaltxtbox.Text +"', '"+ discount_totaltxtbox.Text +"'," +
                "'"+ discounted_totaltxtbox.Text +"', '"+ Terminal_No_lbl.Text +"', '"+ data_time_lbl.Text +"', '"+ emp_id_lbl.Text +"')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                clear_txtboses();
            }
            else if (disc_radio_button.Checked == true)
            {
                posdb_connect.pos_sql = "INSERT INTO salesTbl " +
                "(product_name, product_price, product_quantity_per_transaction, discount_option, discount_amount_per_transaction, discounted_amount_per_transaction," +
                "summary_total_quantity, summary_total_disc_given, summary_total_discounted_amount, terminal_no, time_date, emp_id)" +
                "VALUES ('"+ item_name_txtbox.Text +"', '"+ qty_txtbox.Text +"', '"+ price_txtbox.Text +"', '"+ disc_radio_button.Text +"'," +
                "'"+ discountamounttxtbox.Text +"', '"+ discountedtxtbox.Text +"', '"+ qty_totaltxtbox.Text +"', '"+ discount_totaltxtbox.Text +"'," +
                "'"+ discounted_totaltxtbox.Text +"', '"+ Terminal_No_lbl.Text +"', '"+ data_time_lbl.Text +"', '"+ emp_id_lbl.Text +"')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                clear_txtboses();
            }
            else if (emp_radio_button.Checked == true)
            {
                posdb_connect.pos_sql = "INSERT INTO salesTbl " +
                "(product_name, product_price, product_quantity_per_transaction, discount_option, discount_amount_per_transaction, discounted_amount_per_transaction," +
                "summary_total_quantity, summary_total_disc_given, summary_total_discounted_amount, terminal_no, time_date, emp_id)" +
                "VALUES ('"+ item_name_txtbox.Text +"', '"+ qty_txtbox.Text +"', '"+ price_txtbox.Text +"', '"+ emp_radio_button.Text +"'," +
                "'"+ discountamounttxtbox.Text +"', '"+ discountedtxtbox.Text +"', '"+ qty_totaltxtbox.Text +"', '"+ discount_totaltxtbox.Text +"'," +
                "'"+ discounted_totaltxtbox.Text +"', '"+ Terminal_No_lbl.Text +"', '"+ data_time_lbl.Text +"', '"+ emp_id_lbl.Text +"')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                clear_txtboses();
            }
            else if (nodisc_radio_button.Checked == true)
            {
                posdb_connect.pos_sql = "INSERT INTO salesTbl " +
                "(product_name, product_price, product_quantity_per_transaction, discount_option, discount_amount_per_transaction, discounted_amount_per_transaction," +
                "summary_total_quantity, summary_total_disc_given, summary_total_discounted_amount, terminal_no, time_date, emp_id)" +
                "VALUES ('"+ item_name_txtbox.Text +"', '"+ qty_txtbox.Text +"', '"+ price_txtbox.Text +"', '"+ nodisc_radio_button.Text +"'," +
                "'"+ discountamounttxtbox.Text +"', '"+ discountedtxtbox.Text +"', '"+ qty_totaltxtbox.Text +"', '"+ discount_totaltxtbox.Text +"'," +
                "'"+ discounted_totaltxtbox.Text +"', '"+ Terminal_No_lbl.Text +"', '"+ data_time_lbl.Text +"', '"+ emp_id_lbl.Text +"')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();
                clear_txtboses();
            }
        }
    }
}

using BERLANDINO_DSAL01E.Database.Main_DB_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BERLANDINO_DSAL01E.Database.Activities
{
    public partial class Sales_Report : Form
    {
        pos_dbconnection posdb_connect = new pos_dbconnection();
        public Sales_Report()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
        }

        private void PopulateOptionCombo()
        {
            option_combo.Items.Clear(); // clear any existing items

            option_combo.Items.Add("transaction_id");
            option_combo.Items.Add("terminal_number");
            option_combo.Items.Add("date and time");
            option_combo.Items.Add("product name");
            option_combo.Items.Add("employee_number");

            // Optionally, set default selection
            option_combo.SelectedIndex = 0; // selects the first item by default
        }

        private void pos_select()
        {
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.pos_sql_datasetSelect();
            dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
        }

        private void cleartextboxes()
        {
            option_combo.Text = "";
            option_input_txtbox.Clear();
            option_combo.Focus();
        }

        private void cleartextboxes1()
        {
            option_input_txtbox.Clear();
            option_input_txtbox.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateOptionCombo();
            posdb_connect.pos_sql = "SELECT * FROM salesTbl";
            pos_select();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (option_combo.Text == "transaction_id")
            {
                posdb_connect.pos_sql = "SELECT * FROM salesTbl WHERE transaction_id = '"+ option_input_txtbox.Text +"'";
                pos_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "terminal_number")
            {
                posdb_connect.pos_sql = "SELECT * FROM salesTbl WHERE terminal_no = '"+ option_input_txtbox.Text +"'";
                pos_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "date and time")
            {
                posdb_connect.pos_sql = "SELECT * FROM salesTbl WHERE time_date = '"+ option_input_txtbox.Text +"'";
                pos_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "product name")
            {
                posdb_connect.pos_sql = "SELECT * FROM salesTbl WHERE product_name = '"+ option_input_txtbox.Text +"'";
                pos_select();
                cleartextboxes1();
            }
            else if (option_combo.Text == "employee_number")
            {
                posdb_connect.pos_sql = "SELECT * FROM salesTbl WHERE emp_id = '"+ option_input_txtbox.Text +"'";
                pos_select();
                cleartextboxes1();
            }
            else
            {
                MessageBox.Show("No Available Record Found!");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            posdb_connect.pos_sql = "SELECT * FROM salesTbl";
            pos_select();
            cleartextboxes();
        }
    }
}
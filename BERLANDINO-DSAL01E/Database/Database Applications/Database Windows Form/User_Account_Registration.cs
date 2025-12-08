using BERLANDINO_DSAL01E.Database.Main_DB_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERLANDINO_DSAL01E.Database.Activities
{
    public partial class User_Account_Registration : Form
    {
        useraccount_db_connection useraccount_db_connect = new useraccount_db_connection();

        private void cleartextboxes()
        {
            emp_id_txtbox.Clear();
            user_id_txtbox.Clear();
            username_txtbox.Clear();
            pass_txtbox.Clear();
            confirm_pass_txtbox.Clear();
            pictureBox1.Image = Image.FromFile("C:\\Users\\fla10\\source\\repos\\diceyxzc\\BERLANDINO_3rd_YEAR_DSAL01E\\BERLANDINO-DSAL01E\\Resources\\default_user.jpg");
        }

        public User_Account_Registration()
        {
            useraccount_db_connect.useraccount_connString();
            InitializeComponent();
        }

        private void Database_Activity_8_Load(object sender, EventArgs e)
        {
            fname_txtbox.Enabled = false;
            mname_txtbox.Enabled = false;
            surname_txtbox.Enabled = false;
            position_txtbox.Enabled = false;
            picpathtxtbox.Enabled = false;
            picpathtxtbox.Hide();
            useraccount_db_connect.useraccount_sql =
            "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, " +
            "user_id, username, password, user_status, account_type FROM pos_empRegTbl " +
            "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id ";
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterSelect();
            useraccount_db_connect.useraccount_sqldatasetSelect();
            dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            useraccount_db_connect.useraccount_sql =
            "SELECT emp_id, emp_fname, emp_mname, emp_surname, position, picpath " +
            "FROM pos_empRegTbl WHERE emp_id = '" + emp_id_txtbox.Text + "'";
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterSelect();
            useraccount_db_connect.useraccount_sqldatasetSelect();
            fname_txtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][1].ToString();
            mname_txtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][2].ToString();
            surname_txtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][3].ToString();
            position_txtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][4].ToString();
            picpathtxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][5].ToString();
            pictureBox1.Image = Image.FromFile(picpathtxtbox.Text);
        }

        private void search_for_btn_Click(object sender, EventArgs e)
        {
            useraccount_db_connect.useraccount_sql =
            "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, picpath, " +
            "user_id, username, password, user_status, account_type FROM pos_empRegTbl " +
            "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id " +
            "WHERE user_id = '"+ user_id_txtbox.Text +"'";
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterSelect();
            useraccount_db_connect.useraccount_sqldatasetSelect();
            dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
            fname_txtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][1].ToString();
            mname_txtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][2].ToString();
            surname_txtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][3].ToString();
            position_txtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][4].ToString(); 
            picpathtxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][5].ToString();
            pictureBox1.Image = Image.FromFile(picpathtxtbox.Text);
            username_txtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][7].ToString();
            pass_txtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][8].ToString();
            status_combo.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][9].ToString();
            account_type_combo.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][10].ToString();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            useraccount_db_connect.useraccount_sql =
            "UPDATE useraccountTbl SET account_type = '"+ account_type_combo.Text +"', username = '"+ username_txtbox.Text +"', " +
            "password = '"+ pass_txtbox.Text +"', confirm_password = '"+ confirm_pass_txtbox.Text +"', user_status = '"+ status_combo.Text +"' " +
            "WHERE user_id = '"+ user_id_txtbox.Text +"'";
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterDelete();
            useraccount_db_connect.useraccount_sql =
            "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, " +
            "user_id, username, password, user_status, account_type FROM pos_empRegTbl " +
            "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id ";
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterSelect();
            useraccount_db_connect.useraccount_sqldatasetSelect();
            dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            useraccount_db_connect.useraccount_sql =
            "DELETE FROM useraccountTbl WHERE user_id = '"+ user_id_txtbox.Text +"'";
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterDelete();
            useraccount_db_connect.useraccount_sql =
            "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, " +
            "user_id, username, password, user_status, account_type FROM pos_empRegTbl " +
            "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id ";
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterSelect();
            useraccount_db_connect.useraccount_sqldatasetSelect();
            dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            useraccount_db_connect.useraccount_sql =
            "INSERT INTO useraccountTbl (user_id, account_type, username, password, confirm_password, user_status, emp_id) " +
            "VALUES ('" + user_id_txtbox.Text + "', '" + account_type_combo.Text + "', '" + username_txtbox.Text + "', '" +
            pass_txtbox.Text + "', '" + confirm_pass_txtbox.Text + "', '" + status_combo.Text + "', '" + emp_id_txtbox.Text + "')";
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterInsert();
            useraccount_db_connect.useraccount_sql =
            "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, " +
            "user_id, username, password, user_status, account_type FROM pos_empRegTbl " +
            "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id ";
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterSelect();
            useraccount_db_connect.useraccount_sqldatasetSelect();
            dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

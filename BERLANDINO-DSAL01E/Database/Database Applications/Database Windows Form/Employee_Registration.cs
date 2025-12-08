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
    public partial class Employee_Registration : Form
    {
        string picpath;
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        employee_dbconnection emp_db_connect = new employee_dbconnection();

        public Employee_Registration()
        {
            emp_db_connect.employee_connString();
            InitializeComponent();
        }

        private void cleartextboxes()
        {
            empID_txtbox.Clear(); fname_txtbox.Clear(); mname_txtbox.Clear();
            surname_txtbox.Clear(); sss_txtbox.Clear(); tin_txtbox.Clear();
            philhealth_txtbox.Clear(); pagibig_txtbox.Clear(); height_txtbox.Clear();
            weight_txtbox.Clear(); years_study_txtbox.Clear(); house_num_txtbox.Clear();
            subdvi_txtbox.Clear(); phase_num_txtbox.Clear(); street_txtbox.Clear();
            barangay_txtbox.Clear(); muni_txtbox.Clear(); city_txtbox.Clear();
            province_txtbox.Clear(); country_txtbox.Clear(); zip_txtbox.Clear();
            elem_name_txtbox.Clear(); elem_address_txtbox.Clear(); elem_award_txtbox.Clear();
            junior_name_txtbox.Clear(); junior_address_txtbox.Clear(); junior_award_txtbox.Clear();
            senior_name_txtbox.Clear(); senior_address_txtbox.Clear(); senior_award_txtbox.Clear();
            college_name_txtbox.Clear(); college_address_txtbox.Clear(); college_award_txtbox.Clear();
            college_degree_txtbox.Clear(); other_school_txtbox.Clear(); job_position_txtbox.Clear();
            emp_status_txtbox.Clear(); department_txtbox.Clear(); num_dependants_txtbox.Clear();
            picpath_txtbox.Clear();
            pictureBox1.Image = Image.FromFile("C:\\Users\\fla10\\source\\repos\\diceyxzc\\BERLANDINO_3rd_YEAR_DSAL01E" +
                "\\BERLANDINO-DSAL01E\\Resources\\default_user.jpg");
            empID_txtbox.Focus();
        }

        private void open_file_image()
        {
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.ShowDialog();
        }

        private void Database_Activity_3_Load(object sender, EventArgs e)
        {
            picpath_txtbox.Hide();
            pictureBox1.Image = Image.FromFile("C:\\Users\\fla10\\source\\repos\\diceyxzc\\BERLANDINO_3rd_YEAR_DSAL01E" +
                "\\BERLANDINO-DSAL01E\\Resources\\default_user.jpg");
            emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterSelect();
            emp_db_connect.employee_sqldatasetSelect();
            dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
        }


        private void brws_button_Click(object sender, EventArgs e)
        {
            try
            {
                open_file_image();
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                picpath = openFileDialog.FileName;
                picpath_txtbox.Text = picpath;
            }
            catch (Exception)
            {
                MessageBox.Show("No Image Selected!");
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl WHERE emp_id = '"+ empID_txtbox.Text +"'";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterSelect();
            emp_db_connect.employee_sqldatasetSelect();
            dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
            fname_txtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][2].ToString();

            fname_txtbox.Text            = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][2].ToString();
            mname_txtbox.Text            = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][3].ToString();
            surname_txtbox.Text          = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][4].ToString();
            age_combobox.Text            = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][5].ToString();
            gender_combobox.Text         = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][6].ToString();
            sss_txtbox.Text              = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][7].ToString();
            tin_txtbox.Text              = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][8].ToString();
            philhealth_txtbox.Text        = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][9].ToString();
            pagibig_txtbox.Text          = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][10].ToString();
            status_combobox.Text         = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][11].ToString();
            height_txtbox.Text           = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][12].ToString();
            weight_txtbox.Text           = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][13].ToString();

            years_study_txtbox.Text      = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][14].ToString();
            house_num_txtbox.Text        = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][15].ToString();
            subdvi_txtbox.Text           = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][16].ToString();
            phase_num_txtbox.Text        = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][17].ToString();
            street_txtbox.Text           = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][18].ToString();
            barangay_txtbox.Text         = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][19].ToString();
            muni_txtbox.Text             = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][20].ToString();
            city_txtbox.Text             = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][21].ToString();
            province_txtbox.Text         = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][22].ToString();
            country_txtbox.Text          = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][23].ToString();
            zip_txtbox.Text              = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][24].ToString();

            elem_name_txtbox.Text        = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][25].ToString();
            elem_address_txtbox.Text     = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][26].ToString();
            elem_grad_txtbox.Text        = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][27].ToString();
            elem_award_txtbox.Text       = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][28].ToString();
            junior_name_txtbox.Text      = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][29].ToString();
            junior_address_txtbox.Text   = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][30].ToString();
            junior_graduated_txtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][31].ToString();
            junior_award_txtbox.Text     = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][32].ToString();
            senior_name_txtbox.Text      = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][33].ToString();
            senior_address_txtbox.Text   = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][34].ToString();
            senior_course_txtbox.Text     = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][35].ToString();
            senior_graduated_txtbox.Text = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][36].ToString();
            senior_award_txtbox.Text     = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][37].ToString();
            college_name_txtbox.Text     = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][38].ToString();
            college_address_txtbox.Text  = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][39].ToString();
            college_graduated_txtbox.Text= emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][40].ToString();
            college_degree_txtbox.Text   = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][41].ToString();
            college_award_txtbox.Text    = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][42].ToString();

            other_school_txtbox.Text     = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][43].ToString();
            job_position_txtbox.Text     = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][44].ToString();
            emp_status_txtbox.Text       = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][45].ToString();
            date_hired_txtbox.Text       = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][46].ToString();
            department_txtbox.Text       = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][47].ToString();
            num_dependants_txtbox.Text   = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][48].ToString();
            picpath_txtbox.Text          = emp_db_connect.employee_sql_dataset.Tables[0].Rows[0][49].ToString();
            pictureBox1.Image = Image.FromFile(picpath_txtbox.Text);
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            emp_db_connect.employee_sql = "INSERT INTO pos_empRegTbl " +
            "(emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_sss_no, emp_tin_no, emp_philhealth_no, emp_pagibig_no, " +
            "emp_status, emp_height, emp_weight, years_study, add_house_no, add_subdivision, add_phase, add_street, add_barangay, add_municipality, add_city, add_province, add_country, add_zipcode, " +
            "elem_name, elem_address, elem_grad, elem_award, junior_high_name, junior_high_address, junior_high_grad, junior_high_award, " +
            "senior_high_name, senior_high_address, senior_high_course, senior_high_grad, senior_high_award, college_school_name, college_address, college_year_grad, " +
            "college_course, college_award, others, position, emp_work_status, emp_date_hired, emp_department, emp_no_of_dependents, picpath) " +
            "VALUES ('" + empID_txtbox.Text + "', '" + fname_txtbox.Text + "', '" + mname_txtbox.Text + "', '" + surname_txtbox.Text + "', '" + age_combobox.Text + "', '" + gender_combobox.Text + "', " +
            "'" + sss_txtbox.Text + "', '" + tin_txtbox.Text + "', '" + philhealth_txtbox.Text + "', '" + pagibig_txtbox.Text + "', '" + status_combobox.Text + "', '" + height_txtbox.Text + "', " +
            "'" + weight_txtbox.Text + "', '" + years_study_txtbox.Text + "', '" + house_num_txtbox.Text + "', '" + subdvi_txtbox.Text + "', '" + phase_num_txtbox.Text + "', '" + street_txtbox.Text + "', '" + barangay_txtbox.Text + "', " +
            "'" + muni_txtbox.Text + "', '" + city_txtbox.Text + "', '" + province_txtbox.Text + "', '" + country_txtbox.Text + "', '" + zip_txtbox.Text + "', '" + elem_name_txtbox.Text + "', '" + elem_address_txtbox.Text + "', " +
            "'" + elem_grad_txtbox.Text + "', '" + elem_award_txtbox.Text + "', '" + junior_name_txtbox.Text + "', '" + junior_address_txtbox.Text + "', '" + junior_graduated_txtbox.Text + "', '" + junior_award_txtbox.Text + "', " +
            "'" + senior_name_txtbox.Text + "', '" + senior_address_txtbox.Text + "', '" + senior_course_txtbox.Text + "', '" + senior_graduated_txtbox.Text + "', '" + senior_award_txtbox.Text + "', " +
            "'" + college_name_txtbox.Text + "', '" + college_address_txtbox.Text + "', '" + college_graduated_txtbox.Text + "', '" + college_degree_txtbox.Text + "', '" + college_award_txtbox.Text + "', " +
            "'" + other_school_txtbox.Text + "', '" + job_position_txtbox.Text + "', '" + emp_status_txtbox.Text + "', '" + date_hired_txtbox.Text + "', '" + department_txtbox.Text + "', " +
            "'" + num_dependants_txtbox.Text + "', '" + picpath_txtbox.Text + "')";

            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterInsert();
            emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterSelect();
            emp_db_connect.employee_sqldatasetSelect();
            dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            emp_db_connect.employee_sql =
            "UPDATE pos_empRegTbl SET " +
            "emp_fname = '" + fname_txtbox.Text + "', " +
            "emp_mname = '" + mname_txtbox.Text + "', " +
            "emp_surname = '" + surname_txtbox.Text + "', " +
            "emp_age = '" + age_combobox.Text + "', " +
            "emp_gender = '" + gender_combobox.Text + "', " +
            "emp_sss_no = '" + sss_txtbox.Text + "', " +
            "emp_tin_no = '" + tin_txtbox.Text + "', " +
            "emp_philhealth_no = '" + philhealth_txtbox.Text + "', " +
            "emp_pagibig_no = '" + pagibig_txtbox.Text + "', " +
            "emp_status = '" + status_combobox.Text + "', " +
            "emp_height = '" + height_txtbox.Text + "', " +
            "emp_weight = '" + weight_txtbox.Text + "', " +
            "years_study = '" + years_study_txtbox.Text + "', " +
            "add_house_no = '" + house_num_txtbox.Text + "', " +
            "add_subdivision = '" + subdvi_txtbox.Text + "', " +
            "add_phase = '" + phase_num_txtbox.Text + "', " +
            "add_street = '" + street_txtbox.Text + "', " +
            "add_barangay = '" + barangay_txtbox.Text + "', " +
            "add_municipality = '" + muni_txtbox.Text + "', " +
            "add_city = '" + city_txtbox.Text + "', " +
            "add_province = '" + province_txtbox.Text + "', " +
            "add_country = '" + country_txtbox.Text + "', " +
            "add_zipcode = '" + zip_txtbox.Text + "', " +
            "elem_name = '" + elem_name_txtbox.Text + "', " +
            "elem_address = '" + elem_address_txtbox.Text + "', " +
            "elem_grad = '" + elem_grad_txtbox.Text + "', " +
            "elem_award = '" + elem_award_txtbox.Text + "', " +
            "junior_high_name = '" + junior_name_txtbox.Text + "', " +
            "junior_high_address = '" + junior_address_txtbox.Text + "', " +
            "junior_high_grad = '" + junior_graduated_txtbox.Text + "', " +
            "junior_high_award = '" + junior_award_txtbox.Text + "', " +
            "senior_high_name = '" + senior_name_txtbox.Text + "', " +
            "senior_high_address = '" + senior_address_txtbox.Text + "', " +
            "senior_high_course = '" + senior_course_txtbox.Text + "', " +   
            "senior_high_grad = '" + senior_graduated_txtbox.Text + "', " +
            "senior_high_award = '" + senior_award_txtbox.Text + "', " +
            "college_school_name = '" + college_name_txtbox.Text + "', " +
            "college_address = '" + college_address_txtbox.Text + "', " +
            "college_year_grad = '" + college_graduated_txtbox.Text + "', " +
            "college_course = '" + college_degree_txtbox.Text + "', " +
            "college_award = '" + college_award_txtbox.Text + "', " +
            "others = '" + other_school_txtbox.Text + "', " +
            "position = '" + job_position_txtbox.Text + "', " +
            "emp_work_status = '" + emp_status_txtbox.Text + "', " +
            "emp_date_hired = '" + date_hired_txtbox.Text + "', " +
            "emp_department = '" + department_txtbox.Text + "', " +
            "emp_no_of_dependents = '" + num_dependants_txtbox.Text + "', " +
            "picpath = '" + picpath_txtbox.Text + "' " +
            "WHERE emp_id = '" + empID_txtbox.Text + "'";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterInsert();
            emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterSelect();
            emp_db_connect.employee_sqldatasetSelect();
            dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            emp_db_connect.employee_sql = "DELETE FROM pos_empRegTbl WHERE emp_id = '" + empID_txtbox.Text + "'";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterInsert();
            emp_db_connect.employee_sql = "SELECT * FROM pos_empRegTbl";
            emp_db_connect.employee_cmd();
            emp_db_connect.employee_sqladapterSelect();
            emp_db_connect.employee_sqldatasetSelect();
            dataGridView1.DataSource = emp_db_connect.employee_sql_dataset.Tables[0];
            cleartextboxes();
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

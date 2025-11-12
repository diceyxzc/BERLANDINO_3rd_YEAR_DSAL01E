using BERLANDINO_DSAL01E.Lesson_8.Class_Forms;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERLANDINO_DSAL01E.Database
{
    public partial class DB_Example1 : Form
    {
        String picpath;
        DB_Class db = new DB_Class();

        public DB_Example1()
        {
            InitializeComponent();
        }

        private void DB_Example1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp";
            openFileDialog.Title = "Select Employee Picture";
            openFileDialog.ShowDialog();

            picpath = openFileDialog.FileName;
            picture_path_txtbox.Text = picpath;
            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize and open the database connection
                db.initiate_connection();
                db.connection.Open();

                // Insert a new student record into the table
                db.sql = "INSERT INTO studentTbl(student_id, student_name, department, picpath) VALUES ('" +
                    student_num_txtbox.Text + "', '" + student_name_txtbox.Text + "', '" +
                    department_txtbox.Text + "', '" + picture_path_txtbox.Text + "')";
                db.new_command();
                db.insert_command(); // Executes the INSERT statement

                // Refresh and display the updated table in the DataGridView
                db.sql = "SELECT * FROM studentTbl";
                db.new_command();
                db.select_command();
                db.data_set();
                Data_Grid_View.DataSource = db.dset.Tables[0];

                // Reset the picture to default and clear input fields
                db.default_image(pictureBox1);
                db.clear_inputs(picture_path_txtbox, student_num_txtbox, student_name_txtbox, department_txtbox);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.connection.Close();
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize and open the database connection
                db.initiate_connection();
                db.connection.Open();

                // Select the record for the entered student ID
                db.sql = "SELECT * FROM studentTbl WHERE student_id = '" + student_num_txtbox.Text + "'";
                db.new_command();
                db.select_command();
                db.data_set();

                // Bind the result to the DataGridView
                Data_Grid_View.DataSource = db.dset.Tables[0];

                // Populate the textboxes and picture with the retrieved data
                student_name_txtbox.Text = db.dset.Tables[0].Rows[0][1].ToString();
                department_txtbox.Text = db.dset.Tables[0].Rows[0][2].ToString();
                picture_path_txtbox.Text = db.dset.Tables[0].Rows[0][3].ToString();
                pictureBox1.Image = Image.FromFile(picture_path_txtbox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Invalid Search ID");
            }
            finally
            {
                db.connection.Close();
            }
        }

        private void dlt_btn_Click(object sender, EventArgs e)
        {
            try
            {
                db.initiate_connection();
                db.connection.Open();

                // Delete the record based on student_id
                db.sql = "DELETE FROM studentTbl WHERE student_id = '" + student_num_txtbox.Text + "'";
                db.new_command();
                db.insert_command(); // Executes the DELETE statement

                // Refresh the table to show remaining records
                db.sql = "SELECT * FROM studentTbl";
                db.new_command();
                db.select_command();
                db.data_set();

                Data_Grid_View.DataSource = db.dset.Tables[0];

                // Reset image and clear input fields
                db.default_image(pictureBox1);
                db.clear_inputs(picture_path_txtbox, student_num_txtbox, student_name_txtbox, department_txtbox);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.connection.Close();
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                db.initiate_connection();
                db.connection.Open();

                // Update the record based on student_id
                db.sql = "UPDATE studentTbl SET student_name = '" + student_name_txtbox.Text +
                          "', department = '" + department_txtbox.Text +
                          "', picpath = '" + picture_path_txtbox.Text +
                          "' WHERE student_id = '" + student_num_txtbox.Text + "'";

                db.new_command();
                db.insert_command(); // Executes the UPDATE statement

                // Refresh the table
                db.sql = "SELECT * FROM studentTbl";
                db.new_command();
                db.select_command();
                db.data_set();

                Data_Grid_View.DataSource = db.dset.Tables[0];

                // Reset image and inputs
                db.default_image(pictureBox1);
                db.clear_inputs(picture_path_txtbox, student_num_txtbox, student_name_txtbox, department_txtbox);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.connection.Close();
            }
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            db.default_image(pictureBox1);
            db.clear_inputs(picture_path_txtbox, student_num_txtbox, student_name_txtbox, department_txtbox);
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            try
            {
                db.initiate_connection();
                db.connection.Open();

                // Refresh the table
                db.sql = "SELECT * FROM studentTbl";
                db.new_command();
                db.select_command();
                db.data_set();

                Data_Grid_View.DataSource = db.dset.Tables[0];
                db.default_image(pictureBox1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.connection.Close();
            }
        }
    }
}
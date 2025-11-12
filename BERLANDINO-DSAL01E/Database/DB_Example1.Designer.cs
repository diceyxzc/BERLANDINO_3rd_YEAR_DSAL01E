namespace BERLANDINO_DSAL01E.Database
{
    partial class DB_Example1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            picture_path_txtbox = new TextBox();
            Data_Grid_View = new DataGridView();
            save_btn = new Button();
            label2 = new Label();
            label4 = new Label();
            student_num_txtbox = new TextBox();
            student_name_txtbox = new TextBox();
            department_txtbox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            edit_btn = new Button();
            search_btn = new Button();
            show_btn = new Button();
            dlt_btn = new Button();
            new_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Data_Grid_View).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(22, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(452, 444);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(543, 34);
            label1.Name = "label1";
            label1.Size = new Size(414, 40);
            label1.TabIndex = 1;
            label1.Text = "Calvin Sample Program";
            // 
            // picture_path_txtbox
            // 
            picture_path_txtbox.Location = new Point(688, 86);
            picture_path_txtbox.Name = "picture_path_txtbox";
            picture_path_txtbox.Size = new Size(269, 23);
            picture_path_txtbox.TabIndex = 2;
            // 
            // Data_Grid_View
            // 
            Data_Grid_View.BackgroundColor = SystemColors.ControlLightLight;
            Data_Grid_View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_Grid_View.Location = new Point(507, 202);
            Data_Grid_View.Name = "Data_Grid_View";
            Data_Grid_View.Size = new Size(472, 162);
            Data_Grid_View.TabIndex = 3;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(507, 370);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(149, 51);
            save_btn.TabIndex = 4;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(507, 114);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 5;
            label2.Text = "Student Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(507, 89);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 7;
            label4.Text = "Picture Path:";
            // 
            // student_num_txtbox
            // 
            student_num_txtbox.Location = new Point(688, 115);
            student_num_txtbox.Name = "student_num_txtbox";
            student_num_txtbox.Size = new Size(269, 23);
            student_num_txtbox.TabIndex = 8;
            // 
            // student_name_txtbox
            // 
            student_name_txtbox.Location = new Point(688, 144);
            student_name_txtbox.Name = "student_name_txtbox";
            student_name_txtbox.Size = new Size(291, 23);
            student_name_txtbox.TabIndex = 9;
            // 
            // department_txtbox
            // 
            department_txtbox.Location = new Point(688, 173);
            department_txtbox.Name = "department_txtbox";
            department_txtbox.Size = new Size(291, 23);
            department_txtbox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(507, 143);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 11;
            label5.Text = "Student Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(507, 172);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 12;
            label6.Text = "Department:";
            // 
            // edit_btn
            // 
            edit_btn.Location = new Point(507, 427);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(149, 51);
            edit_btn.TabIndex = 13;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = true;
            edit_btn.Click += edit_btn_Click;
            // 
            // search_btn
            // 
            search_btn.Location = new Point(662, 370);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(162, 51);
            search_btn.TabIndex = 14;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // show_btn
            // 
            show_btn.Location = new Point(662, 427);
            show_btn.Name = "show_btn";
            show_btn.Size = new Size(162, 51);
            show_btn.TabIndex = 15;
            show_btn.Text = "Show";
            show_btn.UseVisualStyleBackColor = true;
            show_btn.Click += show_btn_Click;
            // 
            // dlt_btn
            // 
            dlt_btn.Location = new Point(830, 370);
            dlt_btn.Name = "dlt_btn";
            dlt_btn.Size = new Size(149, 51);
            dlt_btn.TabIndex = 16;
            dlt_btn.Text = "Delete";
            dlt_btn.UseVisualStyleBackColor = true;
            dlt_btn.Click += dlt_btn_Click;
            // 
            // new_btn
            // 
            new_btn.Location = new Point(830, 427);
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(149, 51);
            new_btn.TabIndex = 17;
            new_btn.Text = "New";
            new_btn.UseVisualStyleBackColor = true;
            new_btn.Click += new_btn_Click;
            // 
            // DB_Example1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1012, 504);
            Controls.Add(new_btn);
            Controls.Add(dlt_btn);
            Controls.Add(show_btn);
            Controls.Add(search_btn);
            Controls.Add(edit_btn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(department_txtbox);
            Controls.Add(student_name_txtbox);
            Controls.Add(student_num_txtbox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(save_btn);
            Controls.Add(Data_Grid_View);
            Controls.Add(picture_path_txtbox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "DB_Example1";
            Text = "Form1";
            Load += DB_Example1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Data_Grid_View).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox picture_path_txtbox;
        private DataGridView Data_Grid_View;
        private Button save_btn;
        private Label label2;
        private Label label4;
        private TextBox student_num_txtbox;
        private TextBox student_name_txtbox;
        private TextBox department_txtbox;
        private Label label5;
        private Label label6;
        private Button edit_btn;
        private Button search_btn;
        private Button show_btn;
        private Button dlt_btn;
        private Button new_btn;
    }
}
namespace BERLANDINO_DSAL01E.Database.Activities
{
    partial class User_Account_Registration
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
            label1 = new Label();
            emp_id_txtbox = new TextBox();
            search_btn = new Button();
            status_combo = new ComboBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            search_for_btn = new Button();
            user_id_txtbox = new TextBox();
            fname_txtbox = new TextBox();
            surname_txtbox = new TextBox();
            mname_txtbox = new TextBox();
            position_txtbox = new TextBox();
            username_txtbox = new TextBox();
            pass_txtbox = new TextBox();
            confirm_pass_txtbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            account_type_combo = new ComboBox();
            update_btn = new Button();
            delete_btn = new Button();
            picpathtxtbox = new TextBox();
            submit_btn = new Button();
            cancel_btn = new Button();
            exit_btn = new Button();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 0;
            label1.Text = "Employee ID:";
            // 
            // emp_id_txtbox
            // 
            emp_id_txtbox.Font = new Font("Segoe UI", 9.75F);
            emp_id_txtbox.Location = new Point(166, 21);
            emp_id_txtbox.Name = "emp_id_txtbox";
            emp_id_txtbox.Size = new Size(192, 25);
            emp_id_txtbox.TabIndex = 1;
            // 
            // search_btn
            // 
            search_btn.Font = new Font("Segoe UI", 9.75F);
            search_btn.Location = new Point(364, 21);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(142, 23);
            search_btn.TabIndex = 2;
            search_btn.Text = "SEARCH";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // status_combo
            // 
            status_combo.FormattingEnabled = true;
            status_combo.Location = new Point(166, 207);
            status_combo.Name = "status_combo";
            status_combo.Size = new Size(464, 23);
            status_combo.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(640, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 275);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(838, 243);
            dataGridView1.TabIndex = 5;
            // 
            // search_for_btn
            // 
            search_for_btn.Font = new Font("Segoe UI", 9.75F);
            search_for_btn.Location = new Point(364, 52);
            search_for_btn.Name = "search_for_btn";
            search_for_btn.Size = new Size(142, 23);
            search_for_btn.TabIndex = 7;
            search_for_btn.Text = "SEARCH FOR UPDATE";
            search_for_btn.UseVisualStyleBackColor = true;
            search_for_btn.Click += search_for_btn_Click;
            // 
            // user_id_txtbox
            // 
            user_id_txtbox.Font = new Font("Segoe UI", 9.75F);
            user_id_txtbox.Location = new Point(166, 52);
            user_id_txtbox.Name = "user_id_txtbox";
            user_id_txtbox.Size = new Size(192, 25);
            user_id_txtbox.TabIndex = 6;
            // 
            // fname_txtbox
            // 
            fname_txtbox.Font = new Font("Segoe UI", 9.75F);
            fname_txtbox.Location = new Point(166, 83);
            fname_txtbox.Name = "fname_txtbox";
            fname_txtbox.Size = new Size(154, 25);
            fname_txtbox.TabIndex = 8;
            // 
            // surname_txtbox
            // 
            surname_txtbox.Font = new Font("Segoe UI", 9.75F);
            surname_txtbox.Location = new Point(476, 83);
            surname_txtbox.Name = "surname_txtbox";
            surname_txtbox.Size = new Size(154, 25);
            surname_txtbox.TabIndex = 9;
            // 
            // mname_txtbox
            // 
            mname_txtbox.Font = new Font("Segoe UI", 9.75F);
            mname_txtbox.Location = new Point(321, 83);
            mname_txtbox.Name = "mname_txtbox";
            mname_txtbox.Size = new Size(154, 25);
            mname_txtbox.TabIndex = 10;
            // 
            // position_txtbox
            // 
            position_txtbox.Font = new Font("Segoe UI", 9.75F);
            position_txtbox.Location = new Point(166, 114);
            position_txtbox.Name = "position_txtbox";
            position_txtbox.Size = new Size(464, 25);
            position_txtbox.TabIndex = 11;
            // 
            // username_txtbox
            // 
            username_txtbox.Font = new Font("Segoe UI", 9.75F);
            username_txtbox.Location = new Point(166, 145);
            username_txtbox.Name = "username_txtbox";
            username_txtbox.Size = new Size(464, 25);
            username_txtbox.TabIndex = 12;
            // 
            // pass_txtbox
            // 
            pass_txtbox.Font = new Font("Segoe UI", 9.75F);
            pass_txtbox.Location = new Point(166, 176);
            pass_txtbox.Name = "pass_txtbox";
            pass_txtbox.Size = new Size(234, 25);
            pass_txtbox.TabIndex = 13;
            // 
            // confirm_pass_txtbox
            // 
            confirm_pass_txtbox.Font = new Font("Segoe UI", 9.75F);
            confirm_pass_txtbox.Location = new Point(406, 176);
            confirm_pass_txtbox.Name = "confirm_pass_txtbox";
            confirm_pass_txtbox.Size = new Size(224, 25);
            confirm_pass_txtbox.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 52);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 15;
            label2.Text = "User ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 85);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 16;
            label3.Text = "Employee Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 116);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 17;
            label4.Text = "Designation:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 147);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 18;
            label5.Text = "Username:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 178);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 19;
            label6.Text = "Password:";
            // 
            // account_type_combo
            // 
            account_type_combo.FormattingEnabled = true;
            account_type_combo.Location = new Point(166, 236);
            account_type_combo.Name = "account_type_combo";
            account_type_combo.Size = new Size(234, 23);
            account_type_combo.TabIndex = 20;
            // 
            // update_btn
            // 
            update_btn.Font = new Font("Segoe UI", 9.75F);
            update_btn.Location = new Point(406, 234);
            update_btn.Name = "update_btn";
            update_btn.RightToLeft = RightToLeft.Yes;
            update_btn.Size = new Size(112, 23);
            update_btn.TabIndex = 21;
            update_btn.Text = "UPDATE";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Font = new Font("Segoe UI", 9.75F);
            delete_btn.Location = new Point(524, 236);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(106, 23);
            delete_btn.TabIndex = 22;
            delete_btn.Text = "DELETE";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // picpathtxtbox
            // 
            picpathtxtbox.Font = new Font("Segoe UI", 9.75F);
            picpathtxtbox.Location = new Point(654, 128);
            picpathtxtbox.Name = "picpathtxtbox";
            picpathtxtbox.Size = new Size(194, 25);
            picpathtxtbox.TabIndex = 23;
            // 
            // submit_btn
            // 
            submit_btn.Font = new Font("Segoe UI", 9.75F);
            submit_btn.Location = new Point(706, 178);
            submit_btn.Name = "submit_btn";
            submit_btn.RightToLeft = RightToLeft.Yes;
            submit_btn.Size = new Size(112, 23);
            submit_btn.TabIndex = 24;
            submit_btn.Text = "SUBMIT";
            submit_btn.UseVisualStyleBackColor = true;
            submit_btn.Click += submit_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Font = new Font("Segoe UI", 9.75F);
            cancel_btn.Location = new Point(706, 207);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.RightToLeft = RightToLeft.Yes;
            cancel_btn.Size = new Size(112, 23);
            cancel_btn.TabIndex = 25;
            cancel_btn.Text = "CANCEL";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.Font = new Font("Segoe UI", 9.75F);
            exit_btn.Location = new Point(706, 236);
            exit_btn.Name = "exit_btn";
            exit_btn.RightToLeft = RightToLeft.Yes;
            exit_btn.Size = new Size(112, 23);
            exit_btn.TabIndex = 26;
            exit_btn.Text = "EXIT";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 207);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 27;
            label7.Text = "Status:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 234);
            label8.Name = "label8";
            label8.Size = new Size(105, 21);
            label8.TabIndex = 28;
            label8.Text = "Account Type:";
            // 
            // User_Account_Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(881, 536);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(exit_btn);
            Controls.Add(cancel_btn);
            Controls.Add(submit_btn);
            Controls.Add(picpathtxtbox);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(account_type_combo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(confirm_pass_txtbox);
            Controls.Add(pass_txtbox);
            Controls.Add(username_txtbox);
            Controls.Add(position_txtbox);
            Controls.Add(mname_txtbox);
            Controls.Add(surname_txtbox);
            Controls.Add(fname_txtbox);
            Controls.Add(search_for_btn);
            Controls.Add(user_id_txtbox);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(status_combo);
            Controls.Add(search_btn);
            Controls.Add(emp_id_txtbox);
            Controls.Add(label1);
            Name = "User_Account_Registration";
            Text = "User_Account_Registration";
            Load += Database_Activity_8_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox emp_id_txtbox;
        private Button search_btn;
        private ComboBox status_combo;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button search_for_btn;
        private TextBox user_id_txtbox;
        private TextBox fname_txtbox;
        private TextBox surname_txtbox;
        private TextBox mname_txtbox;
        private TextBox position_txtbox;
        private TextBox username_txtbox;
        private TextBox pass_txtbox;
        private TextBox confirm_pass_txtbox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox account_type_combo;
        private Button update_btn;
        private Button delete_btn;
        private TextBox picpathtxtbox;
        private Button submit_btn;
        private Button cancel_btn;
        private Button exit_btn;
        private Label label7;
        private Label label8;
    }
}
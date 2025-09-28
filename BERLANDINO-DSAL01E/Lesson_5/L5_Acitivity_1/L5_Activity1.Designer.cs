namespace BERLANDINO_DSAL01E.Lesson_5
{
    partial class L5_Activity1
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
            panel1 = new Panel();
            login_btn = new Button();
            cancel_btn = new Button();
            password_txtbox = new TextBox();
            username_txtbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.default_user;
            pictureBox1.Location = new Point(359, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(cancel_btn);
            panel1.Controls.Add(password_txtbox);
            panel1.Controls.Add(username_txtbox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 236);
            panel1.TabIndex = 1;
            // 
            // login_btn
            // 
            login_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.Location = new Point(340, 158);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(103, 39);
            login_btn.TabIndex = 6;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel_btn.Location = new Point(457, 158);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(109, 39);
            cancel_btn.TabIndex = 5;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // password_txtbox
            // 
            password_txtbox.Location = new Point(340, 124);
            password_txtbox.Name = "password_txtbox";
            password_txtbox.Size = new Size(226, 23);
            password_txtbox.TabIndex = 3;
            // 
            // username_txtbox
            // 
            username_txtbox.Location = new Point(340, 83);
            username_txtbox.Name = "username_txtbox";
            username_txtbox.Size = new Size(226, 23);
            username_txtbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(250, 126);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 85);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // Login_Example
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 408);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Login_Example";
            Text = "Form1";
            Load += Login_Example_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button login_btn;
        private Button cancel_btn;
        private TextBox password_txtbox;
        private TextBox username_txtbox;
        private Label label2;
        private Label label1;
    }
}
namespace BERLANDINO_DSAL01E.Lesson_5
{
    partial class Login_Form_Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form_Database));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            login_btn = new Button();
            cancel_btn = new Button();
            password_txtbox = new TextBox();
            username_txtbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(793, 228);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 302);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(cancel_btn);
            panel1.Controls.Add(password_txtbox);
            panel1.Controls.Add(username_txtbox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(419, 379);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 458);
            panel1.TabIndex = 1;
            // 
            // login_btn
            // 
            login_btn.Anchor = AnchorStyles.None;
            login_btn.BackColor = SystemColors.ControlLightLight;
            login_btn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.Location = new Point(439, 338);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(183, 55);
            login_btn.TabIndex = 6;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Anchor = AnchorStyles.None;
            cancel_btn.BackColor = SystemColors.ControlLightLight;
            cancel_btn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            cancel_btn.Location = new Point(628, 338);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(168, 55);
            cancel_btn.TabIndex = 5;
            cancel_btn.Text = "Exit";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // password_txtbox
            // 
            password_txtbox.Anchor = AnchorStyles.None;
            password_txtbox.BackColor = SystemColors.ControlLightLight;
            password_txtbox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_txtbox.Location = new Point(442, 273);
            password_txtbox.Name = "password_txtbox";
            password_txtbox.PasswordChar = '*';
            password_txtbox.Size = new Size(354, 35);
            password_txtbox.TabIndex = 3;
            // 
            // username_txtbox
            // 
            username_txtbox.Anchor = AnchorStyles.None;
            username_txtbox.BackColor = SystemColors.ControlLightLight;
            username_txtbox.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_txtbox.Location = new Point(442, 207);
            username_txtbox.Name = "username_txtbox";
            username_txtbox.Size = new Size(354, 36);
            username_txtbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.PaleTurquoise;
            label2.Location = new Point(244, 272);
            label2.Name = "label2";
            label2.Size = new Size(157, 33);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PaleTurquoise;
            label1.Location = new Point(244, 207);
            label1.Name = "label1";
            label1.Size = new Size(162, 33);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Castellar", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkTurquoise;
            label3.Location = new Point(662, 170);
            label3.Name = "label3";
            label3.Size = new Size(630, 77);
            label3.TabIndex = 2;
            label3.Text = "POS LOGIN PAGE";
            // 
            // Login_Form_Database
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Login_Form_Database";
            Text = "Login Form";
            WindowState = FormWindowState.Maximized;
            Load += Login_Example_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label3;
    }
}
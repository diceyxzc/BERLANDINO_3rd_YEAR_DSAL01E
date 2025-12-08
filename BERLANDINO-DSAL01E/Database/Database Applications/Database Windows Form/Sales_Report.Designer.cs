namespace BERLANDINO_DSAL01E.Database.Activities
{
    partial class Sales_Report
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
            option_input_txtbox = new TextBox();
            option_combo = new ComboBox();
            label1 = new Label();
            search_btn = new Button();
            dataGridView1 = new DataGridView();
            back_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // option_input_txtbox
            // 
            option_input_txtbox.Location = new Point(288, 7);
            option_input_txtbox.Name = "option_input_txtbox";
            option_input_txtbox.Size = new Size(122, 23);
            option_input_txtbox.TabIndex = 0;
            // 
            // option_combo
            // 
            option_combo.FormattingEnabled = true;
            option_combo.Location = new Point(145, 7);
            option_combo.Name = "option_combo";
            option_combo.Size = new Size(137, 23);
            option_combo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 2;
            label1.Text = "Select an Option:";
            // 
            // search_btn
            // 
            search_btn.Location = new Point(416, 9);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(75, 23);
            search_btn.TabIndex = 3;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(866, 428);
            dataGridView1.TabIndex = 4;
            // 
            // back_btn
            // 
            back_btn.Location = new Point(497, 10);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(75, 23);
            back_btn.TabIndex = 5;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // Sales_Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(890, 480);
            Controls.Add(back_btn);
            Controls.Add(dataGridView1);
            Controls.Add(search_btn);
            Controls.Add(label1);
            Controls.Add(option_combo);
            Controls.Add(option_input_txtbox);
            Name = "Sales_Report";
            Text = "Sales_Report";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox option_input_txtbox;
        private ComboBox option_combo;
        private Label label1;
        private Button search_btn;
        private DataGridView dataGridView1;
        private Button back_btn;
    }
}
namespace BERLANDINO_DSAL01E
{
    partial class L8_Activity1_Prnt
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
            label3 = new Label();
            label1 = new Label();
            prntDisplayListBox = new ListBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 42);
            label3.TabIndex = 78;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(487, 30);
            label1.TabIndex = 79;
            label1.Text = "4JEE FOOD ORDERING APPLICATION";
            // 
            // prntDisplayListBox
            // 
            prntDisplayListBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prntDisplayListBox.FormattingEnabled = true;
            prntDisplayListBox.ItemHeight = 25;
            prntDisplayListBox.Location = new Point(12, 54);
            prntDisplayListBox.Name = "prntDisplayListBox";
            prntDisplayListBox.Size = new Size(536, 554);
            prntDisplayListBox.TabIndex = 80;
            // 
            // L3_Activity3_Prnt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 644);
            Controls.Add(prntDisplayListBox);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "L3_Activity3_Prnt";
            Text = "Transaction Receipt";
            Load += L3_Activity3_Prnt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        public ListBox prntDisplayListBox;
    }
}
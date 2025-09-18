namespace Lesson_3
{
    partial class Example_3_Print_Form
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
            this.GeerehFoods_lbl = new System.Windows.Forms.Label();
            this.printdisplay_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // GeerehFoods_lbl
            // 
            this.GeerehFoods_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.GeerehFoods_lbl.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeerehFoods_lbl.Location = new System.Drawing.Point(0, 0);
            this.GeerehFoods_lbl.Name = "GeerehFoods_lbl";
            this.GeerehFoods_lbl.Size = new System.Drawing.Size(407, 89);
            this.GeerehFoods_lbl.TabIndex = 141;
            this.GeerehFoods_lbl.Text = "GEEREH FOOD ORDERING APPLICATION";
            this.GeerehFoods_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printdisplay_listbox
            // 
            this.printdisplay_listbox.FormattingEnabled = true;
            this.printdisplay_listbox.ItemHeight = 20;
            this.printdisplay_listbox.Location = new System.Drawing.Point(12, 92);
            this.printdisplay_listbox.Name = "printdisplay_listbox";
            this.printdisplay_listbox.Size = new System.Drawing.Size(383, 344);
            this.printdisplay_listbox.TabIndex = 0;
            // 
            // Example_3_Print_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.GeerehFoods_lbl);
            this.Controls.Add(this.printdisplay_listbox);
            this.Name = "Example_3_Print_Form";
            this.Text = "Example_3_Print_Form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label GeerehFoods_lbl;
        internal System.Windows.Forms.ListBox printdisplay_listbox;
    }
}
namespace Lesson_3.Example_5
{
    partial class Example_5_Prnt
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
            this.prntDisplayListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // prntDisplayListbox
            // 
            this.prntDisplayListbox.FormattingEnabled = true;
            this.prntDisplayListbox.Location = new System.Drawing.Point(13, 13);
            this.prntDisplayListbox.Name = "prntDisplayListbox";
            this.prntDisplayListbox.Size = new System.Drawing.Size(547, 667);
            this.prntDisplayListbox.TabIndex = 0;
            // 
            // Example_5_Prnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 692);
            this.Controls.Add(this.prntDisplayListbox);
            this.Name = "Example_5_Prnt";
            this.Text = "Print_Example#5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox prntDisplayListbox;
    }
}
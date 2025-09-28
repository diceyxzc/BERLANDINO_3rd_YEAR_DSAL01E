namespace BERLANDINO_DSAL01E.Lesson_5
{
    partial class L5_Activity1_Main
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
            menuStrip1 = new MenuStrip();
            pOSCENTERToolStripMenuItem = new ToolStripMenuItem();
            pOSAdministratorToolStripMenuItem = new ToolStripMenuItem();
            userAccountToolStripMenuItem = new ToolStripMenuItem();
            payrollToolStripMenuItem = new ToolStripMenuItem();
            employeeInformationToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            jEEPOSIncToolStripMenuItem = new ToolStripMenuItem();
            jeePOSOrderingToolStripMenuItem = new ToolStripMenuItem();
            simplePOSToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { pOSCENTERToolStripMenuItem, pOSAdministratorToolStripMenuItem, userAccountToolStripMenuItem, payrollToolStripMenuItem, employeeInformationToolStripMenuItem, reportsToolStripMenuItem, windowToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(690, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pOSCENTERToolStripMenuItem
            // 
            pOSCENTERToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jEEPOSIncToolStripMenuItem, jeePOSOrderingToolStripMenuItem, simplePOSToolStripMenuItem, logoutToolStripMenuItem });
            pOSCENTERToolStripMenuItem.Name = "pOSCENTERToolStripMenuItem";
            pOSCENTERToolStripMenuItem.Size = new Size(83, 20);
            pOSCENTERToolStripMenuItem.Text = "POS Cashier";
            pOSCENTERToolStripMenuItem.Click += pOSCENTERToolStripMenuItem_Click;
            // 
            // pOSAdministratorToolStripMenuItem
            // 
            pOSAdministratorToolStripMenuItem.Name = "pOSAdministratorToolStripMenuItem";
            pOSAdministratorToolStripMenuItem.Size = new Size(117, 20);
            pOSAdministratorToolStripMenuItem.Text = "POS Administrator";
            // 
            // userAccountToolStripMenuItem
            // 
            userAccountToolStripMenuItem.Name = "userAccountToolStripMenuItem";
            userAccountToolStripMenuItem.Size = new Size(90, 20);
            userAccountToolStripMenuItem.Text = "User Account";
            // 
            // payrollToolStripMenuItem
            // 
            payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            payrollToolStripMenuItem.Size = new Size(55, 20);
            payrollToolStripMenuItem.Text = "Payroll";
            // 
            // employeeInformationToolStripMenuItem
            // 
            employeeInformationToolStripMenuItem.Name = "employeeInformationToolStripMenuItem";
            employeeInformationToolStripMenuItem.Size = new Size(137, 20);
            employeeInformationToolStripMenuItem.Text = "Employee Information";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(59, 20);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // windowToolStripMenuItem
            // 
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(63, 20);
            windowToolStripMenuItem.Text = "Window";
            // 
            // jEEPOSIncToolStripMenuItem
            // 
            jEEPOSIncToolStripMenuItem.Name = "jEEPOSIncToolStripMenuItem";
            jEEPOSIncToolStripMenuItem.Size = new Size(180, 22);
            jEEPOSIncToolStripMenuItem.Text = "4Jee POS Inc.";
            // 
            // jeePOSOrderingToolStripMenuItem
            // 
            jeePOSOrderingToolStripMenuItem.Name = "jeePOSOrderingToolStripMenuItem";
            jeePOSOrderingToolStripMenuItem.Size = new Size(180, 22);
            jeePOSOrderingToolStripMenuItem.Text = "4Jee POS Ordering";
            // 
            // simplePOSToolStripMenuItem
            // 
            simplePOSToolStripMenuItem.Name = "simplePOSToolStripMenuItem";
            simplePOSToolStripMenuItem.Size = new Size(180, 22);
            simplePOSToolStripMenuItem.Text = "Simple POS";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(180, 22);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 408);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main_Form";
            Text = "Form2";
            Load += Main_Form_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pOSCENTERToolStripMenuItem;
        private ToolStripMenuItem pOSAdministratorToolStripMenuItem;
        private ToolStripMenuItem userAccountToolStripMenuItem;
        private ToolStripMenuItem payrollToolStripMenuItem;
        private ToolStripMenuItem employeeInformationToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem jEEPOSIncToolStripMenuItem;
        private ToolStripMenuItem jeePOSOrderingToolStripMenuItem;
        private ToolStripMenuItem simplePOSToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}
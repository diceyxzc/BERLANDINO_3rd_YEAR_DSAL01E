namespace BERLANDINO_DSAL01E
{
    partial class L2_Activity3
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
            foodARdbtn = new RadioButton();
            label1 = new Label();
            foodBRdbtn = new RadioButton();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            priceTxtBox = new TextBox();
            discountTxtBox = new TextBox();
            label6 = new Label();
            DisplayPictureBox = new PictureBox();
            clearBtn = new Button();
            exitBtn = new Button();
            label7 = new Label();
            A_FriedChickenCheckBox = new CheckBox();
            A_FriesCheckBox = new CheckBox();
            A_CokeCheckBox = new CheckBox();
            A_SideDishesCheckBox = new CheckBox();
            A_SpecialPizzaCheckBox = new CheckBox();
            label8 = new Label();
            B_HaloHaloCheckBox = new CheckBox();
            B_ChickenCheckBox = new CheckBox();
            B_CarbonaraCheckBox = new CheckBox();
            B_FriesCheckBox = new CheckBox();
            B_HawaiianCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(196, 10);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(591, 44);
            label3.TabIndex = 56;
            label3.Text = "4JEE Food Ordering Application";
            label3.Click += label3_Click;
            // 
            // foodARdbtn
            // 
            foodARdbtn.AutoSize = true;
            foodARdbtn.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foodARdbtn.Location = new Point(92, 186);
            foodARdbtn.Margin = new Padding(4, 3, 4, 3);
            foodARdbtn.Name = "foodARdbtn";
            foodARdbtn.Size = new Size(119, 21);
            foodARdbtn.TabIndex = 57;
            foodARdbtn.TabStop = true;
            foodARdbtn.Text = "Food Bundle A";
            foodARdbtn.UseVisualStyleBackColor = true;
            foodARdbtn.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 137);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 58;
            label1.Text = "Food Order Choices:";
            // 
            // foodBRdbtn
            // 
            foodBRdbtn.AutoSize = true;
            foodBRdbtn.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foodBRdbtn.Location = new Point(92, 234);
            foodBRdbtn.Margin = new Padding(4, 3, 4, 3);
            foodBRdbtn.Name = "foodBRdbtn";
            foodBRdbtn.Size = new Size(119, 21);
            foodBRdbtn.TabIndex = 59;
            foodBRdbtn.TabStop = true;
            foodBRdbtn.Text = "Food Bundle B";
            foodBRdbtn.UseVisualStyleBackColor = true;
            foodBRdbtn.CheckedChanged += foodBRdbtn_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 294);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 60;
            label2.Text = "Order Details:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.25F);
            label4.Location = new Point(92, 338);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 61;
            label4.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.25F);
            label5.Location = new Point(89, 380);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 62;
            label5.Text = "Discount:";
            // 
            // priceTxtBox
            // 
            priceTxtBox.Location = new Point(205, 338);
            priceTxtBox.Margin = new Padding(4, 3, 4, 3);
            priceTxtBox.Name = "priceTxtBox";
            priceTxtBox.Size = new Size(324, 23);
            priceTxtBox.TabIndex = 63;
            // 
            // discountTxtBox
            // 
            discountTxtBox.Location = new Point(205, 380);
            discountTxtBox.Margin = new Padding(4, 3, 4, 3);
            discountTxtBox.Name = "discountTxtBox";
            discountTxtBox.Size = new Size(324, 23);
            discountTxtBox.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.25F);
            label6.Location = new Point(89, 523);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 17);
            label6.TabIndex = 65;
            label6.Text = "Order Image:";
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.BorderStyle = BorderStyle.FixedSingle;
            DisplayPictureBox.Location = new Point(205, 426);
            DisplayPictureBox.Margin = new Padding(4, 3, 4, 3);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(324, 210);
            DisplayPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            DisplayPictureBox.TabIndex = 66;
            DisplayPictureBox.TabStop = false;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.Location = new Point(96, 668);
            clearBtn.Margin = new Padding(4, 3, 4, 3);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(209, 73);
            clearBtn.TabIndex = 67;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.Location = new Point(312, 668);
            exitBtn.Margin = new Padding(4, 3, 4, 3);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(218, 73);
            exitBtn.TabIndex = 68;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(580, 137);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(138, 20);
            label7.TabIndex = 69;
            label7.Text = "Food Bundle A:";
            // 
            // A_FriedChickenCheckBox
            // 
            A_FriedChickenCheckBox.AutoSize = true;
            A_FriedChickenCheckBox.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            A_FriedChickenCheckBox.Location = new Point(623, 186);
            A_FriedChickenCheckBox.Margin = new Padding(4, 3, 4, 3);
            A_FriedChickenCheckBox.Name = "A_FriedChickenCheckBox";
            A_FriedChickenCheckBox.Size = new Size(225, 21);
            A_FriedChickenCheckBox.TabIndex = 70;
            A_FriedChickenCheckBox.Text = "10 Pcs. Delicious Fried Chicken";
            A_FriedChickenCheckBox.UseVisualStyleBackColor = true;
            // 
            // A_FriesCheckBox
            // 
            A_FriesCheckBox.AutoSize = true;
            A_FriesCheckBox.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            A_FriesCheckBox.Location = new Point(623, 217);
            A_FriesCheckBox.Margin = new Padding(4, 3, 4, 3);
            A_FriesCheckBox.Name = "A_FriesCheckBox";
            A_FriesCheckBox.Size = new Size(111, 21);
            A_FriesCheckBox.TabIndex = 71;
            A_FriesCheckBox.Text = "2 Large Fries";
            A_FriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // A_CokeCheckBox
            // 
            A_CokeCheckBox.AutoSize = true;
            A_CokeCheckBox.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            A_CokeCheckBox.Location = new Point(623, 248);
            A_CokeCheckBox.Margin = new Padding(4, 3, 4, 3);
            A_CokeCheckBox.Name = "A_CokeCheckBox";
            A_CokeCheckBox.Size = new Size(83, 21);
            A_CokeCheckBox.TabIndex = 72;
            A_CokeCheckBox.Text = "1.5 Coke";
            A_CokeCheckBox.UseVisualStyleBackColor = true;
            A_CokeCheckBox.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // A_SideDishesCheckBox
            // 
            A_SideDishesCheckBox.AutoSize = true;
            A_SideDishesCheckBox.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            A_SideDishesCheckBox.Location = new Point(623, 279);
            A_SideDishesCheckBox.Margin = new Padding(4, 3, 4, 3);
            A_SideDishesCheckBox.Name = "A_SideDishesCheckBox";
            A_SideDishesCheckBox.Size = new Size(114, 21);
            A_SideDishesCheckBox.TabIndex = 73;
            A_SideDishesCheckBox.Text = "4 Side Dishes";
            A_SideDishesCheckBox.UseVisualStyleBackColor = true;
            // 
            // A_SpecialPizzaCheckBox
            // 
            A_SpecialPizzaCheckBox.AutoSize = true;
            A_SpecialPizzaCheckBox.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            A_SpecialPizzaCheckBox.Location = new Point(623, 310);
            A_SpecialPizzaCheckBox.Margin = new Padding(4, 3, 4, 3);
            A_SpecialPizzaCheckBox.Name = "A_SpecialPizzaCheckBox";
            A_SpecialPizzaCheckBox.Size = new Size(166, 21);
            A_SpecialPizzaCheckBox.TabIndex = 74;
            A_SpecialPizzaCheckBox.Text = "Special Pizza Delights";
            A_SpecialPizzaCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(580, 366);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(139, 20);
            label8.TabIndex = 75;
            label8.Text = "Food Bundle B:";
            // 
            // B_HaloHaloCheckBox
            // 
            B_HaloHaloCheckBox.AutoSize = true;
            B_HaloHaloCheckBox.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_HaloHaloCheckBox.Location = new Point(623, 414);
            B_HaloHaloCheckBox.Margin = new Padding(4, 3, 4, 3);
            B_HaloHaloCheckBox.Name = "B_HaloHaloCheckBox";
            B_HaloHaloCheckBox.Size = new Size(241, 21);
            B_HaloHaloCheckBox.TabIndex = 76;
            B_HaloHaloCheckBox.Text = "4 Cups Special Halo Halo Regular";
            B_HaloHaloCheckBox.UseVisualStyleBackColor = true;
            // 
            // B_ChickenCheckBox
            // 
            B_ChickenCheckBox.AutoSize = true;
            B_ChickenCheckBox.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_ChickenCheckBox.Location = new Point(623, 445);
            B_ChickenCheckBox.Margin = new Padding(4, 3, 4, 3);
            B_ChickenCheckBox.Name = "B_ChickenCheckBox";
            B_ChickenCheckBox.Size = new Size(217, 21);
            B_ChickenCheckBox.TabIndex = 77;
            B_ChickenCheckBox.Text = "6 Pcs. Delicious Fried Chicken";
            B_ChickenCheckBox.UseVisualStyleBackColor = true;
            // 
            // B_CarbonaraCheckBox
            // 
            B_CarbonaraCheckBox.AutoSize = true;
            B_CarbonaraCheckBox.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_CarbonaraCheckBox.Location = new Point(623, 477);
            B_CarbonaraCheckBox.Margin = new Padding(4, 3, 4, 3);
            B_CarbonaraCheckBox.Name = "B_CarbonaraCheckBox";
            B_CarbonaraCheckBox.Size = new Size(192, 21);
            B_CarbonaraCheckBox.TabIndex = 78;
            B_CarbonaraCheckBox.Text = "1 Family Pack Carbonaras";
            B_CarbonaraCheckBox.UseVisualStyleBackColor = true;
            // 
            // B_FriesCheckBox
            // 
            B_FriesCheckBox.AutoSize = true;
            B_FriesCheckBox.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_FriesCheckBox.Location = new Point(623, 508);
            B_FriesCheckBox.Margin = new Padding(4, 3, 4, 3);
            B_FriesCheckBox.Name = "B_FriesCheckBox";
            B_FriesCheckBox.Size = new Size(149, 21);
            B_FriesCheckBox.TabIndex = 79;
            B_FriesCheckBox.Text = "1 Family Pack Fries";
            B_FriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // B_HawaiianCheckBox
            // 
            B_HawaiianCheckBox.AutoSize = true;
            B_HawaiianCheckBox.Font = new Font("Microsoft Sans Serif", 10.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_HawaiianCheckBox.Location = new Point(623, 539);
            B_HawaiianCheckBox.Margin = new Padding(4, 3, 4, 3);
            B_HawaiianCheckBox.Name = "B_HawaiianCheckBox";
            B_HawaiianCheckBox.Size = new Size(187, 21);
            B_HawaiianCheckBox.TabIndex = 80;
            B_HawaiianCheckBox.Text = "1 Medium Hawaiian Pizza";
            B_HawaiianCheckBox.UseVisualStyleBackColor = true;
            // 
            // L2_Activity3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 778);
            Controls.Add(B_HawaiianCheckBox);
            Controls.Add(B_FriesCheckBox);
            Controls.Add(B_CarbonaraCheckBox);
            Controls.Add(B_ChickenCheckBox);
            Controls.Add(B_HaloHaloCheckBox);
            Controls.Add(label8);
            Controls.Add(A_SpecialPizzaCheckBox);
            Controls.Add(A_SideDishesCheckBox);
            Controls.Add(A_CokeCheckBox);
            Controls.Add(A_FriesCheckBox);
            Controls.Add(A_FriedChickenCheckBox);
            Controls.Add(label7);
            Controls.Add(exitBtn);
            Controls.Add(clearBtn);
            Controls.Add(DisplayPictureBox);
            Controls.Add(label6);
            Controls.Add(discountTxtBox);
            Controls.Add(priceTxtBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(foodBRdbtn);
            Controls.Add(label1);
            Controls.Add(foodARdbtn);
            Controls.Add(label3);
            Margin = new Padding(4, 3, 4, 3);
            Name = "L2_Activity3";
            Text = "Example 4";
            Load += Activity3_Load;
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton foodARdbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton foodBRdbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.TextBox discountTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox DisplayPictureBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox A_FriedChickenCheckBox;
        private System.Windows.Forms.CheckBox A_FriesCheckBox;
        private System.Windows.Forms.CheckBox A_CokeCheckBox;
        private System.Windows.Forms.CheckBox A_SideDishesCheckBox;
        private System.Windows.Forms.CheckBox A_SpecialPizzaCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox B_HaloHaloCheckBox;
        private System.Windows.Forms.CheckBox B_ChickenCheckBox;
        private System.Windows.Forms.CheckBox B_CarbonaraCheckBox;
        private System.Windows.Forms.CheckBox B_FriesCheckBox;
        private System.Windows.Forms.CheckBox B_HawaiianCheckBox;
    }
}
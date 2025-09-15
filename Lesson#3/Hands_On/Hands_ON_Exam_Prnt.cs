using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_3.Hands_On
{
    public partial class Hands_ON_Exam_Prnt : Form
    {
        public Hands_ON_Exam_Prnt()
        {
            InitializeComponent();
            itemnameTextbox_prnt.Text = itemnameTextbox_prnt.Text;
            itemquantitytxtbox_prnt.Text = itemquantitytxtbox_prnt.Text;
            priceTextbox_prnt.Text = priceTextbox_prnt.Text;
            discountamounttxtbox_prnt.Text = discountamounttxtbox_prnt.Text;
            discountedtxtbox_prnt.Text = discountedtxtbox_prnt.Text;
            qty_totaltxtbox_prnt.Text = qty_totaltxtbox_prnt.Text;
            discount_totaltxtbox_prnt.Text = discount_totaltxtbox_prnt.Text;
            discounted_totaltxtbox_prnt.Text = discounted_totaltxtbox_prnt.Text;
            changetxtbox_prnt.Text = changetxtbox_prnt.Text;
        }

        private void Hands_ON_Exam_Prnt_Load(object sender, EventArgs e)
        {
            itemnameTextbox_prnt.Enabled = false;
            itemquantitytxtbox_prnt.Enabled = false;
            priceTextbox_prnt.Enabled = false;
            discountamounttxtbox_prnt.Enabled = false;
            discountedtxtbox_prnt.Enabled = false;
            qty_totaltxtbox_prnt.Enabled = false;
            discount_totaltxtbox_prnt.Enabled = false;
            discounted_totaltxtbox_prnt.Enabled = false;
            changetxtbox_prnt.Enabled = false;
        }
    }
}

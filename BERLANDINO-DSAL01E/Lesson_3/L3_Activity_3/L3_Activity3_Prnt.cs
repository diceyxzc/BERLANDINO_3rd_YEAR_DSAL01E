using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BERLANDINO_DSAL01E.Lesson_3.L3_Activity_3
{
    public partial class L3_Activity3_Prnt : Form
    {
        public L3_Activity3_Prnt()
        {
            InitializeComponent();
            /* codes below is to display all the contents of the listbox
             from the Activity3.cs form to this current form. */
            prntDisplayListBox.Items.AddRange(prntDisplayListBox.Items);
        }

        private void L3_Activity3_Prnt_Load(object sender, EventArgs e)
        {

        }
    }
}

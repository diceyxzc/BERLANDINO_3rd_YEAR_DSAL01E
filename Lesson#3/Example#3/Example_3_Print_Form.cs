using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_3
{
    public partial class Example_3_Print_Form : Form
    {
        public Example_3_Print_Form()
        {
            InitializeComponent();

            // codes below is to display all the contents of the listbox from the Activity4.cs form to this current form
            printdisplay_listbox.Items.AddRange(printdisplay_listbox.Items);
        }
    }
}

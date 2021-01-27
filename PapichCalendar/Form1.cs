using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapichCalendar
{
    public partial class Form1 : Form
    {
        int year = DateTime.Now.Year;
        public Form1()
        {
            InitializeComponent();
            label1.Text = $"{(year - 2014) * 30 + year}";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked) label1.Text = $"{(year - 2014) * 31 + year}";
            else label1.Text = $"{(year - 2014) * 30 + year}";
        }
    }
}

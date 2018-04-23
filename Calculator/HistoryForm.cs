using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        public void GetSetHistory(string equation, string result)
        {
            if (HFileBox.Text.Equals("There is no history yet"))
            {
                HFileBox.Text = (equation + "=" + result + "\n" + "\n");
            }
            else
            {
                HFileBox.Text += (equation + "=" + result + "\n" + "\n");
            }
        }

        private void DeleteHistory(object sender, EventArgs e)
        {
            HFileBox.Text = "There is no history yet";
        }
    }
}

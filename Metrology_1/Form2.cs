using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metrology_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void macKeibButton_Click(object sender, EventArgs e)
        {
            macKeibOutTextBox.Text = Metrics.MacKeib(Convert.ToInt32(numberOfKnotsTextBox.Text),
                Convert.ToInt32(numberOfEdgesTextBox.Text),
                Convert.ToInt32(numberOfConnectednessTextBox.Text)).ToString();
        }
    }
}

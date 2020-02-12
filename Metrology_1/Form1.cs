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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = Simulation.Sim(Convert.ToInt32(OperandCount_TextBox.Text),
                Convert.ToInt32(OperatorCount_TextBox.Text),
                Convert.ToInt32(ExpCount_TextBox.Text)).ToString();
        }
    }
}
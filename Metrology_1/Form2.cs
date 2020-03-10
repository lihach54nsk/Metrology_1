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

        private void GilbButton_Click(object sender, EventArgs e)
        {
            GilbOutTextBox.Text = Metrics.Gilb(Convert.ToDouble(numberOfOperatorsTextBox.Text),
                Convert.ToDouble(numberOfIFELSETextBox.Text)).ToString();
        }

        private void globalButton_Click(object sender, EventArgs e)
        {
            globalOutTextBox.Text = Metrics.GlobalVarUse(Convert.ToInt32(numberOfGlobalVars.Text),
                Convert.ToInt32(numberOfPossibleUsingGlobalVars.Text)).ToString();
        }

        private void chepinButton_Click(object sender, EventArgs e)
        {
            chepinOutTextBox.Text = Metrics.Chepin(Convert.ToInt32(inputOutputVarsTextBox.Text),
                Convert.ToInt32(modVarsTextBox.Text),
                Convert.ToInt32(controlVarsTextBox.Text),
                Convert.ToInt32(garbageVarsTextBox.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            commentsOutTextBox.Text = Metrics.Comments(Convert.ToDouble(commentsTextBox.Text),
                Convert.ToDouble(programLenghtTextBox.Text)).ToString();
        }

        private void calculateAllButton_Click(object sender, EventArgs e)
        {
            macKeibOutTextBox.Text = Metrics.MacKeib(Convert.ToInt32(numberOfKnotsTextBox.Text),
                Convert.ToInt32(numberOfEdgesTextBox.Text),
                Convert.ToInt32(numberOfConnectednessTextBox.Text)).ToString();
            GilbOutTextBox.Text = Metrics.Gilb(Convert.ToDouble(numberOfOperatorsTextBox.Text),
                Convert.ToDouble(numberOfIFELSETextBox.Text)).ToString();
            globalOutTextBox.Text = Metrics.GlobalVarUse(Convert.ToInt32(numberOfGlobalVars.Text),
                Convert.ToInt32(numberOfPossibleUsingGlobalVars.Text)).ToString();
            chepinOutTextBox.Text = Metrics.Chepin(Convert.ToInt32(inputOutputVarsTextBox.Text),
                Convert.ToInt32(modVarsTextBox.Text),
                Convert.ToInt32(controlVarsTextBox.Text),
                Convert.ToInt32(garbageVarsTextBox.Text)).ToString();
            commentsOutTextBox.Text = Metrics.Comments(Convert.ToDouble(commentsTextBox.Text),
                Convert.ToDouble(programLenghtTextBox.Text)).ToString();
            spanOutTextBox.Text = Metrics.Span(spanTextBox.Text);
        }

        private void spanButton_Click(object sender, EventArgs e)
        {
            spanOutTextBox.Text = Metrics.Span(spanTextBox.Text);
        }
    }
}

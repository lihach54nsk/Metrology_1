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
            dataGridView1.RowCount = 7;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[1].Name = "n=16";
            dataGridView1.Columns[2].Name = "n=32";
            dataGridView1.Columns[3].Name = "n=64";
            dataGridView1.Columns[4].Name = "n=128";
            dataGridView1.Columns[5].Name = "Размер словаря разработанной программы";
            dataGridView1.Rows[1].Cells[0].Value = "Lэ";
            dataGridView1.Rows[2].Cells[0].Value = "Dэ";
            dataGridView1.Rows[3].Cells[0].Value = "Погрешность э";
            dataGridView1.Rows[4].Cells[0].Value = "Lp";
            dataGridView1.Rows[5].Cells[0].Value = "Dp";
            dataGridView1.Rows[6].Cells[0].Value = "Погрешность р";

            var result = Simulation.Sim(1, 15, Convert.ToInt32(ExpCount_TextBox.Text));
            outputTextBox.Text = result[0].ToString();
            dataGridView1.Rows[1].Cells[1].Value = result[0].ToString();
            dataGridView1.Rows[2].Cells[1].Value = result[1].ToString();
            dataGridView1.Rows[3].Cells[1].Value = result[2].ToString();
            dataGridView1.Rows[4].Cells[1].Value = result[3].ToString();
            dataGridView1.Rows[5].Cells[1].Value = result[4].ToString();
            dataGridView1.Rows[6].Cells[1].Value = result[5].ToString();

            result = Simulation.Sim(12, 20, Convert.ToInt32(ExpCount_TextBox.Text));
            dataGridView1.Rows[1].Cells[2].Value = result[0].ToString();
            dataGridView1.Rows[2].Cells[2].Value = result[1].ToString();
            dataGridView1.Rows[3].Cells[2].Value = result[2].ToString();
            dataGridView1.Rows[4].Cells[2].Value = result[3].ToString();
            dataGridView1.Rows[5].Cells[2].Value = result[4].ToString();
            dataGridView1.Rows[6].Cells[2].Value = result[5].ToString();

            result = Simulation.Sim(25, 39, Convert.ToInt32(ExpCount_TextBox.Text));
            dataGridView1.Rows[1].Cells[3].Value = result[0].ToString();
            dataGridView1.Rows[2].Cells[3].Value = result[1].ToString();
            dataGridView1.Rows[3].Cells[3].Value = result[2].ToString();
            dataGridView1.Rows[4].Cells[3].Value = result[3].ToString();
            dataGridView1.Rows[5].Cells[3].Value = result[4].ToString();
            dataGridView1.Rows[6].Cells[3].Value = result[5].ToString();

            result = Simulation.Sim(28, 100, Convert.ToInt32(ExpCount_TextBox.Text));
            dataGridView1.Rows[1].Cells[4].Value = result[0].ToString();
            dataGridView1.Rows[2].Cells[4].Value = result[1].ToString();
            dataGridView1.Rows[3].Cells[4].Value = result[2].ToString();
            dataGridView1.Rows[4].Cells[4].Value = result[3].ToString();
            dataGridView1.Rows[5].Cells[4].Value = result[4].ToString();
            dataGridView1.Rows[6].Cells[4].Value = result[5].ToString();

            result = Simulation.Sim(Convert.ToInt32(OperandCount_TextBox.Text),
                Convert.ToInt32(OperatorCount_TextBox.Text),
                Convert.ToInt32(ExpCount_TextBox.Text));
            dataGridView1.Rows[1].Cells[5].Value = result[0].ToString();
            dataGridView1.Rows[2].Cells[5].Value = result[1].ToString();
            dataGridView1.Rows[3].Cells[5].Value = result[2].ToString();
            dataGridView1.Rows[4].Cells[5].Value = result[3].ToString();
            dataGridView1.Rows[5].Cells[5].Value = result[4].ToString();
            dataGridView1.Rows[6].Cells[5].Value = result[5].ToString();
        }
    }
}
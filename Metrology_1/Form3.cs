﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[1].Name = "Тестовый эксперимент";
            dataGridView1.Columns[2].Name = "Первый эксперимент";
            dataGridView1.Columns[3].Name = "Второй эксперимент";
            dataGridView1.Columns[4].Name = "Третий эксперимент";
            dataGridView1.Columns[5].Name = "Четвёртый эксперимент";

            dataGridView1.Rows[0].Cells[0].Value = "m";
            dataGridView1.Rows[1].Cells[0].Value = "v";
            dataGridView1.Rows[2].Cells[0].Value = "P";

            dataGridView1.Rows[0].Cells[1].Value = "4";
            dataGridView1.Rows[1].Cells[1].Value = "1";

            dataGridView1.Rows[0].Cells[2].Value = "6";
            dataGridView1.Rows[1].Cells[2].Value = "2";

            dataGridView1.Rows[0].Cells[3].Value = "5";
            dataGridView1.Rows[1].Cells[3].Value = "2";

            dataGridView1.Rows[0].Cells[4].Value = "5";
            dataGridView1.Rows[1].Cells[4].Value = "4";

            dataGridView1.Rows[0].Cells[5].Value = "5";
            dataGridView1.Rows[1].Cells[5].Value = "4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int allMistakes = 9;
            const int allMistakes_test = 11;

            dataGridView1.Rows[2].Cells[1].Value = Metrics.Mills(Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value),
                Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value), allMistakes_test);
            dataGridView1.Rows[2].Cells[2].Value = Metrics.Mills(Convert.ToInt32(dataGridView1.Rows[0].Cells[2].Value),
                Convert.ToInt32(dataGridView1.Rows[1].Cells[2].Value), allMistakes);
            dataGridView1.Rows[2].Cells[3].Value = Metrics.Mills(Convert.ToInt32(dataGridView1.Rows[0].Cells[3].Value),
                Convert.ToInt32(dataGridView1.Rows[1].Cells[3].Value), allMistakes);
            dataGridView1.Rows[2].Cells[4].Value = Metrics.Mills(Convert.ToInt32(dataGridView1.Rows[0].Cells[4].Value),
                Convert.ToInt32(dataGridView1.Rows[1].Cells[4].Value), allMistakes);
            dataGridView1.Rows[2].Cells[5].Value = Metrics.Mills(Convert.ToInt32(dataGridView1.Rows[0].Cells[5].Value),
                Convert.ToInt32(dataGridView1.Rows[1].Cells[5].Value), Convert.ToInt32(mistakesTextBox.Text));
        }
    }
}
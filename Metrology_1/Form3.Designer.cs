﻿namespace Metrology_1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MillsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mistakesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // MillsButton
            // 
            this.MillsButton.Location = new System.Drawing.Point(12, 191);
            this.MillsButton.Name = "MillsButton";
            this.MillsButton.Size = new System.Drawing.Size(122, 23);
            this.MillsButton.TabIndex = 1;
            this.MillsButton.Text = "Посчитать Миллса";
            this.MillsButton.UseVisualStyleBackColor = true;
            this.MillsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Общее число вносимых ошибок: ";
            // 
            // mistakesTextBox
            // 
            this.mistakesTextBox.Location = new System.Drawing.Point(666, 39);
            this.mistakesTextBox.Name = "mistakesTextBox";
            this.mistakesTextBox.Size = new System.Drawing.Size(100, 20);
            this.mistakesTextBox.TabIndex = 3;
            this.mistakesTextBox.Text = "9";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 221);
            this.Controls.Add(this.mistakesTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MillsButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MillsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mistakesTextBox;
    }
}
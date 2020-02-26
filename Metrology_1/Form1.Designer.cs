namespace Metrology_1
{
    partial class Form1
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
            this.start = new System.Windows.Forms.Button();
            this.ExpCount_TextBox = new System.Windows.Forms.TextBox();
            this.ExpCount_Label = new System.Windows.Forms.Label();
            this.OperatorCount_Label = new System.Windows.Forms.Label();
            this.OperatorCount_TextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.second_Button = new System.Windows.Forms.Button();
            this.third_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 68);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(162, 52);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // ExpCount_TextBox
            // 
            this.ExpCount_TextBox.Location = new System.Drawing.Point(192, 8);
            this.ExpCount_TextBox.Name = "ExpCount_TextBox";
            this.ExpCount_TextBox.Size = new System.Drawing.Size(100, 20);
            this.ExpCount_TextBox.TabIndex = 1;
            this.ExpCount_TextBox.Text = "1000";
            // 
            // ExpCount_Label
            // 
            this.ExpCount_Label.AutoSize = true;
            this.ExpCount_Label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpCount_Label.Location = new System.Drawing.Point(12, 9);
            this.ExpCount_Label.Name = "ExpCount_Label";
            this.ExpCount_Label.Size = new System.Drawing.Size(171, 16);
            this.ExpCount_Label.TabIndex = 2;
            this.ExpCount_Label.Text = "Количество эксперементов";
            // 
            // OperatorCount_Label
            // 
            this.OperatorCount_Label.AutoSize = true;
            this.OperatorCount_Label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperatorCount_Label.Location = new System.Drawing.Point(12, 43);
            this.OperatorCount_Label.Name = "OperatorCount_Label";
            this.OperatorCount_Label.Size = new System.Drawing.Size(98, 16);
            this.OperatorCount_Label.TabIndex = 5;
            this.OperatorCount_Label.Text = "Длина словаря";
            // 
            // OperatorCount_TextBox
            // 
            this.OperatorCount_TextBox.Location = new System.Drawing.Point(192, 42);
            this.OperatorCount_TextBox.Name = "OperatorCount_TextBox";
            this.OperatorCount_TextBox.Size = new System.Drawing.Size(100, 20);
            this.OperatorCount_TextBox.TabIndex = 6;
            this.OperatorCount_TextBox.Text = "19";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(192, 68);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(100, 20);
            this.outputTextBox.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(298, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 294);
            this.dataGridView1.TabIndex = 8;
            // 
            // second_Button
            // 
            this.second_Button.Location = new System.Drawing.Point(12, 279);
            this.second_Button.Name = "second_Button";
            this.second_Button.Size = new System.Drawing.Size(75, 23);
            this.second_Button.TabIndex = 9;
            this.second_Button.Text = "Лаба 2";
            this.second_Button.UseVisualStyleBackColor = true;
            this.second_Button.Click += new System.EventHandler(this.second_Button_Click);
            // 
            // third_Button
            // 
            this.third_Button.Location = new System.Drawing.Point(99, 279);
            this.third_Button.Name = "third_Button";
            this.third_Button.Size = new System.Drawing.Size(75, 23);
            this.third_Button.TabIndex = 10;
            this.third_Button.Text = "Лаба 3";
            this.third_Button.UseVisualStyleBackColor = true;
            this.third_Button.Click += new System.EventHandler(this.third_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 314);
            this.Controls.Add(this.third_Button);
            this.Controls.Add(this.second_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.OperatorCount_TextBox);
            this.Controls.Add(this.OperatorCount_Label);
            this.Controls.Add(this.ExpCount_Label);
            this.Controls.Add(this.ExpCount_TextBox);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Оценка качества ПО по Хослтеду";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox ExpCount_TextBox;
        private System.Windows.Forms.Label ExpCount_Label;
        private System.Windows.Forms.Label OperatorCount_Label;
        private System.Windows.Forms.TextBox OperatorCount_TextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button second_Button;
        private System.Windows.Forms.Button third_Button;
    }
}


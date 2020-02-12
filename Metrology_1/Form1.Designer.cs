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
            this.OperandCount_Label = new System.Windows.Forms.Label();
            this.OperandCount_TextBox = new System.Windows.Forms.TextBox();
            this.OperatorCount_Label = new System.Windows.Forms.Label();
            this.OperatorCount_TextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(15, 168);
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
            // OperandCount_Label
            // 
            this.OperandCount_Label.AutoSize = true;
            this.OperandCount_Label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperandCount_Label.Location = new System.Drawing.Point(12, 80);
            this.OperandCount_Label.Name = "OperandCount_Label";
            this.OperandCount_Label.Size = new System.Drawing.Size(145, 16);
            this.OperandCount_Label.TabIndex = 3;
            this.OperandCount_Label.Text = "Количество операндов";
            // 
            // OperandCount_TextBox
            // 
            this.OperandCount_TextBox.Location = new System.Drawing.Point(192, 79);
            this.OperandCount_TextBox.Name = "OperandCount_TextBox";
            this.OperandCount_TextBox.Size = new System.Drawing.Size(100, 20);
            this.OperandCount_TextBox.TabIndex = 4;
            // 
            // OperatorCount_Label
            // 
            this.OperatorCount_Label.AutoSize = true;
            this.OperatorCount_Label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OperatorCount_Label.Location = new System.Drawing.Point(12, 43);
            this.OperatorCount_Label.Name = "OperatorCount_Label";
            this.OperatorCount_Label.Size = new System.Drawing.Size(149, 16);
            this.OperatorCount_Label.TabIndex = 5;
            this.OperatorCount_Label.Text = "Количество операторов";
            // 
            // OperatorCount_TextBox
            // 
            this.OperatorCount_TextBox.Location = new System.Drawing.Point(192, 42);
            this.OperatorCount_TextBox.Name = "OperatorCount_TextBox";
            this.OperatorCount_TextBox.Size = new System.Drawing.Size(100, 20);
            this.OperatorCount_TextBox.TabIndex = 6;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(192, 118);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(100, 20);
            this.outputTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 232);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.OperatorCount_TextBox);
            this.Controls.Add(this.OperatorCount_Label);
            this.Controls.Add(this.OperandCount_TextBox);
            this.Controls.Add(this.OperandCount_Label);
            this.Controls.Add(this.ExpCount_Label);
            this.Controls.Add(this.ExpCount_TextBox);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Оценка качества ПО по Хослтеду";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox ExpCount_TextBox;
        private System.Windows.Forms.Label ExpCount_Label;
        private System.Windows.Forms.Label OperandCount_Label;
        private System.Windows.Forms.TextBox OperandCount_TextBox;
        private System.Windows.Forms.Label OperatorCount_Label;
        private System.Windows.Forms.TextBox OperatorCount_TextBox;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}


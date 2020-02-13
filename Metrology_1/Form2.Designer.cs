namespace Metrology_1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.macKeibOutTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberOfConnectednessTextBox = new System.Windows.Forms.TextBox();
            this.numberOfEdgesTextBox = new System.Windows.Forms.TextBox();
            this.numberOfKnotsTextBox = new System.Windows.Forms.TextBox();
            this.macKeibButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GilbOutTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numberOfIFELSETextBox = new System.Windows.Forms.TextBox();
            this.numberOfOperatorsTextBox = new System.Windows.Forms.TextBox();
            this.GilbButton = new System.Windows.Forms.Button();
            this.numberOfGlobalVars = new System.Windows.Forms.TextBox();
            this.numberOfPossibleUsingGlobalVars = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.globalButton = new System.Windows.Forms.Button();
            this.globalOutTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Метрика МакКейба: ";
            // 
            // macKeibOutTextBox
            // 
            this.macKeibOutTextBox.Location = new System.Drawing.Point(130, 90);
            this.macKeibOutTextBox.Name = "macKeibOutTextBox";
            this.macKeibOutTextBox.ReadOnly = true;
            this.macKeibOutTextBox.Size = new System.Drawing.Size(100, 20);
            this.macKeibOutTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Число узлов графа: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Число рёбер графа: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Число компонентов связности графа: ";
            // 
            // numberOfConnectednessTextBox
            // 
            this.numberOfConnectednessTextBox.Location = new System.Drawing.Point(223, 58);
            this.numberOfConnectednessTextBox.Name = "numberOfConnectednessTextBox";
            this.numberOfConnectednessTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfConnectednessTextBox.TabIndex = 5;
            this.numberOfConnectednessTextBox.Text = "1";
            // 
            // numberOfEdgesTextBox
            // 
            this.numberOfEdgesTextBox.Location = new System.Drawing.Point(223, 32);
            this.numberOfEdgesTextBox.Name = "numberOfEdgesTextBox";
            this.numberOfEdgesTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfEdgesTextBox.TabIndex = 6;
            this.numberOfEdgesTextBox.Text = "31";
            // 
            // numberOfKnotsTextBox
            // 
            this.numberOfKnotsTextBox.Location = new System.Drawing.Point(223, 6);
            this.numberOfKnotsTextBox.Name = "numberOfKnotsTextBox";
            this.numberOfKnotsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfKnotsTextBox.TabIndex = 7;
            this.numberOfKnotsTextBox.Text = "35";
            // 
            // macKeibButton
            // 
            this.macKeibButton.Location = new System.Drawing.Point(15, 123);
            this.macKeibButton.Name = "macKeibButton";
            this.macKeibButton.Size = new System.Drawing.Size(120, 23);
            this.macKeibButton.TabIndex = 1;
            this.macKeibButton.Text = "Метрика Мак-Кейба";
            this.macKeibButton.UseVisualStyleBackColor = true;
            this.macKeibButton.Click += new System.EventHandler(this.macKeibButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Количество операторов: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Количество операторов IF - THEN - ELSE: ";
            // 
            // GilbOutTextBox
            // 
            this.GilbOutTextBox.Location = new System.Drawing.Point(436, 90);
            this.GilbOutTextBox.Name = "GilbOutTextBox";
            this.GilbOutTextBox.ReadOnly = true;
            this.GilbOutTextBox.Size = new System.Drawing.Size(100, 20);
            this.GilbOutTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Метрика Джилба: ";
            // 
            // numberOfIFELSETextBox
            // 
            this.numberOfIFELSETextBox.Location = new System.Drawing.Point(556, 32);
            this.numberOfIFELSETextBox.Name = "numberOfIFELSETextBox";
            this.numberOfIFELSETextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfIFELSETextBox.TabIndex = 13;
            this.numberOfIFELSETextBox.Text = "3";
            // 
            // numberOfOperatorsTextBox
            // 
            this.numberOfOperatorsTextBox.Location = new System.Drawing.Point(556, 6);
            this.numberOfOperatorsTextBox.Name = "numberOfOperatorsTextBox";
            this.numberOfOperatorsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfOperatorsTextBox.TabIndex = 14;
            this.numberOfOperatorsTextBox.Text = "35";
            // 
            // GilbButton
            // 
            this.GilbButton.Location = new System.Drawing.Point(332, 123);
            this.GilbButton.Name = "GilbButton";
            this.GilbButton.Size = new System.Drawing.Size(120, 23);
            this.GilbButton.TabIndex = 15;
            this.GilbButton.Text = "Метрика Джилба";
            this.GilbButton.UseVisualStyleBackColor = true;
            this.GilbButton.Click += new System.EventHandler(this.GilbButton_Click);
            // 
            // numberOfGlobalVars
            // 
            this.numberOfGlobalVars.Location = new System.Drawing.Point(869, 6);
            this.numberOfGlobalVars.Name = "numberOfGlobalVars";
            this.numberOfGlobalVars.Size = new System.Drawing.Size(100, 20);
            this.numberOfGlobalVars.TabIndex = 19;
            this.numberOfGlobalVars.Text = "0";
            // 
            // numberOfPossibleUsingGlobalVars
            // 
            this.numberOfPossibleUsingGlobalVars.Location = new System.Drawing.Point(869, 32);
            this.numberOfPossibleUsingGlobalVars.Name = "numberOfPossibleUsingGlobalVars";
            this.numberOfPossibleUsingGlobalVars.Size = new System.Drawing.Size(100, 20);
            this.numberOfPossibleUsingGlobalVars.TabIndex = 18;
            this.numberOfPossibleUsingGlobalVars.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(662, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Количество возможносте доступа: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(662, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Количество глобальных переменных: ";
            // 
            // globalButton
            // 
            this.globalButton.Location = new System.Drawing.Point(665, 123);
            this.globalButton.Name = "globalButton";
            this.globalButton.Size = new System.Drawing.Size(204, 23);
            this.globalButton.TabIndex = 22;
            this.globalButton.Text = "Метрика глобальных переменных";
            this.globalButton.UseVisualStyleBackColor = true;
            this.globalButton.Click += new System.EventHandler(this.globalButton_Click);
            // 
            // globalOutTextBox
            // 
            this.globalOutTextBox.Location = new System.Drawing.Point(854, 90);
            this.globalOutTextBox.Name = "globalOutTextBox";
            this.globalOutTextBox.ReadOnly = true;
            this.globalOutTextBox.Size = new System.Drawing.Size(100, 20);
            this.globalOutTextBox.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(662, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Метрика глобальных переменных: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 339);
            this.Controls.Add(this.globalButton);
            this.Controls.Add(this.globalOutTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numberOfGlobalVars);
            this.Controls.Add(this.numberOfPossibleUsingGlobalVars);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GilbButton);
            this.Controls.Add(this.numberOfOperatorsTextBox);
            this.Controls.Add(this.numberOfIFELSETextBox);
            this.Controls.Add(this.GilbOutTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.macKeibButton);
            this.Controls.Add(this.numberOfKnotsTextBox);
            this.Controls.Add(this.numberOfEdgesTextBox);
            this.Controls.Add(this.numberOfConnectednessTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.macKeibOutTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox macKeibOutTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numberOfConnectednessTextBox;
        private System.Windows.Forms.TextBox numberOfEdgesTextBox;
        private System.Windows.Forms.TextBox numberOfKnotsTextBox;
        private System.Windows.Forms.Button macKeibButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GilbOutTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numberOfIFELSETextBox;
        private System.Windows.Forms.TextBox numberOfOperatorsTextBox;
        private System.Windows.Forms.Button GilbButton;
        private System.Windows.Forms.TextBox numberOfGlobalVars;
        private System.Windows.Forms.TextBox numberOfPossibleUsingGlobalVars;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button globalButton;
        private System.Windows.Forms.TextBox globalOutTextBox;
        private System.Windows.Forms.Label label10;
    }
}
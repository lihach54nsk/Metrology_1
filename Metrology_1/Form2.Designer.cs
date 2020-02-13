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
            this.inputOutputVarsTextBox = new System.Windows.Forms.TextBox();
            this.modVarsTextBox = new System.Windows.Forms.TextBox();
            this.controlVarsTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.garbageVarsTextBox = new System.Windows.Forms.TextBox();
            this.chepinButton = new System.Windows.Forms.Button();
            this.chepinOutTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
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
            // inputOutputVarsTextBox
            // 
            this.inputOutputVarsTextBox.Location = new System.Drawing.Point(224, 155);
            this.inputOutputVarsTextBox.Name = "inputOutputVarsTextBox";
            this.inputOutputVarsTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputOutputVarsTextBox.TabIndex = 28;
            this.inputOutputVarsTextBox.Text = "4";
            // 
            // modVarsTextBox
            // 
            this.modVarsTextBox.Location = new System.Drawing.Point(224, 181);
            this.modVarsTextBox.Name = "modVarsTextBox";
            this.modVarsTextBox.Size = new System.Drawing.Size(100, 20);
            this.modVarsTextBox.TabIndex = 27;
            this.modVarsTextBox.Text = "12";
            // 
            // controlVarsTextBox
            // 
            this.controlVarsTextBox.Location = new System.Drawing.Point(224, 207);
            this.controlVarsTextBox.Name = "controlVarsTextBox";
            this.controlVarsTextBox.Size = new System.Drawing.Size(100, 20);
            this.controlVarsTextBox.TabIndex = 26;
            this.controlVarsTextBox.Text = "6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Число управляющих переменных: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Число модифицируемых переменных: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Число переменных ввода-вывода: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 236);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Число паразитных переменных: ";
            // 
            // garbageVarsTextBox
            // 
            this.garbageVarsTextBox.Location = new System.Drawing.Point(223, 233);
            this.garbageVarsTextBox.Name = "garbageVarsTextBox";
            this.garbageVarsTextBox.Size = new System.Drawing.Size(100, 20);
            this.garbageVarsTextBox.TabIndex = 30;
            this.garbageVarsTextBox.Text = "0";
            // 
            // chepinButton
            // 
            this.chepinButton.Location = new System.Drawing.Point(16, 295);
            this.chepinButton.Name = "chepinButton";
            this.chepinButton.Size = new System.Drawing.Size(120, 23);
            this.chepinButton.TabIndex = 32;
            this.chepinButton.Text = "Метрика Чепина";
            this.chepinButton.UseVisualStyleBackColor = true;
            this.chepinButton.Click += new System.EventHandler(this.chepinButton_Click);
            // 
            // chepinOutTextBox
            // 
            this.chepinOutTextBox.Location = new System.Drawing.Point(131, 262);
            this.chepinOutTextBox.Name = "chepinOutTextBox";
            this.chepinOutTextBox.ReadOnly = true;
            this.chepinOutTextBox.Size = new System.Drawing.Size(100, 20);
            this.chepinOutTextBox.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 265);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Метрика Чепина: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 339);
            this.Controls.Add(this.chepinButton);
            this.Controls.Add(this.chepinOutTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.garbageVarsTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.inputOutputVarsTextBox);
            this.Controls.Add(this.modVarsTextBox);
            this.Controls.Add(this.controlVarsTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
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
        private System.Windows.Forms.TextBox inputOutputVarsTextBox;
        private System.Windows.Forms.TextBox modVarsTextBox;
        private System.Windows.Forms.TextBox controlVarsTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox garbageVarsTextBox;
        private System.Windows.Forms.Button chepinButton;
        private System.Windows.Forms.TextBox chepinOutTextBox;
        private System.Windows.Forms.Label label15;
    }
}
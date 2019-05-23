namespace PATHFIND_XKQCNV_WINDOWS
{
    partial class FormMain
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonFVSaveTest = new System.Windows.Forms.Button();
            this.buttonMCTest = new System.Windows.Forms.Button();
            this.buttonFValueTest = new System.Windows.Forms.Button();
            this.buttonCLTest = new System.Windows.Forms.Button();
            this.buttonOLTest = new System.Windows.Forms.Button();
            this.buttonOpenListTest = new System.Windows.Forms.Button();
            this.buttonHDisplayConsole = new System.Windows.Forms.Button();
            this.buttonMakeMap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelButtonSize = new System.Windows.Forms.Label();
            this.numericUpDownBtnSize = new System.Windows.Forms.NumericUpDown();
            this.labelDisplayConsole = new System.Windows.Forms.Label();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBtnSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonStart.Location = new System.Drawing.Point(7, 514);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(118, 56);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Útvonal keresése!";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Magasság:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Szélesség";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(6, 32);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownHeight.TabIndex = 3;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numericUpDownLength
            // 
            this.numericUpDownLength.Location = new System.Drawing.Point(68, 32);
            this.numericUpDownLength.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numericUpDownLength.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownLength.Name = "numericUpDownLength";
            this.numericUpDownLength.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownLength.TabIndex = 4;
            this.numericUpDownLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDisplayConsole);
            this.groupBox1.Controls.Add(this.numericUpDownBtnSize);
            this.groupBox1.Controls.Add(this.labelButtonSize);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonFVSaveTest);
            this.groupBox1.Controls.Add(this.buttonMCTest);
            this.groupBox1.Controls.Add(this.buttonFValueTest);
            this.groupBox1.Controls.Add(this.buttonCLTest);
            this.groupBox1.Controls.Add(this.buttonOLTest);
            this.groupBox1.Controls.Add(this.buttonOpenListTest);
            this.groupBox1.Controls.Add(this.buttonHDisplayConsole);
            this.groupBox1.Controls.Add(this.buttonMakeMap);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownHeight);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownLength);
            this.groupBox1.Location = new System.Drawing.Point(561, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 580);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beállítások";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fejlesztői eszközök:";
            // 
            // buttonFVSaveTest
            // 
            this.buttonFVSaveTest.Location = new System.Drawing.Point(6, 432);
            this.buttonFVSaveTest.Name = "buttonFVSaveTest";
            this.buttonFVSaveTest.Size = new System.Drawing.Size(117, 35);
            this.buttonFVSaveTest.TabIndex = 14;
            this.buttonFVSaveTest.Text = "FValueSave";
            this.buttonFVSaveTest.UseVisualStyleBackColor = true;
            this.buttonFVSaveTest.Click += new System.EventHandler(this.buttonFVSaveTest_Click);
            // 
            // buttonMCTest
            // 
            this.buttonMCTest.Location = new System.Drawing.Point(6, 473);
            this.buttonMCTest.Name = "buttonMCTest";
            this.buttonMCTest.Size = new System.Drawing.Size(117, 35);
            this.buttonMCTest.TabIndex = 13;
            this.buttonMCTest.Text = "MovementCost";
            this.buttonMCTest.UseVisualStyleBackColor = true;
            this.buttonMCTest.Click += new System.EventHandler(this.buttonMCTest_Click);
            // 
            // buttonFValueTest
            // 
            this.buttonFValueTest.Location = new System.Drawing.Point(7, 391);
            this.buttonFValueTest.Name = "buttonFValueTest";
            this.buttonFValueTest.Size = new System.Drawing.Size(117, 35);
            this.buttonFValueTest.TabIndex = 12;
            this.buttonFValueTest.Text = "FValue";
            this.buttonFValueTest.UseVisualStyleBackColor = true;
            this.buttonFValueTest.Click += new System.EventHandler(this.buttonFValueTest_Click);
            // 
            // buttonCLTest
            // 
            this.buttonCLTest.Location = new System.Drawing.Point(6, 350);
            this.buttonCLTest.Name = "buttonCLTest";
            this.buttonCLTest.Size = new System.Drawing.Size(117, 35);
            this.buttonCLTest.TabIndex = 11;
            this.buttonCLTest.Text = "ClosedList";
            this.buttonCLTest.UseVisualStyleBackColor = true;
            this.buttonCLTest.Click += new System.EventHandler(this.buttonCLTest_Click);
            // 
            // buttonOLTest
            // 
            this.buttonOLTest.Location = new System.Drawing.Point(7, 309);
            this.buttonOLTest.Name = "buttonOLTest";
            this.buttonOLTest.Size = new System.Drawing.Size(117, 35);
            this.buttonOLTest.TabIndex = 10;
            this.buttonOLTest.Text = "OpenList";
            this.buttonOLTest.UseVisualStyleBackColor = true;
            this.buttonOLTest.Click += new System.EventHandler(this.buttonOLTest_Click);
            // 
            // buttonOpenListTest
            // 
            this.buttonOpenListTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonOpenListTest.Location = new System.Drawing.Point(6, 229);
            this.buttonOpenListTest.Name = "buttonOpenListTest";
            this.buttonOpenListTest.Size = new System.Drawing.Size(117, 35);
            this.buttonOpenListTest.TabIndex = 9;
            this.buttonOpenListTest.Text = "Console frissítés";
            this.buttonOpenListTest.UseVisualStyleBackColor = false;
            this.buttonOpenListTest.Click += new System.EventHandler(this.buttonOpenListTest_Click);
            // 
            // buttonHDisplayConsole
            // 
            this.buttonHDisplayConsole.Location = new System.Drawing.Point(6, 270);
            this.buttonHDisplayConsole.Name = "buttonHDisplayConsole";
            this.buttonHDisplayConsole.Size = new System.Drawing.Size(117, 33);
            this.buttonHDisplayConsole.TabIndex = 8;
            this.buttonHDisplayConsole.Text = "HValue";
            this.buttonHDisplayConsole.UseVisualStyleBackColor = false;
            this.buttonHDisplayConsole.Click += new System.EventHandler(this.buttonHDisplayConsole_Click);
            // 
            // buttonMakeMap
            // 
            this.buttonMakeMap.Location = new System.Drawing.Point(6, 97);
            this.buttonMakeMap.Name = "buttonMakeMap";
            this.buttonMakeMap.Size = new System.Drawing.Size(117, 31);
            this.buttonMakeMap.TabIndex = 7;
            this.buttonMakeMap.Text = "Pálya építése!";
            this.buttonMakeMap.UseVisualStyleBackColor = true;
            this.buttonMakeMap.Click += new System.EventHandler(this.buttonMakeMap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Szerkessze meg az útvonalat, rendelkeznie kell az útvonalnak egy kezdő és végpont" +
    "nak!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 576);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Piros = Akadály, Zöld = Start pont, Kék = Vég pont.";
            // 
            // labelButtonSize
            // 
            this.labelButtonSize.AutoSize = true;
            this.labelButtonSize.Location = new System.Drawing.Point(6, 55);
            this.labelButtonSize.Name = "labelButtonSize";
            this.labelButtonSize.Size = new System.Drawing.Size(73, 13);
            this.labelButtonSize.TabIndex = 9;
            this.labelButtonSize.Text = "Gomb mérete:";
            // 
            // numericUpDownBtnSize
            // 
            this.numericUpDownBtnSize.Location = new System.Drawing.Point(6, 71);
            this.numericUpDownBtnSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownBtnSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownBtnSize.Name = "numericUpDownBtnSize";
            this.numericUpDownBtnSize.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownBtnSize.TabIndex = 9;
            this.numericUpDownBtnSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownBtnSize.ValueChanged += new System.EventHandler(this.numericUpDownBtnSize_ValueChanged);
            // 
            // labelDisplayConsole
            // 
            this.labelDisplayConsole.AutoSize = true;
            this.labelDisplayConsole.Location = new System.Drawing.Point(6, 206);
            this.labelDisplayConsole.Name = "labelDisplayConsole";
            this.labelDisplayConsole.Size = new System.Drawing.Size(101, 13);
            this.labelDisplayConsole.TabIndex = 10;
            this.labelDisplayConsole.Text = "Fejlesztői eszközök:";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.AllowUserToResizeColumns = false;
            this.dataGridViewMain.AllowUserToResizeRows = false;
            this.dataGridViewMain.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Enabled = false;
            this.dataGridViewMain.EnableHeadersVisualStyles = false;
            this.dataGridViewMain.Location = new System.Drawing.Point(690, 10);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMain.ShowCellToolTips = false;
            this.dataGridViewMain.ShowEditingIcon = false;
            this.dataGridViewMain.Size = new System.Drawing.Size(560, 576);
            this.dataGridViewMain.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 598);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "A* útvonal kereső";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBtnSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonMakeMap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonHDisplayConsole;
        private System.Windows.Forms.Button buttonOpenListTest;
        private System.Windows.Forms.Button buttonMCTest;
        private System.Windows.Forms.Button buttonFValueTest;
        private System.Windows.Forms.Button buttonCLTest;
        private System.Windows.Forms.Button buttonOLTest;
        private System.Windows.Forms.Button buttonFVSaveTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownBtnSize;
        private System.Windows.Forms.Label labelButtonSize;
        private System.Windows.Forms.Label labelDisplayConsole;
        private System.Windows.Forms.DataGridView dataGridViewMain;
    }
}


namespace NIM_XKQCNV_WINDOWS
{
    partial class SettingsGame
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
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxRandom = new System.Windows.Forms.GroupBox();
            this.groupBoxCustom = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxCustomGameIndex = new System.Windows.Forms.ComboBox();
            this.numericUpDownCustomAmount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCustomGameRows = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSave = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            this.groupBoxRandom.SuspendLayout();
            this.groupBoxCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomGameRows)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A játék tulajdonságai:";
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(237, 34);
            this.numericUpDownRows.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownRows.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(193, 20);
            this.numericUpDownRows.TabIndex = 1;
            this.numericUpDownRows.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Az itt beállított tulajdonságok alapján indul el a következő játék";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "A sorok számának módosítása:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Minimum sor nagyságának módosítása:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Maximum sor nagyságának módosítása:";
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(237, 60);
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(193, 20);
            this.numericUpDownMin.TabIndex = 8;
            this.numericUpDownMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Location = new System.Drawing.Point(237, 86);
            this.numericUpDownMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(193, 20);
            this.numericUpDownMax.TabIndex = 9;
            this.numericUpDownMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(704, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Mentés";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBoxRandom
            // 
            this.groupBoxRandom.BackColor = System.Drawing.Color.White;
            this.groupBoxRandom.Controls.Add(this.numericUpDownRows);
            this.groupBoxRandom.Controls.Add(this.numericUpDownMin);
            this.groupBoxRandom.Controls.Add(this.label3);
            this.groupBoxRandom.Controls.Add(this.label4);
            this.groupBoxRandom.Controls.Add(this.label5);
            this.groupBoxRandom.Controls.Add(this.numericUpDownMax);
            this.groupBoxRandom.Location = new System.Drawing.Point(15, 38);
            this.groupBoxRandom.Name = "groupBoxRandom";
            this.groupBoxRandom.Size = new System.Drawing.Size(436, 122);
            this.groupBoxRandom.TabIndex = 12;
            this.groupBoxRandom.TabStop = false;
            this.groupBoxRandom.Text = "Beállítások véletlenszerű játékra";
            // 
            // groupBoxCustom
            // 
            this.groupBoxCustom.BackColor = System.Drawing.Color.White;
            this.groupBoxCustom.Controls.Add(this.label9);
            this.groupBoxCustom.Controls.Add(this.label8);
            this.groupBoxCustom.Controls.Add(this.comboBoxCustomGameIndex);
            this.groupBoxCustom.Controls.Add(this.numericUpDownCustomAmount);
            this.groupBoxCustom.Controls.Add(this.numericUpDownCustomGameRows);
            this.groupBoxCustom.Controls.Add(this.label7);
            this.groupBoxCustom.Location = new System.Drawing.Point(457, 38);
            this.groupBoxCustom.Name = "groupBoxCustom";
            this.groupBoxCustom.Size = new System.Drawing.Size(381, 122);
            this.groupBoxCustom.TabIndex = 13;
            this.groupBoxCustom.TabStop = false;
            this.groupBoxCustom.Text = "Beállítások egyéni játékra";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ceruzák száma:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sor index:";
            // 
            // comboBoxCustomGameIndex
            // 
            this.comboBoxCustomGameIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomGameIndex.FormattingEnabled = true;
            this.comboBoxCustomGameIndex.Location = new System.Drawing.Point(22, 88);
            this.comboBoxCustomGameIndex.Name = "comboBoxCustomGameIndex";
            this.comboBoxCustomGameIndex.Size = new System.Drawing.Size(51, 21);
            this.comboBoxCustomGameIndex.TabIndex = 15;
            this.comboBoxCustomGameIndex.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomGameIndex_SelectedIndexChanged);
            // 
            // numericUpDownCustomAmount
            // 
            this.numericUpDownCustomAmount.Location = new System.Drawing.Point(79, 89);
            this.numericUpDownCustomAmount.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownCustomAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCustomAmount.Name = "numericUpDownCustomAmount";
            this.numericUpDownCustomAmount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCustomAmount.TabIndex = 14;
            this.numericUpDownCustomAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCustomAmount.ValueChanged += new System.EventHandler(this.numericUpDownCustomAmount_ValueChanged);
            // 
            // numericUpDownCustomGameRows
            // 
            this.numericUpDownCustomGameRows.Location = new System.Drawing.Point(180, 36);
            this.numericUpDownCustomGameRows.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.numericUpDownCustomGameRows.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownCustomGameRows.Name = "numericUpDownCustomGameRows";
            this.numericUpDownCustomGameRows.Size = new System.Drawing.Size(193, 20);
            this.numericUpDownCustomGameRows.TabIndex = 12;
            this.numericUpDownCustomGameRows.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownCustomGameRows.ValueChanged += new System.EventHandler(this.numericUpDownCustomGameRows_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "A sorok számának módosítása:";
            // 
            // cmbSave
            // 
            this.cmbSave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSave.FormattingEnabled = true;
            this.cmbSave.Items.AddRange(new object[] {
            "Véletlenszerű játék",
            "Egyéni játék"});
            this.cmbSave.Location = new System.Drawing.Point(235, 166);
            this.cmbSave.Name = "cmbSave";
            this.cmbSave.Size = new System.Drawing.Size(421, 21);
            this.cmbSave.TabIndex = 14;
            this.cmbSave.SelectedIndexChanged += new System.EventHandler(this.cmbSave_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Játék tipusa:";
            // 
            // SettingsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(845, 258);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSave);
            this.Controls.Add(this.groupBoxCustom);
            this.Controls.Add(this.groupBoxRandom);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "SettingsGame";
            this.Text = "Beállítások";
            this.Load += new System.EventHandler(this.SettingsGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            this.groupBoxRandom.ResumeLayout(false);
            this.groupBoxRandom.PerformLayout();
            this.groupBoxCustom.ResumeLayout(false);
            this.groupBoxCustom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCustomGameRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBoxRandom;
        private System.Windows.Forms.GroupBox groupBoxCustom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxCustomGameIndex;
        private System.Windows.Forms.NumericUpDown numericUpDownCustomAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownCustomGameRows;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSave;
        private System.Windows.Forms.Label label6;
    }
}
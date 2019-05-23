namespace NIM_XKQCNV_WINDOWS
{
    partial class Menu
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
            this.btn_SettingsGame = new System.Windows.Forms.Button();
            this.btnGameStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SettingsGame
            // 
            this.btn_SettingsGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_SettingsGame.Location = new System.Drawing.Point(17, 70);
            this.btn_SettingsGame.Name = "btn_SettingsGame";
            this.btn_SettingsGame.Size = new System.Drawing.Size(441, 43);
            this.btn_SettingsGame.TabIndex = 0;
            this.btn_SettingsGame.Text = "A játék tulajdonságainak módosítása";
            this.btn_SettingsGame.UseVisualStyleBackColor = true;
            this.btn_SettingsGame.Click += new System.EventHandler(this.btn_SettingsGame_Click);
            // 
            // btnGameStart
            // 
            this.btnGameStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGameStart.Location = new System.Drawing.Point(17, 135);
            this.btnGameStart.Name = "btnGameStart";
            this.btnGameStart.Size = new System.Drawing.Size(441, 79);
            this.btnGameStart.TabIndex = 2;
            this.btnGameStart.Text = "Játék indítása!";
            this.btnGameStart.UseVisualStyleBackColor = true;
            this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "NIM Játék! Készítette: XKQCNV - Szabó Attila";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGameStart);
            this.Controls.Add(this.btn_SettingsGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "NIM Játék!";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SettingsGame;
        private System.Windows.Forms.Button btnGameStart;
        private System.Windows.Forms.Label label1;
    }
}


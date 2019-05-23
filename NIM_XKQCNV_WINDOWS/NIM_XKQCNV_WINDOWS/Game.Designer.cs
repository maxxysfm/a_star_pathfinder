namespace NIM_XKQCNV_WINDOWS
{
    partial class Game
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
            this.labelWinCond = new System.Windows.Forms.Label();
            this.listBoxConsole = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Használat: Válassza ki, melyik sorból hány elemet akar eltávolítani!";
            // 
            // labelWinCond
            // 
            this.labelWinCond.AutoSize = true;
            this.labelWinCond.Location = new System.Drawing.Point(3, 33);
            this.labelWinCond.Name = "labelWinCond";
            this.labelWinCond.Size = new System.Drawing.Size(79, 13);
            this.labelWinCond.TabIndex = 3;
            this.labelWinCond.Text = "Nyerési feltétel:";
            // 
            // listBoxConsole
            // 
            this.listBoxConsole.FormattingEnabled = true;
            this.listBoxConsole.Location = new System.Drawing.Point(502, 9);
            this.listBoxConsole.Name = "listBoxConsole";
            this.listBoxConsole.ScrollAlwaysVisible = true;
            this.listBoxConsole.Size = new System.Drawing.Size(540, 121);
            this.listBoxConsole.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBoxConsole);
            this.panel1.Controls.Add(this.labelWinCond);
            this.panel1.Location = new System.Drawing.Point(15, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 143);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Esemény napló:";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(1078, 525);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(120, 79);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "Újraindítás";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 676);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWinCond;
        private System.Windows.Forms.ListBox listBoxConsole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRestart;
    }
}
namespace RockPaperScissorsTivaR
{
    partial class frmRockPaperScissors
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
            this.grbPlayerChoice = new System.Windows.Forms.GroupBox();
            this.radScissorsP = new System.Windows.Forms.RadioButton();
            this.radPaperP = new System.Windows.Forms.RadioButton();
            this.radRockP = new System.Windows.Forms.RadioButton();
            this.grbComputerChoice = new System.Windows.Forms.GroupBox();
            this.radScissorsC = new System.Windows.Forms.RadioButton();
            this.radPaperC = new System.Windows.Forms.RadioButton();
            this.radRockC = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Button();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.grbPlayerChoice.SuspendLayout();
            this.grbComputerChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPlayerChoice
            // 
            this.grbPlayerChoice.Controls.Add(this.radScissorsP);
            this.grbPlayerChoice.Controls.Add(this.radPaperP);
            this.grbPlayerChoice.Controls.Add(this.radRockP);
            this.grbPlayerChoice.Location = new System.Drawing.Point(72, 42);
            this.grbPlayerChoice.Name = "grbPlayerChoice";
            this.grbPlayerChoice.Size = new System.Drawing.Size(127, 134);
            this.grbPlayerChoice.TabIndex = 0;
            this.grbPlayerChoice.TabStop = false;
            this.grbPlayerChoice.Text = "Player\'s Choice";
            // 
            // radScissorsP
            // 
            this.radScissorsP.AutoSize = true;
            this.radScissorsP.Location = new System.Drawing.Point(6, 98);
            this.radScissorsP.Name = "radScissorsP";
            this.radScissorsP.Size = new System.Drawing.Size(64, 17);
            this.radScissorsP.TabIndex = 2;
            this.radScissorsP.TabStop = true;
            this.radScissorsP.Text = "Scissors";
            this.radScissorsP.UseVisualStyleBackColor = true;
            // 
            // radPaperP
            // 
            this.radPaperP.AutoSize = true;
            this.radPaperP.Location = new System.Drawing.Point(6, 66);
            this.radPaperP.Name = "radPaperP";
            this.radPaperP.Size = new System.Drawing.Size(53, 17);
            this.radPaperP.TabIndex = 1;
            this.radPaperP.TabStop = true;
            this.radPaperP.Text = "Paper";
            this.radPaperP.UseVisualStyleBackColor = true;
            // 
            // radRockP
            // 
            this.radRockP.AutoSize = true;
            this.radRockP.Location = new System.Drawing.Point(6, 34);
            this.radRockP.Name = "radRockP";
            this.radRockP.Size = new System.Drawing.Size(51, 17);
            this.radRockP.TabIndex = 0;
            this.radRockP.TabStop = true;
            this.radRockP.Text = "Rock";
            this.radRockP.UseVisualStyleBackColor = true;
            // 
            // grbComputerChoice
            // 
            this.grbComputerChoice.Controls.Add(this.radScissorsC);
            this.grbComputerChoice.Controls.Add(this.radPaperC);
            this.grbComputerChoice.Controls.Add(this.radRockC);
            this.grbComputerChoice.Enabled = false;
            this.grbComputerChoice.Location = new System.Drawing.Point(72, 203);
            this.grbComputerChoice.Name = "grbComputerChoice";
            this.grbComputerChoice.Size = new System.Drawing.Size(127, 134);
            this.grbComputerChoice.TabIndex = 3;
            this.grbComputerChoice.TabStop = false;
            this.grbComputerChoice.Text = "Computers\' Choice";
            // 
            // radScissorsC
            // 
            this.radScissorsC.AutoSize = true;
            this.radScissorsC.Enabled = false;
            this.radScissorsC.Location = new System.Drawing.Point(6, 98);
            this.radScissorsC.Name = "radScissorsC";
            this.radScissorsC.Size = new System.Drawing.Size(64, 17);
            this.radScissorsC.TabIndex = 2;
            this.radScissorsC.TabStop = true;
            this.radScissorsC.Text = "Scissors";
            this.radScissorsC.UseVisualStyleBackColor = true;
            // 
            // radPaperC
            // 
            this.radPaperC.AutoSize = true;
            this.radPaperC.Enabled = false;
            this.radPaperC.Location = new System.Drawing.Point(6, 66);
            this.radPaperC.Name = "radPaperC";
            this.radPaperC.Size = new System.Drawing.Size(53, 17);
            this.radPaperC.TabIndex = 1;
            this.radPaperC.TabStop = true;
            this.radPaperC.Text = "Paper";
            this.radPaperC.UseVisualStyleBackColor = true;
            // 
            // radRockC
            // 
            this.radRockC.AutoSize = true;
            this.radRockC.Enabled = false;
            this.radRockC.Location = new System.Drawing.Point(6, 34);
            this.radRockC.Name = "radRockC";
            this.radRockC.Size = new System.Drawing.Size(51, 17);
            this.radRockC.TabIndex = 0;
            this.radRockC.TabStop = true;
            this.radRockC.Text = "Rock";
            this.radRockC.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(75, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Shall we play a game?";
            // 
            // lblPlay
            // 
            this.lblPlay.Location = new System.Drawing.Point(78, 358);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(121, 23);
            this.lblPlay.TabIndex = 5;
            this.lblPlay.Text = "Play";
            this.lblPlay.UseVisualStyleBackColor = true;
            this.lblPlay.Click += new System.EventHandler(this.lblPlay_Click);
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Location = new System.Drawing.Point(114, 397);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(47, 13);
            this.lblOutcome.TabIndex = 6;
            this.lblOutcome.Text = "It\'s a Tie";
            this.lblOutcome.Visible = false;
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 442);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grbComputerChoice);
            this.Controls.Add(this.grbPlayerChoice);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock Paper Scissors By Tiva Rait";
            this.grbPlayerChoice.ResumeLayout(false);
            this.grbPlayerChoice.PerformLayout();
            this.grbComputerChoice.ResumeLayout(false);
            this.grbComputerChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPlayerChoice;
        private System.Windows.Forms.RadioButton radRockP;
        private System.Windows.Forms.RadioButton radScissorsP;
        private System.Windows.Forms.RadioButton radPaperP;
        private System.Windows.Forms.GroupBox grbComputerChoice;
        private System.Windows.Forms.RadioButton radScissorsC;
        private System.Windows.Forms.RadioButton radPaperC;
        private System.Windows.Forms.RadioButton radRockC;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button lblPlay;
        private System.Windows.Forms.Label lblOutcome;
    }
}


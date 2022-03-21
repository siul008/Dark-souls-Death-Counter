
namespace Dark_souls_Death_Counter
{
    partial class DeathCounter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeathCounter));
            this.ScreenshotButton = new System.Windows.Forms.Button();
            this.DisplayValueButton = new System.Windows.Forms.Button();
            this.LancerProgrammeButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.OpenFolder = new System.Windows.Forms.Button();
            this.TerminateButton = new System.Windows.Forms.Button();
            this.MortsTotalsLabel = new System.Windows.Forms.Label();
            this.MortsAtmLabel = new System.Windows.Forms.Label();
            this.atmDeathButtonPlus = new System.Windows.Forms.Button();
            this.totalDeathButtonPlus = new System.Windows.Forms.Button();
            this.totalDeathButtonMinus = new System.Windows.Forms.Button();
            this.atmDeathButtonMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScreenshotButton
            // 
            this.ScreenshotButton.Location = new System.Drawing.Point(12, 174);
            this.ScreenshotButton.Name = "ScreenshotButton";
            this.ScreenshotButton.Size = new System.Drawing.Size(180, 31);
            this.ScreenshotButton.TabIndex = 0;
            this.ScreenshotButton.Text = "Screenshot !";
            this.ScreenshotButton.UseVisualStyleBackColor = true;
            this.ScreenshotButton.Click += new System.EventHandler(this.Screenshot_Click);
            // 
            // DisplayValueButton
            // 
            this.DisplayValueButton.Location = new System.Drawing.Point(37, 75);
            this.DisplayValueButton.Name = "DisplayValueButton";
            this.DisplayValueButton.Size = new System.Drawing.Size(335, 31);
            this.DisplayValueButton.TabIndex = 3;
            this.DisplayValueButton.Text = "Arreter Programme";
            this.DisplayValueButton.UseVisualStyleBackColor = true;
            this.DisplayValueButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // LancerProgrammeButton
            // 
            this.LancerProgrammeButton.Location = new System.Drawing.Point(12, 12);
            this.LancerProgrammeButton.Name = "LancerProgrammeButton";
            this.LancerProgrammeButton.Size = new System.Drawing.Size(380, 57);
            this.LancerProgrammeButton.TabIndex = 4;
            this.LancerProgrammeButton.Text = "Lancer Programme";
            this.LancerProgrammeButton.UseVisualStyleBackColor = true;
            this.LancerProgrammeButton.Click += new System.EventHandler(this.LaunchProgram_Click_1);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(12, 112);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(180, 34);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset Morts Du Jour";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // OpenFolder
            // 
            this.OpenFolder.Location = new System.Drawing.Point(198, 112);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(194, 34);
            this.OpenFolder.TabIndex = 6;
            this.OpenFolder.Text = "Ouvrir Dossier";
            this.OpenFolder.UseVisualStyleBackColor = true;
            this.OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // TerminateButton
            // 
            this.TerminateButton.Location = new System.Drawing.Point(198, 174);
            this.TerminateButton.Name = "TerminateButton";
            this.TerminateButton.Size = new System.Drawing.Size(194, 31);
            this.TerminateButton.TabIndex = 7;
            this.TerminateButton.Text = "Quitter";
            this.TerminateButton.UseVisualStyleBackColor = true;
            this.TerminateButton.Click += new System.EventHandler(this.TerminateButton_Click);
            // 
            // MortsTotalsLabel
            // 
            this.MortsTotalsLabel.AutoSize = true;
            this.MortsTotalsLabel.Location = new System.Drawing.Point(236, 153);
            this.MortsTotalsLabel.Name = "MortsTotalsLabel";
            this.MortsTotalsLabel.Size = new System.Drawing.Size(119, 15);
            this.MortsTotalsLabel.TabIndex = 8;
            this.MortsTotalsLabel.Text = "Morts Totales : 10 000";
            // 
            // MortsAtmLabel
            // 
            this.MortsAtmLabel.AutoSize = true;
            this.MortsAtmLabel.Location = new System.Drawing.Point(45, 153);
            this.MortsAtmLabel.Name = "MortsAtmLabel";
            this.MortsAtmLabel.Size = new System.Drawing.Size(119, 15);
            this.MortsAtmLabel.TabIndex = 9;
            this.MortsAtmLabel.Text = "Morts Actuels : 10000";
            // 
            // atmDeathButtonPlus
            // 
            this.atmDeathButtonPlus.Location = new System.Drawing.Point(170, 149);
            this.atmDeathButtonPlus.Name = "atmDeathButtonPlus";
            this.atmDeathButtonPlus.Size = new System.Drawing.Size(22, 23);
            this.atmDeathButtonPlus.TabIndex = 10;
            this.atmDeathButtonPlus.Text = "+";
            this.atmDeathButtonPlus.UseVisualStyleBackColor = true;
            this.atmDeathButtonPlus.Click += new System.EventHandler(this.atmDeathButtonPlus_Click);
            // 
            // totalDeathButtonPlus
            // 
            this.totalDeathButtonPlus.Location = new System.Drawing.Point(370, 149);
            this.totalDeathButtonPlus.Name = "totalDeathButtonPlus";
            this.totalDeathButtonPlus.Size = new System.Drawing.Size(22, 23);
            this.totalDeathButtonPlus.TabIndex = 11;
            this.totalDeathButtonPlus.Text = "+";
            this.totalDeathButtonPlus.UseVisualStyleBackColor = true;
            this.totalDeathButtonPlus.Click += new System.EventHandler(this.totalDeathButtonPlus_Click);
            // 
            // totalDeathButtonMinus
            // 
            this.totalDeathButtonMinus.Location = new System.Drawing.Point(198, 149);
            this.totalDeathButtonMinus.Name = "totalDeathButtonMinus";
            this.totalDeathButtonMinus.Size = new System.Drawing.Size(22, 23);
            this.totalDeathButtonMinus.TabIndex = 12;
            this.totalDeathButtonMinus.Text = "-";
            this.totalDeathButtonMinus.UseVisualStyleBackColor = true;
            this.totalDeathButtonMinus.Click += new System.EventHandler(this.totalDeathButtonMinus_Click);
            // 
            // atmDeathButtonMinus
            // 
            this.atmDeathButtonMinus.Location = new System.Drawing.Point(12, 149);
            this.atmDeathButtonMinus.Name = "atmDeathButtonMinus";
            this.atmDeathButtonMinus.Size = new System.Drawing.Size(22, 23);
            this.atmDeathButtonMinus.TabIndex = 13;
            this.atmDeathButtonMinus.Text = "-";
            this.atmDeathButtonMinus.UseVisualStyleBackColor = true;
            this.atmDeathButtonMinus.Click += new System.EventHandler(this.atmDeathButtonMinus_Click);
            // 
            // DeathCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 207);
            this.Controls.Add(this.atmDeathButtonMinus);
            this.Controls.Add(this.totalDeathButtonMinus);
            this.Controls.Add(this.totalDeathButtonPlus);
            this.Controls.Add(this.atmDeathButtonPlus);
            this.Controls.Add(this.MortsAtmLabel);
            this.Controls.Add(this.MortsTotalsLabel);
            this.Controls.Add(this.TerminateButton);
            this.Controls.Add(this.OpenFolder);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.LancerProgrammeButton);
            this.Controls.Add(this.DisplayValueButton);
            this.Controls.Add(this.ScreenshotButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeathCounter";
            this.Text = "EldenRing Death Counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ScreenshotButton;
        private System.Windows.Forms.Button DisplayValueButton;
        private System.Windows.Forms.Button LancerProgrammeButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button OpenFolder;
        private System.Windows.Forms.Button TerminateButton;
        private System.Windows.Forms.Label MortsTotalsLabel;
        private System.Windows.Forms.Label MortsAtmLabel;
        private System.Windows.Forms.Button atmDeathButtonPlus;
        private System.Windows.Forms.Button totalDeathButtonPlus;
        private System.Windows.Forms.Button totalDeathButtonMinus;
        private System.Windows.Forms.Button atmDeathButtonMinus;
    }
}


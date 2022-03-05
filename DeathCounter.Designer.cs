
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
            this.ScreenshotButton = new System.Windows.Forms.Button();
            this.DisplayValueButton = new System.Windows.Forms.Button();
            this.LancerProgrammeButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScreenshotButton
            // 
            this.ScreenshotButton.Location = new System.Drawing.Point(12, 174);
            this.ScreenshotButton.Name = "ScreenshotButton";
            this.ScreenshotButton.Size = new System.Drawing.Size(154, 31);
            this.ScreenshotButton.TabIndex = 0;
            this.ScreenshotButton.Text = "Screenshot !";
            this.ScreenshotButton.UseVisualStyleBackColor = true;
            this.ScreenshotButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DisplayValueButton
            // 
            this.DisplayValueButton.Location = new System.Drawing.Point(237, 174);
            this.DisplayValueButton.Name = "DisplayValueButton";
            this.DisplayValueButton.Size = new System.Drawing.Size(155, 31);
            this.DisplayValueButton.TabIndex = 3;
            this.DisplayValueButton.Text = "Quitter";
            this.DisplayValueButton.UseVisualStyleBackColor = true;
            this.DisplayValueButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LancerProgrammeButton
            // 
            this.LancerProgrammeButton.Location = new System.Drawing.Point(64, 12);
            this.LancerProgrammeButton.Name = "LancerProgrammeButton";
            this.LancerProgrammeButton.Size = new System.Drawing.Size(267, 80);
            this.LancerProgrammeButton.TabIndex = 4;
            this.LancerProgrammeButton.Text = "Lancer Programme";
            this.LancerProgrammeButton.UseVisualStyleBackColor = true;
            this.LancerProgrammeButton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(64, 106);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(267, 62);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset Morts Du Jour";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DeathCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 207);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.LancerProgrammeButton);
            this.Controls.Add(this.DisplayValueButton);
            this.Controls.Add(this.ScreenshotButton);
            this.Name = "DeathCounter";
            this.Text = "EldenRing Death Counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ScreenshotButton;
        private System.Windows.Forms.Button DisplayValueButton;
        private System.Windows.Forms.Button LancerProgrammeButton;
        private System.Windows.Forms.Button ResetButton;
    }
}


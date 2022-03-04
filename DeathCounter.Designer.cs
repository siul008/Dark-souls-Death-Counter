
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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.DisplayValueButton = new System.Windows.Forms.Button();
            this.LancerProgrammeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScreenshotButton
            // 
            this.ScreenshotButton.Location = new System.Drawing.Point(126, 71);
            this.ScreenshotButton.Name = "ScreenshotButton";
            this.ScreenshotButton.Size = new System.Drawing.Size(162, 54);
            this.ScreenshotButton.TabIndex = 0;
            this.ScreenshotButton.Text = "Screenshot !";
            this.ScreenshotButton.UseVisualStyleBackColor = true;
            this.ScreenshotButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "AddLeft";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(294, 71);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(99, 54);
            this.buttonTest.TabIndex = 2;
            this.buttonTest.Text = "Add Top";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // DisplayValueButton
            // 
            this.DisplayValueButton.Location = new System.Drawing.Point(133, 131);
            this.DisplayValueButton.Name = "DisplayValueButton";
            this.DisplayValueButton.Size = new System.Drawing.Size(155, 23);
            this.DisplayValueButton.TabIndex = 3;
            this.DisplayValueButton.Text = "Display Values";
            this.DisplayValueButton.UseVisualStyleBackColor = true;
            this.DisplayValueButton.Click += new System.EventHandler(this.DisplayValueButton_Click);
            // 
            // LancerProgrammeButton
            // 
            this.LancerProgrammeButton.Location = new System.Drawing.Point(75, 12);
            this.LancerProgrammeButton.Name = "LancerProgrammeButton";
            this.LancerProgrammeButton.Size = new System.Drawing.Size(267, 53);
            this.LancerProgrammeButton.TabIndex = 4;
            this.LancerProgrammeButton.Text = "Lancer Programme";
            this.LancerProgrammeButton.UseVisualStyleBackColor = true;
            this.LancerProgrammeButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DeathCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 207);
            this.Controls.Add(this.LancerProgrammeButton);
            this.Controls.Add(this.DisplayValueButton);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ScreenshotButton);
            this.Name = "DeathCounter";
            this.Text = "EldenRing Death Counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ScreenshotButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button DisplayValueButton;
        private System.Windows.Forms.Button LancerProgrammeButton;
    }
}


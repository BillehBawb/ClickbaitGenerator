namespace ClickbaitGenerator
{
    partial class Form1
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
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.gamingTab = new MetroFramework.Controls.MetroTabPage();
            this.generatedGamingTitle = new MetroFramework.Controls.MetroTextBox();
            this.generateGamingButton = new MetroFramework.Controls.MetroButton();
            this.somethingThatHappenedInput = new MetroFramework.Controls.MetroTextBox();
            this.somethingThatHappenedLabel = new MetroFramework.Controls.MetroLabel();
            this.gameInput = new MetroFramework.Controls.MetroTextBox();
            this.gameLabel = new MetroFramework.Controls.MetroLabel();
            this.vlogsTab = new MetroFramework.Controls.MetroTabPage();
            this.generateVlogsTitle = new MetroFramework.Controls.MetroTextBox();
            this.generateVlogsButton = new MetroFramework.Controls.MetroButton();
            this.somethingThatHappenedVlogsInput = new MetroFramework.Controls.MetroTextBox();
            this.somethingThatHappenedVlogsLabel = new MetroFramework.Controls.MetroLabel();
            this.locationInput = new MetroFramework.Controls.MetroTextBox();
            this.locationLabel = new MetroFramework.Controls.MetroLabel();
            this.tabControl.SuspendLayout();
            this.gamingTab.SuspendLayout();
            this.vlogsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.gamingTab);
            this.tabControl.Controls.Add(this.vlogsTab);
            this.tabControl.Location = new System.Drawing.Point(24, 63);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(538, 285);
            this.tabControl.TabIndex = 0;
            // 
            // gamingTab
            // 
            this.gamingTab.Controls.Add(this.generatedGamingTitle);
            this.gamingTab.Controls.Add(this.generateGamingButton);
            this.gamingTab.Controls.Add(this.somethingThatHappenedInput);
            this.gamingTab.Controls.Add(this.somethingThatHappenedLabel);
            this.gamingTab.Controls.Add(this.gameInput);
            this.gamingTab.Controls.Add(this.gameLabel);
            this.gamingTab.HorizontalScrollbarBarColor = true;
            this.gamingTab.Location = new System.Drawing.Point(4, 35);
            this.gamingTab.Name = "gamingTab";
            this.gamingTab.Size = new System.Drawing.Size(530, 246);
            this.gamingTab.TabIndex = 0;
            this.gamingTab.Text = "Gaming";
            this.gamingTab.VerticalScrollbarBarColor = true;
            // 
            // generatedGamingTitle
            // 
            this.generatedGamingTitle.Location = new System.Drawing.Point(4, 220);
            this.generatedGamingTitle.Name = "generatedGamingTitle";
            this.generatedGamingTitle.ReadOnly = true;
            this.generatedGamingTitle.Size = new System.Drawing.Size(523, 23);
            this.generatedGamingTitle.TabIndex = 7;
            // 
            // generateGamingButton
            // 
            this.generateGamingButton.Location = new System.Drawing.Point(337, 151);
            this.generateGamingButton.Name = "generateGamingButton";
            this.generateGamingButton.Size = new System.Drawing.Size(190, 63);
            this.generateGamingButton.TabIndex = 6;
            this.generateGamingButton.Text = "Generate Title";
            this.generateGamingButton.Click += new System.EventHandler(this.generateGamingButton_Click);
            // 
            // somethingThatHappenedInput
            // 
            this.somethingThatHappenedInput.Location = new System.Drawing.Point(246, 42);
            this.somethingThatHappenedInput.Name = "somethingThatHappenedInput";
            this.somethingThatHappenedInput.Size = new System.Drawing.Size(147, 23);
            this.somethingThatHappenedInput.TabIndex = 5;
            this.somethingThatHappenedInput.TextChanged += new System.EventHandler(this.somethingThatHappenedInput_TextChanged);
            // 
            // somethingThatHappenedLabel
            // 
            this.somethingThatHappenedLabel.AutoSize = true;
            this.somethingThatHappenedLabel.Location = new System.Drawing.Point(4, 42);
            this.somethingThatHappenedLabel.Name = "somethingThatHappenedLabel";
            this.somethingThatHappenedLabel.Size = new System.Drawing.Size(236, 19);
            this.somethingThatHappenedLabel.TabIndex = 4;
            this.somethingThatHappenedLabel.Text = "Something that happened in the video:";
            // 
            // gameInput
            // 
            this.gameInput.Location = new System.Drawing.Point(57, 13);
            this.gameInput.Name = "gameInput";
            this.gameInput.Size = new System.Drawing.Size(147, 23);
            this.gameInput.TabIndex = 3;
            this.gameInput.TextChanged += new System.EventHandler(this.gameInput_TextChanged);
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(4, 13);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(47, 19);
            this.gameLabel.TabIndex = 2;
            this.gameLabel.Text = "Game:";
            // 
            // vlogsTab
            // 
            this.vlogsTab.Controls.Add(this.generateVlogsTitle);
            this.vlogsTab.Controls.Add(this.generateVlogsButton);
            this.vlogsTab.Controls.Add(this.somethingThatHappenedVlogsInput);
            this.vlogsTab.Controls.Add(this.somethingThatHappenedVlogsLabel);
            this.vlogsTab.Controls.Add(this.locationInput);
            this.vlogsTab.Controls.Add(this.locationLabel);
            this.vlogsTab.HorizontalScrollbarBarColor = true;
            this.vlogsTab.Location = new System.Drawing.Point(4, 35);
            this.vlogsTab.Name = "vlogsTab";
            this.vlogsTab.Size = new System.Drawing.Size(530, 246);
            this.vlogsTab.TabIndex = 4;
            this.vlogsTab.Text = "Vlogs";
            this.vlogsTab.VerticalScrollbarBarColor = true;
            // 
            // generateVlogsTitle
            // 
            this.generateVlogsTitle.Location = new System.Drawing.Point(4, 220);
            this.generateVlogsTitle.Name = "generateVlogsTitle";
            this.generateVlogsTitle.ReadOnly = true;
            this.generateVlogsTitle.Size = new System.Drawing.Size(523, 23);
            this.generateVlogsTitle.TabIndex = 7;
            // 
            // generateVlogsButton
            // 
            this.generateVlogsButton.Location = new System.Drawing.Point(337, 151);
            this.generateVlogsButton.Name = "generateVlogsButton";
            this.generateVlogsButton.Size = new System.Drawing.Size(190, 63);
            this.generateVlogsButton.TabIndex = 6;
            this.generateVlogsButton.Text = "Generate Title";
            this.generateVlogsButton.Click += new System.EventHandler(this.generateVlogsButton_Click);
            // 
            // somethingThatHappenedVlogsInput
            // 
            this.somethingThatHappenedVlogsInput.Location = new System.Drawing.Point(246, 42);
            this.somethingThatHappenedVlogsInput.Name = "somethingThatHappenedVlogsInput";
            this.somethingThatHappenedVlogsInput.Size = new System.Drawing.Size(147, 23);
            this.somethingThatHappenedVlogsInput.TabIndex = 5;
            this.somethingThatHappenedVlogsInput.TextChanged += new System.EventHandler(this.somethingThatHappenedVlogsInput_TextChanged);
            // 
            // somethingThatHappenedVlogsLabel
            // 
            this.somethingThatHappenedVlogsLabel.AutoSize = true;
            this.somethingThatHappenedVlogsLabel.Location = new System.Drawing.Point(4, 42);
            this.somethingThatHappenedVlogsLabel.Name = "somethingThatHappenedVlogsLabel";
            this.somethingThatHappenedVlogsLabel.Size = new System.Drawing.Size(236, 19);
            this.somethingThatHappenedVlogsLabel.TabIndex = 4;
            this.somethingThatHappenedVlogsLabel.Text = "Something that happened in the video:";
            // 
            // locationInput
            // 
            this.locationInput.Location = new System.Drawing.Point(71, 13);
            this.locationInput.Name = "locationInput";
            this.locationInput.Size = new System.Drawing.Size(147, 23);
            this.locationInput.TabIndex = 3;
            this.locationInput.TextChanged += new System.EventHandler(this.locationInput_TextChanged);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(4, 13);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(61, 19);
            this.locationLabel.TabIndex = 2;
            this.locationLabel.Text = "Location:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 371);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "THE MOST EPIC CLICKBAIT TITLE GENERATOR EVER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.gamingTab.ResumeLayout(false);
            this.gamingTab.PerformLayout();
            this.vlogsTab.ResumeLayout(false);
            this.vlogsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage gamingTab;
        private MetroFramework.Controls.MetroTextBox generatedGamingTitle;
        private MetroFramework.Controls.MetroButton generateGamingButton;
        private MetroFramework.Controls.MetroTextBox somethingThatHappenedInput;
        private MetroFramework.Controls.MetroLabel somethingThatHappenedLabel;
        private MetroFramework.Controls.MetroTextBox gameInput;
        private MetroFramework.Controls.MetroLabel gameLabel;
        private MetroFramework.Controls.MetroTabPage vlogsTab;
        private MetroFramework.Controls.MetroTextBox generateVlogsTitle;
        private MetroFramework.Controls.MetroButton generateVlogsButton;
        private MetroFramework.Controls.MetroTextBox somethingThatHappenedVlogsInput;
        private MetroFramework.Controls.MetroLabel somethingThatHappenedVlogsLabel;
        private MetroFramework.Controls.MetroTextBox locationInput;
        private MetroFramework.Controls.MetroLabel locationLabel;
    }
}


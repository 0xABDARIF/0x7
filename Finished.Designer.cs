
namespace _0x7_Protector_GUI
{
    partial class Finished
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finished));
            this.siticoneElipse1 = new ns1.SiticoneElipse(this.components);
            this.OkButton = new ns1.SiticoneRoundedButton();
            this.BrowseFile = new ns1.SiticoneRoundedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneControlBox3 = new ns1.SiticoneControlBox();
            this.Logo = new ns1.SiticoneImageButton();
            this.MPanel = new System.Windows.Forms.Panel();
            this.EndButton = new ns1.SiticoneControlBox();
            this.iLabel1 = new ILabel();
            this.iLabel2 = new ILabel();
            this.panel1.SuspendLayout();
            this.MPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 4;
            this.siticoneElipse1.TargetControl = this;
            // 
            // OkButton
            // 
            this.OkButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.OkButton.BorderThickness = 1;
            this.OkButton.CheckedState.Parent = this.OkButton;
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.CustomImages.Parent = this.OkButton;
            this.OkButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.OkButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OkButton.ForeColor = System.Drawing.Color.White;
            this.OkButton.HoveredState.Parent = this.OkButton;
            this.OkButton.ImageSize = new System.Drawing.Size(24, 24);
            this.OkButton.Location = new System.Drawing.Point(388, 113);
            this.OkButton.Name = "OkButton";
            this.OkButton.ShadowDecoration.Parent = this.OkButton;
            this.OkButton.Size = new System.Drawing.Size(80, 36);
            this.OkButton.TabIndex = 21;
            this.OkButton.Text = "Okay";
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // BrowseFile
            // 
            this.BrowseFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.BrowseFile.BorderThickness = 1;
            this.BrowseFile.CheckedState.Parent = this.BrowseFile;
            this.BrowseFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseFile.CustomImages.Parent = this.BrowseFile;
            this.BrowseFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BrowseFile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BrowseFile.ForeColor = System.Drawing.Color.White;
            this.BrowseFile.HoveredState.Parent = this.BrowseFile;
            this.BrowseFile.ImageSize = new System.Drawing.Size(24, 24);
            this.BrowseFile.Location = new System.Drawing.Point(242, 113);
            this.BrowseFile.Name = "BrowseFile";
            this.BrowseFile.ShadowDecoration.Parent = this.BrowseFile;
            this.BrowseFile.Size = new System.Drawing.Size(140, 36);
            this.BrowseFile.TabIndex = 22;
            this.BrowseFile.Text = "Browse file";
            this.BrowseFile.Click += new System.EventHandler(this.BrowseFile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.iLabel2);
            this.panel1.Controls.Add(this.siticoneControlBox3);
            this.panel1.Controls.Add(this.BrowseFile);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.OkButton);
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 160);
            this.panel1.TabIndex = 24;
            // 
            // siticoneControlBox3
            // 
            this.siticoneControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.siticoneControlBox3.HoveredState.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox3.Location = new System.Drawing.Point(-87, 0);
            this.siticoneControlBox3.Name = "siticoneControlBox3";
            this.siticoneControlBox3.ShadowDecoration.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.Size = new System.Drawing.Size(29, 40);
            this.siticoneControlBox3.TabIndex = 2;
            // 
            // Logo
            // 
            this.Logo.CheckedState.Parent = this.Logo;
            this.Logo.HoveredState.ImageSize = new System.Drawing.Size(60, 60);
            this.Logo.HoveredState.Parent = this.Logo;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.ImageSize = new System.Drawing.Size(60, 60);
            this.Logo.Location = new System.Drawing.Point(44, 50);
            this.Logo.Name = "Logo";
            this.Logo.PressedState.ImageSize = new System.Drawing.Size(60, 60);
            this.Logo.PressedState.Parent = this.Logo;
            this.Logo.Size = new System.Drawing.Size(60, 60);
            this.Logo.TabIndex = 3;
            // 
            // MPanel
            // 
            this.MPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.MPanel.Controls.Add(this.iLabel1);
            this.MPanel.Controls.Add(this.EndButton);
            this.MPanel.Location = new System.Drawing.Point(0, 0);
            this.MPanel.Name = "MPanel";
            this.MPanel.Size = new System.Drawing.Size(480, 40);
            this.MPanel.TabIndex = 23;
            this.MPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MPanel_MouseDown_1);
            // 
            // EndButton
            // 
            this.EndButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EndButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.EndButton.HoveredState.Parent = this.EndButton;
            this.EndButton.IconColor = System.Drawing.Color.White;
            this.EndButton.Location = new System.Drawing.Point(-87, 0);
            this.EndButton.Name = "EndButton";
            this.EndButton.ShadowDecoration.Parent = this.EndButton;
            this.EndButton.Size = new System.Drawing.Size(29, 40);
            this.EndButton.TabIndex = 2;
            // 
            // iLabel1
            // 
            this.iLabel1.AutoSize = true;
            this.iLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iLabel1.ForeColor = System.Drawing.Color.White;
            this.iLabel1.Location = new System.Drawing.Point(8, 10);
            this.iLabel1.Name = "iLabel1";
            this.iLabel1.Size = new System.Drawing.Size(133, 19);
            this.iLabel1.TabIndex = 23;
            this.iLabel1.Text = "Obfuscation process";
            this.iLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.iLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MPanel_MouseDown_1);
            // 
            // iLabel2
            // 
            this.iLabel2.AutoSize = true;
            this.iLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iLabel2.ForeColor = System.Drawing.Color.White;
            this.iLabel2.Location = new System.Drawing.Point(110, 61);
            this.iLabel2.Name = "iLabel2";
            this.iLabel2.Size = new System.Drawing.Size(206, 38);
            this.iLabel2.TabIndex = 24;
            this.iLabel2.Text = "Your file obfuscated successfully,\r\ncheck log for more info .";
            this.iLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Finished
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(480, 200);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 200);
            this.Name = "Finished";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finished";
            this.Load += new System.EventHandler(this.Finished_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MPanel.ResumeLayout(false);
            this.MPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.SiticoneElipse siticoneElipse1;
        private ns1.SiticoneImageButton siticoneImageButton1;
        private ns1.SiticoneRoundedButton OkButton;
        private ns1.SiticoneRoundedButton BrowseFile;
        private System.Windows.Forms.Panel panel1;
        private ns1.SiticoneControlBox siticoneControlBox3;
        private ns1.SiticoneImageButton Logo;
        private System.Windows.Forms.Panel MPanel;
        private ns1.SiticoneControlBox EndButton;
        private ILabel iLabel2;
        private ILabel iLabel1;
    }
}
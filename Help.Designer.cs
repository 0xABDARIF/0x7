namespace _0x7_Protector_GUI
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.siticoneElipse1 = new ns1.SiticoneElipse(this.components);
            this.MPanel = new System.Windows.Forms.Panel();
            this.iLabel1 = new ILabel();
            this.EndButton = new ns1.SiticoneControlBox();
            this.Logo = new ns1.SiticoneImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iLabel2 = new ILabel();
            this.OkButton = new ns1.SiticoneRoundedButton();
            this.siticoneControlBox3 = new ns1.SiticoneControlBox();
            this.MPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.TargetControl = this;
            // 
            // MPanel
            // 
            this.MPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.MPanel.Controls.Add(this.iLabel1);
            this.MPanel.Controls.Add(this.EndButton);
            this.MPanel.Location = new System.Drawing.Point(0, 0);
            this.MPanel.Name = "MPanel";
            this.MPanel.Size = new System.Drawing.Size(480, 40);
            this.MPanel.TabIndex = 2;
            this.MPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MPanel_MouseDown_1);
            // 
            // iLabel1
            // 
            this.iLabel1.AutoSize = true;
            this.iLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iLabel1.ForeColor = System.Drawing.Color.White;
            this.iLabel1.Location = new System.Drawing.Point(8, 10);
            this.iLabel1.Name = "iLabel1";
            this.iLabel1.Size = new System.Drawing.Size(145, 19);
            this.iLabel1.TabIndex = 24;
            this.iLabel1.Text = "Need help with login ?";
            this.iLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.iLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MPanel_MouseDown_1);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.iLabel2);
            this.panel1.Controls.Add(this.OkButton);
            this.panel1.Controls.Add(this.siticoneControlBox3);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 160);
            this.panel1.TabIndex = 6;
            // 
            // iLabel2
            // 
            this.iLabel2.AutoSize = true;
            this.iLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iLabel2.ForeColor = System.Drawing.Color.White;
            this.iLabel2.Location = new System.Drawing.Point(110, 61);
            this.iLabel2.Name = "iLabel2";
            this.iLabel2.Size = new System.Drawing.Size(251, 38);
            this.iLabel2.TabIndex = 25;
            this.iLabel2.Text = "If you don\'t have username / password,\r\ncontact adnim to create you one !";
            this.iLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
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
            this.OkButton.TabIndex = 20;
            this.OkButton.Text = "Okay";
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
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
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(480, 200);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 200);
            this.Name = "Help";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Help_Load);
            this.MPanel.ResumeLayout(false);
            this.MPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.SiticoneElipse siticoneElipse1;
        private System.Windows.Forms.Panel MPanel;
        private ns1.SiticoneControlBox EndButton;
        private System.Windows.Forms.Panel panel1;
        private ns1.SiticoneControlBox siticoneControlBox3;
        private ns1.SiticoneImageButton Logo;
        private ns1.SiticoneRoundedButton OkButton;
        private ILabel iLabel1;
        private ILabel iLabel2;
    }
}
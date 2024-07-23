
namespace _0x7_Protector_GUI
{
    partial class NewUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUpdate));
            this.siticoneElipse1 = new ns1.SiticoneElipse(this.components);
            this.SkipUpdate = new ns1.SiticoneRoundedButton();
            this.VisitDiscordServer = new ns1.SiticoneRoundedButton();
            this.MPanel = new System.Windows.Forms.Panel();
            this.EndButton = new ns1.SiticoneControlBox();
            this.iLabel6 = new ILabel();
            this.MPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.TargetControl = this;
            // 
            // SkipUpdate
            // 
            this.SkipUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.SkipUpdate.BorderThickness = 1;
            this.SkipUpdate.CheckedState.Parent = this.SkipUpdate;
            this.SkipUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SkipUpdate.CustomImages.Parent = this.SkipUpdate;
            this.SkipUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SkipUpdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SkipUpdate.ForeColor = System.Drawing.Color.White;
            this.SkipUpdate.HoveredState.Parent = this.SkipUpdate;
            this.SkipUpdate.ImageSize = new System.Drawing.Size(24, 24);
            this.SkipUpdate.Location = new System.Drawing.Point(352, 152);
            this.SkipUpdate.Name = "SkipUpdate";
            this.SkipUpdate.ShadowDecoration.Parent = this.SkipUpdate;
            this.SkipUpdate.Size = new System.Drawing.Size(116, 36);
            this.SkipUpdate.TabIndex = 22;
            this.SkipUpdate.Text = "Skip";
            this.SkipUpdate.Click += new System.EventHandler(this.SkipUpdate_Click);
            // 
            // VisitDiscordServer
            // 
            this.VisitDiscordServer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.VisitDiscordServer.BorderThickness = 1;
            this.VisitDiscordServer.CheckedState.Parent = this.VisitDiscordServer;
            this.VisitDiscordServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisitDiscordServer.CustomImages.Parent = this.VisitDiscordServer;
            this.VisitDiscordServer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.VisitDiscordServer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.VisitDiscordServer.ForeColor = System.Drawing.Color.White;
            this.VisitDiscordServer.HoveredState.Parent = this.VisitDiscordServer;
            this.VisitDiscordServer.ImageSize = new System.Drawing.Size(24, 24);
            this.VisitDiscordServer.Location = new System.Drawing.Point(136, 152);
            this.VisitDiscordServer.Name = "VisitDiscordServer";
            this.VisitDiscordServer.ShadowDecoration.Parent = this.VisitDiscordServer;
            this.VisitDiscordServer.Size = new System.Drawing.Size(210, 36);
            this.VisitDiscordServer.TabIndex = 23;
            this.VisitDiscordServer.Text = "Go to discord";
            this.VisitDiscordServer.Click += new System.EventHandler(this.VisitDiscordServer_Click);
            // 
            // MPanel
            // 
            this.MPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.MPanel.Controls.Add(this.iLabel6);
            this.MPanel.Controls.Add(this.EndButton);
            this.MPanel.Location = new System.Drawing.Point(0, 0);
            this.MPanel.Name = "MPanel";
            this.MPanel.Size = new System.Drawing.Size(480, 40);
            this.MPanel.TabIndex = 24;
            this.MPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iLabel6_MouseDown);
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
            // iLabel6
            // 
            this.iLabel6.AutoSize = true;
            this.iLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iLabel6.ForeColor = System.Drawing.Color.White;
            this.iLabel6.Location = new System.Drawing.Point(8, 10);
            this.iLabel6.Name = "iLabel6";
            this.iLabel6.Size = new System.Drawing.Size(43, 19);
            this.iLabel6.TabIndex = 26;
            this.iLabel6.Text = "Login";
            this.iLabel6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.iLabel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iLabel6_MouseDown);
            // 
            // NewUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 200);
            this.Controls.Add(this.MPanel);
            this.Controls.Add(this.VisitDiscordServer);
            this.Controls.Add(this.SkipUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 200);
            this.Name = "NewUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Update !";
            this.Load += new System.EventHandler(this.NewUpdate_Load);
            this.MPanel.ResumeLayout(false);
            this.MPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ns1.SiticoneElipse siticoneElipse1;
        private ns1.SiticoneRoundedButton VisitDiscordServer;
        private ns1.SiticoneRoundedButton SkipUpdate;
        private System.Windows.Forms.Panel MPanel;
        private ns1.SiticoneControlBox EndButton;
        private ILabel iLabel6;
    }
}
namespace DuelSysApp
{
    partial class MainForm
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
            this.panelRowMenu = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblManagementLevel = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelContentHolder = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnTournament = new System.Windows.Forms.Button();
            this.panelRowMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRowMenu
            // 
            this.panelRowMenu.BackColor = System.Drawing.Color.White;
            this.panelRowMenu.Controls.Add(this.btnTournament);
            this.panelRowMenu.Controls.Add(this.btnAccount);
            this.panelRowMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRowMenu.Location = new System.Drawing.Point(0, 0);
            this.panelRowMenu.Name = "panelRowMenu";
            this.panelRowMenu.Size = new System.Drawing.Size(1266, 67);
            this.panelRowMenu.TabIndex = 0;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Good Times", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(0, 0);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(239, 67);
            this.btnAccount.TabIndex = 7;
            this.btnAccount.Text = "Accounts";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.Font = new System.Drawing.Font("Garet Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(77)))), ((int)(((byte)(67)))));
            this.lblWelcome.Location = new System.Drawing.Point(1768, 45);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWelcome.Size = new System.Drawing.Size(484, 36);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "Welcome, User!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(2280, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblManagementLevel
            // 
            this.lblManagementLevel.AutoSize = true;
            this.lblManagementLevel.Font = new System.Drawing.Font("Good Times", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblManagementLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(122)))), ((int)(((byte)(165)))));
            this.lblManagementLevel.Location = new System.Drawing.Point(12, 9);
            this.lblManagementLevel.Name = "lblManagementLevel";
            this.lblManagementLevel.Size = new System.Drawing.Size(591, 35);
            this.lblManagementLevel.TabIndex = 7;
            this.lblManagementLevel.Text = "General management";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelContentHolder);
            this.panelContent.Controls.Add(this.panelRowMenu);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 125);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1266, 521);
            this.panelContent.TabIndex = 4;
            // 
            // panelContentHolder
            // 
            this.panelContentHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentHolder.Location = new System.Drawing.Point(0, 67);
            this.panelContentHolder.Name = "panelContentHolder";
            this.panelContentHolder.Size = new System.Drawing.Size(1266, 454);
            this.panelContentHolder.TabIndex = 11;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.BurlyWood;
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Controls.Add(this.lblManagementLevel);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1266, 125);
            this.panelHeader.TabIndex = 3;
            // 
            // btnTournament
            // 
            this.btnTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.btnTournament.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTournament.FlatAppearance.BorderSize = 0;
            this.btnTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTournament.Font = new System.Drawing.Font("Good Times", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTournament.ForeColor = System.Drawing.Color.White;
            this.btnTournament.Location = new System.Drawing.Point(239, 0);
            this.btnTournament.Name = "btnTournament";
            this.btnTournament.Size = new System.Drawing.Size(239, 67);
            this.btnTournament.TabIndex = 8;
            this.btnTournament.Text = "Tournament";
            this.btnTournament.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 646);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelRowMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelRowMenu;
        private Button btnAccount;
        private Label lblWelcome;
        private PictureBox pictureBox2;
        private Label lblManagementLevel;
        private Panel panelContent;
        private Panel panelContentHolder;
        private Panel panelHeader;
        private Button btnTournament;
    }
}
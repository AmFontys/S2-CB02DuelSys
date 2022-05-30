namespace DualSysApp
{
    partial class MatchesOverview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbView = new System.Windows.Forms.ListBox();
            this.lblSectionName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTournaments = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbView
            // 
            this.lbView.FormattingEnabled = true;
            this.lbView.ItemHeight = 20;
            this.lbView.Location = new System.Drawing.Point(75, 157);
            this.lbView.Name = "lbView";
            this.lbView.Size = new System.Drawing.Size(1180, 204);
            this.lbView.TabIndex = 38;
            this.lbView.SelectedIndexChanged += new System.EventHandler(this.lbView_SelectedIndexChanged);
            // 
            // lblSectionName
            // 
            this.lblSectionName.AutoSize = true;
            this.lblSectionName.Font = new System.Drawing.Font("Good Times", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSectionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(122)))), ((int)(((byte)(165)))));
            this.lblSectionName.Location = new System.Drawing.Point(321, 14);
            this.lblSectionName.Name = "lblSectionName";
            this.lblSectionName.Size = new System.Drawing.Size(394, 35);
            this.lblSectionName.TabIndex = 21;
            this.lblSectionName.Text = "View Matches";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(57, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 101);
            this.panel1.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbTournaments);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnLoad);
            this.panel3.Controls.Add(this.lblSectionName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(57, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1220, 141);
            this.panel3.TabIndex = 34;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(29)))), ((int)(((byte)(49)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Good Times", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(1031, 74);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(167, 50);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1277, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 477);
            this.panel4.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 477);
            this.panel2.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "View matches of";
            // 
            // cmbTournaments
            // 
            this.cmbTournaments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTournaments.FormattingEnabled = true;
            this.cmbTournaments.Location = new System.Drawing.Point(862, 96);
            this.cmbTournaments.Name = "cmbTournaments";
            this.cmbTournaments.Size = new System.Drawing.Size(151, 28);
            this.cmbTournaments.TabIndex = 23;
            // 
            // MatchesOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "MatchesOverview";
            this.Size = new System.Drawing.Size(1337, 477);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbView;
        private Label lblSectionName;
        private Panel panel1;
        private Panel panel3;
        private ComboBox cmbTournaments;
        private Label label1;
        private Button btnLoad;
        private Panel panel4;
        private Panel panel2;
    }
}

namespace DuelSysApp.TournamentViews
{
    partial class TournamentOverview
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
            this.lblSectionName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbAvaible = new System.Windows.Forms.RadioButton();
            this.rbOnGoing = new System.Windows.Forms.RadioButton();
            this.rbFinished = new System.Windows.Forms.RadioButton();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbView = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSectionName
            // 
            this.lblSectionName.AutoSize = true;
            this.lblSectionName.Font = new System.Drawing.Font("Good Times", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSectionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(122)))), ((int)(((byte)(165)))));
            this.lblSectionName.Location = new System.Drawing.Point(321, 14);
            this.lblSectionName.Name = "lblSectionName";
            this.lblSectionName.Size = new System.Drawing.Size(534, 35);
            this.lblSectionName.TabIndex = 21;
            this.lblSectionName.Text = "View Tournaments";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(29)))), ((int)(((byte)(49)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Good Times", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(272, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 50);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(29)))), ((int)(((byte)(49)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Good Times", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(99, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 50);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(57, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 123);
            this.panel1.TabIndex = 32;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(29)))), ((int)(((byte)(49)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Good Times", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(445, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(167, 50);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbAvaible);
            this.panel3.Controls.Add(this.rbOnGoing);
            this.panel3.Controls.Add(this.rbFinished);
            this.panel3.Controls.Add(this.btnLoad);
            this.panel3.Controls.Add(this.lblSectionName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(57, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1209, 130);
            this.panel3.TabIndex = 29;
            // 
            // rbAvaible
            // 
            this.rbAvaible.AutoSize = true;
            this.rbAvaible.Location = new System.Drawing.Point(400, 99);
            this.rbAvaible.Name = "rbAvaible";
            this.rbAvaible.Size = new System.Drawing.Size(80, 24);
            this.rbAvaible.TabIndex = 30;
            this.rbAvaible.Text = "Avaible";
            this.rbAvaible.UseVisualStyleBackColor = true;
            // 
            // rbOnGoing
            // 
            this.rbOnGoing.AutoSize = true;
            this.rbOnGoing.Checked = true;
            this.rbOnGoing.Location = new System.Drawing.Point(302, 99);
            this.rbOnGoing.Name = "rbOnGoing";
            this.rbOnGoing.Size = new System.Drawing.Size(92, 24);
            this.rbOnGoing.TabIndex = 29;
            this.rbOnGoing.TabStop = true;
            this.rbOnGoing.Text = "On going";
            this.rbOnGoing.UseVisualStyleBackColor = true;
            // 
            // rbFinished
            // 
            this.rbFinished.AutoSize = true;
            this.rbFinished.Location = new System.Drawing.Point(204, 99);
            this.rbFinished.Name = "rbFinished";
            this.rbFinished.Size = new System.Drawing.Size(84, 24);
            this.rbFinished.TabIndex = 28;
            this.rbFinished.Text = "Finished";
            this.rbFinished.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(29)))), ((int)(((byte)(49)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Good Times", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(27, 73);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(167, 50);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbView
            // 
            this.lbView.FormattingEnabled = true;
            this.lbView.ItemHeight = 20;
            this.lbView.Location = new System.Drawing.Point(84, 149);
            this.lbView.Name = "lbView";
            this.lbView.Size = new System.Drawing.Size(1180, 224);
            this.lbView.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1266, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 585);
            this.panel4.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 585);
            this.panel2.TabIndex = 31;
            // 
            // TournamentOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "TournamentOverview";
            this.Size = new System.Drawing.Size(1326, 585);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblSectionName;
        private Button btnDelete;
        private Button btnAdd;
        private Panel panel1;
        private Button btnUpdate;
        private Panel panel3;
        private RadioButton rbAvaible;
        private RadioButton rbOnGoing;
        private RadioButton rbFinished;
        private Button btnLoad;
        private ListBox lbView;
        private Panel panel4;
        private Panel panel2;
    }
}

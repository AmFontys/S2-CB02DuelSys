namespace DualSysApp
{
    partial class MatchForm
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
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.btnAddResult = new System.Windows.Forms.Button();
            this.nudPlayer1 = new System.Windows.Forms.NumericUpDown();
            this.nudPlayer2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.Location = new System.Drawing.Point(12, 9);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(268, 60);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "Player 1 name";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.Location = new System.Drawing.Point(318, 20);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(253, 49);
            this.lblPlayer2.TabIndex = 1;
            this.lblPlayer2.Text = "Player 2 name";
            // 
            // btnAddResult
            // 
            this.btnAddResult.Location = new System.Drawing.Point(12, 164);
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.Size = new System.Drawing.Size(155, 45);
            this.btnAddResult.TabIndex = 4;
            this.btnAddResult.Text = "Add result";
            this.btnAddResult.UseVisualStyleBackColor = true;
            this.btnAddResult.Click += new System.EventHandler(this.btnAddResult_Click);
            // 
            // nudPlayer1
            // 
            this.nudPlayer1.Location = new System.Drawing.Point(12, 83);
            this.nudPlayer1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudPlayer1.Name = "nudPlayer1";
            this.nudPlayer1.Size = new System.Drawing.Size(268, 27);
            this.nudPlayer1.TabIndex = 5;
            // 
            // nudPlayer2
            // 
            this.nudPlayer2.Location = new System.Drawing.Point(303, 83);
            this.nudPlayer2.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudPlayer2.Name = "nudPlayer2";
            this.nudPlayer2.Size = new System.Drawing.Size(268, 27);
            this.nudPlayer2.TabIndex = 6;
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 221);
            this.Controls.Add(this.nudPlayer2);
            this.Controls.Add(this.nudPlayer1);
            this.Controls.Add(this.btnAddResult);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Name = "MatchForm";
            this.Text = "MatchForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayer2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblPlayer1;
        private Label lblPlayer2;
        private Button btnAddResult;
        private NumericUpDown nudPlayer1;
        private NumericUpDown nudPlayer2;
    }
}
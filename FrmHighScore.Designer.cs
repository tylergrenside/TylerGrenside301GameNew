namespace TylerGrenside301Game
{
    partial class FrmHighScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblPlayerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblPlayerScore = new System.Windows.Forms.Label();
            this.LblMessage = new System.Windows.Forms.Label();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LstBoxName = new System.Windows.Forms.ListBox();
            this.LstBoxScore = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player\'s Name";
            // 
            // LblPlayerName
            // 
            this.LblPlayerName.AutoSize = true;
            this.LblPlayerName.Location = new System.Drawing.Point(244, 450);
            this.LblPlayerName.Name = "LblPlayerName";
            this.LblPlayerName.Size = new System.Drawing.Size(39, 15);
            this.LblPlayerName.TabIndex = 3;
            this.LblPlayerName.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Player\'s Score";
            // 
            // LblPlayerScore
            // 
            this.LblPlayerScore.AutoSize = true;
            this.LblPlayerScore.Location = new System.Drawing.Point(247, 533);
            this.LblPlayerScore.Name = "LblPlayerScore";
            this.LblPlayerScore.Size = new System.Drawing.Size(36, 15);
            this.LblPlayerScore.TabIndex = 5;
            this.LblPlayerScore.Text = "Score";
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Location = new System.Drawing.Point(50, 625);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(0, 15);
            this.LblMessage.TabIndex = 6;
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(436, 582);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(107, 23);
            this.BtnReturn.TabIndex = 7;
            this.BtnReturn.Text = "Get A New Pet";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LstBoxName
            // 
            this.LstBoxName.FormattingEnabled = true;
            this.LstBoxName.ItemHeight = 15;
            this.LstBoxName.Location = new System.Drawing.Point(50, 62);
            this.LstBoxName.Name = "LstBoxName";
            this.LstBoxName.Size = new System.Drawing.Size(120, 259);
            this.LstBoxName.TabIndex = 8;
            // 
            // LstBoxScore
            // 
            this.LstBoxScore.FormattingEnabled = true;
            this.LstBoxScore.ItemHeight = 15;
            this.LstBoxScore.Location = new System.Drawing.Point(247, 62);
            this.LstBoxScore.Name = "LstBoxScore";
            this.LstBoxScore.Size = new System.Drawing.Size(120, 259);
            this.LstBoxScore.TabIndex = 9;
            // 
            // FrmHighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 761);
            this.Controls.Add(this.LstBoxScore);
            this.Controls.Add(this.LstBoxName);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.LblPlayerScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblPlayerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmHighScore";
            this.Text = "High Scores";
            this.Load += new System.EventHandler(this.FrmHighScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblPlayerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblPlayerScore;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.ListBox LstBoxName;
        private System.Windows.Forms.ListBox LstBoxScore;
    }
}
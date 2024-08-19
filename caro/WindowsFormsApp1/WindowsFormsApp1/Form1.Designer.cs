namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.IP = new System.Windows.Forms.TextBox();
            this.Mark = new System.Windows.Forms.PictureBox();
            this.CoolDown = new System.Windows.Forms.ProgressBar();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.ChessBoard = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mark)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Connect);
            this.panel1.Controls.Add(this.IP);
            this.panel1.Controls.Add(this.Mark);
            this.panel1.Controls.Add(this.CoolDown);
            this.panel1.Controls.Add(this.PlayerName);
            this.panel1.Location = new System.Drawing.Point(660, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 322);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "5 in a line to win";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(0, 106);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(161, 38);
            this.Connect.TabIndex = 4;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(0, 74);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(161, 26);
            this.IP.TabIndex = 3;
            // 
            // Mark
            // 
            this.Mark.Location = new System.Drawing.Point(166, 0);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(171, 144);
            this.Mark.TabIndex = 2;
            this.Mark.TabStop = false;
            // 
            // CoolDown
            // 
            this.CoolDown.Location = new System.Drawing.Point(3, 39);
            this.CoolDown.Name = "CoolDown";
            this.CoolDown.Size = new System.Drawing.Size(158, 33);
            this.CoolDown.TabIndex = 1;
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(3, 3);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(158, 26);
            this.PlayerName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Avatar);
            this.panel2.Location = new System.Drawing.Point(660, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 337);
            this.panel2.TabIndex = 3;
            // 
            // Avatar
            // 
            this.Avatar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.caro1;
            this.Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Avatar.Location = new System.Drawing.Point(0, 0);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(337, 337);
            this.Avatar.TabIndex = 0;
            this.Avatar.TabStop = false;
            // 
            // ChessBoard
            // 
            this.ChessBoard.Location = new System.Drawing.Point(12, 12);
            this.ChessBoard.Name = "ChessBoard";
            this.ChessBoard.Size = new System.Drawing.Size(665, 665);
            this.ChessBoard.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 678);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChessBoard);
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mark)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.ProgressBar CoolDown;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.PictureBox Mark;
        private System.Windows.Forms.Panel ChessBoard;
    }
}


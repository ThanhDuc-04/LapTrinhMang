namespace GameCaro
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.Mark = new System.Windows.Forms.PictureBox();
            this.CoolDown = new System.Windows.Forms.ProgressBar();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.ChessBoard = new System.Windows.Forms.Panel();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mark)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Avatar);
            this.panel2.Location = new System.Drawing.Point(662, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 337);
            this.panel2.TabIndex = 6;
            // 
            // Avatar
            // 
            this.Avatar.BackgroundImage = global::GameCaro.Properties.Resources.caro;
            this.Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Avatar.Location = new System.Drawing.Point(0, 0);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(337, 337);
            this.Avatar.TabIndex = 0;
            this.Avatar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.connect);
            this.panel1.Controls.Add(this.txbIP);
            this.panel1.Controls.Add(this.Mark);
            this.panel1.Controls.Add(this.CoolDown);
            this.panel1.Controls.Add(this.PlayerName);
            this.panel1.Location = new System.Drawing.Point(662, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 322);
            this.panel1.TabIndex = 5;
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
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(10, 106);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(151, 38);
            this.connect.TabIndex = 4;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(10, 74);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(151, 26);
            this.txbIP.TabIndex = 3;
            this.txbIP.Text = "127.0.0.1";
            // 
            // Mark
            // 
            this.Mark.Location = new System.Drawing.Point(166, 0);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(171, 144);
            this.Mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mark.TabIndex = 2;
            this.Mark.TabStop = false;
            // 
            // CoolDown
            // 
            this.CoolDown.Location = new System.Drawing.Point(10, 39);
            this.CoolDown.Name = "CoolDown";
            this.CoolDown.Size = new System.Drawing.Size(151, 33);
            this.CoolDown.TabIndex = 1;
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(10, 3);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            this.PlayerName.Size = new System.Drawing.Size(151, 26);
            this.PlayerName.TabIndex = 0;
            // 
            // ChessBoard
            // 
            this.ChessBoard.Location = new System.Drawing.Point(12, 37);
            this.ChessBoard.Name = "ChessBoard";
            this.ChessBoard.Size = new System.Drawing.Size(665, 665);
            this.ChessBoard.TabIndex = 7;
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 36);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 744);
            this.Controls.Add(this.ChessBoard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mark)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.PictureBox Mark;
        private System.Windows.Forms.ProgressBar CoolDown;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Panel ChessBoard;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}


namespace Pictionary
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.input = new System.Windows.Forms.TextBox();
            this.countdown = new System.Windows.Forms.Label();
            this.chat = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.Panel();
            this.icon = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.playerList = new Pictionary.PlayerList();
            this.right = new System.Windows.Forms.Panel();
            this.btnReady = new System.Windows.Forms.Button();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.chooseWord = new Pictionary.ChooseWord();
            this.drawingBoard = new Pictionary.DrawingBoard();
            this.menu.SuspendLayout();
            this.icon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.right.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input.Location = new System.Drawing.Point(0, 679);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(197, 20);
            this.input.TabIndex = 0;
            this.input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // countdown
            // 
            this.countdown.Dock = System.Windows.Forms.DockStyle.Left;
            this.countdown.Enabled = false;
            this.countdown.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown.Location = new System.Drawing.Point(0, 0);
            this.countdown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(69, 52);
            this.countdown.TabIndex = 7;
            this.countdown.Text = "90";
            this.countdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countdown.Visible = false;
            this.countdown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // chat
            // 
            this.chat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chat.Location = new System.Drawing.Point(0, 0);
            this.chat.Multiline = true;
            this.chat.Name = "chat";
            this.chat.ReadOnly = true;
            this.chat.Size = new System.Drawing.Size(197, 673);
            this.chat.TabIndex = 9;
            this.chat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chat_KeyPress);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.menu.Controls.Add(this.icon);
            this.menu.Controls.Add(this.playerList);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(200, 757);
            this.menu.TabIndex = 11;
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.icon.Controls.Add(this.pictureBox1);
            this.icon.Controls.Add(this.label6);
            this.icon.Location = new System.Drawing.Point(0, 0);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(200, 55);
            this.icon.TabIndex = 0;
            this.icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(5, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pictionary";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // playerList
            // 
            this.playerList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playerList.Location = new System.Drawing.Point(0, 55);
            this.playerList.Margin = new System.Windows.Forms.Padding(4);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(200, 702);
            this.playerList.TabIndex = 4;
            this.playerList.TabStop = false;
            this.playerList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chat_KeyPress);
            // 
            // right
            // 
            this.right.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.right.Controls.Add(this.chat);
            this.right.Controls.Add(this.input);
            this.right.Location = new System.Drawing.Point(1236, 55);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(200, 702);
            this.right.TabIndex = 13;
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnReady.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReady.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnReady.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReady.Location = new System.Drawing.Point(206, 62);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(92, 34);
            this.btnReady.TabIndex = 2;
            this.btnReady.TabStop = false;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            this.btnReady.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chat_KeyPress);
            // 
            // lblWaiting
            // 
            this.lblWaiting.BackColor = System.Drawing.Color.Transparent;
            this.lblWaiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWaiting.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblWaiting.Location = new System.Drawing.Point(69, 0);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Padding = new System.Windows.Forms.Padding(0, 0, 200, 0);
            this.lblWaiting.Size = new System.Drawing.Size(1167, 52);
            this.lblWaiting.TabIndex = 16;
            this.lblWaiting.Text = "Waiting for players to get ready";
            this.lblWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWaiting.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.LightGray;
            this.header.Controls.Add(this.btnClose);
            this.header.Controls.Add(this.btnMinimize);
            this.header.Controls.Add(this.lblWaiting);
            this.header.Controls.Add(this.countdown);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(200, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1236, 52);
            this.header.TabIndex = 17;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1206, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 15;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1175, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            // 
            // chooseWord
            // 
            this.chooseWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.chooseWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chooseWord.Enabled = false;
            this.chooseWord.Location = new System.Drawing.Point(408, 111);
            this.chooseWord.Margin = new System.Windows.Forms.Padding(2);
            this.chooseWord.Name = "chooseWord";
            this.chooseWord.Size = new System.Drawing.Size(630, 220);
            this.chooseWord.TabIndex = 6;
            this.chooseWord.TabStop = false;
            this.chooseWord.Visible = false;
            this.chooseWord.NewWordChosen += new System.EventHandler(this.chooseWord_NewWordChosen);
            this.chooseWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chat_KeyPress);
            // 
            // drawingBoard
            // 
            this.drawingBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingBoard.Location = new System.Drawing.Point(203, 55);
            this.drawingBoard.Margin = new System.Windows.Forms.Padding(2);
            this.drawingBoard.Name = "drawingBoard";
            this.drawingBoard.Size = new System.Drawing.Size(1032, 702);
            this.drawingBoard.TabIndex = 10;
            this.drawingBoard.ButtonClearClick += new System.EventHandler(this.drawingBoard_ButtonClearClick);
            this.drawingBoard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chat_KeyPress);
            this.drawingBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseDown);
            this.drawingBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseMove);
            this.drawingBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseUp);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1436, 757);
            this.Controls.Add(this.header);
            this.Controls.Add(this.right);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.chooseWord);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.drawingBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Client";
            this.Text = "Pictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            this.Enter += new System.EventHandler(this.Client_Enter);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chat_KeyPress);
            this.menu.ResumeLayout(false);
            this.icon.ResumeLayout(false);
            this.icon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.right.ResumeLayout(false);
            this.right.PerformLayout();
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PlayerList playerList;
        private ChooseWord chooseWord;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.TextBox chat;
        private DrawingBoard drawingBoard;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel icon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel right;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Label lblWaiting;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
    }
}
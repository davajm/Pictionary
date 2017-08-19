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
            this.btnReady = new System.Windows.Forms.Button();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.countdown = new System.Windows.Forms.Label();
            this.chat = new System.Windows.Forms.TextBox();
            this.chooseWord = new Pictionary.ChooseWord();
            this.playerList = new Pictionary.PlayerList();
            this.drawingBoard = new Pictionary.DrawingBoard();
            this.SuspendLayout();
            // 
            // btnReady
            // 
            this.btnReady.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnReady.Location = new System.Drawing.Point(223, 9);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(75, 30);
            this.btnReady.TabIndex = 2;
            this.btnReady.TabStop = false;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // lblWaiting
            // 
            this.lblWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWaiting.BackColor = System.Drawing.Color.Transparent;
            this.lblWaiting.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblWaiting.Location = new System.Drawing.Point(304, 13);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(872, 29);
            this.lblWaiting.TabIndex = 3;
            this.lblWaiting.Text = "Waiting for players to get ready";
            this.lblWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.input.Location = new System.Drawing.Point(1218, 732);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(206, 20);
            this.input.TabIndex = 0;
            this.input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // countdown
            // 
            this.countdown.Enabled = false;
            this.countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.countdown.Location = new System.Drawing.Point(224, 9);
            this.countdown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(75, 35);
            this.countdown.TabIndex = 7;
            this.countdown.Text = "90";
            this.countdown.Visible = false;
            // 
            // chat
            // 
            this.chat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chat.Location = new System.Drawing.Point(1218, 9);
            this.chat.Multiline = true;
            this.chat.Name = "chat";
            this.chat.ReadOnly = true;
            this.chat.Size = new System.Drawing.Size(206, 717);
            this.chat.TabIndex = 9;
            this.chat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chat_KeyPress);
            // 
            // chooseWord
            // 
            this.chooseWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseWord.BackColor = System.Drawing.SystemColors.Control;
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
            // 
            // playerList
            // 
            this.playerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.playerList.BackColor = System.Drawing.SystemColors.Control;
            this.playerList.Location = new System.Drawing.Point(6, 9);
            this.playerList.Margin = new System.Windows.Forms.Padding(4);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(211, 743);
            this.playerList.TabIndex = 4;
            this.playerList.TabStop = false;
            // 
            // drawingBoard
            // 
            this.drawingBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingBoard.Location = new System.Drawing.Point(218, 44);
            this.drawingBoard.Margin = new System.Windows.Forms.Padding(2);
            this.drawingBoard.Name = "drawingBoard";
            this.drawingBoard.Size = new System.Drawing.Size(994, 708);
            this.drawingBoard.TabIndex = 10;
            this.drawingBoard.ButtonClearClick += new System.EventHandler(this.drawingBoard_ButtonClearClick);
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
            this.Controls.Add(this.chat);
            this.Controls.Add(this.input);
            this.Controls.Add(this.chooseWord);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.lblWaiting);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.drawingBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Client";
            this.Text = "Pictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            this.Enter += new System.EventHandler(this.Client_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Label lblWaiting;
        private PlayerList playerList;
        private ChooseWord chooseWord;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.TextBox chat;
        private DrawingBoard drawingBoard;
    }
}
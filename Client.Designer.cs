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
            this.drawingBoard = new System.Windows.Forms.PictureBox();
            this.input = new System.Windows.Forms.TextBox();
            this.chat = new System.Windows.Forms.TextBox();
            this.chooseWord = new Pictionary.ChooseWord();
            this.playerList = new Pictionary.PlayerList();
            this.countdown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReady
            // 
            this.btnReady.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnReady.Location = new System.Drawing.Point(297, 11);
            this.btnReady.Margin = new System.Windows.Forms.Padding(4);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(100, 37);
            this.btnReady.TabIndex = 2;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // lblWaiting
            // 
            this.lblWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWaiting.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblWaiting.Location = new System.Drawing.Point(405, 16);
            this.lblWaiting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(1163, 36);
            this.lblWaiting.TabIndex = 3;
            this.lblWaiting.Text = "Waiting for players to get ready";
            this.lblWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawingBoard
            // 
            this.drawingBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingBoard.Location = new System.Drawing.Point(291, 2);
            this.drawingBoard.Margin = new System.Windows.Forms.Padding(4);
            this.drawingBoard.Name = "drawingBoard";
            this.drawingBoard.Size = new System.Drawing.Size(1325, 929);
            this.drawingBoard.TabIndex = 5;
            this.drawingBoard.TabStop = false;
            this.drawingBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingBoard_Paint);
            this.drawingBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseDown);
            this.drawingBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseMove);
            this.drawingBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseUp);
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.input.Location = new System.Drawing.Point(1624, 901);
            this.input.Margin = new System.Windows.Forms.Padding(4);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(285, 22);
            this.input.TabIndex = 0;
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // chat
            // 
            this.chat.Location = new System.Drawing.Point(1624, 2);
            this.chat.Margin = new System.Windows.Forms.Padding(4);
            this.chat.Multiline = true;
            this.chat.Name = "chat";
            this.chat.ReadOnly = true;
            this.chat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chat.Size = new System.Drawing.Size(285, 891);
            this.chat.TabIndex = 1;
            // 
            // chooseWord
            // 
            this.chooseWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chooseWord.Enabled = false;
            this.chooseWord.Location = new System.Drawing.Point(544, 137);
            this.chooseWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseWord.Name = "chooseWord";
            this.chooseWord.Size = new System.Drawing.Size(839, 270);
            this.chooseWord.TabIndex = 6;
            this.chooseWord.Visible = false;
            this.chooseWord.NewWordChosen += new System.EventHandler(this.chooseWord_NewWordChosen);
            // 
            // playerList
            // 
            this.playerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerList.Location = new System.Drawing.Point(1, 2);
            this.playerList.Margin = new System.Windows.Forms.Padding(5);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(288, 933);
            this.playerList.TabIndex = 4;
            // 
            // countdown
            // 
            this.countdown.Enabled = false;
            this.countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.countdown.Location = new System.Drawing.Point(298, 11);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(100, 43);
            this.countdown.TabIndex = 7;
            this.countdown.Text = "90";
            this.countdown.Visible = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 926);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.input);
            this.Controls.Add(this.chat);
            this.Controls.Add(this.chooseWord);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.lblWaiting);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.drawingBoard);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1994, 973);
            this.MinimumSize = new System.Drawing.Size(1917, 973);
            this.Name = "Client";
            this.Text = "Pictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawingBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Label lblWaiting;
        private PlayerList playerList;
        private System.Windows.Forms.PictureBox drawingBoard;
        private ChooseWord chooseWord;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox chat;
        private System.Windows.Forms.Label countdown;
    }
}
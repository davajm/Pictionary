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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chat = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.btnReady = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.drawingBoard = new System.Windows.Forms.PictureBox();
            this.playerList = new Pictionary.PlayerList();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chat);
            this.groupBox2.Controls.Add(this.input);
            this.groupBox2.Location = new System.Drawing.Point(1261, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 764);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // chat
            // 
            this.chat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chat.Location = new System.Drawing.Point(0, 4);
            this.chat.Multiline = true;
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(219, 725);
            this.chat.TabIndex = 1;
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.input.Location = new System.Drawing.Point(0, 735);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(219, 20);
            this.input.TabIndex = 0;
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // btnReady
            // 
            this.btnReady.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnReady.Location = new System.Drawing.Point(223, 12);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(75, 30);
            this.btnReady.TabIndex = 2;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label1.Location = new System.Drawing.Point(519, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Waiting for players to get ready";
            // 
            // drawingBoard
            // 
            this.drawingBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingBoard.Location = new System.Drawing.Point(218, 5);
            this.drawingBoard.Name = "drawingBoard";
            this.drawingBoard.Size = new System.Drawing.Size(1039, 752);
            this.drawingBoard.TabIndex = 5;
            this.drawingBoard.TabStop = false;
            this.drawingBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseDown);
            this.drawingBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseMove);
            this.drawingBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseUp);
            // 
            // playerList
            // 
            this.playerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.playerList.Location = new System.Drawing.Point(1, 2);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(216, 758);
            this.playerList.TabIndex = 4;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.drawingBoard);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "Client";
            this.Text = "Pictionary";
            this.Load += new System.EventHandler(this.Client_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox chat;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Label label1;
        private PlayerList playerList;
        private System.Windows.Forms.PictureBox drawingBoard;
    }
}
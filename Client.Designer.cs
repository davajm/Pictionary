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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.btnReady = new System.Windows.Forms.Button();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.countdown = new System.Windows.Forms.Label();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.btnSize = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.Button();
            this.cmsSize = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.point1 = new System.Windows.Forms.ToolStripMenuItem();
            this.point2 = new System.Windows.Forms.ToolStripMenuItem();
            this.point3 = new System.Windows.Forms.ToolStripMenuItem();
            this.point4 = new System.Windows.Forms.ToolStripMenuItem();
            this.drawingBoard = new System.Windows.Forms.PictureBox();
            this.chat = new System.Windows.Forms.TextBox();
            this.chooseWord = new Pictionary.ChooseWord();
            this.playerList = new Pictionary.PlayerList();
            this.drawingPanel.SuspendLayout();
            this.cmsSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawingBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReady
            // 
            this.btnReady.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnReady.Location = new System.Drawing.Point(297, 11);
            this.btnReady.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(100, 37);
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
            this.lblWaiting.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblWaiting.Location = new System.Drawing.Point(405, 16);
            this.lblWaiting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(1163, 36);
            this.lblWaiting.TabIndex = 3;
            this.lblWaiting.Text = "Waiting for players to get ready";
            this.lblWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.input.Location = new System.Drawing.Point(1624, 901);
            this.input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(273, 22);
            this.input.TabIndex = 0;
            this.input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // countdown
            // 
            this.countdown.Enabled = false;
            this.countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.countdown.Location = new System.Drawing.Point(299, 11);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(100, 43);
            this.countdown.TabIndex = 7;
            this.countdown.Text = "90";
            this.countdown.Visible = false;
            // 
            // drawingPanel
            // 
            this.drawingPanel.Controls.Add(this.btnSize);
            this.drawingPanel.Controls.Add(this.btnErase);
            this.drawingPanel.Controls.Add(this.btnFill);
            this.drawingPanel.Controls.Add(this.btnPen);
            this.drawingPanel.Controls.Add(this.colorPicker);
            this.drawingPanel.Enabled = false;
            this.drawingPanel.Location = new System.Drawing.Point(291, 853);
            this.drawingPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(1325, 73);
            this.drawingPanel.TabIndex = 8;
            this.drawingPanel.Visible = false;
            // 
            // btnSize
            // 
            this.btnSize.BackColor = System.Drawing.Color.Transparent;
            this.btnSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSize.Image = global::Pictionary.Properties.Resources.point4;
            this.btnSize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSize.Location = new System.Drawing.Point(319, 5);
            this.btnSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(67, 62);
            this.btnSize.TabIndex = 4;
            this.btnSize.TabStop = false;
            this.btnSize.Text = "Size";
            this.btnSize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSize.UseVisualStyleBackColor = false;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnErase
            // 
            this.btnErase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnErase.BackgroundImage")));
            this.btnErase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErase.Location = new System.Drawing.Point(155, 4);
            this.btnErase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(67, 62);
            this.btnErase.TabIndex = 3;
            this.btnErase.TabStop = false;
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnFill
            // 
            this.btnFill.BackgroundImage = global::Pictionary.Properties.Resources.fill;
            this.btnFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFill.Location = new System.Drawing.Point(80, 4);
            this.btnFill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(67, 62);
            this.btnFill.TabIndex = 2;
            this.btnFill.TabStop = false;
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnPen
            // 
            this.btnPen.BackgroundImage = global::Pictionary.Properties.Resources.brush;
            this.btnPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPen.Location = new System.Drawing.Point(5, 4);
            this.btnPen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(67, 62);
            this.btnPen.TabIndex = 1;
            this.btnPen.TabStop = false;
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // colorPicker
            // 
            this.colorPicker.BackColor = System.Drawing.Color.Black;
            this.colorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPicker.Location = new System.Drawing.Point(393, 5);
            this.colorPicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(67, 62);
            this.colorPicker.TabIndex = 0;
            this.colorPicker.TabStop = false;
            this.colorPicker.UseVisualStyleBackColor = false;
            this.colorPicker.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmsSize
            // 
            this.cmsSize.AutoSize = false;
            this.cmsSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmsSize.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSize.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.point1,
            this.point2,
            this.point3,
            this.point4});
            this.cmsSize.Name = "cmsSize";
            this.cmsSize.ShowImageMargin = false;
            this.cmsSize.Size = new System.Drawing.Size(100, 85);
            // 
            // point1
            // 
            this.point1.AutoSize = false;
            this.point1.BackColor = System.Drawing.Color.Transparent;
            this.point1.BackgroundImage = global::Pictionary.Properties.Resources.point1;
            this.point1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.point1.CheckOnClick = true;
            this.point1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point1.Name = "point1";
            this.point1.Size = new System.Drawing.Size(100, 20);
            this.point1.Click += new System.EventHandler(this.SizeClick);
            // 
            // point2
            // 
            this.point2.AutoSize = false;
            this.point2.BackColor = System.Drawing.Color.Transparent;
            this.point2.BackgroundImage = global::Pictionary.Properties.Resources.point2;
            this.point2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.point2.CheckOnClick = true;
            this.point2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point2.Name = "point2";
            this.point2.Size = new System.Drawing.Size(100, 20);
            this.point2.Click += new System.EventHandler(this.SizeClick);
            // 
            // point3
            // 
            this.point3.AutoSize = false;
            this.point3.BackColor = System.Drawing.Color.Transparent;
            this.point3.BackgroundImage = global::Pictionary.Properties.Resources.point3;
            this.point3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.point3.CheckOnClick = true;
            this.point3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point3.Name = "point3";
            this.point3.Size = new System.Drawing.Size(100, 20);
            this.point3.Click += new System.EventHandler(this.SizeClick);
            // 
            // point4
            // 
            this.point4.AutoSize = false;
            this.point4.BackColor = System.Drawing.Color.Transparent;
            this.point4.BackgroundImage = global::Pictionary.Properties.Resources.point4;
            this.point4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.point4.CheckOnClick = true;
            this.point4.Name = "point4";
            this.point4.Size = new System.Drawing.Size(100, 22);
            this.point4.Click += new System.EventHandler(this.SizeClick);
            // 
            // drawingBoard
            // 
            this.drawingBoard.Location = new System.Drawing.Point(291, 2);
            this.drawingBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drawingBoard.Name = "drawingBoard";
            this.drawingBoard.Size = new System.Drawing.Size(1325, 848);
            this.drawingBoard.TabIndex = 5;
            this.drawingBoard.TabStop = false;
            this.drawingBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingBoard_Paint);
            this.drawingBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseDown);
            this.drawingBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseMove);
            this.drawingBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingBoard_MouseUp);
            // 
            // chat
            // 
            this.chat.Location = new System.Drawing.Point(1624, 11);
            this.chat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chat.Multiline = true;
            this.chat.Name = "chat";
            this.chat.ReadOnly = true;
            this.chat.Size = new System.Drawing.Size(273, 882);
            this.chat.TabIndex = 9;
            this.chat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chat_KeyPress);
            // 
            // chooseWord
            // 
            this.chooseWord.BackColor = System.Drawing.SystemColors.Control;
            this.chooseWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chooseWord.Enabled = false;
            this.chooseWord.Location = new System.Drawing.Point(544, 137);
            this.chooseWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseWord.Name = "chooseWord";
            this.chooseWord.Size = new System.Drawing.Size(839, 270);
            this.chooseWord.TabIndex = 6;
            this.chooseWord.TabStop = false;
            this.chooseWord.Visible = false;
            this.chooseWord.NewWordChosen += new System.EventHandler(this.chooseWord_NewWordChosen);
            // 
            // playerList
            // 
            this.playerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerList.BackColor = System.Drawing.SystemColors.Control;
            this.playerList.Location = new System.Drawing.Point(8, 11);
            this.playerList.Margin = new System.Windows.Forms.Padding(5);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(281, 914);
            this.playerList.TabIndex = 4;
            this.playerList.TabStop = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1914, 924);
            this.Controls.Add(this.chat);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.input);
            this.Controls.Add(this.chooseWord);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.lblWaiting);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.drawingBoard);
            this.Controls.Add(this.countdown);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1994, 971);
            this.MinimumSize = new System.Drawing.Size(1917, 971);
            this.Name = "Client";
            this.Text = "Pictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            this.Enter += new System.EventHandler(this.Client_Enter);
            this.drawingPanel.ResumeLayout(false);
            this.cmsSize.ResumeLayout(false);
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
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Button colorPicker;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.ContextMenuStrip cmsSize;
        private System.Windows.Forms.ToolStripMenuItem point1;
        private System.Windows.Forms.ToolStripMenuItem point3;
        private System.Windows.Forms.ToolStripMenuItem point2;
        private System.Windows.Forms.ToolStripMenuItem point4;
        private System.Windows.Forms.TextBox chat;
    }
}
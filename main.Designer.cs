namespace Pictionary
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menu = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnJoinGame = new System.Windows.Forms.Button();
            this.btnHostGame = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.headerText = new System.Windows.Forms.Label();
            this.panelHostGame = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHost = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHostPort = new System.Windows.Forms.TextBox();
            this.panelJoinGame = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJoinIP = new System.Windows.Forms.TextBox();
            this.txtJoinPort = new System.Windows.Forms.TextBox();
            this.txtJoinName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.icon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.header.SuspendLayout();
            this.panelHostGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelJoinGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.menu.Controls.Add(this.btnQuit);
            this.menu.Controls.Add(this.btnSettings);
            this.menu.Controls.Add(this.btnJoinGame);
            this.menu.Controls.Add(this.btnHostGame);
            this.menu.Controls.Add(this.icon);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(200, 516);
            this.menu.TabIndex = 8;
            // 
            // btnQuit
            // 
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQuit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuit.Location = new System.Drawing.Point(0, 220);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnQuit.Size = new System.Drawing.Size(200, 55);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSettings.Location = new System.Drawing.Point(0, 165);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(200, 55);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnJoinGame
            // 
            this.btnJoinGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJoinGame.FlatAppearance.BorderSize = 0;
            this.btnJoinGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinGame.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnJoinGame.ForeColor = System.Drawing.SystemColors.Control;
            this.btnJoinGame.Location = new System.Drawing.Point(0, 110);
            this.btnJoinGame.Name = "btnJoinGame";
            this.btnJoinGame.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnJoinGame.Size = new System.Drawing.Size(200, 55);
            this.btnJoinGame.TabIndex = 2;
            this.btnJoinGame.Text = "Join game";
            this.btnJoinGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJoinGame.UseVisualStyleBackColor = true;
            this.btnJoinGame.Click += new System.EventHandler(this.btnJoinGame_Click);
            // 
            // btnHostGame
            // 
            this.btnHostGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHostGame.FlatAppearance.BorderSize = 0;
            this.btnHostGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHostGame.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHostGame.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHostGame.Location = new System.Drawing.Point(0, 55);
            this.btnHostGame.Name = "btnHostGame";
            this.btnHostGame.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHostGame.Size = new System.Drawing.Size(200, 55);
            this.btnHostGame.TabIndex = 1;
            this.btnHostGame.Text = "Host game";
            this.btnHostGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHostGame.UseVisualStyleBackColor = true;
            this.btnHostGame.Click += new System.EventHandler(this.btnHostGame_Click);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.icon.Controls.Add(this.pictureBox1);
            this.icon.Controls.Add(this.label6);
            this.icon.Dock = System.Windows.Forms.DockStyle.Top;
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
            // header
            // 
            this.header.BackColor = System.Drawing.Color.LightGray;
            this.header.Controls.Add(this.btnMinimize);
            this.header.Controls.Add(this.btnClose);
            this.header.Controls.Add(this.headerText);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(200, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(537, 55);
            this.header.TabIndex = 9;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::Pictionary.Properties.Resources.minimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(476, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(507, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnQuit_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // headerText
            // 
            this.headerText.BackColor = System.Drawing.Color.Transparent;
            this.headerText.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(0, 0);
            this.headerText.Name = "headerText";
            this.headerText.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.headerText.Size = new System.Drawing.Size(537, 55);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Home";
            this.headerText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.headerText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // panelHostGame
            // 
            this.panelHostGame.Controls.Add(this.label7);
            this.panelHostGame.Controls.Add(this.numericUpDown2);
            this.panelHostGame.Controls.Add(this.numericUpDown1);
            this.panelHostGame.Controls.Add(this.label5);
            this.panelHostGame.Controls.Add(this.btnHost);
            this.panelHostGame.Controls.Add(this.label8);
            this.panelHostGame.Controls.Add(this.txtHostName);
            this.panelHostGame.Controls.Add(this.label1);
            this.panelHostGame.Controls.Add(this.txtHostPort);
            this.panelHostGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHostGame.Enabled = false;
            this.panelHostGame.Location = new System.Drawing.Point(0, 0);
            this.panelHostGame.Name = "panelHostGame";
            this.panelHostGame.Size = new System.Drawing.Size(737, 516);
            this.panelHostGame.TabIndex = 32;
            this.panelHostGame.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(346, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 21);
            this.label7.TabIndex = 40;
            this.label7.Text = "Time per round (seconds)";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(350, 348);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown2.TabIndex = 39;
            this.numericUpDown2.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(350, 280);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown1.TabIndex = 38;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Total rounds";
            // 
            // btnHost
            // 
            this.btnHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnHost.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHost.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHost.Location = new System.Drawing.Point(403, 392);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(85, 33);
            this.btnHost.TabIndex = 36;
            this.btnHost.Text = "Host game";
            this.btnHost.UseVisualStyleBackColor = false;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(346, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "Name";
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(350, 148);
            this.txtHostName.MaxLength = 15;
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(200, 20);
            this.txtHostName.TabIndex = 32;
            this.txtHostName.Text = "skrrrr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Port number";
            // 
            // txtHostPort
            // 
            this.txtHostPort.Location = new System.Drawing.Point(349, 213);
            this.txtHostPort.MaxLength = 5;
            this.txtHostPort.Name = "txtHostPort";
            this.txtHostPort.Size = new System.Drawing.Size(200, 20);
            this.txtHostPort.TabIndex = 33;
            this.txtHostPort.Text = "25565";
            // 
            // panelJoinGame
            // 
            this.panelJoinGame.Controls.Add(this.button2);
            this.panelJoinGame.Controls.Add(this.label4);
            this.panelJoinGame.Controls.Add(this.txtJoinIP);
            this.panelJoinGame.Controls.Add(this.txtJoinPort);
            this.panelJoinGame.Controls.Add(this.txtJoinName);
            this.panelJoinGame.Controls.Add(this.label2);
            this.panelJoinGame.Controls.Add(this.label3);
            this.panelJoinGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelJoinGame.Enabled = false;
            this.panelJoinGame.Location = new System.Drawing.Point(0, 0);
            this.panelJoinGame.Name = "panelJoinGame";
            this.panelJoinGame.Size = new System.Drawing.Size(737, 516);
            this.panelJoinGame.TabIndex = 33;
            this.panelJoinGame.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(403, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 33);
            this.button2.TabIndex = 65;
            this.button2.Text = "Join game";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(346, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 64;
            this.label4.Text = "Name";
            // 
            // txtJoinIP
            // 
            this.txtJoinIP.Location = new System.Drawing.Point(350, 236);
            this.txtJoinIP.MaxLength = 15;
            this.txtJoinIP.Name = "txtJoinIP";
            this.txtJoinIP.Size = new System.Drawing.Size(200, 20);
            this.txtJoinIP.TabIndex = 60;
            this.txtJoinIP.Text = "94.254.64.5";
            // 
            // txtJoinPort
            // 
            this.txtJoinPort.Location = new System.Drawing.Point(350, 309);
            this.txtJoinPort.MaxLength = 5;
            this.txtJoinPort.Name = "txtJoinPort";
            this.txtJoinPort.Size = new System.Drawing.Size(200, 20);
            this.txtJoinPort.TabIndex = 61;
            this.txtJoinPort.Text = "25565";
            // 
            // txtJoinName
            // 
            this.txtJoinName.Location = new System.Drawing.Point(350, 165);
            this.txtJoinName.Name = "txtJoinName";
            this.txtJoinName.Size = new System.Drawing.Size(200, 20);
            this.txtJoinName.TabIndex = 59;
            this.txtJoinName.Text = "xdd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(346, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "IP address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(346, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 21);
            this.label3.TabIndex = 63;
            this.label3.Text = "Port";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 516);
            this.Controls.Add(this.header);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panelHostGame);
            this.Controls.Add(this.panelJoinGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(948, 662);
            this.Name = "main";
            this.Text = "Pictionary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.menu.ResumeLayout(false);
            this.icon.ResumeLayout(false);
            this.icon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.header.ResumeLayout(false);
            this.panelHostGame.ResumeLayout(false);
            this.panelHostGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelJoinGame.ResumeLayout(false);
            this.panelJoinGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.Button btnHostGame;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnJoinGame;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel icon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelHostGame;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHostPort;
        private System.Windows.Forms.Panel panelJoinGame;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJoinIP;
        private System.Windows.Forms.TextBox txtJoinPort;
        private System.Windows.Forms.TextBox txtJoinName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
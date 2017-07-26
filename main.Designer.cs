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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnJoinGame = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHostGame = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpJoinGame = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpHostGame = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHost = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnJoin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJoinName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpJoinGame.SuspendLayout();
            this.grpHostGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(39, 422);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(187, 33);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnJoinGame
            // 
            this.btnJoinGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinGame.Location = new System.Drawing.Point(39, 314);
            this.btnJoinGame.Name = "btnJoinGame";
            this.btnJoinGame.Size = new System.Drawing.Size(187, 33);
            this.btnJoinGame.TabIndex = 2;
            this.btnJoinGame.Text = "Join game";
            this.btnJoinGame.UseVisualStyleBackColor = true;
            this.btnJoinGame.Click += new System.EventHandler(this.btnJoinGame_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(32, 201);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(90, 37);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Menu";
            // 
            // btnHostGame
            // 
            this.btnHostGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHostGame.Location = new System.Drawing.Point(39, 260);
            this.btnHostGame.Name = "btnHostGame";
            this.btnHostGame.Size = new System.Drawing.Size(187, 33);
            this.btnHostGame.TabIndex = 0;
            this.btnHostGame.Text = "Host game";
            this.btnHostGame.UseVisualStyleBackColor = true;
            this.btnHostGame.Click += new System.EventHandler(this.btnHostGame_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHostGame);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.btnJoinGame);
            this.groupBox1.Controls.Add(this.btnQuit);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 599);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // grpJoinGame
            // 
            this.grpJoinGame.Controls.Add(this.label4);
            this.grpJoinGame.Controls.Add(this.txtJoinName);
            this.grpJoinGame.Controls.Add(this.btnJoin);
            this.grpJoinGame.Controls.Add(this.label3);
            this.grpJoinGame.Controls.Add(this.label2);
            this.grpJoinGame.Controls.Add(this.textBox2);
            this.grpJoinGame.Controls.Add(this.textBox1);
            this.grpJoinGame.Enabled = false;
            this.grpJoinGame.Location = new System.Drawing.Point(355, 30);
            this.grpJoinGame.Name = "grpJoinGame";
            this.grpJoinGame.Size = new System.Drawing.Size(507, 204);
            this.grpJoinGame.TabIndex = 6;
            this.grpJoinGame.TabStop = false;
            this.grpJoinGame.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(198, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port";
            // 
            // grpHostGame
            // 
            this.grpHostGame.Controls.Add(this.label8);
            this.grpHostGame.Controls.Add(this.txtHostName);
            this.grpHostGame.Controls.Add(this.numericUpDown1);
            this.grpHostGame.Controls.Add(this.btnHost);
            this.grpHostGame.Controls.Add(this.label7);
            this.grpHostGame.Controls.Add(this.label6);
            this.grpHostGame.Controls.Add(this.label5);
            this.grpHostGame.Controls.Add(this.textBox7);
            this.grpHostGame.Controls.Add(this.textBox5);
            this.grpHostGame.Controls.Add(this.label1);
            this.grpHostGame.Controls.Add(this.textBox3);
            this.grpHostGame.Enabled = false;
            this.grpHostGame.Location = new System.Drawing.Point(324, 264);
            this.grpHostGame.Name = "grpHostGame";
            this.grpHostGame.Size = new System.Drawing.Size(567, 347);
            this.grpHostGame.TabIndex = 7;
            this.grpHostGame.TabStop = false;
            this.grpHostGame.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(21, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Port number";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(21, 145);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(209, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(21, 199);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(209, 20);
            this.textBox7.TabIndex = 11;
            this.textBox7.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Room name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Maximum slots";
            // 
            // btnHost
            // 
            this.btnHost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHost.Location = new System.Drawing.Point(80, 306);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(101, 33);
            this.btnHost.TabIndex = 15;
            this.btnHost.Text = "Host";
            this.btnHost.UseVisualStyleBackColor = true;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(21, 255);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(209, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(21, 39);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(160, 20);
            this.txtHostName.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Name";
            // 
            // btnJoin
            // 
            this.btnJoin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.Location = new System.Drawing.Point(107, 136);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(101, 33);
            this.btnJoin.TabIndex = 16;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Name";
            // 
            // txtJoinName
            // 
            this.txtJoinName.Location = new System.Drawing.Point(341, 102);
            this.txtJoinName.Name = "txtJoinName";
            this.txtJoinName.Size = new System.Drawing.Size(160, 20);
            this.txtJoinName.TabIndex = 18;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 623);
            this.Controls.Add(this.grpHostGame);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpJoinGame);
            this.Name = "main";
            this.Text = "Pictionary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpJoinGame.ResumeLayout(false);
            this.grpJoinGame.PerformLayout();
            this.grpHostGame.ResumeLayout(false);
            this.grpHostGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnJoinGame;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHostGame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpJoinGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpHostGame;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnHost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJoinName;
        private System.Windows.Forms.Button btnJoin;
    }
}
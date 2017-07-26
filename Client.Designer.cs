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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playerList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chat = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playerList);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 678);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // playerList
            // 
            this.playerList.FormattingEnabled = true;
            this.playerList.Location = new System.Drawing.Point(6, 11);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(120, 238);
            this.playerList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chat);
            this.groupBox2.Controls.Add(this.input);
            this.groupBox2.Location = new System.Drawing.Point(1043, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 678);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // chat
            // 
            this.chat.Location = new System.Drawing.Point(4, 11);
            this.chat.Multiline = true;
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(211, 635);
            this.chat.TabIndex = 1;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(4, 652);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(215, 20);
            this.input.TabIndex = 0;
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Client";
            this.Text = "Pictionary";
            this.Load += new System.EventHandler(this.Client_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox chat;
        private System.Windows.Forms.ListBox playerList;
    }
}
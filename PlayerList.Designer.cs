namespace Pictionary
{
    partial class PlayerList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpPlayers
            // 
            this.flpPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPlayers.Location = new System.Drawing.Point(0, 0);
            this.flpPlayers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpPlayers.Name = "flpPlayers";
            this.flpPlayers.Size = new System.Drawing.Size(288, 775);
            this.flpPlayers.TabIndex = 0;
            // 
            // PlayerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpPlayers);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PlayerList";
            this.Size = new System.Drawing.Size(288, 775);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPlayers;
    }
}

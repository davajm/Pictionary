namespace Pictionary
{
    partial class ChooseWord
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
            this.word1 = new System.Windows.Forms.Button();
            this.word2 = new System.Windows.Forms.Button();
            this.word3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // word1
            // 
            this.word1.BackColor = System.Drawing.Color.Transparent;
            this.word1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.word1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.word1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.word1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.word1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.word1.ForeColor = System.Drawing.SystemColors.Control;
            this.word1.Location = new System.Drawing.Point(23, 82);
            this.word1.Margin = new System.Windows.Forms.Padding(2);
            this.word1.Name = "word1";
            this.word1.Size = new System.Drawing.Size(188, 49);
            this.word1.TabIndex = 0;
            this.word1.UseVisualStyleBackColor = false;
            this.word1.Click += new System.EventHandler(this.Word_Click);
            // 
            // word2
            // 
            this.word2.BackColor = System.Drawing.Color.Transparent;
            this.word2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.word2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.word2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.word2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.word2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.word2.ForeColor = System.Drawing.SystemColors.Control;
            this.word2.Location = new System.Drawing.Point(224, 82);
            this.word2.Margin = new System.Windows.Forms.Padding(2);
            this.word2.Name = "word2";
            this.word2.Size = new System.Drawing.Size(188, 49);
            this.word2.TabIndex = 1;
            this.word2.UseVisualStyleBackColor = false;
            this.word2.Click += new System.EventHandler(this.Word_Click);
            // 
            // word3
            // 
            this.word3.BackColor = System.Drawing.Color.Transparent;
            this.word3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.word3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.word3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.word3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.word3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.word3.ForeColor = System.Drawing.SystemColors.Control;
            this.word3.Location = new System.Drawing.Point(426, 82);
            this.word3.Margin = new System.Windows.Forms.Padding(2);
            this.word3.Name = "word3";
            this.word3.Size = new System.Drawing.Size(188, 49);
            this.word3.TabIndex = 2;
            this.word3.UseVisualStyleBackColor = false;
            this.word3.Click += new System.EventHandler(this.Word_Click);
            // 
            // ChooseWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.word3);
            this.Controls.Add(this.word2);
            this.Controls.Add(this.word1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChooseWord";
            this.Size = new System.Drawing.Size(628, 218);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button word1;
        private System.Windows.Forms.Button word2;
        private System.Windows.Forms.Button word3;
    }
}

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
            this.word1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word1.Location = new System.Drawing.Point(31, 101);
            this.word1.Name = "word1";
            this.word1.Size = new System.Drawing.Size(250, 60);
            this.word1.TabIndex = 0;
            this.word1.UseVisualStyleBackColor = true;
            this.word1.Click += new System.EventHandler(this.Word_Click);
            // 
            // word2
            // 
            this.word2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word2.Location = new System.Drawing.Point(298, 101);
            this.word2.Name = "word2";
            this.word2.Size = new System.Drawing.Size(250, 60);
            this.word2.TabIndex = 1;
            this.word2.UseVisualStyleBackColor = true;
            this.word2.Click += new System.EventHandler(this.Word_Click);
            // 
            // word3
            // 
            this.word3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word3.Location = new System.Drawing.Point(568, 101);
            this.word3.Name = "word3";
            this.word3.Size = new System.Drawing.Size(250, 60);
            this.word3.TabIndex = 2;
            this.word3.UseVisualStyleBackColor = true;
            this.word3.Click += new System.EventHandler(this.Word_Click);
            // 
            // ChooseWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.word3);
            this.Controls.Add(this.word2);
            this.Controls.Add(this.word1);
            this.Name = "ChooseWord";
            this.Size = new System.Drawing.Size(840, 271);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button word1;
        private System.Windows.Forms.Button word2;
        private System.Windows.Forms.Button word3;
    }
}

namespace Pictionary
{
    partial class Results
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
            this.mainTitle = new System.Windows.Forms.Label();
            this.subTitle = new System.Windows.Forms.Label();
            this.tlpScoreBoard = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.mainTitle.Location = new System.Drawing.Point(7, 9);
            this.mainTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(521, 39);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "Round\'s over, the word was:";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subTitle
            // 
            this.subTitle.BackColor = System.Drawing.Color.Transparent;
            this.subTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitle.ForeColor = System.Drawing.Color.Red;
            this.subTitle.Location = new System.Drawing.Point(2, 41);
            this.subTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subTitle.Name = "subTitle";
            this.subTitle.Size = new System.Drawing.Size(526, 42);
            this.subTitle.TabIndex = 1;
            this.subTitle.Text = "WORD";
            this.subTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpScoreBoard
            // 
            this.tlpScoreBoard.ColumnCount = 2;
            this.tlpScoreBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpScoreBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpScoreBoard.Location = new System.Drawing.Point(60, 101);
            this.tlpScoreBoard.Name = "tlpScoreBoard";
            this.tlpScoreBoard.RowCount = 1;
            this.tlpScoreBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpScoreBoard.Size = new System.Drawing.Size(418, 291);
            this.tlpScoreBoard.TabIndex = 2;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tlpScoreBoard);
            this.Controls.Add(this.subTitle);
            this.Controls.Add(this.mainTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Results";
            this.Size = new System.Drawing.Size(528, 437);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Label subTitle;
        private System.Windows.Forms.TableLayoutPanel tlpScoreBoard;
    }
}

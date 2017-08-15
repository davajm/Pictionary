namespace Pictionary
{
    partial class DrawingBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingBoard));
            this.board = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            this.drawingPanel.SuspendLayout();
            this.cmsSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.board.Location = new System.Drawing.Point(0, 0);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(485, 266);
            this.board.TabIndex = 0;
            this.board.TabStop = false;
            // 
            // drawingPanel
            // 
            this.drawingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingPanel.Controls.Add(this.btnSize);
            this.drawingPanel.Controls.Add(this.btnErase);
            this.drawingPanel.Controls.Add(this.btnFill);
            this.drawingPanel.Controls.Add(this.btnPen);
            this.drawingPanel.Controls.Add(this.colorPicker);
            this.drawingPanel.Enabled = false;
            this.drawingPanel.Location = new System.Drawing.Point(0, 268);
            this.drawingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(485, 77);
            this.drawingPanel.TabIndex = 9;
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
            this.btnSize.Margin = new System.Windows.Forms.Padding(4);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(67, 62);
            this.btnSize.TabIndex = 4;
            this.btnSize.TabStop = false;
            this.btnSize.Text = "Size";
            this.btnSize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSize.UseVisualStyleBackColor = false;
            // 
            // btnErase
            // 
            this.btnErase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnErase.BackgroundImage")));
            this.btnErase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErase.Location = new System.Drawing.Point(155, 4);
            this.btnErase.Margin = new System.Windows.Forms.Padding(4);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(67, 62);
            this.btnErase.TabIndex = 3;
            this.btnErase.TabStop = false;
            this.btnErase.UseVisualStyleBackColor = true;
            // 
            // btnFill
            // 
            this.btnFill.BackgroundImage = global::Pictionary.Properties.Resources.fill;
            this.btnFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFill.Location = new System.Drawing.Point(80, 4);
            this.btnFill.Margin = new System.Windows.Forms.Padding(4);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(67, 62);
            this.btnFill.TabIndex = 2;
            this.btnFill.TabStop = false;
            this.btnFill.UseVisualStyleBackColor = true;
            // 
            // btnPen
            // 
            this.btnPen.BackgroundImage = global::Pictionary.Properties.Resources.brush;
            this.btnPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPen.Location = new System.Drawing.Point(5, 4);
            this.btnPen.Margin = new System.Windows.Forms.Padding(4);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(67, 62);
            this.btnPen.TabIndex = 1;
            this.btnPen.TabStop = false;
            this.btnPen.UseVisualStyleBackColor = true;
            // 
            // colorPicker
            // 
            this.colorPicker.BackColor = System.Drawing.Color.Black;
            this.colorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPicker.Location = new System.Drawing.Point(393, 5);
            this.colorPicker.Margin = new System.Windows.Forms.Padding(4);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(67, 62);
            this.colorPicker.TabIndex = 0;
            this.colorPicker.TabStop = false;
            this.colorPicker.UseVisualStyleBackColor = false;
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
            // 
            // DrawingBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.board);
            this.Name = "DrawingBoard";
            this.Size = new System.Drawing.Size(485, 345);
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            this.drawingPanel.ResumeLayout(false);
            this.cmsSize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox board;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Button colorPicker;
        private System.Windows.Forms.ContextMenuStrip cmsSize;
        private System.Windows.Forms.ToolStripMenuItem point1;
        private System.Windows.Forms.ToolStripMenuItem point2;
        private System.Windows.Forms.ToolStripMenuItem point3;
        private System.Windows.Forms.ToolStripMenuItem point4;
    }
}

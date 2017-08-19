using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Pictionary
{
    public partial class DrawingBoard : UserControl
    {
        /* Bitmap */
        Bitmap bmp;

        /* Pen stuff */
        Pen pen;
        int size;
        Color color;
        bool erase;

        Point currPoint;

        public event EventHandler ButtonClearClick;

        public DrawingBoard()
        {
            DoubleBuffered = true;
            bmp = new Bitmap(1920, 1080);
            InitializeComponent();
            pen = new Pen(Color.Black);
            size = 3;
            color = Color.Black;
            btnPen_Click(this, new EventArgs());
        }
        // When user starts drawing
        public void StartDrawing()
        {
            drawingPanel.Enabled = drawingPanel.Visible = true;
            color = Color.Black;
            colorPicker.BackColor = color;
        }

        // When user is finished
        public void StopDrawing()
        {
            drawingPanel.Enabled = drawingPanel.Visible = false;
        }

        // Create a new stroke
        public void NewStroke(Point point, int size, Color color)
        {
            this.size = size;
            this.color = color;
            colorPicker.BackColor = color;
            NewStroke(point);
        }

        // Create a new stroke
        public void NewStroke(Point point)
        {
            if (erase)
                color = this.BackColor;
            Graphics.FromImage(bmp).FillEllipse(new SolidBrush(color), point.X - (size/2), point.Y - (size/2), size, size);
            currPoint = point;
            Invalidate();
        }

        // Add a point to current stroke
        public void AddPointToStroke(Point point)
        {
            pen.DashStyle = DashStyle.Solid;
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            pen.Color = color;
            pen.Width = size;
            Graphics.FromImage(bmp).DrawLine(pen, currPoint, point);
            currPoint = point;
            Invalidate();
        }

        // Clear board
        public void Clear()
        {
            bmp = new Bitmap(1000, 800);
            Invalidate();
        }

        // Color picker to change color of pen
        private void colorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            DialogResult result = cd.ShowDialog();
            if (result == DialogResult.OK)
            {
                colorPicker.BackColor = cd.Color;
                color = cd.Color;
            }
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            btnPen.FlatAppearance.BorderColor = Color.Blue;
            btnPen.FlatAppearance.BorderSize = 2;
            btnFill.FlatAppearance.BorderColor = Color.Black;
            btnFill.FlatAppearance.BorderSize = 1;
            btnErase.FlatAppearance.BorderColor = Color.Black;
            btnErase.FlatAppearance.BorderSize = 1;
            erase = false;
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fill not yet implemented :(", "Error");
            //btnPen.FlatAppearance.BorderColor = Color.Black;
            //btnPen.FlatAppearance.BorderSize = 1;
            //btnFill.FlatAppearance.BorderColor = Color.Blue;
            //btnFill.FlatAppearance.BorderSize = 2;
            //btnErase.FlatAppearance.BorderColor = Color.Black;
            //btnErase.FlatAppearance.BorderSize = 1;
            //erase = false;
            //fill = true;
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            btnPen.FlatAppearance.BorderColor = Color.Black;
            btnPen.FlatAppearance.BorderSize = 1;
            btnFill.FlatAppearance.BorderColor = Color.Black;
            btnFill.FlatAppearance.BorderSize = 1;
            btnErase.FlatAppearance.BorderColor = Color.Blue;
            btnErase.FlatAppearance.BorderSize = 2;
            erase = true;
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            cmsSize.Show(btnSize, new Point(-(cmsSize.Width - btnSize.Width) / 2, -cmsSize.Height));
        }

        // Draw function
        private void Draw(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        // Get pen size
        public int GetPenSize()
        {
            return size;
        }

        // Get pen color
        public Color GetPenColor()
        {
            if (erase)
                return this.BackColor;
            return color;
        }

        // Change size of pen
        private void ChangeSize(object sender, EventArgs e)
        {
            ToolStripMenuItem senderItem = (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem item in cmsSize.Items)
            {
                if (item == senderItem)
                    item.BackColor = SystemColors.GradientActiveCaption;
                else
                    item.BackColor = Color.Transparent;
            }
            int indexOfItem = cmsSize.Items.IndexOf(senderItem);
            switch (indexOfItem)
            {
                case 0:
                    size = 3;
                    break;
                case 1:
                    size = 5;
                    break;
                case 2:
                    size = 9;
                    break;
                case 3:
                    size = 15;
                    break;
            }
        }

        // Custom event for button clear click.
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (ButtonClearClick != null)
            {
                ButtonClearClick(this, e);
            }
        }
    }
}

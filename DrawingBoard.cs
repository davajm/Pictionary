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
        struct Stroke
        {
            public List<Point> points;
            public int size;    
            public Color color;
        }

        Stroke currentStroke;
        List<Stroke> allStrokes;

        int size;
        Color color;
        bool erase;

        Pen pen;

        public event EventHandler ButtonClearClick;

        public DrawingBoard()
        {
            DoubleBuffered = true;
            InitializeComponent();
            allStrokes = new List<Stroke>();
            pen = new Pen(Color.Black);
            size = 3;
            color = Color.Black;
        }
        public void StartDrawing()
        {
            drawingPanel.Enabled = drawingPanel.Visible = true;
            color = Color.Black;
            colorPicker.BackColor = color;
        }

        public void StopDrawing()
        {
            drawingPanel.Enabled = drawingPanel.Visible = false;
        }

        public void NewStroke(Point point, int size, Color color)
        {
            this.size = size;
            this.color = color;
            colorPicker.BackColor = color;
            NewStroke(point);
        }
        public void NewStroke(Point point)
        {
            currentStroke = new Stroke();
            currentStroke.points = new List<Point>();
            currentStroke.points.Add(point);
            currentStroke.size = size;
            if (erase)
                currentStroke.color = this.BackColor;
            else
                currentStroke.color = color;
            allStrokes.Add(currentStroke);
            Invalidate();
        }
        public void AddPointToStroke(Point point)
        {
            currentStroke.points.Add(point);
            Invalidate();
        }
        public void Clear()
        {
            if (currentStroke.points != null)
                currentStroke.points.Clear();
            if (allStrokes != null)
                allStrokes.Clear();
            Invalidate();
        }

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

        private void Draw(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            foreach (Stroke stroke in allStrokes)
            {
                pen.DashStyle = DashStyle.Solid;
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                pen.Color = stroke.color;
                pen.Width = stroke.size;

                int count = stroke.points.Count;
                if (count == 1)
                {
                    e.Graphics.FillEllipse(new SolidBrush(stroke.color), stroke.points[0].X-(stroke.size/2), 
                                           stroke.points[0].Y-(stroke.size/2), stroke.size, stroke.size);
                }
                for (int i = 1; i < count; i++)
                {
                    e.Graphics.DrawLine(pen, stroke.points[i - 1], stroke.points[i]);
                }

            }
        }

        public int GetPenSize()
        {
            return size;
        }

        public Color GetPenColor()
        {
            if (erase)
                return this.BackColor;
            return color;
        }

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (ButtonClearClick != null)
            {
                ButtonClearClick(this, e);
            }
        }
    }
}

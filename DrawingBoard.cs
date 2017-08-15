using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public DrawingBoard()
        {
            DoubleBuffered = true;
            InitializeComponent();
            allStrokes = new List<Stroke>();
            pen = new Pen(Color.Black);
            size = 1;
            color = Color.Black;
        }
        public void StartDrawing()
        {
            drawingPanel.Enabled = drawingPanel.Visible = true;
            color = Color.Black;
            colorPicker.BackColor = color;
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
            btnPen.FlatAppearance.BorderColor = Color.Black;
            btnPen.FlatAppearance.BorderSize = 1;
            btnFill.FlatAppearance.BorderColor = Color.Blue;
            btnFill.FlatAppearance.BorderSize = 2;
            btnErase.FlatAppearance.BorderColor = Color.Black;
            btnErase.FlatAppearance.BorderSize = 1;
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
            foreach (Stroke stroke in allStrokes.Where(x => x.points.Count > 1))
            {
                pen.Width = stroke.size;
                pen.Color = stroke.color;
                e.Graphics.DrawLines(pen, stroke.points.ToArray());
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
                    size = 1;
                    break;
                case 1:
                    size = 3;
                    break;
                case 2:
                    size = 5;
                    break;
                case 3:
                    size = 8;
                    break;
            }
        }
    }
}

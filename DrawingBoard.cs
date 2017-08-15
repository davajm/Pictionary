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

        Graphics g;
        Stroke currentStroke;
        List<Stroke> allStrokes;

        int size;
        Color color;
        bool isDrawing;

        public DrawingBoard()
        {
            InitializeComponent();
            allStrokes = new List<Stroke>();
            g = board.CreateGraphics();
            isDrawing = true;
        }
        public void StartDrawing()
        {
            isDrawing = true;
            drawingPanel.Enabled = drawingPanel.Visible = true;
        }

        public void NewStroke(Point point, int size, Color color)
        {
            this.size = size;
            this.color = color;
            NewStroke(point);
        }
        public void NewStroke(Point point)
        {
            currentStroke = new Stroke();
            currentStroke.points = new List<Point>();
            currentStroke.points.Add(point);
            currentStroke.size = size;
            currentStroke.color = color;
            allStrokes.Add(currentStroke);
            board.Invalidate();
        }
        public void AddPointToStroke(Point point)
        {
            currentStroke.points.Add(point);
            board.Invalidate();
        }
        public void Clear()
        {
            currentStroke.points.Clear();
            allStrokes.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
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
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            cmsSize.Show(btnSize, new Point(-(cmsSize.Width - btnSize.Width) / 2, -cmsSize.Height));
        }

    }
}

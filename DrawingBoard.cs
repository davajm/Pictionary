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
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Pictionary
{
    public partial class DrawingBoard : UserControl
    {
        /* Bitmap */
        Bitmap bmp;
        Bitmap cursor;

        /* Pen stuff */
        Pen pen;
        int size;
        Color color;
        bool erase, fill;

        Point currPoint;
        bool isDrawing;

        public event EventHandler ButtonClearClick;

        public DrawingBoard()
        {
            DoubleBuffered = true;
            bmp = new Bitmap(1920, 1080);
            cursor = new Bitmap(61, 61);
            InitializeComponent();
            pen = new Pen(Color.Black);
            size = 3;
            color = Color.Black;
            btnPen_Click(this, new EventArgs());
            isDrawing = false;
            fill = erase = false;
        }
        // When user starts drawing
        public void StartDrawing()
        {
            drawingPanel.Enabled = drawingPanel.Visible = isDrawing = true;
            placeholder.Enabled = placeholder.Visible = false;
            color = Color.Black;
            colorPicker.BackColor = color;
        }

        // When user is finished
        public void StopDrawing()
        {
            placeholder.Enabled = placeholder.Visible = true;
            drawingPanel.Enabled = drawingPanel.Visible = isDrawing = false;
        }

        // Create a new stroke
        public void NewStroke(Point point, int size, Color color)
        {
            if (size == 0)
            {
                fill = true;
                erase = false;
            }
            else
            {
                fill = false;
            }
            this.size = size;
            this.color = color;
            colorPicker.BackColor = color;
            NewStroke(point);
        }

        // Create a new stroke
        public void NewStroke(Point point)
        {
            if (fill)
            {
                FloodFill(point.X, point.Y, color);
            }
            else
            {
                Graphics.FromImage(bmp).FillEllipse(new SolidBrush(color), point.X - (size / 2), point.Y - (size / 2), size, size);
                currPoint = point;
            }
            Invalidate();
        }

        // Add a point to current stroke
        public void AddPointToStroke(Point point)
        {
            if (!fill)
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
                if (erase)
                    btnPen_Click(this, new EventArgs());
                colorPicker.BackColor = cd.Color;
                color = cd.Color;
            }
            ChangeCursor();
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            btnPen.FlatAppearance.BorderColor = Color.Blue;
            btnPen.FlatAppearance.BorderSize = 2;
            btnFill.FlatAppearance.BorderColor = Color.Black;
            btnFill.FlatAppearance.BorderSize = 1;
            btnErase.FlatAppearance.BorderColor = Color.Black;
            btnErase.FlatAppearance.BorderSize = 1;
            erase = fill = false;
            color = colorPicker.BackColor;
            ChangeCursor();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            btnPen.FlatAppearance.BorderColor = Color.Black;
            btnPen.FlatAppearance.BorderSize = 1;
            btnFill.FlatAppearance.BorderColor = Color.Blue;
            btnFill.FlatAppearance.BorderSize = 2;
            btnErase.FlatAppearance.BorderColor = Color.Black;
            btnErase.FlatAppearance.BorderSize = 1;
            erase = false;
            fill = true;
            color = colorPicker.BackColor;
            ChangeCursor();
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
            fill = false;
            color = BackColor;
            ChangeCursor();
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
            if (fill)
                return 0;
            else
                return size;
        }

        // Get pen color
        public Color GetPenColor()
        {
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
            ChangeCursor();
        }

        private void ChangeCursor()
        {
            Bitmap c = new Bitmap(60, 60);
            using (Graphics graphics = Graphics.FromImage(c))
            {
                if (erase)
                {
                    graphics.DrawEllipse(new Pen(Color.Black), c.Width / 2 - size / 2 - 1, cursor.Height / 2 - size / 2 - 1, size + 2, size + 2);
                    graphics.FillEllipse(new SolidBrush(color), c.Width / 2 - size / 2, cursor.Height / 2 - size / 2, size, size);
                }
                else if (fill)
                {
                    c = new Bitmap(Properties.Resources.paintCursor.ToBitmap());
                }
                else
                {
                    graphics.DrawEllipse(new Pen(Color.White), c.Width / 2 - size / 2-1, cursor.Height / 2 - size / 2-1, size+2, size+2);
                    graphics.FillEllipse(new SolidBrush(color), c.Width / 2 - size / 2, cursor.Height / 2 - size / 2, size, size);
                }
            }
            Cursor = new Cursor(c.GetHicon());
        }

        // Custom event for button clear click.
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (ButtonClearClick != null)
            {
                ButtonClearClick(this, e);
            }
        }

        private void HideCursor(object sender, EventArgs e)
        {
            if (isDrawing)
                ChangeCursor();
        }
        private void ShowCursor(object sender, EventArgs e)
        {
            if (isDrawing)
                Cursor = Cursors.Default;
        }
        void FloodFill(int x, int y, Color color)
        {
            BitmapData data = bmp.LockBits(
                new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            int[] bits = new int[data.Stride / 4 * data.Height];
            Marshal.Copy(data.Scan0, bits, 0, bits.Length);

            LinkedList<Point> check = new LinkedList<Point>();
            int floodTo = color.ToArgb();
            int floodFrom = bits[x + y * data.Stride / 4];
            bits[x + y * data.Stride / 4] = floodTo;

            if (floodFrom != floodTo)
            {
                check.AddLast(new Point(x, y));
                while (check.Count > 0)
                {
                    Point cur = check.First.Value;
                    check.RemoveFirst();

                    foreach (Point off in new Point[] {
                new Point(0, -1), new Point(0, 1),
                new Point(-1, 0), new Point(1, 0)})
                    {
                        Point next = new Point(cur.X + off.X, cur.Y + off.Y);
                        if (next.X >= 0 && next.Y >= 0 &&
                            next.X < data.Width &&
                            next.Y < data.Height)
                        {
                            if (bits[next.X + next.Y * data.Stride / 4] == floodFrom)
                            {
                                check.AddLast(next);
                                bits[next.X + next.Y * data.Stride / 4] = floodTo;
                            }
                        }
                    }
                }
            }

            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
            bmp.UnlockBits(data);
        }
    }
}

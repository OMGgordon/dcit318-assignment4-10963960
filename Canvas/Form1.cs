using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class DrawingForm : Form
    {
        private bool isDrawing = false;
        private Point previousPoint;

        public DrawingForm()
        {
            InitializeComponent();
        }

        private void DrawingForm_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = e.Location;
        }

        private void DrawingForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = CreateGraphics())
                {
                    g.DrawLine(Pens.Black, previousPoint, e.Location);
                }
                previousPoint = e.Location;
            }
        }

        private void DrawingForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
    }
}

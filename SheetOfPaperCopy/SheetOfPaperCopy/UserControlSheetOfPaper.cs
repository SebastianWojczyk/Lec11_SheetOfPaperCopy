using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheetOfPaperCopy
{
    public partial class UserControlSheetOfPaper : UserControl
    {
        Graphics g;
        Point tmp;
        Pen pen = new Pen(Color.Black, 2);

        public delegate void delegateLine(Object sender, Pen pen, Point start, Point stop);
        public event delegateLine drawLine;

        public UserControlSheetOfPaper()
        {
            InitializeComponent();

        }

        private void pictureBoxSheet_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tmp = e.Location;
            }
        }

        private void pictureBoxSheet_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pen.Color = this.ForeColor;
                g.DrawLine(pen, tmp, e.Location);
                if (drawLine != null)
                {
                    drawLine(this, pen, tmp, e.Location);
                }

                tmp = e.Location;
                pictureBoxSheet.Refresh();
            }
        }

        public void OutsideDrawLine(Pen pen, Point start, Point stop)
        {
            g.DrawLine(pen, start, stop);
            pictureBoxSheet.Refresh();
        }
        private void pictureBoxSheet_SizeChanged(object sender, EventArgs e)
        {
            pictureBoxSheet.Image = new Bitmap(pictureBoxSheet.Width, pictureBoxSheet.Height);
            g = Graphics.FromImage(pictureBoxSheet.Image);
            g.Clear(Color.White);
        }
    }
}

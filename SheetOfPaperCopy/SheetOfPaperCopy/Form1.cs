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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            paper1.ForeColor = Color.Red;
            paper2.ForeColor = Color.Green;
            paper3.ForeColor = Color.Blue;
            paper4.ForeColor = Color.Magenta;
        }

        private void userControlSheetOfPaper_drawLine(Object sender, Pen pen, Point start, Point stop)
        {
            if(sender is UserControlSheetOfPaper)
            {
                UserControlSheetOfPaper paper = sender as UserControlSheetOfPaper;
                richTextBox1.AppendText($"{paper.Name}(color={pen.Color}, start={start}, stop={stop}\n");
                richTextBox1.ScrollToCaret();

                //draw on each UserControlSheetOfPaper
                foreach (Object u in this.Controls)
                {
                    if(u is UserControlSheetOfPaper)
                    {
                        (u as UserControlSheetOfPaper).OutsideDrawLine(pen, start, stop);
                    }
                }
            }
            
        }
    }
}

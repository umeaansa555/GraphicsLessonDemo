using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLessonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen redPen = new Pen(Color.Red);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Pen greenPen = new Pen(Color.Green);
            //clear canvas
            g.Clear(Color.White);

            g.DrawLine(redPen, 0, 0, 200, 200);
            g.DrawLine(redPen, 0, 200, 200, 0);

            g.DrawRectangle(redPen, 30,30, 100, 200);
            
            g.FillRectangle(blackBrush, 30, 30, 100, 200);

            g.DrawEllipse(redPen, 25, 25, 200, 100);

            g.DrawArc(redPen, 250, 20, 50, 50, 60, 80);

            g.DrawPie(redPen, 250, 20, 50, 50, 60, 60);
            g.DrawPie(greenPen, 250, 20, 50, 50, 90, 60);


        }
    }
}

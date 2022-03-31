using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen;
            myPen = new Pen(System.Drawing.Color.Black);
            Graphics formGraphics = e.Graphics;
            formGraphics.Clear(Color.Turquoise);
            SolidBrush myCorp = new SolidBrush(Color.Brown);
            SolidBrush myCorp1 = new SolidBrush(Color.White);
            SolidBrush solidBrush7 = new SolidBrush(Color.White);
            Region region1 = new Region(new Rectangle(0, 300, 900, 300));
            SolidBrush solidBrush1 = new SolidBrush(Color.Green);
            formGraphics.FillRegion(solidBrush1, region1);

            SolidBrush solidBrush3 = new SolidBrush(Color.Yellow);      //солнце
            formGraphics.FillEllipse(solidBrush3, 600, 50, 70, 70);

            formGraphics.FillRectangle(myCorp, 50, 250, 200, 150);
            formGraphics.FillRectangle(myCorp, 250, 250, 200, 150);

            SolidBrush solidBrush8 = new SolidBrush(Color.Black);
            Pen pen1 = new Pen(solidBrush8);
            formGraphics.DrawBezier(pen1, 450.0F, 60.0F, 457.0F, 50.0F, 468.0F, 50.0F, 475.0F, 60.0F);
            formGraphics.DrawBezier(pen1, 475.0F, 60.0F, 482.0F, 50.0F, 493.0F, 50.0F, 500.0F, 60.0F);
            formGraphics.DrawBezier(pen1, 500.0F, 80.0F, 507.0F, 70.0F, 518.0F, 70.0F, 525.0F, 80.0F);
            formGraphics.DrawBezier(pen1, 525.0F, 80.0F, 532.0F, 70.0F, 543.0F, 70.0F, 550.0F, 80.0F);


            Point point1 = new Point(150, 150);                         //заливка крыши
            Point point2 = new Point(50, 250);
            Point point3 = new Point(250, 250);
            Point point5 = new Point(350, 150);
            Point point6 = new Point(450, 250);
            Point[] points = { point1, point2, point3, point6, point5 };
            formGraphics.FillPolygon(myCorp1, points);

            formGraphics.DrawLine(myPen, 150, 150, 50, 250);        //дом
            formGraphics.DrawLine(myPen, 150, 150, 250, 250);
            formGraphics.DrawLine(myPen, 50, 250, 250, 250);
            formGraphics.DrawLine(myPen, 150, 150, 350, 150);
            formGraphics.DrawLine(myPen, 250, 250, 450, 250);
            formGraphics.DrawLine(myPen, 350, 150, 450, 250);
            formGraphics.DrawLine(myPen, 50, 250, 50, 400);
            formGraphics.DrawLine(myPen, 250, 250, 250, 400);
            formGraphics.DrawLine(myPen, 50, 400, 250, 400);
            formGraphics.DrawLine(myPen, 250, 400, 450, 400);
            formGraphics.DrawLine(myPen, 450, 250, 450, 400);

            SolidBrush brush = new SolidBrush(Color.Yellow);  //окно
            formGraphics.FillRectangle(brush, 320, 280, 60, 60);
            Pen pen = new Pen(Color.Black, 2);
            formGraphics.DrawRectangle(pen, 320, 280, 60, 60);
            formGraphics.DrawLine(pen, 320, 310, 380, 310);
            formGraphics.DrawLine(pen, 350, 280, 350, 340);

            formGraphics.FillEllipse(solidBrush7, 500, 100, 55, 20);    //маленькие облака
            formGraphics.FillEllipse(solidBrush7, 520, 110, 55, 20);
            formGraphics.FillEllipse(solidBrush7, 470, 110, 65, 20);

            formGraphics.FillEllipse(solidBrush7, 150, 50, 150, 50);        // овальное облако


            myPen.Dispose();
            formGraphics.Dispose();
        }

    }
}

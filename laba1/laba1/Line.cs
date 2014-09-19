using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace laba1
{
    class Line:Figure
    {
        int x1, x2, y1, y2;
        public Line(int x, int y, int a, int b)
        {
            x1 = x;
            y1 = y;
            x2 = a;
            y2 = b;
        }
        public override void draw(Graphics gr)
        {
            Pen p = new Pen(Color.Red, 5);// цвет линии и ширина
            Point p1 = new Point(x1, y1);// первая точка
            Point p2 = new Point(x2, y2);// вторая точка
            gr.DrawLine(p, p1, p2);// рисуем линию
        }
    }
}

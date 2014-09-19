using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace laba1
{
    class rectangle:Figure
    {
        int x1, y1, x2, y2;
        public rectangle(int x,int y,int a,int b)
        {
            x1 = x;
            y1 = y;
            x2 = a;
            y2 = b;
        }
        public override  void draw(Graphics gr)
        {
            gr.DrawRectangle(Pens.Purple, x1, y1, x2, y2);

        }
    }
}

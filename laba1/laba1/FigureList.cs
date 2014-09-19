using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba1
{
    static class FigureList
    {
        static List<Figure>rol = new List<Figure>();
        public static void add(Figure fig)
        {
            rol.Add(fig);
            
        }
        public static void draw(Graphics gr)
        {
            foreach (var xui in rol)
            {
                xui.draw(gr);
            }
        }
    }
}

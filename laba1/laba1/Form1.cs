using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    public partial class Form1 : Form
    {
        Graphics gr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FigureList.add(new ellipse(400,105,150,70));
            FigureList.add(new Line(90, 90, 190, 190));
            FigureList.add(new rectangle(250,90,100,100));
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gr = this.CreateGraphics();
            FigureList.draw(gr);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
           
        }

        private void Form1_Enter(object sender, EventArgs e)
        {

        }
    }
}

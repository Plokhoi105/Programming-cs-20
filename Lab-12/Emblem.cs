using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr11
{
    class Emblem:Figure
    {
        //const int DefaultRadius = 50;
        private Graphics g;
        private int _radius;

        public int Radius { get { return _radius; } set { _radius = value >= 200 ? 200 : value; _radius = value <= 5 ? 5 : value; } }
        public Emblem(Graphics graphics, int X, int Y, int Radius)
        {
            this.g = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
        }
        protected override void Draw(Pen pen)
        {
            Rectangle rectangle = new Rectangle(X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            PointF [] rectangle1 = new PointF[]
            {
                new PointF(X-Radius+Radius*2, Y),
                new PointF(X + Radius+Radius*2, Y - Radius),
                new PointF(X + Radius+Radius*2, Y+Radius)
            };
            
            Rectangle rectangle2 = new Rectangle(X - Radius + Radius * 4, Y - Radius, 2 * Radius, 2 * Radius);
            g.DrawEllipse(pen, rectangle);
            g.DrawPolygon(pen, rectangle1);
            g.DrawRectangle(pen, rectangle2);
        }
        override public void Expand(int dR)
        {
            Hide();
            Radius = Radius + dR;
            Show();
        }
        override public void Collapse(int dR)
        {
            Hide();
            Radius = Radius - dR;
            Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr11
{
    class Emblem
    {
        const int DefaultRadius = 50;
        private Graphics g;
        private int _radius;
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get { return _radius; } set { _radius = value >= 200 ? 200 : value; _radius = value <= 5 ? 5 : value; } }
        public Emblem(Graphics graphics, int X, int Y)
        {
            this.g = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = DefaultRadius;
        }
        public Emblem(Graphics graphics, int X, int Y, int Radius)
        {
            this.g = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
        }
        private void Draw(Pen pen)
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
        public void Show()
        {
            Draw(Pens.Red);
        }
        public void Hide()
        {
            Draw(Pens.White);

        }
        public void Expand()
        {
            Hide();
            Radius++;
            Show();
        }
        public void Expand(int dR)
        {
            Hide();
            Radius = Radius + dR;
            Show();
        }
        public void Collapse()
        {
            Hide();
            Radius--;
            Show();
        }
        public void Collapse(int dR)
        {
            Hide();
            Radius = Radius - dR;
            Show();
        }
        public void Move(int dX, int dY)
        {
            Hide();
            X = X + dX;
            Y = Y + dY;
            Show();
        }
    }
}

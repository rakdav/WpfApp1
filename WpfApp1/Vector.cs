using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Vector
    {
        private MyPoint p1, p2;

        public Vector(MyPoint v1, MyPoint v2)
        {
            this.p1 = v1;
            this.p2 = v2;
        }
        public double Length()
        {
            return Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
        }

        public static Vector operator +(Vector v1,Vector v2)
        {
            MyPoint x = new MyPoint(v1.p1.X+v2.p2.X, v1.p1.Y+v2.p2.Y);
            MyPoint y = new MyPoint(v1.p1.X + v2.p2.Y, v1.p1.X + v2.p1.Y);
            return new Vector(x,y);
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            MyPoint x = new MyPoint(v1.p1.X - v2.p2.X, v1.p1.Y - v2.p2.Y);
            MyPoint y = new MyPoint(v1.p1.X - v2.p2.Y, v1.p1.X - v2.p1.Y);
            return new Vector(x, y);
        }

    }
}

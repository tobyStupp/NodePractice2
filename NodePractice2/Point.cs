using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodePractice2
{
    class Point
    {
        private double x;
        private double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double GetX() => x;
        public double GetY() => y;
        public bool Equals(Point p)
        {
            return this.x == p.x && this.y == p.y;
        }
        public double Distance(Point p)
        {
            double x1 = this.x - p.x;
            double y1 = this.y - p.y;
            return Math.Sqrt(x * x + y * y);
        }
        public override string ToString() => $"({x},{y})";
}



    
}

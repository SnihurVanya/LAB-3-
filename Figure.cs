using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Figure
    {
        private Point[] points;
        private string cap;
        private double perimeter;
        public string cap { get { return title; } }
        public double Perimeter
        {
            get
            {
                return perimeter;
            }
        }
        public Figure(string cap, Point p1, Point p2, Point p3)
        {
            this.title = cap;
            this.points = new Point[3];
            this.points[0] = p1;
            this.points[1] = p2;
            this.points[2] = p3;
            CalculatePerimeter();
        }
        public Figure(string cap, Point p1, Point p2, Point p3, Point p4)
        {
            this.cap = cap;
            this.points = new Point[4];
            this.points[0] = p1;
            this.points[1] = p2;
            this.points[2] = p3;
            this.points[3] = p4;
            CalculatePerimeter();
        }
        public Figure(string cap, Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            this.cap = cap;
            this.points = new Point[5];
            this.points[0] = p1;
            this.points[1] = p2;
            this.points[2] = p3;
            this.points[3] = p4;
            this.points[4] = p5;
            CalculatePerimeter();
        }
        private double GetSideLength(Point A, Point B)
        {
            double dx2 = (B.X - A.X) * (B.X - A.X);
            double dy2 = (B.Y - A.Y) * (B.Y - A.Y);
            double length = Math.Sqrt(dx2 + dy2);
            return length;
        }

        private void CalculatePerimeter()
        {
            Point a, b;
            double l;
            this.perimeter = 0;
            for (int i = 0; i < this.points.Length - 1; i++)
            {
                a = this.points[i];
                b = this.points[i + 1];
                l = GetSideLength(a, b);
                this.perimeter += l;
            }
            a = this.points[0];
            b = this.points[this.points.Length - 1];
            l = GetSideLength(a, b);
            this.perimeter += l;
        }
}

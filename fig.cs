using System;

namespace test
{
    public class fig
    {

        public double SCircle(double r) 
        {
            return r * r * Math.PI;
        }

        public double STriangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool RightTriangle(double a, double b, double c)
        {
            if ((c * c == b * b + a * a) || (a * a == b * b + c * c) || (b * b == c * c + a * a))
                return true;
            return false; 
        }

        public double SCoordin (int[,] points) // массив координат х и у (int[n,2])
        {
            double s = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                s += points[i, 0] * points[i + 1, 1];
                s -= points[i, 1] * points[i + 1, 0];
            }
            return s / 2;
        }
    }
}

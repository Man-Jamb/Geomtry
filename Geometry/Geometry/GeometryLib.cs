using System;

namespace Geometry
{
    interface Geometry
    {
        double Square();
    }


    public class Triangle : Geometry
    {
        double a, b, c;

        public Triangle(double A, double B, double C)
        {
            if ((A <= 0) || (B <= 0) || (C <= 0))
            {
                throw new ArgumentException();
            }
            if ((A >= B + C) || (B >= A + C) || (C >= A + B))
            {
                throw new ArgumentException();
            }

            a = A;
            b = B;
            c = C;
        }

        public double Square()
        {
            double p = (a + b + c) / 2;
            return (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }

        public bool IsRight()
        {
            if (a * a == b * b + c * c)
            {
                return true;
            }
            if (b * b == a * a + c * c)
            {
                return true;
            }
            if (c * c == a * a + b * b)
            {
                return true;
            }
            return false;
        }
    }

    public class Circle : Geometry
    {
        double r;

        public Circle(double R)
        {
            if (R <= 0)
            {
                throw new ArgumentException();
            }

            r = R;
        }

        public double Square()
        {
            return (Math.PI * r * r);
        }
    }
}

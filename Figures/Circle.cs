using System;

namespace Figures
{
    public class Circle
    {
        public Point Center { private set; get; }

        public float Radius { private set; get; }

        public double Length
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }

        public Circle(Point center, float radius)
        {
            Center = center;
            Radius = radius;
        }

        public bool IsPointOnCircle(Point p)
        {
            return Math.Abs(Math.Pow(p.X, 2) + Math.Pow(p.Y, 2) - Math.Pow(Radius, 2)) < 10e-6;
        }
        
        
        public override string ToString()
        {
            return String.Format("Окружность с центром ({0}, {1}), радиусом {2}, длина - {3}", Center.X, Center.Y,
                Radius, Length);
        }
    }
}
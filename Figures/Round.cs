using System;

namespace Figures
{
    public class Round : Circle
    {

        public double Square
        {
            get { return Math.PI * Math.Pow(Radius, 2); }
        }
        
        public Round(Point center, float radius) : base(center, radius)
        {
        }

        public bool IsPointInRound(Point p)
        {
            return Math.Pow(p.X, 2) + Math.Pow(p.Y, 2) <= Math.Pow(Radius, 2);
        }
        
        public override string ToString()
        {
            return String.Format("Круг с центром ({0}, {1}), радиусом {2}, длина - {3}, площадь - {4}", Center.X, Center.Y,
                Radius, Length, Square);
        }
    }
}
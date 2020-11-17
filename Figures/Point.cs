namespace Figures
{
    public class Point
    {
        public float X
        {
            private set; get;
        }

        public float Y { private set; get; }

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
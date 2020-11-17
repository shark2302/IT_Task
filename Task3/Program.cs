using System;
using Figures;

namespace Task3
{
    class Program
    {
        /*
        Создать объект класса Круг, используя классы Точка, Окружность.
        Методы: задание размеров, изменение радиуса, определение принадлежности точки данному кругу.
        */
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите центр окружности");
                var p = EnterPoint();
                Console.WriteLine("Введите радиус окружности");
                var r =Convert.ToInt32(Console.ReadLine());
                Circle c = new Circle(p, r);
                Console.WriteLine(c + "\n");
                Console.WriteLine("Введите точку чтобы проверить леит ли она на окружности");
                var checkPoint = EnterPoint();
                Console.WriteLine(c.IsPointOnCircle(checkPoint));
                Console.WriteLine("Введите центр круга");
                var p1 = EnterPoint();
                Console.WriteLine("Введите радиус окружности");
                var r1 =Convert.ToInt32(Console.ReadLine());
                Round round = new Round(p1, r1);
                Console.WriteLine(round + "\n");
                Console.WriteLine("Введите точку чтобы проверить лежит ли она внутри круга");
                var checkPoint1 = EnterPoint();
                Console.WriteLine(round.IsPointInRound(checkPoint1));
            }
            catch (Exception e)
            {
                Console.WriteLine("Неккоректные данные");
            }
        }

        private static Point EnterPoint()
        {
            Console.WriteLine("Введите координату x:");
            var x =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y:");
            var y =Convert.ToInt32(Console.ReadLine());
            return new Point(x,y);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using FurnitureLib;
using Material = FurnitureLib.Cupboard.Material;
using Location = FurnitureLib.Bookcase.Location;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Введите количество шкафов");
           int count = Convert.ToInt32(Console.ReadLine());
           List<IFurniture> furnitures = new List<IFurniture>(count);
           for (int i = 0; i < count; i++)
           {
               Console.WriteLine("Введите инфу для шкафа № " + (i + 1));
               var b = EnterBookcase();
               if(b != null) 
                   furnitures.Add(b);
           }

           (furnitures[0] as Bookcase)?.AddBook(new Book("Стивенг Кинг", "11 22 63"));
           (furnitures[furnitures.Count - 1] as Bookcase)?.AddBook
               (new List<Book>(3){
               new Book("Дж.Роулинг", "Гарри Поттер"), 
               new Book("Запрягаев С.А", "Электродинмаика"),
               new Book("Достоевсикй", "Престулпение и наказание")
           });
           foreach (var furn in furnitures)
           {
               Console.WriteLine((furn as Bookcase)?.GetInfo());
           }
        }

        private static IFurniture EnterBookcase()
        {
            Bookcase b = null;
            while (b == null)
            {
                try
                {
                    Console.WriteLine("Выберете матреиал 1 - дерево, в остальных случаях сталь");
                    Material mat = SelectMaterial();
                    Console.WriteLine("Введите количество полок");
                    int shelfCount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите стартовую цену");
                    float startPrice = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Введите год выпуска");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Location location = SelectLocation();
                    Console.WriteLine("Введите количество книжек на полке");
                    int count = Convert.ToInt32(Console.ReadLine());
                    b = new Bookcase(mat, shelfCount, startPrice, year, location, count);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("что-то неправильно!");
                }
            }

            return b;
        }

        private static Material SelectMaterial()
        {
            int answer = Convert.ToInt32(Console.ReadLine());
            return answer == 1 ? Material.WOOD : Material.STEEL;
        }

        private static Location SelectLocation()
        {
            Console.WriteLine("Выбрать комнату : 1 - спальня, 2 - гостиная, 3 - кухня, остальное - ванна");
            int answer = Convert.ToInt32(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    return Location.BEDROOM;
                case 2:
                    return Location.LIVVING_ROOM;
                case 3:
                    return Location.KITCHEN;
                default:
                    return Location.BATHROOM;
            }
        }
    }
}
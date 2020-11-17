using System;
using System.Collections.Generic;
using Furniture;

namespace Task5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IFurniture> furnitures = new List<IFurniture>();
            furnitures.Add(new Bookcase("дерево", "гостиная", 5, 30));
            furnitures.Add(new Bookcase("металл", "кухня", 3, 20));
            foreach (var f in furnitures)
            {
                Console.WriteLine(f.GetInfo());
                f.Creak();
            }
        }
    }
}
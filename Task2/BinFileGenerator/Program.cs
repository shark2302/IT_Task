using System;
using FileUtilsLib;

namespace BinFileGenerator
{
    class Program
    {
        ///Users/evgenijkravcenko/RiderProjects/IT_task/Task2/NameN.bin
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название файла, который нужно создать");
            var path2 = Console.ReadLine();
            FileUtils.WriteNumbersFromStringToFile(Console.ReadLine(),path2);
        }
    }
}
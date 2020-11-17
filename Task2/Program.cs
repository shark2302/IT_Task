using System;
using System.IO;
using System.Xml;
using FileUtilsLib;
namespace Task2
{
    internal class Program
    {
        /*Дан текстовый файл NameT и файл с числами NameN. Добавить в начало1|конец2 каждой строки файла NameT
         соответствующий числа из файла NameN. Если файл NameN короче файла NameT, 
         то оставшиеся строки файла NameT не изменять. */
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите путь файла к файлу куда вставлять");
            var path1 = Console.ReadLine();
            Console.WriteLine("Введите название файла откуда брать");
            var path2 = Console.ReadLine();
            Console.WriteLine("Напишите 1, если хотите, чтобы числа проставились в конец, в другом случае числа поставятся в начало");
            var end = Console.ReadLine() == "1";
            try
            {
                FileUtils.SetNumbersInFileContent(path1, 
                    FileUtils.ReadNumbersFromFile(path2), end);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File consist chars, it's not only numbers or not found");
            }
        }
    }
}
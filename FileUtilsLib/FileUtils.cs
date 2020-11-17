using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;

namespace FileUtilsLib
{
    public static class FileUtils
    {
        public static List<int> ReadNumbersFromFile (string fileName) 
        {
            List<int> res = new List<int>();
            BinaryReader binaryReader = new BinaryReader(File.Open(fileName, FileMode.Open));
            while (binaryReader.PeekChar() > -1)
            {
                res.Add(binaryReader.ReadInt32());
            }
            return res;
        }

        public static void SetNumbersInFileContent(string fileName, List<int> numbers, bool end)
        {
            string[] fileContent = File.ReadAllLines(fileName);
            var iterCount = numbers.Count > fileContent.Length ? fileContent.Length : numbers.Count;
            for (int i = 0; i < iterCount; i++)
            {
                fileContent[i] = end ? fileContent[i] + numbers[i] : numbers[i] + fileContent[i];
            }
            File.WriteAllLines(fileName, fileContent);
        }

        public static void WriteNumbersFromStringToFile(string content, string fileName)
        {
            BinaryWriter binaryWriter = new BinaryWriter(File.Open(fileName, FileMode.Create));
            foreach (var number in content)
            {
                if (Char.IsDigit(number))
                {
                    binaryWriter.Write(int.Parse(number.ToString()));
                }
            }
            binaryWriter.Close();
        }
    }
}
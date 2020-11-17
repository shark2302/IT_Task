using System;
using MatrixVectorLib;
namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter rows : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter cols : ");
            int cols = Convert.ToInt32(Console.ReadLine());
            
            Matrix m = new Matrix(rows, cols);
            
            m.Read();
            m.Write();
            
            Console.WriteLine("Count of monotone rows " + m.CountMonotoneRows());
        }
    }
}
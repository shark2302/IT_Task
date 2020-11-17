using System;

namespace MatrixVectorLib
{
    public class Matrix
    {
        private int[][] _data;

        private int Rows
        {
            get { return _data == null ? 0 : _data.Length; }
        }

        private int Cols
        {
            get { return _data.Length > 0 ? _data[0].Length : 0; }
        }
       
        public Matrix(int rows, int cols)
        {
            _data = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                _data[i] = new int[cols];
            }
        }

        public void Read()
        {
            Console.WriteLine("Input matrix" + Rows + "x" + Cols);
            for (int i = 0; i < Rows; i++)
            {
                Console.WriteLine("Input row" + i);
                var strings = Console.ReadLine().Split(' ');
                if (strings.Length > Cols) throw new Exception("To lot numbers");
                int col = 0;
                foreach (var s in strings)
                {
                    int res = 0;
                    if (int.TryParse(s, out res))
                    {
                        _data[i][col++] = res;
                    }
                }
            }
            
        }

        public void Write()
        {
            Console.WriteLine("The matrix is ");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Console.Write(_data[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int CountMonotoneRows()
        {
            int res = 0;
            foreach (var row in _data)
            {
                if (CheckDecreasingRow(row) || CheckGrowingRow(row))
                    res += 1;
            }
            return res;
        }

        private bool CheckGrowingRow(int[] row)
        {
            for (int i = 0; i < row.Length - 1; i++)
            {
                if (row[i + 1] <= row[i])
                    return false;
            }
            return true;
        }
        
        private bool CheckDecreasingRow(int[] row)
        {
            for (int i = 0; i < row.Length - 1; i++)
            {
                if (row[i + 1] >= row[i])
                    return false;
            }
            return true;
        }
    }
}
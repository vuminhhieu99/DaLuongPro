using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace B16_VMHieu_NDHung
{
    class Matrix
    {
        private int size;
        private int[,] matrix;

        public int Size { get => size; set => size = value; }

        public Matrix()
        {
            Size = 0;
            matrix = new int[0, 0];
        }
        public Matrix(int size)
        {
            Size = size;
            matrix = new int[size, size];
        }

        // Indexer -------------------------
        public int this[int x, int y]
        {
            get
            {
                return matrix[x, y];
            }
            set
            {
                matrix[x, y] = value;
            }
        }
        // ----------------------------------

        public void Display()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public int SumRow(int r)
        {
            int S = 0;
            for (int i = 0; i < size; i++)
            {
                S += matrix[r, i];
                Thread.Sleep(100);
            }
            return S;
        }



    }
}

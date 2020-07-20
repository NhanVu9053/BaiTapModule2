using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace bai3
{
    public class matrix
    {
        public int[,] CreatMatrix(int num)
        {
            Random rmd = new Random();
            int[,] matrix = new int[num, num];
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    matrix[i, j] = rmd.Next(20, 60);
                }
            }
            return matrix;
        }

        public string[,] FindMatrix(int[,] matrix, int v)
        {
            //int n = matrix.GetLength(0);
            //int m = matrix.GetLength(1);
            string[,] matrix1 = new string[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != v)
                    {
                        matrix1[i, j] = "*";
                    }
                    else
                    {
                        matrix1[i, j] = $"{ matrix[i, j]}";
                    }
                }
            }
            return matrix1;

        }
        public string[,] ShowMulti5(int[,] matrix)
        {
            string[,] matrix1 = new string[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 5 != 0)
                    {
                        matrix1[i, j] = "*";
                    }
                    else
                    {
                        matrix1[i, j] = $"{ matrix[i, j]}";
                    }
                }
            }
            return matrix1;
        }
        public void ShowMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public int[,] MaTrixMN(int[,] matrix)
        {
            int[,] matrix2 = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix2[i, j] = matrix[i, j];
                }
            }
            return matrix2;
        }
        public void ShowMatrixString(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

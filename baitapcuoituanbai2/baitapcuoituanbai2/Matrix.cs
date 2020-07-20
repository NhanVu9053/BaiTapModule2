using System;
using System.Collections.Generic;
using System.Text;

namespace baitapcuoituanbai2
{
    class Matrix
    {
        public int [,] Creatmatrix1(int num)
            {
            int[,] matrix1 = new int[num, num];
            Random rnd = new Random();
            for(int i =0; i< num;i++)
            {
                for(int j =0; j<num; j++)
                {
                    matrix1[i, j] = rnd.Next(10,40);
                }
            }
            return matrix1;
        }
        public int[,] Creatmatrix2(int num)
        {
            int[,] matrix2 = new int[num, num];
            Random rnd = new Random();
            for(int i=0; i<num;i++)
            {
                for(int j= 0; j<num;j++)
                {
                    matrix2[i, j] = rnd.Next(10, 40);
                }
            }
            return matrix2;
        }

        public int [,] Sum2Matrix(int [,] matrix1, int [,] matrix2)
        {
            int n = matrix1.GetLength(0);
            int[,] matrixsum = new int[n,n];
            for(int i =0; i< matrix1.GetLength(0);i++)
            {
                for(int j=0; j<matrix1.GetLength(0);j++)
                {
                    matrixsum[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrixsum;
        }
        public int [,] MultiMatrix(int [,] matrix1, int [,] matrix2)
        {
            int n = matrix1.GetLength(0);
            int[,] multimatrix = new int[n, n];
            for( int i =1;i<matrix1.GetLength(0);i++)
            {
                for(int j=1;j<matrix1.GetLength(0);j++)
                {
                    multimatrix[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }
            return multimatrix;
        }
        public void ShowMatrix(int[,] matrix)
        {
            for(int i =0; i< matrix.GetLength(0);i++)
            {
                for( int j =0; j< matrix.GetLength(0);j++)
                {
                    Console.WriteLine(matrix[i,j]);
                }
            }
        }
    }
}

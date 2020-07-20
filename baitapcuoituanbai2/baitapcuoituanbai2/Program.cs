using System;

namespace baitapcuoituanbai2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            Console.WriteLine("input number of matrix");
            int num = int.Parse(Console.ReadLine());
            int[,] matrix1 = matrix.Creatmatrix1(num);
            matrix.ShowMatrix(matrix1);
            int[,] matrix2 = matrix.Creatmatrix1(num);
            matrix.ShowMatrix(matrix2);
            int[,] summatrix = matrix.Sum2Matrix(matrix1, matrix2);
            matrix.ShowMatrix(summatrix);
            Console.WriteLine($" tich 2 ma tran 1 va 2 : {matrix.MultiMatrix(matrix1, matrix2)}");

        }
    }
}

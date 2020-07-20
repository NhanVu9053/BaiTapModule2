using System;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            matrix matrix1 = new matrix();
            Console.WriteLine(" input n:");
            int n = int.Parse(Console.ReadLine());
            int[,]a=  matrix1.CreatMatrix(n);
            matrix1.ShowMatrix(matrix1.CreatMatrix(n));
            Console.WriteLine(" input v:");
            int v = int.Parse(Console.ReadLine());
            matrix1.ShowMatrixString(matrix1.FindMatrix(a,v));
            //matrix1.ShowMatrixString(matrix1.ShowMulti5(a));

            //matrix1.ShowMatrix(matrix1.MaTrixMN(a));
        }
    }
}

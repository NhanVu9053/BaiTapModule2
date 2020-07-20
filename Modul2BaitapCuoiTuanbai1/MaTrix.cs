using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Modul2BaitapCuoiTuan
{
    public class MaTrix
    {


        public int[,] CreatMatrix(int n)
        {
            int[,] arr = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(10, 90);
                }
            }
            return arr;

        }
        public void show(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int Tongcheochinh(int[,] arr)
        {
            int tcc = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                tcc += arr[i, i];
            }

            return tcc;
        }
        public int Tongcheophu(int[,] arr)
        {
            int tcp = 0;
            for (int i = arr.GetLength(0) - 1; i >= 0; i--)
            {
                tcp += arr[i, i];
            }
            return tcp;
        }

        public int Tongcacsochan(int[,] arr)
        {
            int tsc = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] % 2 == 0)
                    {
                        tsc += arr[i, j];
                    }
                }
            }
            return tsc;
        }

        public int TongCacDuongVien(int[,] arr)
        {
            int sum = 0;
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                sum += arr[0, j];
                sum += arr[arr.GetLength(0) - 1, j];
            }
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                sum += arr[i, 0];
                sum += arr[i, arr.GetLength(0) - 1];
            }
            return sum;
        }
        public void hienthitamgiacduoi(int[,] arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
              
                for (int j = 0; j < arr.GetLength(1)-i; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void hienthitamgiactren(int[,] arr)
        {
            int n = arr.GetLength(0);
            for (int i = 0; i< arr.GetLength(0); i++)
            {
                for (int j = 0; j< n - 1 - i; j++)
                {
                    Console.Write($"    ");
                }
                for(int k = n -1  - i; k <n; k++)
                {
                    Console.Write(arr[i,k]+"  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

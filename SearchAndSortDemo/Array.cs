using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAndSortDemo
{
    public class Array
    {
        public int[] CreatArray(int num)
        {
            int[] arr = new int[num];
            Random rnd = new Random();
            for (int i = 0; i < num; i++)
            {
                arr[i] = rnd.Next(30, 60);
            }
            return arr;
        }
        public void SortArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;

                    }
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }

        }
        public void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public bool CheckSymetricalArray(int[] arr)
        {
            bool check = true;
            int n = arr.Length / 2;
            for (int i = 0; i < n / 2; i++)
            {
                if (arr[i] != arr[n - i - 1])
                {
                    return check = false;
                }
            }
            return check;
        }
        public int find(int[] arr, int n)
        {
            int low = 0; int hight = arr.Length - 1; 
            while (hight > low)
            {
                int mid = arr.Length / 2;
                if (n < arr[mid])
                {
                    low = mid - 1;
                }
                else if (n == arr[mid])
                {
                    return mid;
                    
                }
                else
                {
                    hight = mid + 1;
                }
            }
            return -1;
        }

    }

}

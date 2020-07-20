using System;

namespace SearchAndSortDemo
{
    class Program
    {
        private static int[] arr;
        static void Main(string[] args)
        {
            Array array = new Array();
            //Console.WriteLine("input N:");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = array.CreatArray(n);
            //array.ShowArray(arr);
            //Console.WriteLine("kiem tra mang doi xung");
            //Console.WriteLine(array.CheckSymetricalArray(arr));
            //array.SortArray(arr);
            //Console.WriteLine($"array after sort:");
            //array.ShowArray(arr);
            int choice = -1;
            while (choice != 5)
            {
                Console.WriteLine("Please input an option:");
                Console.WriteLine("1. Create array. ");
                Console.WriteLine("2. Check for symmetric arrays.");
                Console.WriteLine("3. Array sort."); ;
                Console.WriteLine("4. Find.");
                Console.WriteLine("5. Exit.");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("input N:");
                        int n = int.Parse(Console.ReadLine());
                        arr = array.CreatArray(n);
                        array.ShowArray(arr);
                        break;
                    case 2:
                        Console.WriteLine("Check Symetrical Array :");
                        Console.WriteLine(array.CheckSymetricalArray(arr));
                        break;
                    case 3:
                        array.SortArray(arr);
                        Console.WriteLine($"array after sort:");
                        array.ShowArray(arr);
                        break;
                    case 4:
                        Console.WriteLine($"input value ");
                        int value = int.Parse(Console.ReadLine());
                     int check =   array.find(arr,value);
                        if(check !=-1)
                        {
                            Console.WriteLine($"{value} nam o vi tri {check}");
                        }
                        else
                        {
                            Console.WriteLine("not found");
                        }
                        break;
                   
                }
                Console.WriteLine();

            }
        }
    }
}

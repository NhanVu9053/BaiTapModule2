using System;

namespace Modul2BaitapCuoiTuan
{
    class Program
    {


        static void Main(string[] args)
        {
            MaTrix matrix = new MaTrix();
            Console.WriteLine("input n");
            int n = int.Parse(Console.ReadLine());
            int[,] b = matrix.CreatMatrix(n);
            matrix.show(b);
            //Console.WriteLine("sochan" + matrix.Tongcacsochan(b));
            //Console.WriteLine("cheo chinh " + matrix.Tongcheochinh(b));
            //Console.WriteLine("cheophu :" + matrix.Tongcheophu(b));
            //Console.WriteLine("duong vien : " + matrix.TongCacDuongVien(b));
            Console.WriteLine();
            matrix.hienthitamgiacduoi(b);
            Console.WriteLine();
            matrix.hienthitamgiactren(b);


        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Schema;

namespace GioHangDemo
{
    class Program
    {
        public static Dictionary<int, Cart> menuProducts = new Dictionary<int, Cart>();
        public static Data data = new Data()
        {
            carts = new List<Cart>()
        };
        static void Main(string[] args)
        {
            string choice = "5";
            while (choice != "0")
            {
                Console.WriteLine("****....ONLINE SHOPPING....****");
                Console.WriteLine("1. Buy online product.");
                Console.WriteLine("2. Show shopping cart.");
                Console.WriteLine("3. Pay.");
                Console.WriteLine("0. Exit.");
                Console.Write("Enter you choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("...Buy online product...");
                        PayBill();
                        break;
                    case "2":
                        Console.WriteLine("...Show shopping cart...");
                        ShowProduct();
                        break;
                    case "3":
                        Console.WriteLine("...Pay...");
                        Buy();
                        break;
                    case "0":
                        Console.WriteLine("****....EXIT....****");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }

        public static void CreatProduct(int code, string name, double price)
        {
            Cart cart = new Cart();
            cart.NameProduct = name;
            cart.NameCode = code;
            //cart.Amout = amout;
            cart.Price = price;
            menuProducts.Add(code, cart);
        }
        public static void CreatMenu()
        {
            CreatProduct(1, "Iphone", 30000000);
            CreatProduct(2, "SamSung", 20000000);
            CreatProduct(3, "Nokia", 1000000);
            CreatProduct(4, "Oppo", 150000);
            CreatProduct(5, "VinSmart", 2000000);
            CreatProduct(6, "LG", 30000000);

        }

        public static bool IsInt(string number, out int value)
        {
            return Int32.TryParse(number, out value);
        }

        public static bool CheckCode(int name)
        {
            foreach (var value in menuProducts)
            {
                if (value.Key == name)
                {
                    return true;
                }

            }
            return false;
        }

        public static int GetAmout()
        {
            Console.WriteLine("How many do you want?:");
            string number = Console.ReadLine();
            int value;
            while (!IsInt(number, out value) || value <= 0)
            {
                Console.WriteLine("The value is incorrect");
                number = (Console.ReadLine());
            }
            return value;
        }

        public static void Reset()
        {
            foreach (var item in menuProducts)
            {
                item.Value.Amout = 0;

            }
        }

        public static void Shopping()
        {
            data = new Data()
            {
                carts = new List<Cart>()
            };
            Reset();
        }

        public static void WriteBill(Data bill)
        {
            var path = @"C:\Users\Administrator\source\repos\JSonDemo\GioHang\GioHangDemo\GioHangDemo\Data\Bill.json";
            using (StreamWriter sw = File.CreateText(path))
            {
                var data = JsonConvert.SerializeObject(bill);
                sw.Write(data);
            }
        }
        public static void Buy()
        {
            double total = 0;
            var dataCart = new Data()
            {
                carts = new List<Cart>()
            };
         
            Console.WriteLine($" NameProduct \t\t  NameCode \t\t   Amout \t\t Price \t\t Pay ");

            foreach (var item in menuProducts)
            {
                Console.WriteLine(item.ToString());


            }
            foreach (var product in data.carts)
            {
                Console.WriteLine(product.ToString());
                total += product.Pay;
                dataCart.carts.Add(product);
            }
            Console.WriteLine($"Total money: {total} VND");
            WriteBill(data);
            Shopping();




        }
        public static void ShowProduct()
        {
            
            Console.WriteLine($" NameProduct \t\t  NameCode \t\t   Amout \t\t Price \t\t Pay ");
            foreach (var item in data.carts)
            {
                Console.WriteLine(item.ToString());
            }

        }


        public static void PayBill()
        {
            CreatMenu();
            string number = "n";
            while (number != "0")
            {
                Console.WriteLine("...Menu Product...");
                foreach (var product in menuProducts)
                {
                    Console.WriteLine($"{product.Key}. {product.Value.NameProduct}, price: {product.Value.Price} ");
                }
                Console.WriteLine("0. Back");
                Console.Write("Buy number: ");
                number = Console.ReadLine();
                switch (number)
                {
                    case "0":
                        Console.WriteLine("Back...");

                        break;
                    default:
                        int idProduct;
                        while (!IsInt(number, out idProduct) || idProduct <= 0 || !CheckCode(idProduct))
                        {
                            Console.WriteLine("The selection does not exist!");
                            PayBill();
                        }
                        int amount = GetAmout();
                        if (menuProducts[idProduct].Amout > 0)
                        {
                            menuProducts[idProduct].Amout += amount;
                        }
                        else
                        {
                            menuProducts[idProduct].Amout = amount;
                            data.carts.Add(menuProducts[idProduct]);
                        }
                        break;
                }

            }
        }
    }

}






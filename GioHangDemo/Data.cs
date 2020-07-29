using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace GioHangDemo
{
   public class Data
    {
      public  List<Cart> carts { get; set; }
        public double total { get; set; }
    }
    public class Cart
    {
        public string NameProduct { get; set; }
        public int NameCode { get; set; }
        public int Amout { get; set; }
        public double Price { get; set; }
        public double Pay => PayMoney();
        public double PayMoney()
        {
            return Amout * Price;
        }
        public override string ToString()
        {
            return $"{NameProduct}\t\t{NameCode}\t\t {Amout}\t\t{Price}\t\t{Pay}\t\t";
        }
    }
}

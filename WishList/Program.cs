using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWhishList = new List<string>();

            Console.WriteLine(myWhishList.Count);

            myWhishList.Add("coffee machine");
            myWhishList.Add("new pair of socks");
            myWhishList.Add("box of chocolates");
            myWhishList.Add("new pillow");

            Console.WriteLine(myWhishList.Count);

            foreach(string wish in myWhishList)
            {
                Console.WriteLine(wish);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyWishListFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"D:\visual_studio_failid\wishList\";
            string fileName = @"\\wishList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myWishList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while(loopActive)
            {
                Console.WriteLine("Would you like to add a wish? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if(userInput == 'y')
                {
                    Console.WriteLine("Enter your wish:");
                    string userWish = Console.ReadLine();
                    myWishList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }

            Console.Clear();

            foreach(string wish in myWishList)
            {
                Console.WriteLine($"Your wish: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myWishList);



            // shoppinglist, myshoppinglist.txt

            // lisada ostuniekirja

            // ühes projektis

            // mis kausta teeme, mis faili teeme ning mis me sinna lisame

            // funktsioonide abil

            // saadame ära



        }
    }
}

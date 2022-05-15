using System;
using System.Collections.Generic;
using System.IO;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"D:\visual_studio_failid";
            string newDirectorty = "";

            Console.WriteLine("Millist kataloogi me soovime luua?");

            while (true)
            {
                newDirectorty = Console.ReadLine();

                if (Directory.Exists($"{rootDirectory}\\{newDirectorty}"))
                {
                    Console.WriteLine($"Soovitud kataloog '{rootDirectory}\\{newDirectorty}' juba eksisteerib");
                    Console.WriteLine("Palun vali mingi uus kataloog!");
                }
                else
                {
                    Directory.CreateDirectory($@"{rootDirectory}\\{newDirectorty}");

                    break;
                }
            }
            Console.WriteLine($"Meie uus kataloog on '{rootDirectory}\\{newDirectorty}'");
            Console.WriteLine("Millist failinime soovid kasutada?:");
            string fileName = Console.ReadLine();

            FileStream file = File.Create($"{rootDirectory}\\{newDirectorty}\\{fileName}");
            file.Close();

            List<string> shoppingList = new List<string>();

            while (true)
            {
                Console.WriteLine("Kas sa soovid poenimekirja uusi tooteid lisada? J/E");

                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'j')
                {
                    Console.WriteLine("Sisesta oma toode");

                    string shopItem = Console.ReadLine();
                    shoppingList.Add(shopItem);
                }
                else
                {
                    break;
                }
            }
            File.WriteAllLines($"{rootDirectory}\\{newDirectorty}\\{fileName}", shoppingList);
            Console.Clear();
            Console.WriteLine("Ostunimekiri on valmis ning kirjutatud faili:");

            foreach (string item in shoppingList)
            {
                Console.WriteLine($"Toode nimekirjas: {item}");
            }
        }
    }
}

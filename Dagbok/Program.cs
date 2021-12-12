using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Dagbok
{
    public class Dagbok : DbContext
    {
        [Key]
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string Titel { get; set; }
        public string Anteckning { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();

            Console.WriteLine("Hello World!");
        }

        private static void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Spara anteckning");
                Console.WriteLine("2. Visa lista");
                Console.WriteLine("3. Visa anteckning");
                Console.WriteLine("4. Sök anteckning");
                Console.WriteLine("5. Avsluta");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Du valde 1 - spoara anteckning");
                        break;
                    case "2":
                        Console.WriteLine("Du valde 2 -  visa  lista");
                        break;
                    case "3":
                        Console.WriteLine("Du valde 3 - visa antecknig");
                        break;
                    case "4":
                        Console.WriteLine("Du valde 4 - sök anteckning");
                        break;
                    case "5":
                        Console.WriteLine("Du valde 5 - Programmet kommer att avsluytas");
                        break;
                    default:
                        Console.WriteLine("Ogiltig input");
                        break;
                }

                //break; // Aavluta loopen efter användarvalet.
            }
        }
    }
}

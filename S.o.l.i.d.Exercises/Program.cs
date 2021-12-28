using System;
using System.IO;
using System.Linq;

namespace SingleResponsibilityPrinciple
{
    // EJ SOLID:
    class Program
    {
        static void Main(string[] args)
        {
            // Läs en fil om den finns, annars skapa den:
            const string filename = "MyText.txt";
            var data = "";
            if (File.Exists(filename))
            {
                data = File.ReadAllText(filename);
            }
            else
            {
                data = "Hello world " + DateTime.Now.ToString("yyyy-MM-dd mm:ss");
                File.WriteAllText(filename, data);
            }
            // Plocka ut alla tal från texten:
            var nums = new string(data.Where(char.IsDigit).ToArray());
            // Omvandla det till en unsigned long för att vara säker på att den kan hantera enorma tal:
            ulong.TryParse(nums, out var value);
            // Omvandar num string till en char array  och adderar värdena i den:
            var sum = nums.Sum(n => int.Parse(n.ToString()));

            Console.WriteLine(data); // 2021-12-28 45:59
            Console.WriteLine(nums); // 202112284559
            Console.WriteLine(value); // 202112284559
            Console.WriteLine(sum); // 41

            // MAIN MED SOLID:
            var fh = new FileHandler("MyText.txt");
            var num = new NumberHandler(fh.ReadFile());

            Console.WriteLine(num.Numbers);
            Console.WriteLine(num.ExtractNumbers());
            Console.WriteLine(num.GetNumericValue());
            Console.WriteLine(num.SumAllDigits());
        }
    }

    // SOLID:
    // Skapa en FileHandler och en NumberHandler:
    public class FileHandler
    {
        public string Filename { get; set; } = "MyFile.txt";

        public FileHandler(string filename) //ctor (en metod)
        {
            Filename = filename;
        }
        public string ReadFile()
        {
            var data = GetFileData();
            if (data == "")
                data = CreateFile();
            return data;
        }

        private string CreateFile()
        {
            if (File.Exists(Filename))
                return File.ReadAllText(Filename);
            return "";
        }

        private string GetFileData()
        {
            var data = "Hello word " + DateTime.Now.ToString("yyyy-MM.dd mm:ss");
            File.WriteAllText(Filename, data);
            return data;
        }
    }

    public class NumberHandler
    {
        public string Numbers { get; set; }
        public NumberHandler(string numbers)
        {
            Numbers = numbers;
        }

        public string ExtractNumbers()
        {
            return new string(Numbers.Where(char.IsDigit).ToArray());
        }

        public ulong GetNumericValue()
        {
            ulong.TryParse(ExtractNumbers(), out var num);
            return num;
        }

        public int SumAllDigits()
        {
            return ExtractNumbers().Sum(n => int.Parse(n.ToString()));
        }
    }

}

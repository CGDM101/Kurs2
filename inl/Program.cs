using System; // Environment kommer härifrån.
using System.IO;

namespace inl
{
    class Program
    {
        static void Main(string[] args)
        {
            // SpecialFolder är en enum, kolla metadata! MyDocuments är 5.
            var userFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var userFolder2 = Directory.GetCurrentDirectory(); // Om man har den i .sln (?).

            string myText = "";
            string filePath = Path.Combine(userFolder2, "MyText.txt");
            if (File.Exists(filePath)) // "MyText.txt"
            {
                myText = File.ReadAllText(filePath); // ReadAllLines returnerar en array/lista i st.
            }
            Console.WriteLine(myText); // skriver ut filtexten i konsollen.



            // ============ INLÄMNINGSUPPGIFT: ==================


            Console.WriteLine();
            Console.WriteLine("SVAR PÅ FRÅGORNA: ");
            // Hur många olika länder finns representerade?
            Console.WriteLine("Antal olika länder i databasen:");
            // Är alla username och password unika?
            Console.WriteLine("Är alla username och password unika? ");
            // Hur många är från Norden respektive Skandinavien?
            Console.Write("Från Norden: ");
            Console.Write("Från Skandinavien: ");
            // Vilket är det vanligaste landet?
            Console.WriteLine("Vanligaste landet:");
            // Lista de 10 första användarna vars efternamn börjar på bokstaven L.
            Console.WriteLine("De tio första användarna vars efternamn börjar på \'L\':");
            // Visa alla användare vars för- och efternamn har samma begynnelsebokstav.
            Console.WriteLine("Alla användare vars för- och efternamn har samma begynnelsebokstav:");
        }
    }
}

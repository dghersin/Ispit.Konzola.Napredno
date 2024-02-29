using Ispit.Konzola.Napredno.Sucelja;

namespace Ispit.Konzola.Napredno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite model pametnog telefona:");
            string model = Console.ReadLine();
            IPametniTelefon telefon = new PametniTelefon(model);
            TestirajTelefon(telefon);
        }

        static void TestirajTelefon(IPametniTelefon telefon)
        {
            Console.WriteLine("Unesite telefonski broj:");
            string telefonski_broj = Console.ReadLine();
            Console.WriteLine("Unesite URL za surfanje:");
            string url = Console.ReadLine();

            Console.WriteLine(telefon.Poziv(telefonski_broj));
            Console.WriteLine(telefon.Surfanje(url));
        }
    }
}

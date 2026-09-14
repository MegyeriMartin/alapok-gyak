namespace FelhasznaloFiok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Felhasznalo felhasznalo = new Felhasznalo();

            felhasznalo.Felhasznalonev = "Péter";

            Console.WriteLine("Felhasználónév: " + felhasznalo.Felhasznalonev);

            felhasznalo.JelszoModositas("123456", "abcdef");

            felhasznalo.JelszoModositas("rossz", "ghijkl");

            felhasznalo.JelszoModositas("abcdef", "123");
        }
    }
}
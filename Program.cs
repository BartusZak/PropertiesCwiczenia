using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Podaj model:");

            string model = Console.ReadLine();

            Console.WriteLine("Podaj cene:");

            double cena;
            double.TryParse(Console.ReadLine(), out cena);

            Console.WriteLine("Podaj marké:");

            string marka = Console.ReadLine();
            //string.TryParse(Console.ReadLine(), out marka);

            Console.WriteLine("Wyswietlam wprowadzone zmienne:");
            Console.WriteLine("Model pojazdu: {1}, Cena pojazdu: {0}, Marka pojazdu: {2}", cena,model,marka);

            Console.WriteLine("Tworze obiekt i wyświetlam go:");
            Samochod audi = new Samochod() { Cena = cena, Model = model, Marka = marka };
            Console.WriteLine("Model pojazdu: {1}, Cena pojazdu: {0}, Marka pojazdu: {2}", audi.Cena, audi.Model, audi.Marka);


            Console.WriteLine("Teraz telefon...");

            Telefon nowytel = new Telefon() {Model = "Samsung", Cena = 200.20, Marka = "S3"};
            Console.WriteLine("Model telefonu: {1}, Cena telefonu: {0}, Marka telefonu: {2}", nowytel.Cena, nowytel.Model, nowytel.Marka);


           


            Console.ReadKey();


        }
    }
}

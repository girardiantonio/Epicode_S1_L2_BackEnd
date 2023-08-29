using System;

namespace Epicode_S1_L2_BackEnd
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("PERSONA");

            Console.WriteLine("Inserisci il nome della persona:");
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci il cognome della persona:");
            string cognome = Console.ReadLine();

            Console.WriteLine("Inserisci l'età della persona:");
            int eta = Convert.ToInt32(Console.ReadLine());

            Persona persona = new Persona()
            {
                Nome = nome,
                Cognome = cognome,
                Eta = eta
            };

            Console.WriteLine($"Dettagli: {persona.GetDettagli()}");

            Console.WriteLine("PRODOTTO");

            Console.WriteLine("Inserisci il nome del prodotto:");
            string nomeProdotto = Console.ReadLine();

            Console.WriteLine("Inserisci il prezzo del prodotto:");
            decimal prezzo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Inserisci la quantità del prodotto:");
            int quantita = Convert.ToInt32(Console.ReadLine());

            Prodotto prodotto = new Prodotto
            {
                NomeProdotto = nomeProdotto,
                Prezzo = prezzo,
                Quantita = quantita
            };

            decimal totale = prodotto.CalcolaTotale();
            Console.WriteLine($"Il costo totale del prodotto è: {totale} euro");

            Console.ReadLine();
        }
    }
}

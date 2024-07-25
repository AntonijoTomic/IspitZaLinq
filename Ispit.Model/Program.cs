using Ispit.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ispit.Model
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            int brojac = 0;
            var ListaProizvoda = new List<Proizvod>()
            {
                new Proizvod(1,"Cokolada - za kuhanje"),
                new Proizvod(2,"Lino Lada – Gold"),
                new Proizvod(3,"Papir za pecenje"),
                new Proizvod(4,"Brasno – psenicno"),
                new Proizvod(5,"Secer - standard"),

            };

            var ListaRacuna = new List<Racun>()
            {
                new Racun(100, 3, 800),
                new Racun(101, 2, 650),
                new Racun(102, 3, 900 ),
                new Racun(103, 4, 700),
                new Racun(104, 3, 900),
                new Racun(105,4,650),
                new Racun(106, 1, 458 ),
            };

            foreach(var proizvod in ListaProizvoda)
            {
                brojac++;
                if (brojac == 1)
                {
                    Console.WriteLine("Ovdje je popis proizvoda:\n=============================");
                }
                Console.WriteLine("ID: {0}, Naziv: {1}", proizvod.ProizvodID, proizvod.Naziv);
              
            }
            brojac = 0;
            foreach (var racun in ListaRacuna)
            {
                brojac++;
                if (brojac == 1)
                {
                    Console.WriteLine("\nOvdje je popis racuna:\n=============================");
                }
                Console.WriteLine("Broj racuna: {0}, ID proizvoda: {1}, Kolicina: {2}", racun.BrojRacuna, racun.ProizvodID, racun.Kolicina);

            }
            brojac = 0;

            var SortiraniProizvodi = ListaProizvoda.OrderBy(s => s.Naziv);


           
            foreach (var proizvod in SortiraniProizvodi)
            {
                brojac++;
                if (brojac == 1)
                {
                    Console.WriteLine("\nOvdje je popis sortiranih proizvoda:\n=============================");
                }
                Console.WriteLine("ID: {0}, Naziv: {1}", proizvod.ProizvodID, proizvod.Naziv);

            }

            var ListaSpojenihPodataka = ListaRacuna.Join(
                ListaProizvoda,
                r1 => r1.ProizvodID,
                s1 => s1.ProizvodID,
                (r1, s1) => new
                {
                    ProizvodId = r1.ProizvodID,
                    s1.Naziv,
                    r1.Kolicina
                }).OrderBy(s => s.ProizvodId);

            brojac = 0;
            foreach (var proizvod in ListaSpojenihPodataka)
            {
                brojac++;
                if (brojac == 1)
                {
                    Console.WriteLine("\nEvo popisa nakon pridruzivanja:" +
                        "\nID proizvoda         Naziv proizvoda         Kupljena kolicina"+
                        "\n=============================");
                }
                Console.WriteLine("{0}             {1}                 {2}", proizvod.ProizvodId, proizvod.Naziv, proizvod.Kolicina);

            }

            Console.ReadLine();
        }
    }
}

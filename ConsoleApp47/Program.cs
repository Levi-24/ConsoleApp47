using KategoriaKlassz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace titanic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kategoria> kategoriak = new List<Kategoria>();
            var sr = new StreamReader(
                path: @"..\..\..\src\titanic.txt",
                encoding: Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                //string sor = sr.ReadLine();
                //Kategoria kat = new Kategoria(sor);
                //kategoriak.Add(kat);
                kategoriak.Add(new Kategoria(sr.ReadLine()));
            }

            Console.WriteLine($"2.Feladat: {kategoriak.Count}db");

            var f3 = kategoriak.Sum(k => k.UtasokSzama);
            Console.WriteLine($"3.Feladat: {f3}fő");

            Console.WriteLine("4.Feladat Kulcsszó:");
            string ksz = Console.ReadLine();

            bool f4 = kategoriak.Any(k => k.KategoriaNeve.Contains(ksz));
            Console.WriteLine($"\t{(f4 ? "Van" : "Nincs")} találat");

            //int i = 0;
            //while (i < kategoriak.Count() && !kategoriak[i].KategoriaNeve.Contains(ksz))
            //{
            //    i++;
            //}
            //if (i <kategoriak.Count)
            //{
            //    Console.WriteLine("\t van találat");
            //}
            //else
            //{
            //    Console.WriteLine("\t nincs találat");
            //}



            Console.ReadKey();
        }
    }
}

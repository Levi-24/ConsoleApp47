using _230905;
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

            while (!sr.EndOfStream) kategoriak.Add(new Kategoria(sr.ReadLine()));

            Console.WriteLine($"2.Feladat: {kategoriak.Count}db");

            var f3 = kategoriak.Sum(k => k.UtasokSzama);
            Console.WriteLine($"3.Feladat: {f3}fő");

            Console.Write("4.Feladat Kulcsszó:");
            string ksz = Console.ReadLine();

            bool f4 = kategoriak.Any(k => k.KategoriaNeve.Contains(ksz));
            Console.WriteLine($"\t{(f4 ? "Van" : "Nincs")} találat");

            Console.WriteLine("5.Feladat:");
            foreach (var k in kategoriak)
            { 
                if (k.KategoriaNeve.Contains(ksz)) Console.WriteLine("\t {0} {1}fő",k.KategoriaNeve,k.UtasokSzama);
            }

            Console.WriteLine("6.Feladat:");
            List<string> meghaladta = new List<string>();
            foreach (var k in kategoriak)
            {
                if (k.EltuntekSzama > k.UtasokSzama*.6)
                {
                    meghaladta.Add(k.KategoriaNeve);
                }
            }

            foreach (var m in meghaladta)
            {
                Console.WriteLine($"\t {m}");
            }

            int max = 0;
            for (int j = 1; j < kategoriak.Count; j++)
            {
                if (kategoriak[j].TulelokSzama > kategoriak[max].TulelokSzama)
                {
                    max = j;
                }
            }
            Console.WriteLine($"7.Feladat: {kategoriak[max].KategoriaNeve}");
        }
    }
}

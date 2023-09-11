using _230905;
using System;
using System.Collections.Generic;
using System.IO;
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


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViginereProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            string fájl = "Vtabla.dat";
            Viginere v = new Viginere(fájl);

            Console.WriteLine("1. felaedat");
            string nyíltSzöveg = "Árvíztűrő tükörfúrógép";
            //Console.Write("Írjon be egy szöveget: ");
            //nyíltSzöveg = Console.ReadLine();

            Console.WriteLine("\n2-3. feladat:");
            string átalakítottSzöveg = v.Ékezettelenítő(nyíltSzöveg);
            Console.WriteLine("{0} -> {1}", nyíltSzöveg, átalakítottSzöveg);

            Console.WriteLine("\n4. feladat");
            string kulcsSzó = "asdfg";
            //Console.Write("Írjon be egy szöveget: ");
            //kulcsSzó = Console.ReadLine();

            Console.WriteLine("\n5. feladat");
            string kulcsSzöveg = v.kulcsSzóToKulcsSzöveg(kulcsSzó, nyíltSzöveg);
            Console.WriteLine(átalakítottSzöveg);
            Console.WriteLine(kulcsSzöveg);

            Console.WriteLine("\n6-7. feladat");
            fájl = "kodolt.dat";
            string kódoltSzöveg = v.Kódol(átalakítottSzöveg, kulcsSzöveg, fájl);
            Console.WriteLine("{0} (eredeti)",átalakítottSzöveg);
            Console.WriteLine("{0} (kódolt)", kódoltSzöveg);

            Console.ReadLine();

        }
    }
}

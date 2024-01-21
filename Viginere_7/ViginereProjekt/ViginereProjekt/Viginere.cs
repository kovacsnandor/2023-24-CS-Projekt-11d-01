using System;
using System.IO;

namespace ViginereProjekt
{
    internal class Viginere
    {
        private string fájl;
        private char[,] vTábla;
        private string abc;

        public Viginere(string fájl)
        {
            this.fájl = fájl;
            Beolvas();
        }

        private void Beolvas()
        {
            string[] sorok = File.ReadAllLines(fájl);
            int sorokSzáma = sorok.Length;
            int oszlopokSáma = sorok[0].Length;
            abc = sorok[0];
            vTábla = new char[sorokSzáma, oszlopokSáma];
            for (int s = 0; s < sorok.Length; s++)
            {
                for (int o = 0; o < sorok[s].Length; o++)
                {
                    char betű = sorok[s][o];
                    vTábla[s, o] = betű;
                }
            }
        }

        internal string Ékezettelenítő(string nyíltSzöveg)
        {
            string szöveg = nyíltSzöveg.ToUpper();
            string ékezetes = "ÁÍŰŐÜÖÚÓÉ";
            string nemÉkezetes = "AIUOUOUOE";
            for (int i = 0; i < ékezetes.Length; i++)
            {
                char mit = ékezetes[i];
                char mire = nemÉkezetes[i];
                szöveg = szöveg.Replace(mit, mire);
            }
            return szöveg;
        }

        internal string Kódol(string átalakítottSzöveg, string kulcsSzöveg, string fájl)
        {
            string szöveg = "";
            for (int i = 0; i < átalakítottSzöveg.Length; i++)
            {
                char eredetiKarakter = átalakítottSzöveg[i];
                char kódoltKarakter = ' ';
                if (eredetiKarakter != ' ')
                {
                    int s = abc.IndexOf(eredetiKarakter);
                    int o = abc.IndexOf(kulcsSzöveg[i]);
                    kódoltKarakter = vTábla[s, o];
                }
                szöveg += kódoltKarakter;
            }

            //Írás fájlba
            File.WriteAllText(fájl, szöveg);

            return szöveg;

        }

        internal string kulcsSzóToKulcsSzöveg(string kulcsSzó, string nyíltSzöveg)
        {
            string szöveg = "";
            int kulcsSzóHossz = kulcsSzó.Length;
            int mutató = 0;
            for (int i = 0; i < nyíltSzöveg.Length; i++)
            {
                mutató = i % kulcsSzóHossz;
                szöveg += kulcsSzó[mutató];
            }

            return szöveg.ToUpper();
        }
    }
}
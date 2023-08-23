using System;

namespace SessizKontrolUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String ifade: ");
            string ifade = Console.ReadLine();

            SessizKontrolcu sessizKontrolcu = new SessizKontrolcu();
            bool[] sonuclar = sessizKontrolcu.SessizleriKontrolEt(ifade);

            foreach (bool sonuc in sonuclar)
            {
                Console.Write(sonuc + " ");
            }
        }
    }

    class SessizKontrolcu
    {
        public bool[] SessizleriKontrolEt(string ifade)
        {
            string sessizHarfler = "bcdfghjklmnpqrstvwxyz";
            bool[] sonuclar = new bool[ifade.Length - 1];

            for (int i = 0; i < ifade.Length - 1; i++)
            {
                char karakter1 = Char.ToLower(ifade[i]);
                char karakter2 = Char.ToLower(ifade[i + 1]);
                
                sonuclar[i] = sessizHarfler.Contains(karakter1) && sessizHarfler.Contains(karakter2);
            }

            return sonuclar;
        }
    }
}

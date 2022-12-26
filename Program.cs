using System;

namespace karakterdegistirme
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Aralarında Boşluk Bırakarak kelimeler Giriniz:");
            string Kelimeler = Console.ReadLine();
            string[] kelime = Kelimeler.Split();

            foreach (var item in kelime)
            {

                char[] karakter = item.ToCharArray();
                char temp = karakter[0];

                karakter[0] = karakter[karakter.Length - 1];
                karakter[karakter.Length - 1] = temp;

                foreach (var item1 in karakter)
                {
                    string yeni=item1.ToString();
                    Console.Write(yeni);
                }
            }
        }
    }
}
using System;

namespace Odev_1_Ozge_Ozyurt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int s1 = SayiAl("1. Sayıyı girin: ");
            int s2 = SayiAl("2. Sayıyı girin: ");
            Console.WriteLine();

            Console.WriteLine("Toplama için 1e basın");
            Console.WriteLine("Çıkarma için 2'ye basın");
            Console.WriteLine("Çarpma için 3'e basın");
            Console.WriteLine("Bölme için 4'e basın");

            Console.WriteLine();
            Console.Write("Seçiminiz: ");
            string islem = Console.ReadLine();

            float sonuc = 0;

            if (islem == "1")
            {
                sonuc = Toplama(s1, s2);
            }
            else if (islem == "2")
            {
                sonuc = Cikarma(s1, s2);
            }
            else if (islem == "3")
            {
                sonuc = Carpma(s1, s2);
            }
            else if (islem == "4")
            {
                sonuc = Bolme(s1, s2);
            }

            Console.WriteLine("İşlem Sonucu: " + sonuc);

        }

        static int SayiAl(string text)
        {
            int sayi;
            do
            {
                Console.Write(text);
                string giris = Console.ReadLine();
                if (int.TryParse(giris, out sayi) == true)
                {
                    return sayi;
                }

                Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin.");


            } while (true);

        }

        static int Toplama(int sayi_1, int sayi_2)
        {

            return sayi_1 + sayi_2;
        }

        static int Cikarma(int sayi_1, int sayi_2)
        {
            return sayi_1 - sayi_2;
        }

        static int Carpma(int sayi_1, int sayi_2)
        {
            return sayi_1 * sayi_2;
        }

        static float Bolme(int sayi_1, int sayi_2)
        {

            return (float)sayi_1 / sayi_2;
        }



    }
}

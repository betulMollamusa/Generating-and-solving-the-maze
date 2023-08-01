using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabirentOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen Labirent üretme-Çözme için 1'i ,\nlabirent okuma-Çözme için ise 2'yi giriniz");
            int cevap =Convert.ToInt32(Console.ReadLine());
            switch (cevap)
            {
                case 1:
                    {
                        Labirent.LabirentÜretme();
                        Labirent.LabirentiMatriseAta(cevap);
                        break;
                    }
                case 2:
                    {
                        Labirent.LabirentiMatriseAta(cevap);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("lütfen 1 ve 2 dışında değer girmeyiniz");
                        break;
                    }
            }
            Bomba.BombaAta();
            
            Console.WriteLine("{");
            for (int i = 0; i <= 29; i++)
            {
                for (int k = 0; k <= 29; k++)
                {
                    if (k == 0)
                    {
                        Console.Write("{" + Labirent.LabirentMatrisi[i, k] + ",");
                    }
                    else if (k == 29)
                    {
                        Console.Write(Labirent.LabirentMatrisi[i, k]);
                    }
                    else
                    {
                        Console.Write(Labirent.LabirentMatrisi[i, k] + ",");
                    }
                }
                Console.WriteLine("},");
            }
            Console.WriteLine("}");
            Çıkış.ÇıkışıBul(0, 0);
            Çıkış.ÇıkışıYazdır();
            //Console.Clear();

            Kullanıcı.KullanıcıTalebi();

            Console.WriteLine("\nlabirent oyunu sonlanmıştır çıkmak için herhangi bir tuşa basınız");

            Console.ReadKey();
        }
    }
}

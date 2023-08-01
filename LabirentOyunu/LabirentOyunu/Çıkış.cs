using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabirentOyunu
{
    internal class Çıkış
    {
        private static Stack<string> adımlar = new Stack<string>();
        private static List<int> yatay = new List<int>();
        private static List<int> dikey = new List<int>();
        private static bool HedefeUlaşıldı = false;

        public static bool HedefeUlaşıldıMı()
        {
            return HedefeUlaşıldı;
        }

        private static bool CheckForBomb(int satir, int sütun)
        {
            return Labirent.LabirentMatrisi[satir, sütun] == "B";
        }

        public static void ÇıkışıBul(int satir, int sütun)
        {
            try
            {
                if (satir >= 0 && satir < 30 && sütun >= 0 && sütun < 30)
                {
                    if (CheckForBomb(satir, sütun))
                    {
                        Console.Beep(900, 600);
                        adımlar.Push("B");
                        HedefeUlaşıldı = true;
                        return;
                    }

                    if (Labirent.LabirentMatrisi[satir, sütun] == "0" && sütun==29)
                    {
                        HedefeUlaşıldı = true;
                        adımlar.Push("(" + satir + "," + sütun + ")");
                        return;
                    }

                    if (Labirent.LabirentMatrisi[satir, sütun] == "0" && !adımlar.Contains("(" + satir + "," + sütun + ")"))
                    {
                        adımlar.Push("(" + satir + "," + sütun + ")");

                        // Sağa git
                        ÇıkışıBul(satir, sütun + 1);
                        if (HedefeUlaşıldı) return;

                        // Aşağı git
                        ÇıkışıBul(satir + 1, sütun);
                        if (HedefeUlaşıldı) return;

                        // Sola git
                        ÇıkışıBul(satir, sütun - 1);
                        if (HedefeUlaşıldı) return;

                        // Yukarı git
                        ÇıkışıBul(satir - 1, sütun);
                        if (HedefeUlaşıldı) return;

                        adımlar.Pop();
                    }
                }
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.WriteLine("Çıkış yolu arama esnasında hatalı işlem yapıldı.");
            }
        }

        public static string[,] ÇıkışıYazdır()
        {

            if (HedefeUlaşıldı)
            {
                Console.WriteLine("Labirent Çıkış Yolu:");
                foreach (var adım in adımlar)
                {
                    if (adım == "B")
                    {
                        Console.WriteLine("Bomba!");
                    }
                    else
                    {
                        Console.WriteLine(adım);
                    }
                }
            }
            else
            {
                Console.WriteLine("Çıkış yolu bulunamadı!");
            }

            return Labirent.LabirentMatrisi;
        }
    }

}

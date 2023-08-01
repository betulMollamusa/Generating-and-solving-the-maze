using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabirentOyunu
{
    internal class Bomba
    {
        public static Random Brandom = new Random();
        public static int sayac=0;

        public static string[,] BombaAta()
        {

            while(sayac<3)
            {
                int satir = Brandom.Next(0, 30);
                int sütun = Brandom.Next(0, 30);
                if (Labirent.LabirentMatrisi[satir, sütun] =="1")
                {
                 Labirent.LabirentMatrisi[satir, sütun]="B";
                    sayac++;
                }
            }
            return Labirent.LabirentMatrisi;
        }

        public static void BombaKordinatları()
        {
            BombaAta();
            sayac = 0;
            for(int satir = 0; satir < 30; satir++)
            {
                for(int sütun = 0; sütun < 30; sütun++)
                {
                    if(Labirent.LabirentMatrisi[satir,sütun] == "B")
                    {
                        Console.WriteLine(sayac + 1 + ".Bomba = ( {0} , {1} )", satir, sütun);
                        sayac++;
                    }
                }
            }
        }


    }
}

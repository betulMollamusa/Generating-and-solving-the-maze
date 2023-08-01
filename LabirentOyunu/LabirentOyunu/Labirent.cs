using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabirentOyunu
{
    internal class Labirent
    {
        public  static string dosya = @"labirent.txt";
        public  static Random NumGen = new Random();
        public static string[,] LabirentMatrisi = new string[30, 30];
        //Program program=new Program();


        public static string LabirentÜretme()
        {
           int z;
           int x = NumGen.Next(0, 2);// 0 yolu 1 ise duvarı temsil etmektedir
           int y = 0;//y çıkışa götüren yolu çizecektir
            StreamWriter YazmaNesnesi = new StreamWriter(dosya, false);//write modunda yazma için false kullanıldı


             //Bu şekilde yapılmasının nedeni tüm dizi random oluşturulursa hiç çıkış yol oluşmama ihtimali var onun için y ile çözüm garanti edilir ve x ile farklı labirentler oluşur
            int[,] labirent =
                {
                { y, y, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x },
                { x, y, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x },
                { x, y, x, x, x, x, y, y, y, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x },
                { x, y, x, x, x, x, y, x, y, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x },
                { x, y, x, x, x, x, y, x, y, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x },
                { x, y, x, x, x, x, y, x, y, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x },
                { x, y, x, x, x, x, y, x, y, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x },
                { x, y, x, x, x, x, y, x, y, x, x, x, x, x, x, x, x, x, y, y, y, y, y, y, y, x, x, x, x, x },
                { x, y, x, x, x, x, y, x, y, x, x, x, x, x, x, x, x, x, y, x, x, x, x, x, y, x, x, x, x, x },
                { x, y, x, x, x, x, y, x, y, x, x, x, x, x, x, x, x, x, y, x, x, x, x, x, y, x, x, x, x, x },
                { x, y, x, x, x, x, y, x, y, x, x, x, x, x, x, x, x, x, y, x, x, x, x, x, y, x, x, x, x, x },
                { x, y, x, x, x, x, y, x, y, y, y, y, y, y, x, x, x, x, y, x, x, x, x, x, y, x, x, x, x, x },
                { x, y, x, x, x, x, y, x, x, x, x, x, x, y, x, x, x, x, y, x, x, x, x, x, y, x, x, x, x, x },
                { x, y, x, x, x, x, y, x, x, x, x, x, x, y, x, x, x, x, y, x, x, x, x, x, y, x, x, x, x, x },
                { x, y, y, y, x, x, y, x, x, x, x, x, x, y, x, x, x, x, y, x, x, x, x, x, y, x, x, x, x, x },
                { x, x, x, y, x, x, y, x, x, x, x, x, x, y, x, x, x, x, y, x, x, x, x, x, y, x, x, x, x, x },
                { x, x, x, y, x, x, y, x, x, x, x, x, x, y, x, x, x, x, y, x, x, x, x, x, y, x, x, x, x, x },
                { x, x, x, y, x, x, y, x, x, x, x, x, x, y, y, y, x, x, y, x, x, x, x, x, y, x, x, x, x, x },
                { x, x, x, y, x, x, y, x, x, x, x, x, x, x, x, y, x, x, y, x, x, x, x, x, y, x, x, x, x, x },
                { x, x, x, y, x, x, y, x, x, x, x, x, x, x, x, y, y, y, y, x, x, x, x, x, y, x, x, x, x, x },
                { x, x, x, y, x, x, y, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, y, x, x, x, x, x },
                { x, x, x, y, x, x, y, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, y, x, x, y, y, y },
                { x, x, x, y, x, x, y, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, y, x, x, y, x, x },
                { x, x, x, y, x, x, y, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, y, x, x, y, x, x },
                { x, x, x, y, x, x, y, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, y, x, x, y, x, x },
                { x, x, x, y, x, x, y, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, y, x, x, y, y, x },
                { x, x, x, y, x, x, y, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, y, x, x, x, y, x },
                { x, x, x, y, y, y, y, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, y, x, x, x, y, x },
                { x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, y, y, y, y, y, x },
                { x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x },
                };

            YazmaNesnesi.WriteLine("{");
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    z = NumGen.Next(0, 2);
                    if (j == 0)
                        YazmaNesnesi.Write("{");


                    if (labirent[i, j] == y)
                        YazmaNesnesi.Write(labirent[i, j]);


                    else if(labirent[i, j] == x)
                    {
                        YazmaNesnesi.Write(z);
                    }


                    if (j == 29)
                        YazmaNesnesi.Write("},");
                    else
                        YazmaNesnesi.Write(",");
                }
                YazmaNesnesi.WriteLine();
            }
            YazmaNesnesi.Write("}");

            YazmaNesnesi.Close();
            return dosya;
        }


        public static string[,] LabirentiMatriseAta(int cevap)
        {
            string içerik, içerik0;
            char[] sil = { '{', '}', ',', '\n', ' ' };
            string[] içerik1;
            if (cevap == 1)
            {
                int a = 3;
                StreamReader OkunacakDosya = new StreamReader(dosya);
                içerik = " ";
                while (OkunacakDosya.EndOfStream == false)
                {
                    içerik += OkunacakDosya.ReadToEnd() ;
                }
                OkunacakDosya.Close();
                içerik0 = içerik.Trim();
                içerik1 = içerik0.Split(sil);

                for (int i = 0; i < 30; i++)
                {
                        for (int j = 0; j < 30; j++)
                        {
                            LabirentMatrisi[i, j] = içerik1[a];
                            a++;
                        }
                        a += 3;
                } 
               
            }
            else if (cevap == 2)
            {
                try
                {
                    Console.WriteLine("lütfen yol karakteri 1 duvar kaarkteri ise 0 olan dosya yolunu giriniz");
                    string uzantı = Console.ReadLine();
                    int a = 3;
                    StreamReader OkunacakDosya = new StreamReader(uzantı);
                    içerik = " ";
                    while (OkunacakDosya.EndOfStream == false)
                    {
                        içerik += OkunacakDosya.ReadToEnd();
                    }
                    OkunacakDosya.Close();
                    içerik0 = içerik.Trim();
                    içerik1 = içerik0.Split(sil);

                    for (int i = 0; i < 30; i++)
                    {
                            for (int j = 0; j < 30; j++)
                            {
                                LabirentMatrisi[i, j] = içerik1[a];
                                a++;
                            }
                            a += 3;

                    }
                }
                catch (System.IO.FileNotFoundException ex)
                {
                    Console.WriteLine("lütfen geçerli bir uzantı giriniz");
                }
            }
            else
            {
                Console.WriteLine("geçerli bir seçim yapılmamıştır");
            }
            return LabirentMatrisi;
        }
    }
}

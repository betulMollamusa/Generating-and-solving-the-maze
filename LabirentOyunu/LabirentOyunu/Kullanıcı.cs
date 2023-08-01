using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabirentOyunu
{
    internal class Kullanıcı
    {
        public static void KullanıcıTalebi()
        {
            Console.WriteLine("labirentin orijinal hali için L'ye, \nlabirentte bulunan Bombaların kordinatları için B'ye,\nTüm yol Kordinatları için ise X'e basınız");
            Console.SetCursorPosition(0, 29);
            ConsoleKeyInfo BasılanTuş;
            BasılanTuş = Console.ReadKey();
            switch (BasılanTuş.Key)
            {
                case ConsoleKey.L:
                    {
                        Console.Clear();
                        Console.WriteLine("Labirentin orjinal hali");
                        Console.WriteLine("--------------------------------------------------------------\n");
                        Console.WriteLine("{");
                            for (int i = 0; i <= 29; i++)
                            {
                                for (int k = 0; k <= 29; k++)
                                {
                                  if (k == 0)
                                  {
                                    if (Labirent.LabirentMatrisi[i, k] == "B")
                                    {
                                        Console.Write("{1,");
                                    }
                                    else
                                    {
                                        Console.Write("{" + Labirent.LabirentMatrisi[i, k] + ",");
                                    }
                                  }
                                  else if (k == 29)
                                  {
                                    if (Labirent.LabirentMatrisi[i, k] == "B")
                                    {
                                        Console.Write("1},");
                                    }
                                    else
                                    {
                                        Console.Write(Labirent.LabirentMatrisi[i, k]+ "},");
                                    }
                                  }
                                  else
                                  {
                                    if (Labirent.LabirentMatrisi[i, k] == "B")
                                    {
                                        Console.Write("1,");
                                    }
                                    else
                                    {
                                        Console.Write(Labirent.LabirentMatrisi[i, k]+",");
                                    }
                                  }
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("}");
                        break;
                    }
                case ConsoleKey.B:
                    {
                        Console.Clear();
                        Console.WriteLine("Atanan Bombaların Koordinatları");
                        Console.WriteLine("--------------------------------------------------------------\n");
                        Bomba.BombaKordinatları();
                        break;
                    }
                case ConsoleKey.X:
                    {
                        Console.Clear();
                        Console.WriteLine("Labirentte bulunan tüm yolların Koordinatları");
                        Console.WriteLine("--------------------------------------------------------------\n");
                        for (int i = 0; i < 30; i++)
                        {
                            for (int k = 0; k < 30; k++)
                            {
                                if (Labirent.LabirentMatrisi[i, k] == "0")
                                    Console.WriteLine("( {0} , {1} )", i, k);
                            }
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("lütfen B X L karakterleri dışında bir karakter girmeyiniz");
                        break;
                    }
            }
        }
    }
}

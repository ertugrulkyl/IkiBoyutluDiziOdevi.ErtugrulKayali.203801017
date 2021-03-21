using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkiBoyutluDiziOdevi.ErtugrulKayali._203801017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci Not Hesaplama ve 2 Boyutlu Dizi Oluşturma \n");

            Console.WriteLine("1. Öğrencinin Vize Notunu Giriniz: ");
            float vize1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("1. Öğrencinin Final Notunu Giriniz: ");
            float final1 = Convert.ToSingle(Console.ReadLine());
            float vizefinalortalama1 = (float)(vize1 * 0.4) + (float)(final1 * 0.6);
            Console.WriteLine("1. Öğrencinin Not Ortalaması: " + vizefinalortalama1);

            if (vizefinalortalama1 >= 90)
            {
                Console.WriteLine("1. Öğrencinin Harf Notu: AA (4)");
            }
            else if (vizefinalortalama1 >= 80)
            {
                Console.WriteLine("1. Öğrencinin Harf Notu: BA (3.5)");
            }
            else if (vizefinalortalama1 >= 70)
            {
                Console.WriteLine("1. Öğrencinin Harf Notu: BB (3)");
            }
            else if (vizefinalortalama1 >= 60)
            {
                Console.WriteLine("1. Öğrencinin Harf Notu: CB (2.5)");
            }
            else if (vizefinalortalama1 >= 50)
            {
                Console.WriteLine("1. Öğrencinin Harf Notu: CC (2)");
            }
            else if (vizefinalortalama1 >= 45)
            {
                Console.WriteLine("1. Öğrencinin Harf Notu: DC (Koşullu Geçtiniz)");
            }
            else if (vizefinalortalama1 >= 40)
            {
                Console.WriteLine("1. Öğrencinin Harf Notu: DD (Koşullu Geçtiniz)");
            }
            else if (vizefinalortalama1 <= 39.99)
            {
                Console.WriteLine("1. Öğrencinin Harf Notu: FF (Kaldınız)");
            }
            else
            {
                Console.WriteLine("Koşullu Geçtiniz : Yılsonu ANO = 2 Olmalıdır");
            }

            Console.WriteLine("2. Öğrencinin Vize Notunu Giriniz: ");
            float vize2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("2. Öğrencinin Final Notunu Giriniz: ");
            float final2 = Convert.ToSingle(Console.ReadLine());
            float vizefinalortalama2 = (float)(vize2 * 0.4) + (float)(final2 * 0.6);
            Console.WriteLine("2. Öğrencinin Not Ortalaması: " + vizefinalortalama2);

            if (vizefinalortalama2 >= 90)
            {
                Console.WriteLine("2. Öğrencinin Harf Notu: AA (4)");
            }
            else if (vizefinalortalama2 >= 80)
            {
                Console.WriteLine("2. Öğrencinin Harf Notu: BA (3.5)");
            }
            else if (vizefinalortalama2 >= 70)
            {
                Console.WriteLine("2. Öğrencinin Harf Notu: BB (3)");
            }
            else if (vizefinalortalama2 >= 60)
            {
                Console.WriteLine("2. Öğrencinin Harf Notu: CB (2.5)");
            }
            else if (vizefinalortalama2 >= 50)
            {
                Console.WriteLine("2. Öğrencinin Harf Notu: CC (2)");
            }
            else if (vizefinalortalama2 >= 45)
            {
                Console.WriteLine("2. Öğrencinin Harf Notu: DC (Koşullu Geçtiniz)");
            }
            else if (vizefinalortalama2 >= 40)
            {
                Console.WriteLine("2. Öğrencinin Harf Notu: DD (Koşullu Geçtiniz)");
            }
            else if (vizefinalortalama2 <= 39.99)
            {
                Console.WriteLine("2. Öğrencinin Harf Notu: FF (Kaldınız)");
            }
            else
            {
                Console.WriteLine("Koşullu Geçtiniz : Yılsonu ANO = 2 Olmalıdır");
            }

            Console.WriteLine("3. Öğrencinin Vize Notunu Giriniz: ");
            float vize3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("3. Öğrencinin Final Notunu Giriniz: ");
            float final3 = Convert.ToSingle(Console.ReadLine());
            float vizefinalortalama3 = (float)(vize3 * 0.4) + (float)(final3 * 0.6);
            Console.WriteLine("3. Öğrencinin Not Ortalaması: " + vizefinalortalama3);

            if (vizefinalortalama3 >= 90)
            {
                Console.WriteLine("3. Öğrencinin Harf Notu: AA (4)");
            }
            else if (vizefinalortalama3 >= 80)
            {
                Console.WriteLine("3. Öğrencinin Harf Notu: BA (3.5)");
            }
            else if (vizefinalortalama3 >= 70)
            {
                Console.WriteLine("3. Öğrencinin Harf Notu: BB (3)");
            }
            else if (vizefinalortalama3 >= 60)
            {
                Console.WriteLine("3. Öğrencinin Harf Notu: CB (2.5)");
            }
            else if (vizefinalortalama3 >= 50)
            {
                Console.WriteLine("3. Öğrencinin Harf Notu: CC (2)");
            }
            else if (vizefinalortalama3 >= 45)
            {
                Console.WriteLine("3. Öğrencinin Harf Notu: DC (Koşullu Geçtiniz)");
            }
            else if (vizefinalortalama3 >= 40)
            {
                Console.WriteLine("3. Öğrencinin Harf Notu: DD (Koşullu Geçtiniz)");
            }
            else if (vizefinalortalama3 <= 39.99)
            {
                Console.WriteLine("3. Öğrencinin Harf Notu: FF (Kaldınız)");
            }
            else
            {
                Console.WriteLine("Koşullu Geçtiniz : Yılsonu ANO = 2 Olmalıdır");
            }

            Console.WriteLine("\nHesaplanmış Notları Diziye Tanımlayınız: ");

            string[,] ogrencidizisi = new string[4, 6];
            ogrencidizisi[0, 0] = "Öğrenci Adı";
            ogrencidizisi[0, 1] = "Öğrenci Soyadı";
            ogrencidizisi[0, 2] = "Vize Notu";
            ogrencidizisi[0, 3] = "Final Notu";
            ogrencidizisi[0, 4] = "Ortalama Notu";
            ogrencidizisi[0, 5] = "Harf Notu";

            for (int i = 1; i < ogrencidizisi.GetLength(0); i++)
            {
                for (int j = 0; j < ogrencidizisi.GetLength(1); j++)
                {
                    switch (j)
                    {
                        case 0:
                            Console.WriteLine("Öğrenci Adı Giriniz: ");
                            break;
                        case 1:
                            Console.WriteLine("Öğrenci Soyadı Giriniz: ");
                            break;
                        case 2:
                            Console.WriteLine("Tanımladığınız Vize Sonucunu Tekrar Giriniz: ");
                            break;
                        case 3:
                            Console.WriteLine("Tanımladığınız Final Sonucunu Tekrar Giriniz: ");
                            break;
                        case 4:
                            Console.WriteLine("Hesaplanmış Ortalama Sonucunu Tekrar Giriniz: ");
                            break;
                        case 5:
                            Console.WriteLine("Hesaplanmış Harf Notu Sonucunu Tekrar Giriniz: ");
                            break;
                        default:
                            break;
                    }
                    ogrencidizisi[i, j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < ogrencidizisi.GetLength(0); i++)
            {
                for (int j = 0; j < ogrencidizisi.GetLength(1); j++)
                {
                    Console.Write(ogrencidizisi[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
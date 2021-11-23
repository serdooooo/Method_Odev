using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs_23112021_45_Method_Example_2
{
    class Program
    {
        static void Main(string[] args)
        {

  devamet:          Matematik m1 = new Matematik();
            Matematik.Menu();
            
            Console.Write("Lütfen bir değer seçiniz: ");
            int deger = Convert.ToInt32(Console.ReadLine());

           
            do
            {
                Console.WriteLine("İşlem yapmak istediğiniz değerleri giriniz");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                switch (deger)
            {
                case 1:
                    m1.toplama(a,b);
                    break;
                case 2:
                    m1.cikarma(a,b);
                    break;
                case 3:
                    m1.carpma(a,b);
                    break;
                case 4:
                    m1.bolme(a,b);
                    break;
                default:
                        Console.WriteLine("Belirtmiş olduğunuz değer liste içerisinde bulunamadı.");
                        Console.WriteLine("Lütfen tekrar deneyiniz...");
                        System.Threading.Thread.Sleep(2000);
                        goto devamet;
             }
                Console.WriteLine("Başka işlem yapmak ister misiniz? e/h");
                string devam = Console.ReadLine();
                if (devam == "e")
                {
                    goto devamet;
                }
                else
                {
                    Console.WriteLine("Matematik buraya kadardı...");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(0);
                }

            } while (true);
            Console.ReadLine();

        }
    }
}
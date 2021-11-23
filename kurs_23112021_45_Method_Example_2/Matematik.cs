using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs_23112021_45_Method_Example_2
{
    class Matematik
    {

        public static void Menu()
        {
            Console.WriteLine("****Menü****");
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkarma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            
        }
        public  void toplama(int a,int b)
        {

            int top = 0;
            top = a + b;
            Console.WriteLine("Toplama sonucu: "+top);
        }
        public  void cikarma(int a,int b)
        {
            int cikar = 0;
            cikar = a - b;
            Console.WriteLine("Çıkartma sonucu: "+cikar);
        }
        public  void carpma(int a,int b)
        {
            int carp = 0;
            carp = a * b;
            Console.WriteLine("Çarpma sonucu: "+carp);
        }
        public  void bolme(double a,double b)
        {
            double bol = 0;
            bol = a / b;
            Console.WriteLine("Bölme sonucu: "+bol);

        }        
    }    
}
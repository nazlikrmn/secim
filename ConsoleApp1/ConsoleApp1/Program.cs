using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kac adet aday girilecek");
            int sayi = Convert.ToInt32(Console.ReadLine());
            string[] dizi = new string[sayi];
            for (int i = 0; i < sayi; i++)
            {
                dizi[i] = Console.ReadLine();
            }
            Console.WriteLine(kazanan(dizi));
            Console.Read();
        }
        public static string kazanan(string[] adaylar)
        {
            int max = 0;
            Array.Sort(adaylar);
            List<string> enyuksekoy = new List<string>();
            int sayac = 0;
            foreach (string item in adaylar)
            {
                sayac = 0;
                for (int i = 0; i < adaylar.Length; i++)
                {
                    if (item == adaylar[i])
                        sayac++;
                }
                if (sayac == max)
                    enyuksekoy.Add(item);
                else if(sayac>max)
                {
                    max = sayac;
                    enyuksekoy.Clear();
                    enyuksekoy.Add(item);
                }
            }
            enyuksekoy.Sort();
            return enyuksekoy[0];
        }
    }
}

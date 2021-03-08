
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace sayilari_siralama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];           
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Sayıyı giriniz..:");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

            }
            Array.Sort(sayilar);      //küçükten büyüğe sıralayan komut         
            foreach (int i in sayilar)
            {

                Console.WriteLine("{0}", i);

            }
            Console.ReadKey();
        }
    }
}

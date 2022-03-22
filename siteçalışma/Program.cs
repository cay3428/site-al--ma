using System;

namespace siteçalışma
{
    class Program
    {
        static void Main(string[] args)
        {
            string seçim1 = "koşmaya başladın";
            string seçim2 = "zıpladın";
            string seçim3 = "uçmayı denedin";
            string seçim4 = "bölündün ";
            string seçim5 = "simbiyot budlun";

            Console.WriteLine(seçim1);
            Console.WriteLine(seçim2);
            Console.WriteLine(seçim3);
            Console.WriteLine(seçim4);
            Console.WriteLine(seçim5);




            string[] kaçışlar = new string[] { "koşmaya başladın", "zıpladın", "uçmayı denedin", "seni yedi" };


            for (int i = 0; i < kaçışlar.Length; i++)
            {

                Console.WriteLine(kaçışlar[i]);
            }
            Console.WriteLine("seçimler bitti");

            foreach (string seçim in kaçışlar)
            {
                Console.WriteLine(seçim);
             }


            Console.WriteLine("seçimler bu kadar");














        }


    }
}





































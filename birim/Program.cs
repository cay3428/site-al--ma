using System;

namespace birim
{
    class Program
    {
        static void Main(string[] args)
        {
            string seçimetiket = "seçimler";
                int nüfüs = 32013;
            double değeroranı = 1.45;
            bool başlamışmı = true;
            double tüketimdün = 7.00;
            double tüketimbugün = 7.13;

            if(tüketimdün>tüketimbugün)
            {
                Console.Write("azalış butonu");
            }

            else if (tüketimdün < tüketimbugün)
            {
                Console.WriteLine("artış butonu");

            }
            else
            {
                Console.WriteLine("değişim yok butonu");

            }
            if (başlamışmı == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar butonu");
                
            }
            else
            {
                Console.WriteLine("Başla butonu");


            }

            Console.WriteLine(seçimetiket);

            Console.ReadKey();

        }
    }
}

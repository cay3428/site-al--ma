using System;

namespace market
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi1 = "Kılıç";
            double fiyatı1 = 4;
            string açıklama1 = "Demirden yapılmıştır. ";

            string urunAdi = "Hançer ";
            double fiyatı =  2.10;
            string açıklama = " Derimden yapılmıştır ";

            string[] yakınmesafearaçları = new string[] { "Kılıç","Hançer"};

            urun urun1 = new urun();
            urun1.Adi = "Kılıç";
            urun1.Fiyatı = 4;
            urun1.Aciklama = "demirden yapılmıştır.";

            urun urun2 = new urun();
            urun2.Adi = "hançer";
            urun2.Fiyatı = 2.10;
            urun2.Aciklama = "demirden yapılmış 3 tane ayrı ucu olan kısa saplı";

            urun[] urunler = new urun[] {urun1,urun2 };

            foreach(var urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("*********");



            }
            sepet_yönetimi sepetyönetim = new sepet_yönetimi();
            sepetyönetim.Edin(urun1);
            sepetyönetim.Edin(urun2);





        }
    }
}

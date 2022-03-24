using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Tanımlama Kişi1 = new Tanımlama();
            //    Kişi1.Adi = "taşağ";
            //    Kişi1.ID = 1 / 2;
            //    Kişi1.Nufusu = "belkıran";                   >>>>>>>>>>>>>> BU ŞEKİLDE DE YAPILABİLİR AMA iş yükü artar 
            //    Kişi1.Özelizi = "29745863027/2*" ;
            //    Kişi1.Grupadi = "Aletçiler";
            //    Kişi1.RütbeNumarası = "255!46!1 " ;
            //    Kişi1.Resmiyetİzi = "997588^^554^1313";

            Düzenciler müşteri1 = new Düzenciler();
            müşteri1.Adi = "kaçkın";
            müşteri1.Nufusu = "şakacı";
            müşteri1.ID = 1;
            müşteri1.RütbeNumarası = "68465!1";
            müşteri1.Özelizi = "5546825468756/2*";

            Gelgelçler müşteri2 = new Gelgelçler();
            müşteri2.Grupadi = "çıkagelmişler";
            müşteri2.ID = 2;
            müşteri2.Resmiyetİzi = "56468716875649!2";
            müşteri2.RütbeNumarası = "900374!2";

            Tanımlama müşteri4 = new Düzenciler();
            Tanımlama müşteri5 = new Gelgelçler();

            MüşteriYönetimi müşteriYönetimi = new MüşteriYönetimi();
            müşteriYönetimi.Yaz(müşteri1);
            müşteriYönetimi.Yaz(müşteri2);






        }
    }
}












   


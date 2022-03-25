using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
           ISaygınlıkYönetimi ihtiyacSaygınlıkYönetimi = new İhtiyacSaygınlıkYönetimi();
            ISaygınlıkYönetimi taşıtSaygınlıkYönetimi = new TaşıtSaygınlıkYönetimi ();
            ISaygınlıkYönetimi evsaygınlığıyönetimi = new Evsaygınlığıyönetimi();

            ISoytarı dosyaHizmeti = new DosyaaHizmeti();
            ISoytarı soytaro = new SoytarınınHizmeti();

            List<ISoytarı> soytarıs = new List<ISoytarı> { new İleti_belgeleme_hizmeti(), new SoytarınınHizmeti() };  


            BaşvuruYönetimi başvuruYönetimi = new BaşvuruYönetimi();
            başvuruYönetimi.BaşvuruYap(ihtiyacSaygınlıkYönetimi, soytaro/*,new KöylüSaygınlıkYönetimi(),new İleti_belgeleme_hizmeti()*/);
            List<ISaygınlıkYönetimi> saygınlıks = new List<ISaygınlıkYönetimi>() {ihtiyacSaygınlıkYönetimi,taşıtSaygınlıkYönetimi,evsaygınlığıyönetimi  };
            başvuruYönetimi.saygınlıkbildirisiyap(saygınlıks);








        }
    }
}

//evsaygınlığıyönetimi.Hesapla();
//ihtiyacSaygınlıkYönetimi.Hesapla();
//taşıtSaygınlıkYönetimi.Hesapla();
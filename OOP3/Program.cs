using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
           ISaygınlıkYönetimi ihtiyacSaygınlıkYönetimi = new İhtiyacSaygınlıkYönetimi();
            ISaygınlıkYönetimi taşıtSaygınlıkYönetimi = new TaşıtSaygınlıkYönetimi ();
            ISaygınlıkYönetimi evsaygınlığıyönetimi = new Evsaygınlığıyönetimi();

            BaşvuruYönetimi başvuruYönetimi = new BaşvuruYönetimi();
            başvuruYönetimi.BaşvuruYap(ihtiyacSaygınlıkYönetimi);

        }
    }
}

//evsaygınlığıyönetimi.Hesapla();
//ihtiyacSaygınlıkYönetimi.Hesapla();
//taşıtSaygınlıkYönetimi.Hesapla();
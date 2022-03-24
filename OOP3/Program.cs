using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
           ISaygınlıkYönetimi ihtiyacSaygınlıkYönetimi = new İhtiyacSaygınlıkYönetimi();
            ihtiyacSaygınlıkYönetimi.Hesapla();

            ISaygınlıkYönetimi taşıtSaygınlıkYönetimi = new TaşıtSaygınlıkYönetimi ();
            taşıtSaygınlıkYönetimi.Hesapla();

            ISaygınlıkYönetimi evsaygınlığıyönetimi = new Evsaygınlığıyönetimi();
            evsaygınlığıyönetimi.Hesapla();


        }
    }
}

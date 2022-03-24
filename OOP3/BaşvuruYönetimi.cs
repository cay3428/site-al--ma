using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BaşvuruYönetimi
    {
        public void BaşvuruYap(ISaygınlıkYönetimi saygınlıkYönetimi,ISoytarı soytarı)
        {

            saygınlıkYönetimi.Hesapla();
            soytarı.Log();

        }
        public void saygınlıkbildirisiyap(List<ISaygınlıkYönetimi> saygınlıklarq)
        {
            foreach (var saygınlık in saygınlıklarq)
            {
                saygınlık.Hesapla();

            }
        
        
        
        


        }
    }
}

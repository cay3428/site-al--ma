using System;
using System.Collections.Generic;
using System.Text;

namespace market
{
    class sepet_yönetimi
    {
        public void Edin(urun urun)
        {
            Console.WriteLine("Edinildi   " + urun.Adi);
            //Console.WriteLine("Edindin" + urun.Adi);
            //Console.WriteLine("çalmadın vay" + urun.Adi);


        }

        public void Edin2(string urunAdi, string açıklama, double fiyat,int stokAdedi)
        {

            Console.WriteLine("Edinildi,Çantaya eklendi : " + urunAdi);


        }


    }
}

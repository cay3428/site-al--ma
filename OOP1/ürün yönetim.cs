using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ürün_yönetim
    {
        public void Ekle(Program program)
        {
            Console.WriteLine(program.Ürünadı + " edindin ");
        }
        

        public void güncelle(Program program)
        {
            Console.WriteLine(program.Ürünadı + "değiştirildi ");

        }

        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;


        }

        public void Topla2(int sayi1, int sayi2)
        {

            Console.WriteLine(sayi1 + sayi2);



        }

    
    }
}

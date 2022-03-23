using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Ürünüler
    {

        static void Main(string[] args)
            {
            Program program1 = new Program();
            program1.Id = 1;
            program1.KategoriId = 2;/* tek kod parçasındada yazılabilir*/
            program1.StokAdedi = 40;
            program1.Fiyatı = 15;
            program1.Ürünadı = "diken";

            Program program2 = new Program { Id = -6, KategoriId = 13, StokAdedi = 23, Ürünadı = "çivi", Fiyatı = 1.23 };

            ürün_yönetim ürnynt = new ürün_yönetim();
            ürnynt.Ekle(program1);





        }




    }
}

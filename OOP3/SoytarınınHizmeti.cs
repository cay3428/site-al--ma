using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SoytarınınHizmeti : ISoytarı
    {

        public void Log()
        {
            Console.WriteLine("soytarı veriyi logldı");/*>>>>>>>>>>>>>>>> bu şekildede yapılabilir*/




        }
    }


    class DosyaaHizmeti : ISoytarı
    {

        public void Log()
        {
            Console.WriteLine("soytarı dosyayı logladı");




        }
    }
}

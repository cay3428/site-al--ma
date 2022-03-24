using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class İhtiyacSaygınlıkYönetimi : ISaygınlıkYönetimi
    {
        public void Hesapla()
        {
            Console.WriteLine("ihtiyaç saygınlığı ödemesi düzenlendi");
        }

        public void zımbırtı()
        {


            throw new NotImplementedException();


        }
    }
}

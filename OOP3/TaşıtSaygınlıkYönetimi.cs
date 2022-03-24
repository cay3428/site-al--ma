using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TaşıtSaygınlıkYönetimi : ISaygınlıkYönetimi
    {
        public void Hesapla()
        {
            Console.WriteLine("taşıt saygınlığı ödemesi düzenlendi");
        }

        public void zımbırtı()
        {
            throw new NotImplementedException();
        }
    }
}

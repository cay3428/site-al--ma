using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KöylüSaygınlıkYönetimi : ISaygınlıkYönetimi

    {
        public void Hesapla()
        {
            Console.WriteLine("Köylü saygınlığı hesaplandı");

        }

        public void zımbırtı()
        {
            throw new NotImplementedException();
        }
    }
}

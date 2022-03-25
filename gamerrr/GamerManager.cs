using System;
using System.Collections.Generic;
using System.Text;

namespace gamerrr
{
    class GamerManager : IGamerService
    {
        public void eklee(Gamer gamer)
        {
            Console.WriteLine("oyuncu vadiye indi");
        }

        public void gübelle(Gamer gamer)
        {
            Console.WriteLine("oyuncu kendini güncelledi");
        }

        public void silll(Gamer gamer)
        {
            Console.WriteLine("oyuncu varlığı yok oldu");

        }
    }
}

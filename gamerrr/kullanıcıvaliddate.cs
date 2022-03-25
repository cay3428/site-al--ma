using OOP3;
using System;
using System.Collections.Generic;
using System.Text;

namespace gamerrr
{
    class kullanıcıvaliddate : IValiddate
    {
        public bool kuvalidatte(Gamer gamer)
        {

            if (gamer.doğumyılı == 1970 && gamer.İlkadd == "jeton"  && gamer.Id == 1 && gamer.Kimliknumaar == "165463254" && gamer.Sonnad == "ğğğaaaaa")
            {
                return true;
            }
            else
            {

                return false;
            }


        }
    }
}


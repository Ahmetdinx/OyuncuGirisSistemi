using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuGirisSistemi
{
    class PlayerCheckServiceManager : IPlayerCheckService
    {
        public bool CheckEdevletSystem(Gamer gamer)
        {
            if (gamer.DogumYili == "20/09/2001" && gamer.Adı == "Ahmet" && gamer.Soyad == "Dinç" && gamer.TcNo == "27137821378127" )
            {
                
                return true;

            }
            else {
                return false; }
                
        }
    }
}

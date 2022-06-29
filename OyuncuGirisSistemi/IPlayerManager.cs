using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuGirisSistemi
{
    interface IPlayerService
    {
        void Login(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
        
    }
}

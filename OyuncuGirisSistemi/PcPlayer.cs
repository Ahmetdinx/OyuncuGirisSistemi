using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuGirisSistemi
{
    
    class PcPlayer : Gamer , IPlayerService , IPlayerCheckService
    {
        IPlayerCheckService _playerCheckService;

        public PcPlayer(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public int MouseNo { get; set; }

        public bool CheckEdevletSystem(Gamer gamer)
        {
            return true;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Pc oyuncusu silindi.");
        }

        public void Login(Gamer gamer)
        {
            if (_playerCheckService.CheckEdevletSystem(gamer) == true)
            {
                Console.WriteLine("kayıt başarılı");

            }
            else
            {
                Console.WriteLine("kayıt başarısız");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Pc oyuncusunun bilgileri güncellendi.");
        }

        
    }
}

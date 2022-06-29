using System;
using System.Collections.Generic;
using System.Text;

namespace OyuncuGirisSistemi
{
    class ConsolePlayer : Gamer , IPlayerService , IPlayerCheckService

       
    {
         IPlayerCheckService _playerCheckService;

        public ConsolePlayer(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public int KonsolNo { get; set; }

        public bool CheckEdevletSystem(Gamer gamer)
        {
            return true;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Console oyuncusu silindi.");
        }

        public void Login(Gamer gamer)
        {
            if(_playerCheckService.CheckEdevletSystem( gamer)==true)
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
            Console.WriteLine("console oyuncusunun bilgileri güncellendi.");
        }
    }
}

using System;

namespace OyuncuGirisSistemi
{
    class Program
    {
        static void Main(string[] args)
        {

            
            ConsolePlayer gamer = new ConsolePlayer(new PlayerCheckServiceManager());
            gamer.Adı = "Ahmet";
            gamer.DogumYili = "20/09/2001";
            gamer.Soyad = "Dinç";
            gamer.TcNo = "27137821378127";
            gamer.KonsolNo = 2312;
            gamer.Login(gamer);
            gamer.Update(gamer);
            gamer.Delete(gamer);
            
            

            PcPlayer gamer1 = new PcPlayer(new PlayerCheckServiceManager());
            gamer1.Adı = "Efe";
            gamer1.DogumYili = "14/12/2006";
            gamer1.Soyad = "Dinç"; 
            gamer1.TcNo = "4543534542312";
            gamer1.MouseNo = 2313;
            gamer1.Login(gamer1);
            gamer1.Update(gamer1);
            gamer1.Delete(gamer1);
            





        }
    }
}

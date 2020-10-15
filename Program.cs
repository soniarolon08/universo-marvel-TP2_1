using System;

namespace TP2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Marvel------");
            
            Superheroe _superheroe = new Superheroe("Iron Man", 1963, "Marvel", 550);
            Villano _villano = new Villano("Whiplash", 1963, "Marvel", 500);

            Console.WriteLine("----- El combate comenzó -----");

            _superheroe.Atacar(_villano);

            _villano.Atacar(_superheroe);

        }
    }
}

using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int round = 1;
            var Raymond = new Marksman("Raymond", 100, 30);
            var Kirk = new Fighter("Kirk", 200, 15);
            var Eloi = new Tank("Eloi", 150, 30);

            Raymond.DisplayStats();
            Kirk.DisplayStats();
            Eloi.DisplayStats();

            while (Raymond.IsAlive && Kirk.IsAlive && Eloi.IsAlive)
            {

                Raymond.Attack(Kirk);
                Console.WriteLine("----------------------------------------------");
                Eloi.Attack(Raymond);
                Console.WriteLine("----------------------------------------------");
                round++;
            }

            Console.ReadKey();
        }
    }
}
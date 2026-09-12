using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var Raymond = new Raymond(100, 30, 15);
            var Kirk = new Kirk(200, 15, 20);
            var Eloi = new Eloi(150, 30, 25);

            Raymond.DisplayStats();
            Kirk.DisplayStats();
            Eloi.DisplayStats();
            Console.WriteLine("===================================================");


            while (Raymond.IsAlive && Kirk.IsAlive && Eloi.IsAlive)
            {

                Raymond.Attack(Kirk);
                Kirk.DisplayStats() ;
                Console.WriteLine("----------------------------------------------");
                Eloi.Attack(Raymond);
                Raymond.DisplayStats();
                Console.WriteLine("----------------------------------------------");
                Thread.Sleep(2000);
            }

            Console.WriteLine("===================== END =========================");

            Console.ReadKey();
        }
    }
}
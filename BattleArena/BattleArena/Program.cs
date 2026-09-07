using BattleArena.Warrior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena.Warrior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior Raymond = new Warrior("Raymond", 100, 30, "tumakbo");
            Warrior Kirk = new Warrior("Kirk", 150, 50, "hinabol");
            Warrior Eloi = new Warrior("Eloi", 200, 40, "taguro");

            Raymond.DisplayStatus();
            Kirk.DisplayStatus();
            Eloi.DisplayStatus();

            int round = 1;
            while (Raymond.IsAlive && Kirk.IsAlive && Eloi.IsAlive)
            {
                Console.WriteLine("-------- Round {round}");
                Raymond.Attack(Kirk);
                Kirk.Attack(Eloi);
                Eloi.Attack(Raymond);
                Console.WriteLine("-----------------------");
                round++;
            }
            Console.ReadKey();
        }
    }
}



using System;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BattleArena.Warriors
{
    public class Eloi: Warrior
    {
        public int Shield { get; private set; }
        public Eloi(int health, int attackPower, int shield)
            : base("Eloi", health, attackPower, WarriorType.Tank)
        {
            Shield = shield;
        }
        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Ewan", HasCriticalChance);
            TakeDamage(dmginfo);

            Console.WriteLine($"\t-> {Name}: Wala kang Takas Boi! {target.Name}!");
            Thread.Sleep(1000);

            Console.WriteLine($"\t-> {target.Name}: Napinsala ako!");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t-> {target.Name}: Aray kopo! {target.Name}");
        }
    }
}
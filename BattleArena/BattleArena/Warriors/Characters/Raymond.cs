using System;
using System.Threading;
using System.Xml.Linq;

namespace BattleArena.Warriors
{
    public class Raymond : Warrior
    {
        public int ArrowDamage { get; private set; }
        public Raymond(int health, int attackPower, int arrowDamage)
            : base("Raymond", health, attackPower,WarriorType.Marksman)
        {
            ArrowDamage = arrowDamage;
            attackPower += arrowDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Raymond", HasCriticalChance);
            TakeDamage(dmginfo);

            Console.WriteLine($"\t-> {Name}: Ano ka Boi! {target.Name}!");
            Thread.Sleep(1000);

            Console.WriteLine($"\t-> {target.Name}: Takas kapa!");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t-> {target.Name}: Punit ako! {target.Name}");
            Thread.Sleep(1000);
        }
    }
}
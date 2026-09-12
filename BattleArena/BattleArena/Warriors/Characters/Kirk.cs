using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace BattleArena.Warriors
{
    public class Kirk : Warrior
    {
        public int SwordDamage { get; private set; }
        public Kirk(int health, int attackPower, int swordDamage)
            : base("Kirk", health, attackPower, WarriorType.Fighter)
        {
            SwordDamage = swordDamage;
            attackPower += swordDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Ewan", HasCriticalChance);
            TakeDamage(dmginfo);

            Console.WriteLine($"\t-> {Name}: Ano na Boi kapa! {target.Name}!");
            Thread.Sleep(1000);

            Console.WriteLine($"\t-> {target.Name}: Napinsala ako!");
            Console.WriteLine($"\t-------- {target.Name} --------");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t-> {target.Name}: Patay ka ngayon! {target.Name}");
        }
    }
}
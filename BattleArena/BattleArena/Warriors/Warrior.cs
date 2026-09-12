using System;

namespace BattleArena.Warriors
{
    public enum WarriorType
    {
        Fighter,
        Marksman,
        Tank,
        Magery
    }

    public abstract class Warrior
    {
        private bool _isAlive;
        private DamageInfo _damagedTaken;
        private Random _random = new Random();
        private bool _hasCriticalChance;

        public string Name { get; private set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }
        public WarriorType WarriorType { get; private set; }

        public bool IsAlive
        {
            get
            {
                _isAlive = Health > 0;
                return _isAlive;
            }
            private set { _isAlive = value; }
        }

        public bool HasCriticalChance
        {
            get
            {
                var chance = _random.Next(0, 100);
                _hasCriticalChance = chance > 30;
                return _hasCriticalChance;
            }
            private set { _hasCriticalChance = value; }
        }

        public Warrior(string name, int health, int attackPower, WarriorType warriorType)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            WarriorType = warriorType;
        }

        protected virtual void TakeDamage(DamageInfo damage)
        {
            _damagedTaken = damage;
            int actualDamage = damage.TotalAmountDamage;

            if (damage.IsCritical)
                actualDamage *= damage.TotalAmountDamage * 2;

            Health -= actualDamage;
            if (Health < 0) Health = 0;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine($"\t---=={Name}---==");

            if (_damagedTaken.IsCritical)
                Console.WriteLine($"\t----- Critical Hit -----");

            Console.WriteLine($"\t[*] Health: {Health}");
            Console.WriteLine($"\t[*] Attack Power: {AttackPower}");
            Console.WriteLine($"\t[*] Damage Taken: {_damagedTaken.TotalAmountDamage}");
        }
        public abstract void Attack(Warrior target);

    }
}
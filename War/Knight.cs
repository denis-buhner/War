namespace War
{

    internal class Knight : Warrior
    {
        public Knight(float health, float damage, string name = "Рыцарь")
            : base(health, damage, name)
        {
        }

        public override void Attack(List<Warrior> enemyes)
        {
            base.Attack(enemyes);

            Warrior enemyForAttack = enemyes[Utility.CreateRandomNumber(enemyes.Count)];
            enemyForAttack.TakeDamage(Damage);
        }

        public override string ToString()
        {
            Console.WriteLine($"я просто {Name}");
            return base.ToString();
        }
    }
}
namespace War;

internal class Paladin : Warrior
{
    private readonly int _maxTargets;

    public Paladin(float maxHealth, float damage, int maxTargets, string name = "Паладин")
        : base(maxHealth, damage, name)
    {
        _maxTargets = maxTargets;
    }

    public override void Attack(List<Warrior> enemyes)
    {
        base.Attack(enemyes);
        List<Warrior> enemyesForAttack = new List<Warrior>();

        for (int i = 0; i < _maxTargets; i++)
        {
            int enemyIndex = Utility.CreateRandomNumber(enemyes.Count);

            if (enemyesForAttack.Contains(enemyes[enemyIndex]) == false)
            {
                enemyesForAttack.Add(enemyes[enemyIndex]);
            }
        }

        foreach (Warrior enemy in enemyesForAttack)
        {
            enemy.TakeDamage(Damage);
        }
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"я могу атаковать до {_maxTargets} целей");
    }

    public override string ToString()
    {
        Console.WriteLine($"я гордый {Name}");
        return base.ToString();
    }
}
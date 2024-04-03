namespace War;

internal class GrandPaladin : Warrior
{
    private readonly int _maxTargets;

    public GrandPaladin(float maxHealth, float damage, int maxTargets, string name = "Великий паладин")
        : base(maxHealth, damage, name)
    {
        _maxTargets = maxTargets;
    }

    public override void Attack(List<Warrior> enemyes)
    {
        base.Attack(enemyes);

        for (int i = 0; i < _maxTargets; i++)
        {
            int enemyIndex = Utility.CreateRandomNumber(enemyes.Count);
            enemyes[enemyIndex].TakeDamage(Damage);
        }
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"я могу атаковать до {_maxTargets} целей");
    }

    public override string ToString()
    {
        Console.WriteLine($"я гордый и великий {Name}");
        return base.ToString();
    }
}
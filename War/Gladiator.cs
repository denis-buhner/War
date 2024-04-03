namespace War;

internal class Gladiator : Warrior
{
    private readonly float _damageScale;

    public Gladiator(float maxHealth, float damage, float damageScale, string name = "Гладиатор")
        : base(maxHealth, damage, name)
    {
        _damageScale = damageScale;
    }

    public override void Attack(List<Warrior> enemyes)
    {
        base.Attack(enemyes);

        float changedDmage = Damage + (Damage * _damageScale);
        Warrior enemyForAttack = enemyes[Utility.CreateRandomNumber(enemyes.Count)];
        enemyForAttack.TakeDamage(changedDmage);
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"мой множитель урона{_damageScale}");
    }

    public override string ToString()
    {
        Console.WriteLine($"я {Name}");
        return base.ToString();
    }
}
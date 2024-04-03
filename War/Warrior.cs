namespace War;

internal abstract class Warrior
{
    private float _maxHealth;

    public Warrior(float maxHealth, float damage, string name)
    {
        _maxHealth = maxHealth;
        CurrentHealth = _maxHealth;
        Damage = damage;
        Name = name;
    }

    public float CurrentHealth { get; protected set; }

    public float Damage { get; protected set; }

    public string Name { get; protected set; }

    public bool IsAlive => CurrentHealth > 0;

    public virtual void Attack(List<Warrior> enemyes)
    {
        if (enemyes.Count <= 0)
            return;
        Console.WriteLine($"{this}атакую");
    }

    public virtual void TakeDamage(float damage)
    {
        CurrentHealth -= damage;

        if (CurrentHealth < 0)
        {
            CurrentHealth = 0;
        }
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"мое здоровье - {CurrentHealth}, мой урон - {Damage}");
    }

    public override string ToString()
    {
        ShowInfo();

        return null;
    }
}
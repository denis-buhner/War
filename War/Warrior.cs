namespace War;

internal abstract class Warrior
{
    private float _health;
    private float _maxHealth;
    private float _damage;
    private string _name;

    public Warrior(float maxHealth, float damage, string name)
    {
        _maxHealth = maxHealth;
        _health = _maxHealth;
        _damage = damage;
        _name = name;
    }

    public float CurrentHealth => _health;

    public float Damage => _damage;

    public bool IsAlive => _health > 0;

    public string Name => _name;

    public virtual void Attack(List<Warrior> enemyes)
    {
        if (enemyes.Count <= 0) return;
        Console.WriteLine($"{this}атакую ");
    }

    public virtual void TakeDamage(float damage)
    {
        _health -= damage;

        if (_health < 0)
        {
            _health = 0;
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
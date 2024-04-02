namespace War;

internal class Army
{
    private readonly List<Warrior> _platoon = new List<Warrior>();
    private List<Type> _warriorTypes;

    public Army(string name, int platoonSize = 100)
    {
        Name = name;
        _warriorTypes = new List<Type>
        {
            typeof(Knight),
            typeof(Gladiator),
            typeof(Paladin),
            typeof(GrandPaladin),
        };

        FormDetachment(platoonSize);
    }

    public List<Warrior> Platoon => _platoon;

    public int ArmyCount => _platoon.Count;

    public string Name { get; }

    public bool IsAlive => _platoon.Count > 0;

    public void Attack(Army army)
    {
        Console.WriteLine($"-----------------\n" +
                          $"ход за армией {Name}");
        foreach (var warior in _platoon)
        {
            warior.Attack(army.Platoon);
        }

        army.DeleteDeadWarriors();
    }

    public void DeleteDeadWarriors()
    {
        for (int i = _platoon.Count - 1; i >= 0; i--)
        {
            if (_platoon[i].IsAlive == false)
                _platoon.RemoveAt(i);
        }
    }

    private Warrior? CreateWarrior(Type warriorType)
    {
        switch (warriorType)
        {
            case Type type when type == typeof(Knight):
                return new Knight(100, 10);
            case Type type when type == typeof(Gladiator):
                return new Gladiator(100, 10, Utility.NextSingle());
            case Type type when type == typeof(Paladin):
                return new Paladin(100, 10, 5);
            case Type type when type == typeof(GrandPaladin):
                return new GrandPaladin(100, 10, 5);
        }

        return null;
    }

    private void FormDetachment(int platoonSize)
    {
        for (int i = 0; i < platoonSize; i++)
        {
            Warrior warrior = CreateWarrior(_warriorTypes[Utility.GetRandomNumber(_warriorTypes.Count)]);
            _platoon.Add(warrior);
        }
    }
}
namespace War;

internal class BattleField
{
    public void Battle()
    {

        Army army1 = new Army("Кортофельляндия");
        Army army2 = new Army("Суппрокисший");

        while (army1.IsAlive && army2.IsAlive)
        {
            if (army1.IsAlive)
            {
                army1.Attack(army2);
            }

            if (army2.IsAlive)
            {
                army2.Attack(army1);
            }

            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                              $"{army1.Name} - в живых {army1.ArmyCount}.\n" +
                              $"{army2.Name} - в живых {army2.ArmyCount}.\n" +
                              $"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

        ShowWinner(army1, army2);
    }

    private void ShowWinner(Army army1, Army army2)
    {
        if (army1.IsAlive)
            Console.WriteLine($"Победила армия {army1.Name}");
        else
            Console.WriteLine($"Победила армия {army2.Name}");
    }
}
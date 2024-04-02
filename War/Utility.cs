namespace War;

internal class Utility
{
    private static readonly Random s_random = new Random();

    public static int GetRandomNumber(int maxNumber)
        => s_random.Next(maxNumber);

    public static float NextSingle()
        => s_random.NextSingle();
}
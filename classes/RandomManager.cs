
public class RandomManager
{
    private static Random rand = new Random();

    // Dice.
    public static int roleD6()
    {
        return RandomManager.rand.Next(1, 7);
    }
    public static int roleD100()
    {
        return RandomManager.rand.Next(1, 101);
    }

    //.
    public static int Next()
    {
        return RandomManager.rand.Next();
    }
    public static int Next(int max)
    {
        return RandomManager.rand.Next(max);
    }
    public static int Next(int min, int max)
    {
        return RandomManager.rand.Next(min, max);
    }
}
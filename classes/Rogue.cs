
public class Rogue : Adventurer
{

    protected override bool tryCrit()
    {
        return RandomManager.roleD100() <= 11;
    }

    protected override bool tryDodge()
    {
        return RandomManager.roleD100() <= 21;
    }

    // ---->

    public override string ToString()
    {
        return $"Rogue ({this.name})";
    }

}
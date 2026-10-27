
public class Goblin : Monster
{

    protected override bool tryDodge()
    {
        return RandomManager.roleD100() <= 31;
    }

    // ---->

    public override string ToString()
    {
        return "Goblin";
    }

}
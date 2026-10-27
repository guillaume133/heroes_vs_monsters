
public class Slime : Monster
{

    protected override bool tryCrit()
    {
        return false;
    }

    // ---->

    public override string ToString()
    {
        return "Slime";
    }

}
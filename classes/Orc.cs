
public class Orc : Monster
{

    public Orc() : base(40)
    { }

    protected override int evalBaseDamage()
    {
        return base.evalBaseDamage() + 1;
    }

    // ---->

    public override string ToString()
    {
        return "Orc";
    }

}

public class Mage : Adventurer
{
    protected override int evalBaseDamage()
    {
        return base.evalBaseDamage() + 2;
    }

    // ---->

    public override string ToString()
    {
        return $"Mage ({this.name})";
    }
}
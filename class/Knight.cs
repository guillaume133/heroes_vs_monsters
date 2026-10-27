
public class Knight : Adventurer
{

    protected override void evalDamageTake(ref int damage)
    {
        damage -= 2;
    }

    // ---->

    public override string ToString()
    {
        return $"Kright ({this.name})";
    }

}
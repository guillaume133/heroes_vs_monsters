
public class Entity
{
    // health point.
    private int hp;
    public bool isLiving
    {
        get { return this.hp > 0; }
    }

    public Entity(int hp = 30)
    {
        this.hp = hp;
    }

    // function take / make damage.
    public int makeDamage()
    {
        int damage = evalBaseDamage();

        if (tryCrit())
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("CRIT !");
            Console.ForegroundColor = ConsoleColor.Gray;
            damage *= 2;
        }

        damage = Math.Max(0, damage);  // not able to hit in negatif.

        return damage;
    }
    protected virtual int evalBaseDamage()
    {
        return RandomManager.roleD6();
    }

    public int takeDamage(int damage)
    {
        evalDamageTake(ref damage);
        if (tryDodge())
        {
            Console.WriteLine("dodge.");
            damage = 0;
        }

        damage = Math.Max(0, damage);  // not able to take hit in negatif.

        this.hp -= damage;
        return damage;
    }
    protected virtual void evalDamageTake(ref int damage){}  // do nothing by default.

    protected virtual bool tryCrit()
    {
        return RandomManager.roleD100() <= 1;
    }
    protected virtual bool tryDodge()
    {
        return RandomManager.roleD100() <= 1;
    }
    protected virtual bool tryDodge2()
    {
        return RandomManager.roleD100() <= 1;
    }

    // name.
    public override string ToString()
    {
        return "Entity object";
    }

     protected virtual bool tryDodge3()
    {
        return RandomManager.roleD100() <= 1;
    }
}
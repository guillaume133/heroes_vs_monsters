
public class Monster : Entity
{

    public Monster(int hp = 30) : base(hp)
    { }
    
    public static IEnumerable<Monster> getRandomMonster(int count)
    {
        for (int i = 0; i < count; i += 1)
        {
            int randomIndex = RandomManager.Next(3);
            switch (randomIndex)
            {
                case (0):
                    yield return new Slime();
                    break;
                case (1):
                    yield return new Goblin();
                    break;
                case (2):
                    yield return new Orc();
                    break;
            }
        }
    }
}
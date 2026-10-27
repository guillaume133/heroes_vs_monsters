
public class Battle
{
    private List<Entity> entities = new();

    public Battle(List<Entity> entities)
    {
        this.entities = entities;
    }

    public void runBattle()
    {
        Console.WriteLine("<<-- BATTLE START ! -->");

        while (!this.isHasOneTeamLeft())
        {
            for (int i = 0; i < this.entities.Count; i++)
            {
                Entity currentEntity = this.entities[i];

                if (!currentEntity.isLiving)
                    continue;

                Console.WriteLine($"{currentEntity} is attacking.");
                int damageMake = currentEntity.makeDamage();

                // choose an oponenet to atk.
                List<Entity> oponents = this.entities.FindAll(e =>
                {  // do not take Entity in your own team.
                    return (e is Adventurer) != (currentEntity is Adventurer);
                }).FindAll(e =>
                {  // do not take Entity already dead.
                    return e.isLiving;
                });
                if (oponents.Count == 0)  // no more oponent.
                    break;
                int indexOponentChoost = RandomManager.Next(0, oponents.Count);
                Entity oponenetChoose = oponents[indexOponentChoost];

                int damageApply = oponenetChoose.takeDamage(damageMake);
                Console.WriteLine($"{oponenetChoose} loose {damageApply} HP.");

                if (!oponenetChoose.isLiving)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{oponenetChoose} die.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

        }

        Console.WriteLine("<<-- BATTLE END ! -->>\n");

        Entity? pickFistLiving = this.entities.Find(e => e.isLiving);
        if (pickFistLiving == null)
            Console.WriteLine("Every body is dead.");
        else if (pickFistLiving is Adventurer)
            Console.WriteLine("Adventurer Win !");
        else
            Console.WriteLine("Adventurer Loose.");
    }

    private bool isHasOneTeamLeft()
    {
        int adventurerCount = 0;
        int monsterCount = 0;

        for (int i = 0; i < this.entities.Count; i++)
        {

            Entity currentEntity = this.entities[i];
            if (!currentEntity.isLiving)  // skip thos who die.
                continue;

            if (currentEntity is Adventurer)
                adventurerCount += 1;
            else
                monsterCount += 1;

        }

        bool allAdventurerDead = adventurerCount == 0;
        bool allMonsterDead = monsterCount == 0;

        return allAdventurerDead || allMonsterDead;
    }

}
using System;
using System.Globalization;

namespace TestProject
{

    class Program
    {

        static void Main(string[] args)
        {
            // get 3 random Adventurer.
            IEnumerable<Entity> adventurers = Adventurer.getRandomAdventurers(3)
                .Select(adventurer => adventurer as Entity);  // cast all in Entity.
            // get 3 random Monsters.
            IEnumerable<Entity> monsters = Monster.getRandomMonster(3)
                .Select(monster => monster as Entity);  // cast all in Entity.
            // merge both in one list, and shuffle.
            List<Entity> allsForBattle = adventurers
                .Concat(monsters)
                .OrderBy(_ => RandomManager.Next())  // order randomely.
                .ToList();

            // presentation.
            Console.WriteLine("<<-- Entities -->>");
            allsForBattle.ForEach((e) =>
            {
                if (e is Adventurer a)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(a.name);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    return;
                }
                Console.WriteLine(e.ToString());
            });
            Console.WriteLine("");

            Battle battle = new Battle(allsForBattle);
            battle.runBattle();


        }

    }
}
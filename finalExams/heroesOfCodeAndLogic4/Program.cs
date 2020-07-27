using System;
using System.Collections.Generic;
using System.Linq;

namespace heroesOfCodeAndLogic4
{
    class Program
    {
        static void Main(string[] args)
        {
            var heroesCount = int.Parse(Console.ReadLine());
            var heroes = new List<Hero>();
            for (int i = 0; i < heroesCount; i++)
            {
                var heroInfo = Console.ReadLine().Split();
                var name = heroInfo[0];
                var hp = int.Parse(heroInfo[1]);
                var mp = int.Parse(heroInfo[2]);
                Hero hero = new Hero
                {
                    Name = name,
                    HP = hp,
                    MP = mp
                };
                heroes.Add(hero);
            }
            var input = Console.ReadLine();
            while (input!="End")
            {
                var command = input.Split(" - ");
                var action = command[0];
                switch (action)
                {
                    case "CastSpell":
                        var heroName = command[1];
                        var mpNeeded = int.Parse(command[2]);
                        var spellName = command[3];
                        var currentHero = heroes.Find(x => x.Name == heroName);
                        if(mpNeeded<=currentHero.MP)
                        {
                            currentHero.MP -= mpNeeded;
                            Console.WriteLine($"{currentHero.Name} has successfully cast {spellName} and now has {currentHero.MP} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{currentHero.Name} does not have enough MP to cast {spellName}!");
                        }
                        break;
                    case "TakeDamage":
                        heroName = command[1];
                        var damageTaken = int.Parse(command[2]);
                        var attacker = command[3];
                        currentHero = heroes.Find(x => x.Name == heroName);
                        currentHero.HP -= damageTaken;
                        if (currentHero.HP > 0)
                        {
                            Console.WriteLine($"{currentHero.Name} was hit for {damageTaken} HP by {attacker} and now has {currentHero.HP} HP left!");
                        }
                        else
                        {
                            heroes.Remove(currentHero);
                            Console.WriteLine($"{currentHero.Name} has been killed by {attacker}!");
                        }
                        break;
                    case "Recharge":
                        heroName = command[1];
                        var mpAmount = int.Parse(command[2]);
                        currentHero = heroes.Find(x => x.Name == heroName);
                        currentHero.MP += mpAmount;
                        if(currentHero.MP<=200)
                        {
                            Console.WriteLine($"{currentHero.Name} recharged for {mpAmount} MP!");
                        }
                        else
                        {
                            mpAmount -= currentHero.MP - 200;
                            currentHero.MP = 200;
                            Console.WriteLine($"{currentHero.Name} recharged for {mpAmount} MP!");
                        }
                        break;
                    case "Heal":
                        heroName = command[1];
                        var hpAmount = int.Parse(command[2]);
                        currentHero = heroes.Find(x => x.Name == heroName);
                        currentHero.HP += hpAmount;
                        if(currentHero.HP<=100)
                        {
                            Console.WriteLine($"{currentHero.Name} healed for {hpAmount} HP!");
                        }
                        else
                        {
                            hpAmount -= currentHero.HP - 100;
                            currentHero.HP = 100;
                            Console.WriteLine($"{currentHero.Name} healed for {hpAmount} HP!");
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            foreach (var hero in heroes.OrderByDescending(x=>x.HP).ThenBy(x=>x.Name))
            {
                Console.WriteLine(hero.Name);
                Console.WriteLine($"  HP: {hero.HP}");
                Console.WriteLine($"MP: {hero.MP}");
            }
        }
        public class Hero
        {
            public string Name { get; set; }
            public int HP { get; set; }
            public int MP { get; set; }
        }
    }
}

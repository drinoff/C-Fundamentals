using System;
using System.Linq;

namespace pokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemons = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var temp = 0;
            var sum = 0;

            while (pokemons.Count != 0)
            {
                var index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    temp = pokemons[0];
                    sum += temp;
                    
                    pokemons[0] = pokemons[pokemons.Count - 1];
                    for (int i = 0; i <= pokemons.Count - 1; i++)
                    {
                        if (pokemons[i] <= temp)
                        {
                            pokemons[i] += temp;
                        }
                        else
                        {
                            pokemons[i] -= temp;
                        }
                    }

                }
                else if (index > pokemons.Count - 1)
                {
                    temp = pokemons[pokemons.Count - 1];
                    sum += pokemons[pokemons.Count - 1];

                    pokemons[pokemons.Count - 1] = pokemons[0];

                    for (int i = 0; i <= pokemons.Count - 1; i++)
                    {
                        if (pokemons[i] <= temp)
                        {
                            pokemons[i] += temp;
                        }
                        else
                        {
                            pokemons[i] -= temp;
                        }
                    }
                }
                else
                {
                    temp = pokemons[index];
                    sum += pokemons[index];
                    pokemons.RemoveAt(index);
                    for (int i = 0; i <= pokemons.Count - 1; i++)
                    {
                        if (pokemons[i] <= temp)
                        {
                            pokemons[i] += temp;
                        }
                        else
                        {
                            pokemons[i] -= temp;
                        }

                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}

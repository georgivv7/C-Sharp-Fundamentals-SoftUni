using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            while (pokemons.Count > 0)
            {
                int removeIndex = int.Parse(Console.ReadLine());

                if (removeIndex < 0)
                {
                    removeIndex = 0;
                    int removedElement = pokemons[removeIndex];
                    sum += removedElement;
                    pokemons.RemoveAt(removeIndex);
                    pokemons.Insert(0, pokemons[pokemons.Count - 1]);

                    for (int i = 0; i <= pokemons.Count - 1; i++)
                    {
                        if (pokemons[i] <= removedElement)
                        {
                            pokemons[i] += removedElement;
                        }
                        else
                        {
                            if (pokemons[i] > removedElement)
                            {
                                pokemons[i] -= removedElement;
                            }

                        }

                    }

                }
                else if (removeIndex > pokemons.Count - 1)
                {
                    removeIndex = pokemons.Count - 1;
                    int removedElement = pokemons[removeIndex];
                    sum += removedElement;
                    pokemons.RemoveAt(removeIndex);
                    pokemons.Insert(removeIndex, pokemons[0]);
                    for (int i = 0; i <= pokemons.Count - 1; i++)
                    {
                        if (pokemons[i] <= removedElement)
                        {
                            pokemons[i] += removedElement;
                        }
                        else
                        {
                            if (pokemons[i] > removedElement)
                            {
                                pokemons[i] -= removedElement;
                            }
                        }
                    }

                }
                else
                {
                    int removedElement = pokemons[removeIndex];
                    sum += removedElement;
                    pokemons.RemoveAt(removeIndex);
                    for (int i = 0; i <= pokemons.Count - 1; i++)
                    {
                        if (pokemons[i] <= removedElement)
                        {
                            pokemons[i] += removedElement;
                        }
                        else
                        {
                            if (pokemons[i] > removedElement)
                            {
                                pokemons[i] -= removedElement;
                            }
                        }
                    }

                }

            }
            Console.WriteLine(sum);
        }
    }
}

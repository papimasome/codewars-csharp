﻿/*
https://www.codewars.com/kata/567d71b93f8a50f461000019/csharp

7 kyu
Genetic Algorithm Series - #3 Crossover

In genetic algorithms, crossover is a genetic operator used to vary the programming of chromosomes from one generation to the next.

The one-point crossover consists in swapping one's cromosome part with another in a specific given point. 
The image bellow shows the crossover being applied on chromosomes 1011011001111 and 1011100100110 with the cut point (index) 4:

In this kata you have to implement a function crossover that receives two chromosomes chromosome1, 
chromosome2 and a zero-based index and it has to return an array with the crossover result on both chromosomes [chromosome1, chromosome2].

Example:
crossover('111000', '000110', 3) should return ['111110', 000000']

See other katas from this series
Genetic Algorithm Series - #1 Generate
Genetic Algorithm Series - #2 Mutation
Genetic Algorithm Series - #3 Crossover
Genetic Algorithm Series - #4 Get population and fitnesses
Genetic Algorithm Series - #5 Roulette wheel selection
This kata is a piece of2 kyuBinary Genetic Algorithm
*/

using System.Collections.Generic;

namespace CodeWars
{
    public class GeneticAlgorithmSeries3Crossover
    {
        public IEnumerable<string> Crossover(string chromosome1, string chromosome2, int cut)
        {
            return new[] {chromosome1[..cut] + chromosome2[cut..], chromosome2[..cut] + chromosome1[cut..]};

            // return new string[]
            // {
            //     chromosome1.Substring(0, cut) + chromosome2.Substring(cut),
            //     chromosome2.Substring(0, cut) + chromosome1.Substring(cut)
            // };
        }
    }
}
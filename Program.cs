using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Animal animalInstance = null;
            //I tried to instantiate a new animal here, create the name and eats properties here and do the writelog for the name and eats here so that I did not have to write those properties into each of the instances below but it would not work. 
            
            switch (args[0])
            {
                case "badger":
                    animalInstance = new Badger
                    {
                        name = args[1],
                        weight = args[2],
                        height = args[3],
                        origin = args[4],
                        aggressive = args[5],
                        diet = args[6]

                    };
                    Console.WriteLine(animalInstance.description());
                    break;

                case "elephant":
                    animalInstance = new Elephant
                    {
                        name = args[1],
                        weight = args[2],
                        height = args[3],
                        origin = args[4],
                        tuskSize = args[5],
                        color = args[6]
                    };
                    Console.WriteLine(animalInstance.description());
                    break;

                case "wolf":
                    animalInstance = new Wolf
                    {
                        name = args[1],
                        weight = args[2],
                        height = args[3],
                        origin = args[4],
                        dominance = args[5],
                        gender = args[6]
                    };
                    Console.WriteLine(animalInstance.description());
                    break;
            }
        }
    }
}

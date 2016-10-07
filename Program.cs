using System;
using Zoolandia.Animals;


namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Mustelidae honeyBadger = new Mustelidae ()
            {
                height = "30 inches",
                origin = "North America",
                aggressive = "ferocious",
                diet = "small babies"
            };
            Console.WriteLine($"{honeyBadger.name} the Honey Badger resides in {honeyBadger.origin} and averages {honeyBadger.height}. It is known for it's {honeyBadger.aggressive} mentality and eating {honeyBadger.diet}.");

            Elephantidae indianElephant = new Elephantidae ()
            {
                height = "10 ft",
                origin = "India",
                tuskSize = "large",
                color = "brown"
            };
            Console.WriteLine($"{indianElephant.name} the {indianElephant.color} Indian Elephant resides in {indianElephant.origin} and averages {indianElephant.height}. It is known for it's {indianElephant.tuskSize} tusks and peaceful ways.");

            Canidae alaskanWolf = new Canidae ()
            {
                height = "50 inches",
                origin = "Alaska",
                dominance = "Alpha",
                gender = "male"
            };
            Console.WriteLine($"{alaskanWolf.name} the Alaskan Wolf resides in {alaskanWolf.origin} and averages {alaskanWolf.height}. {alaskanWolf.name} is the {alaskanWolf.dominance} {alaskanWolf.gender} of its pack!");
        }
    }
}

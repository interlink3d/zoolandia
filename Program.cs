using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Badger honeyBadger = new Badger ();
            {
                honeyBadger.name = "Killer";
                honeyBadger.weight = "40 lbs";
                honeyBadger.height = "30 inches";
                honeyBadger.origin = "North America";
                honeyBadger.aggressive = "ferocious";
                honeyBadger.diet = "small babies";
            }
            Console.WriteLine($"{honeyBadger.name} the Honey Badger resides in {honeyBadger.origin} and averages {honeyBadger.weight} and {honeyBadger.height}. It is known for it's {honeyBadger.aggressive} mentality and eating {honeyBadger.diet}.");

            Elephant indianElephant = new Elephant ();
            {
                indianElephant.name = "Lucky";
                indianElephant.weight = "1 ton";
                indianElephant.height = "10 ft";
                indianElephant.origin = "India";
                indianElephant.tuskSize = "large";
                indianElephant.color = "brown";
            }
            Console.WriteLine($"{indianElephant.name} the {indianElephant.color} Indian Elephant resides in {indianElephant.origin} and averages {indianElephant.weight} and {indianElephant.height}. It is known for it's {indianElephant.tuskSize} tusks and peaceful ways.");

            Wolf alaskanWolf = new Wolf ();
            {
                alaskanWolf.name = "Night Crawler";
                alaskanWolf.weight = "80 lbs";
                alaskanWolf.height = "50 inches";
                alaskanWolf.origin = "Alaska";
                alaskanWolf.dominance = "Alpha";
                alaskanWolf.gender = "male";
            }
            Console.WriteLine($"{alaskanWolf.name} the Alaskan Wolf resides in {alaskanWolf.origin} and averages {alaskanWolf.weight} and {alaskanWolf.height}. {alaskanWolf.name} is the {alaskanWolf.dominance} {alaskanWolf.gender} of its pack!");
        }
    }
}

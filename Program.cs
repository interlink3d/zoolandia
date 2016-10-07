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

            Mustelidae Edgar = new Mustelidae ("Edgar")
            {
                height = "30 inches",
                origin = "North America",
                aggressive = "ferocious",
                diet = "small babies",
                age = 29
            };
            Console.WriteLine($"{Edgar.name} the {Edgar.age} year old Honey Badger resides in {Edgar.origin} and averages {Edgar.height}. He is known for his {Edgar.aggressive} mentality and eating {Edgar.diet}.");

             Mustelidae Jose = new Mustelidae (25)
            {
                name = "Jose",
                height = "30 inches",
                origin = "North America",
                aggressive = "ferocious",
                diet = "small babies"
            };
            Console.WriteLine($"{Jose.name} the {Jose.age} year old Honey Badger resides in {Jose.origin} and averages {Jose.height}. He is known for his {Jose.aggressive} mentality and eating {Jose.diet}.");

            Mustelidae Gio = new Mustelidae ("Gio", 26)
            {
                height = "30 inches",
                origin = "North America",
                aggressive = "ferocious",
                diet = "small babies"
            };
            Console.WriteLine($"{Gio.name} the {Gio.age} year old Honey Badger resides in {Gio.origin} and averages {Gio.height}. He is known for his {Gio.aggressive} mentality and eating {Gio.diet}.");


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
            Console.WriteLine($"{alaskanWolf.description()}\n {alaskanWolf.name} is originally from {alaskanWolf.origin} and averages {alaskanWolf.height} tall.");
        }
    }
}

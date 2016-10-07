using System;

namespace Zoolandia.Animals
{
    class Animal
    {
        public string name { get; set; }
        public string height {get; set; }
        public string origin {get; set; }        

        public static void sleep ()
        {
            Console.WriteLine("Animal is now sleeping.");
        }

        public static void eating ()
        {
            Console.WriteLine("Animal is eating its favorite meal.");
        }
        public virtual string description ()
        {
            return $"{this.name} lives in Zoolandia.";
        }
    }
}
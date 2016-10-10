using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string name {get; set;}
        public string origin {get; set;}
        public string loves {get; set;}     
        public int age {get; set;}

        public virtual string eat()
        {
            return "Animal is eating.";
        } 
        public virtual string eat(string food)
        {
            return $"Animal is eating.";
        }
        public virtual string sleep()
        {
            return "Animal is sleeping.";
        }
        public virtual string sleep(int hours)
        {
            return $"Animal likes to nap for {hours} hours.";
        }
        public virtual string sleep(int hours, string location)
        {
            return $"Animal likes to nap for {hours} in the {location}.";
        }
        public virtual string description ()
        {
            return $"{this.name} lives in Zoolandia.";
        }
    }
}
using System;

namespace Zoolandia.Animals
{
    class Diceros: Animal
    {
        public bool hasHorns = true;
        public virtual string fight() 
        {
            return "Animal is enjoying a good friendly fight.";
        }
        public virtual string fight(double speed)
        {
            return $"Animal is charging its adversary at {speed} mph.";
        }
        public virtual string fight(double speed, string cause)
        {
            return $"They can charge at up to {speed} mph when {cause}.";
        }
    }
}
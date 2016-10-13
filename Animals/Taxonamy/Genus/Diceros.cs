using System;

namespace Zoolandia.Animals
{
    class Diceros : Animal, IRunning
    {
        public bool hasHorns = true;
        
        public virtual string running() 
        {
            return $"{this.name} is known to stampede in parades";
        }
        public virtual string running(double speed)
        {
            return $"{this.name} can go up to {speed} mph.";
        }
        public virtual string fight() 
        {
            return $"{this.name} is enjoying a good friendly fight.";
        }
        public virtual string fight(double speed)
        {
            return $"{this.name} is charging its adversary at {speed} mph.";
        }
    }
}
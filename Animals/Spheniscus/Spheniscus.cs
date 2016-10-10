using System;

namespace Zoolandia.Animals
{
    class Spheniscus: Animal
    {
        public bool cantFly = true;
        public virtual string swim() 
        {
            return "Animal is out swimming";
        }
        public virtual string swim(double speed)
        {
            return $"Animal is swimming at {speed} mph.";
        }
        public virtual string swim(double speed, string destination)
        {
            return $"{this.name} is swimming at {speed} mph towards {destination}";
        }
    }
}
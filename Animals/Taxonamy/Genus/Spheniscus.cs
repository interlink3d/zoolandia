using System;

namespace Zoolandia.Animals
{
    class Spheniscus : Animal
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
    }
}
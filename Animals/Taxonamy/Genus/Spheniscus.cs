using System;

namespace Zoolandia.Animals
{
    class Spheniscus : Animal, ISwimming
    {
        public bool cantFly = true;
        public virtual string swim() 
        {
            return $"{this.name} is out swimming";
        }
        public virtual string swim(double speed)
        {
            return $"{this.name} is swimming at {speed} mph.";
        }
    }
}
using System;

namespace Zoolandia.Animals
{
    class Eretmochelys : Animal, ISwimming
    {
        public string livesLong = "Are known to live past 40 yrs of age";
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
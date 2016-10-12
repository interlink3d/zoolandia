using System;

namespace Zoolandia.Animals
{
    class Eretmochelys : Animal
    {
        public string livesLong = "Are known to live past 40 yrs of age";
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
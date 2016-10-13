using System;

namespace Zoolandia.Animals
{
    class Elephas : Animal, IRunning
    {
        public string herdAnimal = "Elephants live in herds otherwise known as \"parades\"";
        public virtual string running() 
        {
            return $"{this.name} is known to stampede in parades";
        }
        public virtual string running(double speed)
        {
            return $"{this.name} can go up to {speed} mph.";
        }
    }
}
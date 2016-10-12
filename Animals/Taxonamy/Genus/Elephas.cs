using System;

namespace Zoolandia.Animals
{
    class Elephas : Animal
    {
        public string herdAnimal = "Elephants live in herds otherwise known as \"parades\"";
        public virtual string stampede() 
        {
            return "Animal is known to stampede in parades";
        }
        public virtual string stampede(double speed)
        {
            return $"Stampedes can go up to {speed} mph.";
        }
    }
}
using System;

namespace Zoolandia.Animals
{
    class Ailurus: Animal
    {
        public string climbTrees = "Most people don't know that these animals climb trees";
        public virtual string climb() 
        {
            return "Animal is out climbing trees";
        }
        public virtual string climb(double speed)
        {
            return $"Animal climbed up the tree at {speed} mph.";
        }
        public virtual string climb(double speed, string destination)
        {
            return $"Animal climbed on the {destination} at {speed} mph.";
        }
    }
}
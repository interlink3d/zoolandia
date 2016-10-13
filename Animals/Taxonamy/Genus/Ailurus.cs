using System;

namespace Zoolandia.Animals
{
    class Ailurus : Animal, IClimbing
    {
        public string climbTrees = "Most people don't know that these animals climb trees";
        public virtual string climb() 
        {
            return $"{this.name} is out climbing trees";
        }
        public virtual string climb(double speed)
        {
            return $"{this.name} climbed up the tree at {speed} mph.";
        }
    }
}
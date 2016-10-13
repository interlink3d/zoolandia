using System;

namespace Zoolandia.Animals
{
    class Panthera : Animal, IClimbing
    {
        public string bigCat = "The Leopard is bigger than a domesticated cat";

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
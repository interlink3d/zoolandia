using System;

namespace Zoolandia.Animals
{
    class Panthera: Animal
    {
        public string bigCat = $"The Leopard is bigger than a domesticated cat";

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
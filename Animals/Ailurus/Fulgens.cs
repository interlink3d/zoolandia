using System;

namespace Zoolandia.Animals
{
    class Fulgens: Ailurus
    {
        public string commonName = "Red Panda";
        public string scientificName = "Ailurus Fulgens";

        public string catLike = "They are nimble like cats but built like small bears."; 

        public override string description ()
        {
            return $"{this.name} lives in Zoolandia and is loveable!";
        }
    }
}
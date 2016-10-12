using System;

namespace Zoolandia.Animals
{
    class Fulgens : Ailurus
    {
        public Fulgens ()
        {
        this.name = "Burgler";
        this.loves = "playing";
        this.origin = "Himalayas";
        this.age = 5;
        this.genus = new Genus("Fulgens");
        this.species = new Species("Ailurus");
        this.commonName = "Red Panda";
        this.scientificName = "Ailurus Fulgens";
        }

        public string catLike = "They are nimble like cats but built like small bears."; 

        public override string description ()
        {
            return $"{this.name} lives in Zoolandia and is loveable!";
        }
    }
}
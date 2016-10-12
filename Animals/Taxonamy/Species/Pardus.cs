using System;

namespace Zoolandia.Animals
{
    class Pardus : Panthera
    {
        public Pardus ()
        {
        this.name = "Spot";
        this.loves = "the hunt";
        this.origin = "Northern China into Russia";
        this.age = 13;
        this.genus = new Genus("Pardus");
        this.species = new Species("Panthera");
        this.commonName = "Amur Leopard";
        this.scientificName = "Panthera Pardus";
        }

        public string hunts = "small animals like rodents and birds."; 

        public override string description ()
        {
            return $"{this.name} lives in Zoolandia.";
        }
    }
}
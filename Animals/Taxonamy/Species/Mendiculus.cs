using System;

namespace Zoolandia.Animals
{
    class Mendiculus : Spheniscus
    {
        public Mendiculus()
        {
            this.name = "Happy";
            this.loves = "acrobatics";
            this.origin = "Galapagos Islands";
            this.age = 3;
            this.genus = new Genus("Mendiculus");
            this.species = new Species("Spheniscus");
            this.commonName = "Galapagos Penguin";
            this.scientificName = "Spheniscus Mendiculus";
        }

        public string niceLevel = "sweet and cuddly"; 

        public override string description ()
        {
            return $"{this.name} lives in Zoolandia.";
        }
    }
}
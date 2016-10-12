using System;

namespace Zoolandia.Animals
{
    class Bicornis : Diceros
    {
        public Bicornis ()
        {
            this.name = "Rhydon";
            this.loves = "chasing people";
            this.origin = "African grasslands";
            this.age = 17;
            this.genus = new Genus("Bicornis");
            this.species = new Species("Diceros");
            this.scientificName = "Diceros Bicornis";
            this.commonName = "Black Rhino";
        }

        public string hunted = "Sadly these animals are hunted for sport."; 

        public override string description ()
        {
            return $"{this.name} lives in Zoolandia.";
        }
    }
}
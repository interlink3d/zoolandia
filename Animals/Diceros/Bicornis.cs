using System;

namespace Zoolandia.Animals
{
    class Bicornis: Diceros
    {
        public string commonName = "Black Rhino";
        public string scientificName = "Diceros Bicornis";

        public string hunted = "Sadly these animals are hunted for sport."; 

        public override string description ()
        {
            return $"{this.name} lives in Zoolandia.";
        }
    }
}
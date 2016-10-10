using System;

namespace Zoolandia.Animals
{
    class Sumatranus: Elephas
    {
        public string commonName = "Sumatran Elephant";
        public string scientificName = "Elephas Sumatranus";

        public string lucky = "Elephants are thought to be a lucky symbol"; 

        public override string description ()
        {
            return $"{this.name} lives in Zoolandia.";
        }
    }
}
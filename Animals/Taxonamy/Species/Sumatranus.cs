using System;

namespace Zoolandia.Animals
{
    class Sumatranus : Elephas
    {
        public Sumatranus ()
        {
        this.name = "Lucky";
        this.loves = "attention";
        this.origin = "Asian Islands";
        this.age = 13;
        this.genus = new Genus("Sumatranus");
        this.species = new Species("Elephas");
        this.commonName = "Sumatran Elephant";
        this.scientificName = "Elephas Sumatranus";
        }
        
        public string lucky = "Elephants are thought to be a lucky symbol"; 

        public override string description ()
        {
            return $"{this.name} lives in Zoolandia.";
        }
    }
}
using System;

namespace Zoolandia.Animals
{
    class Pardus: Panthera
    {
        public string commonName = "Amur Leopard";
        public string scientificName = "Panthera Pardus";

        public string hunts = "small animals like rodents and birds."; 

        public override string description ()
        {
            return $"{this.name} lives in Zoolandia.";
        }
    }
}
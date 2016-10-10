using System;

namespace Zoolandia.Animals
{
    class Imbricata: Eretmochelys
    {
        public string commonName = "Hawksbill Turtle";
        public string scientificName = "Eretmochelys Imbricata";

        public string dinoRelation = "They are known to be relatives of dinosaurs"; 

        public override string description ()
        {
            return $"{this.name} lives in Zoolandia.";
        }
    }
}
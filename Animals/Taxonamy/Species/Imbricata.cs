using System;

namespace Zoolandia.Animals
{
    class Imbricata : Eretmochelys
    {
        public Imbricata ()
        {
        this.name = "Dude";
        this.loves = "relaxing";
        this.origin = "tropical area oceans";
        this.age = 21;
        this.genus = new Genus("Imbricata");
        this.species = new Species("Eretmochelys");
        this.commonName = "Hawksbill Turtle";
        this.scientificName = "Eretmochelys Imbricata";
        }

        public string dinoRelation = "They are known to be relatives of dinosaurs"; 

        public override string description ()
        {
            return $"{this.name} lives in Zoolandia.";
        }
    }
}
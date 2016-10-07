using System;

namespace Zoolandia.Animals
{
    class Mustelidae: Animal
    {
        public string aggressive { get; set; }
        public string diet {get; set; }      

        public Mustelidae()
        {
            this.name = "Killer";
        }
        public override string description ()
        {
            return $"{base.description()}\n The Honey Badger is known for it's {this.aggressive} mentality and eating {this.diet}.";
        }
    }
}
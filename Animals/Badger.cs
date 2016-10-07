using System;

namespace Zoolandia.Animals
{
    class Badger: Animal
    {
        public string aggressive { get; set; }
        public string diet {get; set; }      

        public override string description ()
        {
            return $"{base.description()}\n The Honey Badger is known for it's {this.aggressive} mentality and eating {this.diet}.";
        }
    }
}
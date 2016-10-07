using System;

namespace Zoolandia.Animals
{
    public class Badger: Animal
    {
        public string aggressive { get; set; }
        public string diet {get; set; }    
        public string age {get; set; }

        public Badger()
        {
            this.age = "young";
        }  

        public override string description ()
        {
            return $"{base.description()}\n The {this.age} Honey Badger is known for it's {this.aggressive} mentality and eating {this.diet}.";
        }
    }
}
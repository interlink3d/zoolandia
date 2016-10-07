using System;

namespace Zoolandia.Animals
{
    public class Elephant: Animal
    {
        public string tuskSize { get; set; }
        public string color {get; set; }
        public string age {get; set; }

        public Elephant()
        {
            this.age = "teenage";
        }       

        public override string description ()
        {
            return $"{base.description()}\n This {this.age} Indian Elephant is known for it's {this.color} skin, {this.tuskSize} tusks, and peaceful ways.";
        }
    }
}
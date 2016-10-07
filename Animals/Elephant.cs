using System;

namespace Zoolandia.Animals
{
    class Elephantidae: Animal
    {
        public string tuskSize { get; set; }
        public string color {get; set; }  

        public Elephantidae ()
        {
            this.name = "Lucky";
        }
        public override string description ()
        {
            return $"{base.description()}\n This Indian Elephant is known for it's {this.color} skin, {this.tuskSize} tusks, and peaceful ways.";
        }    
    }
}
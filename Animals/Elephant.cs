using System;

namespace Zoolandia.Animals
{
    class Elephant: Animal
    {
        public string tuskSize { get; set; }
        public string color {get; set; }      

        public override string description ()
        {
            return $"{base.description()}\n The Indian Elephant is known for it's {this.color} skin, {this.tuskSize} tusks, and peaceful ways.";
        }
    }
}
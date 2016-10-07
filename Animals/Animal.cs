using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string name { get; set; }
        public string height {get; set; }
        public string weight {get; set; }
        public string origin {get; set; }        

        public virtual string description ()
        {
            return $"{this.name} resides in {this.origin} and averages {this.weight} and {this.height}.";
        }
    }
}
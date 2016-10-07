using System;

namespace Zoolandia.Animals
{
    class Canidae: Animal
    {
        public string dominance { get; set; }
        public string gender {get; set; }   

        public Canidae ()
        {
            this.name = "Night Wolf";
        }   
        public override string description ()
        {
            return $"{base.description()}\n This Alaskan Wolf is the {this.dominance} {this.gender} of its pack!";
        }
    }
}
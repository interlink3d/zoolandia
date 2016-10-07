using System;

namespace Zoolandia.Animals
{
    class Wolf: Animal
    {
        public string dominance { get; set; }
        public string gender {get; set; }      

        public override string description ()
        {
            return $"{base.description()}\n This Alaskan Wolf is the {this.dominance} {this.gender} of its pack!";
        }
    }
}
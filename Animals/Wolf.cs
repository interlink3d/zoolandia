using System;

namespace Zoolandia.Animals
{
    public class Wolf: Animal
    {
        public string dominance { get; set; }
        public string gender {get; set; } 
        public string age {get; set; }

        public Wolf()
        {
            this.age = "mature adult";
        }      

        public override string description ()
        {
            return $"{base.description()}\n This {this.age} Alaskan Wolf is the {this.dominance} {this.gender} of its pack!";
        }
    }
}
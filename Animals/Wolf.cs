using System;

namespace Zoolandia.Animals
{
    class Wolf: Animal
    {
        public string dominance { get; set; }
        public string gender {get; set; }      

        public override void description ()
        {
            Console.WriteLine(" ");
        }
    }
}
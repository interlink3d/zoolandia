using System;

namespace Zoolandia.Animals
{
    class Elephant: Animal
    {
        public string tuskSize { get; set; }
        public string color {get; set; }      

        public override void description ()
        {
            Console.WriteLine(" ");
        }
    }
}
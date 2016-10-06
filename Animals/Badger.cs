using System;

namespace Zoolandia.Animals
{
    class Badger: Animal
    {
        public string aggressive { get; set; }
        public string diet {get; set; }      

        public override void description ()
        {
            Console.WriteLine(" ");
        }
    }
}
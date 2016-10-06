using System;

namespace Zoolandia.Animals
{
    class Animal
    {
        public string name { get; set; }
        public string height {get; set; }
        public string weight {get; set; }
        public string origin {get; set; }        

        public static void sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }
        public virtual void description ()
        {
            Console.WriteLine(" ");
        }
    }
}
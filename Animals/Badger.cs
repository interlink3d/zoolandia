using System;

namespace Zoolandia.Animals
{
    class Mustelidae: Animal
    {
        public string aggressive { get; set; }
        public string diet {get; set; }      

        public Mustelidae()
        {
            this.name = "Killer";
        }
        public Mustelidae(string name)
        {
            this.name = name;
        }
        public Mustelidae(int age)
        {
            this.age = age;
        }
        public  Mustelidae(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string description ()
        {
            return $"{base.description()}\n The Honey Badger is known for it's {this.aggressive} mentality and eating {this.diet}.";
        }
    }
}
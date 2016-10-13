using System;
using System.Collections.Generic;

namespace Zoolandia.Habitats
{
    public class Aquarium : Habitat, IAquatic
    {
        // `public_name`, and `saltwater` properties can only be set when habitat is created
        public Aquarium (string name, bool isSaltwater)
        {
            _saltwater = isSaltwater;
            this.public_name = name;
        }
        private bool _saltwater = false;
        public bool coral = false;
        public double volume { get; set; }
        public void empty()
        {
            Console.WriteLine($"You have emptied out the tank.");
        }
        public void fill()
        {
            Console.WriteLine($"You have filled up the tank.");
        }
        private List<Employee> scubaCrew = new List<Employee>();

    }
}
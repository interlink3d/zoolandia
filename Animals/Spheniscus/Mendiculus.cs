using System;

namespace Zoolandia.Animals
{
    class Mendiculus: Spheniscus
    {
        public string commonName = "Galapagos Penguin";
        public string scientificName = "Spheniscus Mendiculus";

        public string niceLevel = "sweet and cuddly"; 

        public override string description ()
        {
            return $"{this.name} lives in Zoolandia.";
        }
    }
}
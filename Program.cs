using System;
using Zoolandia.Animals;


namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Fulgens aPanda = new Fulgens ()
            {
                name = "Burgler",
                loves = "playing",
                origin = "Himalayas",
                age = 5,
            };
            
            Bicornis aRhyno = new Bicornis ()
            {
                name = "Rhydon",
                loves = "chasing people",
                origin = "African grasslands",
                age = 17,
            };

             Sumatranus aElephant = new Sumatranus ()
            {
                name = "Lucky",
                loves = "attention",
                origin = "Asian Islands",
                age = 13,
            };

            Imbricata aTurtle = new Imbricata ()
            {
                name = "Dude",
                loves = "relaxing",
                origin = "tropical area oceans",
                age = 21,
            };

            Pardus aLeopard = new Pardus ()
            {
                name = "Spot",
                loves = "the hunt",
                origin = "Northern China into Russia",
                age = 13,
            };

            Mendiculus aPenguin = new Mendiculus ()
            {
                name = "Happy",
                loves = "acrobatics",
                origin = "Galapagos Islands",
                age = 3,
            };
            
            Console.WriteLine($@"
            {aPanda.name} the {aPanda.scientificName} otherwise known as {aPanda.commonName} resides in the {aPanda.origin}. 
            It is known for its love of {aPanda.loves}. 
            {aPanda.name} is {aPanda.age} years old. 
            {aPanda.climbTrees} 
            {aPanda.climb(24, "tree")} 
            {aPanda.catLike} 
            {aPanda.sleep(2)} 
            {aPanda.description()} ");

            Console.WriteLine($@"
            It is {aRhyno.hasHorns} that they have horns. {aRhyno.fight(8, "attacked")}
            {aElephant.herdAnimal} {aElephant.eat("plants")}
            {aTurtle.livesLong} {aTurtle.swim(21, "coral reef")}
            {aLeopard.bigCat}. Likes to hunt {aLeopard.hunts}
            Penguins love {aPenguin.loves}. {aPenguin.swim(15, "boat")}
            ");
            
        }
    }
}

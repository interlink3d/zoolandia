﻿using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Fulgens aPanda = new Fulgens ();
            
            Bicornis aRhyno = new Bicornis ();
        
            Sumatranus aElephant = new Sumatranus ();

            Imbricata aTurtle = new Imbricata ();

            Pardus aLeopard = new Pardus ();
         
            Mendiculus aPenguin = new Mendiculus ();
         
            
            Console.WriteLine($@"
            {aPanda.name} the {aPanda.scientificName} otherwise known as {aPanda.commonName} resides in the {aPanda.origin}. 
            It is known for its love of {aPanda.loves}. 
            {aPanda.name} is {aPanda.age} years old. 
            {aPanda.climbTrees} 
            {aPanda.climb(24)} 
            {aPanda.catLike} 
            {aPanda.sleep(2)} 
            {aPanda.description()} ");

            Console.WriteLine($@"
            It is {aRhyno.hasHorns} that they have horns. {aRhyno.fight(8)}
            {aElephant.herdAnimal} {aElephant.eat("plants")}
            {aTurtle.livesLong} {aTurtle.swim(21)}
            {aLeopard.bigCat}. Likes to hunt {aLeopard.hunts}
            Penguins love {aPenguin.loves}. {aPenguin.swim(15)}
            ");
            
        }
    }
}

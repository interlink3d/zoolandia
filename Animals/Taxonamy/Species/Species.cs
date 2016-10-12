namespace Zoolandia.Animals 
{
    public class Species: TaxonomyTerm
    {
        public string speciesName {get; set;}
        public Species (string species)
        {
            this.speciesName = species;
        }

    }
} 
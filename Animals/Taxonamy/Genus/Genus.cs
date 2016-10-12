namespace Zoolandia.Animals 
{
    public class Genus: TaxonomyTerm
    {
        public string genusName {get; set;}
        public Genus (string genus)
        {
            this.genusName = genus;
        }
    }
}
namespace Zoolandia.Animals
{
    interface IAnimal
    {
        // properties
        string name {get; set;}
        string origin {get; set;}
        string loves {get; set;}     
        int age {get; set;}
        string diet {get; set;}

        // methods
        string eat();
        string eat(string food);
        string sleep();
        string sleep(int hours);
        string reproduce(); 
   
       
    }
}
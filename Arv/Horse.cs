namespace Arv;
// Subklasser som ärver från Animal
public class Horse : Animal
{
    public string Breed { get; set; }  // En unik egenskap för Horse

    public Horse(string name, double weight, int age, string breed) : base(name, weight, age)
    {
        Breed = breed;
    }

    public override void DoSound() => Console.WriteLine("Neigh");
}
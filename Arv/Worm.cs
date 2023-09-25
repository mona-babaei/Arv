namespace Arv;
public class Worm : Animal
{
    public bool IsPoisonous { get; set; }  // En unik egenskap för Worm

    public Worm(string name, double weight, int age, bool isPoisonous) : base(name, weight, age)
    {
        IsPoisonous = isPoisonous;
    }

    public override void DoSound() => Console.WriteLine("Squirm");
}
namespace Arv;
public class Hedgehog : Animal
{
    public int Spikes { get; set; }  // En unik egenskap för Hedgehog

    public Hedgehog(string name, double weight, int age, int spikes) : base(name, weight, age)
    {
        Spikes = spikes;
    }

    public override void DoSound() => Console.WriteLine("Sniff");
}
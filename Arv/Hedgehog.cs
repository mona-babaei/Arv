namespace Arv;
public class Hedgehog : Animal
{
    public int NrOfSpikes { get; set; }  // En unik egenskap för Hedgehog

    public Hedgehog(string name, double weight, int age, int nrOfSpikes) : base(name, weight, age)
    {
        NrOfSpikes = nrOfSpikes;
    }

    public override void DoSound() => Console.WriteLine("Sniff");
}
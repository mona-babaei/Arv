namespace Arv;
// Klasser som ärver från Bird
public class Pelican : Bird
{
    public double BeakLength { get; set; }  // En unik egenskap för Pelican

    public Pelican(string name, double weight, int age, double wingSpan, double beakLength) : base(name, weight, age, wingSpan)
    {
        BeakLength = beakLength;

    }
}
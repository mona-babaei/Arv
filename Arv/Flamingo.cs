namespace Arv;
public class Flamingo : Bird
{
    public string Color { get; set; }  // En unik egenskap för Flamingo

    public Flamingo(string name, double weight, int age, double wingSpan, string color) : base(name, weight, age, wingSpan)
    {
        Color = color;
    }
}
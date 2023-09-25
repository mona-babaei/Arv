namespace Arv;
public class Bird : Animal
{
    public double WingSpan { get; set; }  // En unik egenskap för Bird

    public Bird(string name, double weight, int age, double wingSpan) : base(name, weight, age)
    {
        WingSpan = wingSpan;
    }

    public override void DoSound() => Console.WriteLine("Tweet");
}
//Om samtliga fåglar behöver ett nytt attribut ska vi lägga det i Bird klassen.
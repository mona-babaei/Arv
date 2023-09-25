namespace Arv;
public class Wolf : Animal
{
    public string PackName { get; set; }  // En unik egenskap för Wolf

    public Wolf(string name, double weight, int age, string packName) : base(name, weight, age)
    {
        PackName = packName;
    }

    public override void DoSound() => Console.WriteLine("Howl");

    public interface IPerson
    {
    }
}
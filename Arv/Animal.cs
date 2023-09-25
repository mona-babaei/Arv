namespace Arv;
// Abstrakta klassen Animal
public abstract class Animal
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }

    public Animal(string name, double weight, int age)
    {
        Name = name;
        Weight = weight;
        Age = age;
    }

    public abstract void DoSound();

    virtual public string Stats()
    {
        throw new NotImplementedException();
    }
}

//Om alla djur behöver det nya attributet skulle vi  lägga det i Animal klassen.
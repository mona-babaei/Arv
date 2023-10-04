namespace Arv;

public class Dog : Animal, IPerson
{
    public string Breed { get; set; }

    public Dog(string name, double weight, int age, string breed)
        : base(name, weight, age)
    {
        this.Breed = breed;
    }

    public override void DoSound()
    {
        Console.WriteLine("wof:");
    }
    public string Talk()
    {
        return "Hello, I'm a talking dog!";
    }

    public override string Stats()
    {
        return base.Stats() + $", Breed: {Breed}";
    }

   

        
}

 


//public class Dog : Animal

//public string Breed { get; set; }  // En unik egenskap för Dog

// public Dog(string name, double weight, int age, string breed) : base(name, weight, age)//
//  {
//  Breed = breed;


// public override void DoSound() => Console.WriteLine("Bark");


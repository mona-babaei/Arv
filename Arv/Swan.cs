namespace Arv;
public class Swan : Bird
{
    public bool IsMigratory { get; set; }  // En unik egenskap för Swan

    public Swan(string name, double weight, int age, double wingSpan, bool isMigratory) : base(name, weight, age, wingSpan)
    {
        IsMigratory = isMigratory;
    }
}

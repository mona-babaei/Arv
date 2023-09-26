﻿namespace Arv;
// IPerson gränssnitt
public interface IPerson
{
    void Talk();
}


public class Wolfman : Wolf, IPerson
{
    public Wolfman(string name, double weight, int age, string packName) : base(name, weight, age, packName) { }

    public void  Talk()
    {
        Console.WriteLine("I'm a wolfman!");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Arv;
public class Program
{
    public static IPerson? person;
    public static bool DoSound = true;

    public static void Main(string[] args)
    {


        // Skapa olika djurinstanser
        Horse horse = new Horse("Pegasus", 500, 5, "Mustang");
        Dog dog = new Dog("Buddy", 20, 3, "Golden Retriever");
        Hedgehog hedgehog = new Hedgehog("Sonic", 1, 2, 5000);
        Worm worm = new Worm("Wiggly", 0.05, 1, false);
        Bird bird = new Bird("Tweety", 0.5, 2, 15);
        Wolf wolf = new Wolf("Akela", 60, 6, "Mountain Pack");
        Pelican pelican = new Pelican("Pelly", 3, 4, 50, 7.5);
        Flamingo flamingo = new Flamingo("Mingo", 2, 2, 45, "Pink");
        Swan swan = new Swan("Queen", 10, 3, 60, true);
        Wolfman wolfman = new Wolfman("Lupin", 70, 30, "Moonlit Pack");

        // Lägg till djuren i en lista
        List<Animal> animals = new List<Animal>()
            {
            horse, dog, hedgehog, worm, bird, wolf, pelican, flamingo, swan, wolfman
            };


        foreach (Animal animal in animals)
        {
            animal.DoSound();


            Console.WriteLine($"Animal Name: {animal.Name}");



            if (animal is IPerson Person)
            {
                //string Sound = Person.Talk();
                Console.WriteLine(Person.Talk());



                Console.WriteLine("--------------------------------");
                Console.ReadLine();
            }


        }
    }

}

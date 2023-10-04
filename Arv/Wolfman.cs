using System;
namespace Arv;




    public class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, string packName) : base(name, weight, age, packName) { }

        public string Talk()
        {
            Console.WriteLine("I'm a wolfman!");
            return "I am a wolfman";
        }


    }













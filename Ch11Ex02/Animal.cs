using System;
using System.Collections.Generic;
using System.Text;

namespace Ch11Ex02
{
    public abstract class Animal
    {
        protected string name;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public Animal()
        {
            name = "The animalwith no name.";
        }
        public Animal(string newName)
        {
            name = newName;
        }
        public void Feed()
        {
            Console.WriteLine($"{name} has been feed.");
        }
    }
}

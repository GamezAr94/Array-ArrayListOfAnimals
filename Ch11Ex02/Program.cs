using System;
using System.Collections;

namespace Ch11Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create an Array type collection of Animal objects and use it:");
            Animal[] animalArray = new Animal[2];
            Cow myCow1 = new Cow("Lea");
            animalArray[0] = myCow1;
            animalArray[1] = new Chicken("Noa");
            foreach(Animal a in animalArray)
            {
                Console.WriteLine($"New {a.ToString()} object added to Array collection, Name = {a.Name}");
            }
            Console.WriteLine($"Array collection contains {animalArray.Length} objects.");
            animalArray[0].Feed();
            ((Chicken)animalArray[1]).LayEgg();
            Console.WriteLine();
            Console.WriteLine($"Crate an ArrayList type collection of Animal objects and use it:");
            ArrayList animalArraylist = new ArrayList();
            Cow myCow2 = new Cow("Rual");
            animalArraylist.Add(myCow2);
            animalArraylist.Add(new Chicken("Andrea"));
            foreach(Animal a in animalArraylist)
            {
                Console.WriteLine($"New {a.ToString()} object added to ArrayList collection, name = {a.Name}");
            }
            Console.WriteLine($"ArrayList collection contains {animalArraylist.Count} objects.");
            ((Animal)animalArraylist[0]).Feed();
            ((Chicken)animalArraylist[1]).LayEgg();
            Console.WriteLine("\nAdditional manipulation of ArrayList:");
            animalArraylist.RemoveAt(0);
            ((Animal)animalArraylist[0]).Feed();
            animalArraylist.AddRange(animalArray);
            ((Chicken)animalArraylist[2]).LayEgg();
            Console.WriteLine($"The animal called {myCow1.Name} is at: index {animalArraylist.IndexOf(myCow1)}.");
            myCow1.Name = "Mary";
            Console.WriteLine($"The animal is now called{((Cow)animalArraylist[1]).Name}.");
            Console.ReadKey();
        }
    }
}

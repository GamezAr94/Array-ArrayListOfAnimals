using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Ch11Ex02
{
    class Animals : CollectionBase
    {
        public void Add(Animal newAnimal)
        {
            List.Add(newAnimal);
        }
        public void Remove(Animal newAnimal)
        {
            List.Remove(newAnimal);
        }
        public Animal this[int animalIndex]
        {
            get => (Animal)List[animalIndex];
            set => List[animalIndex] = value;
        }
    }
}

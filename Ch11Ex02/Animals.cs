using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ch11Ex02
{
    class Animals : DictionaryBase
    {
        public void Add(string newID, Animal newAnimal)
        {
            Dictionary.Add(newID, newAnimal);
        }
        public void Remove(string animalID)
        {
            Dictionary.Remove(animalID);
        }
        public Animals() { }
        public Animal this[string animalID]
        {
            get => (Animal)Dictionary[animalID];
            set => Dictionary[animalID] = value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Zoo
    {
        //putem sa punem si tipuri de Gender
        public List<Animal> Animals { get; set; }
        
        public Zoo()
        {
            Animals = new List<Animal>();
            InitZoo();
        }
        private void InitZoo()
        {
            Animals.Add(new Animal("Elephant", Gender.Female));
            Animals.Add(new Animal("Tiger", Gender.Male));
            Animals.Add(new Animal("Zebra", Gender.Female));
            Animals.Add(new Animal("Fox", Gender.Female));
        }
    }
}

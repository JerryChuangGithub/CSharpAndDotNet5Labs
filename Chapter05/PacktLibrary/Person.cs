using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person
    {
        // constructors
        public Person()
        {
            // set default values for fields
            // including read-only fields 
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        public string Name;

        public DateTime DateOfBirth;

        public WondersOfTheAncientWorld FavoriteAncientWonder;

        public List<Person> Children = new List<Person>();

        // constants
        public const string Species = "Homo Sapien";

        // read-only fields
        public readonly string HomePlanet = "Earth";

        public readonly DateTime Instantiated;
    }
}

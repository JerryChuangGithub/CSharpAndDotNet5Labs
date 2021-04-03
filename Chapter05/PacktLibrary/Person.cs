using System.Security.Cryptography.X509Certificates;
using System;
using static System.Console;
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

        // methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }
        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 5);
        }

        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }
        public string SayHelloTo(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }
    }
}

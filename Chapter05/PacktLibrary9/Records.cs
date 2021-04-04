﻿namespace Packt.Shared
{
    public class ImmutablePerson
    {
        // private field by default
        // int Age;
    
        public string FirstName { get; init; }

        public string LastName { get; init; }
    }

    public record ImmutableVehicle
    {
        //int Age; // public property equivalent to: public int Age { get; init; }

        public int Wheels { get; init; }

        public string Color { get; init; }

        public string Brand { get; init; }
    }

    // Positional records
    // public record ImmutableAnimal
    // {
    //     string Name; // i.e. public init-only properties
    //     string Species;
    //     public ImmutableAnimal(string name, string species)
    //     {
    //         Name = name;
    //         Species = species;
    //     }
    //     public void Deconstruct(out string name, out string species)
    //     {
    //         name = Name;
    //         species = Species;
    //     }
    // }
    // simpler way to define a record that does the equivalent
    public record ImmutableAnimal(string Name, string Species);
}
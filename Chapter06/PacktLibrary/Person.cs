﻿using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class Person : IComparable<Person>
    {
        // fields 
        public string Name;

        public DateTime DateOfBirth;

        public List<Person> Children = new List<Person>();

        // event delegate field
        // Defining and handling events
        public event EventHandler Shout;

        // data field 
        public int AngerLevel;

        // methods 
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        // operator to "multiply"
        public static Person operator *(Person p1, Person p2)
        {
            return Procreate(p1, p2);
        }

        // static method to "multiply" 
        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };

            p1.Children.Add(baby);
            p2.Children.Add(baby);
            return baby;
        }

        // method with a local function 
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException(
                  $"{nameof(number)} cannot be less than zero.");
            }
            return localFactorial(number);

            int localFactorial(int localNumber) // local function
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }

        // instance method to "multiply" 
        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }

        // method 
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                // if something is listening... 
                if (Shout != null)
                {
                    // ...then call the delegate
                    Shout(this, EventArgs.Empty);
                }
            }
        }

        // Comparing objects when sorting
        public int CompareTo(Person person)
        {
            return Name.CompareTo(person.Name);
        }
    }
}

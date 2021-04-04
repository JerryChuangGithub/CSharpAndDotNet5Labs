namespace Packt.Shared
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
}
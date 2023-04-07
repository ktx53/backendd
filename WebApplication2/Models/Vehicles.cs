namespace WebApplication2.Models
{
    public class Vehicles
    {
        public class Car : Vehicle
        {
            public int Wheels { get; set; } = 4;
            public bool Headlights { get; set; }

            public Car(string color) : base(color)
            {
                Headlights = false;
            }
        }

        public class Bus : Vehicle
        {
            public Bus(string color) : base(color)
            {
            }
        }

        public class Boat : Vehicle
        {
            public Boat(string color) : base(color)
            {
            }
        }
    }
}

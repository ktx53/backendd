namespace WebApplication2.Models
{
    public class Vehicle
    {
        public string Color { get; set; }
        public int Id { get; internal set; }

        public Vehicle(string color)
        {
            Color = color;
        }
    }
}
